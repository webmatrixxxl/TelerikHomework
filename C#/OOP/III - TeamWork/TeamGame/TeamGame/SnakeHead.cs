using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;

namespace TeamGame
{
    public class SnakeHead : MovingObject
    {
        public static List<GameObject> DoNotEatingList = new List<GameObject>();

        List<TrailObject> tail = new List<TrailObject>();

        public new const string CollisionGroupString = "SnakeHead";

        public int tailLength { get; set; }

        public static bool playing = true;

        public static int Score;

        MatrixCoords Speed = new MatrixCoords(0, 0);
        
        public SnakeHead(MatrixCoords topLeft, MatrixCoords speed, int tailLength)
            : base(topLeft,new char[,]{{'O'}}, speed)
        {
            this.Speed = new MatrixCoords(speed.Row, speed.Col);
            this.tailLength = tailLength;
        }
        

        public virtual void MoveUp()
        {
            if (this.Speed.Row == 1)
            {
                this.Speed.Row = 1;
            }
            else if (this.Speed.Row != -1)
            {
                this.Speed.Row = -1;
                this.Speed.Col = 0;
            }

        }

        public virtual void MoveDown()
        {
            if (this.Speed.Row == -1)
            {
                this.Speed.Row = -1;
            }
            else if (this.Speed.Row != 1)
            {
                this.Speed.Row = 1;
                this.Speed.Col = 0;
            }
        }

        public virtual void MoveLeft()
        {
            if (this.Speed.Col == 1)
            {
                this.Speed.Col = 1;
            }
            else if (this.Speed.Col != -1)
            {
                this.Speed.Row = 0;
                this.Speed.Col = -1;
            }
        }

        public virtual void MoveRight()
        {
            if (this.Speed.Col == -1)
            {
                this.Speed.Col = -1;
            }
            else if (this.Speed.Col != 1)
            {
                this.Speed.Row = 0;
                this.Speed.Col = 1;
            }
        }

        public override string GetCollisionGroupString()
        {
            return SnakeHead.CollisionGroupString;
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "foodforsnake";
        }

        public override void Update()
        {

            this.topLeft.Row += this.Speed.Row;
            this.topLeft.Col += this.Speed.Col;
            Eating();
            DoNotEating();
            
            // Check if the Snake is outside the field
           //if (this.topLeft.Row < 6 || this.topLeft.Row > 22 || this.topLeft.Col < 3 || this.topLeft.Col > 47)
            if (SnakeHead.playing == false)

            {
                Engine.Over();
            }
            
        }

        
        public void Eating()
        {
            if (FoodForSnake.food.TopLeft.Row == this.topLeft.Row && 
                FoodForSnake.food.TopLeft.Col==this.topLeft.Col )
            {
                Score += 5;
                this.tailLength += 6;
            }
        }

        public void DoNotEating()
        {
            foreach (var uneatable in DoNotEatingList)
            {
                if (uneatable.TopLeft.Row == this.topLeft.Row 
                    && uneatable.TopLeft.Col == this.topLeft.Col)
                {
                    this.Speed = new MatrixCoords(0, 0);
                    SnakeHead.playing = false;
                    
                }
            }

        }

        public virtual void RespondToCollision(CollisionData collisionData)
        {
            this.body = new char[,] { {'F'} };
        }

       

        public override IEnumerable<GameObject> ProduceObjects()
        {
            
            
            TrailObject trailObject = new TrailObject(
                new MatrixCoords(this.topLeft.Row - this.Speed.Row, this.topLeft.Col-this.Speed.Col), 
                new char[,] { { '+' } }, tailLength);
            
            DoNotEatingList.Add(trailObject);
            
            tail.Add(trailObject);

            tail.RemoveAll(obj => obj.IsDestroyed==true);
            
            DoNotEatingList.RemoveAll(obj => obj.IsDestroyed == true);
            
            
            return tail;
        }
        
    }
}
