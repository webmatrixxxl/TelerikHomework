using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamGame
{
    public class KeyboardInterface : IUserInterface
    {

        public void ProcessInput()
        {
            if (Console.KeyAvailable)
	        {
                var KeyInfo = Console.ReadKey();

                if (KeyInfo.Key.Equals(ConsoleKey.A))
	            {
                    if (this.OnLeftPressed != null )
                    {
                        this.OnLeftPressed(this, new EventArgs());
                        
                    }
	            }

                if (KeyInfo.Key.Equals(ConsoleKey.W))
                {
                    if (this.OnUpPressed != null)
                    {
                        this.OnUpPressed(this, new EventArgs());
                    }
                }

                if (KeyInfo.Key.Equals(ConsoleKey.S))
                {
                    if (this.OnDownPressed != null)
                    {
                        this.OnDownPressed(this, new EventArgs());
                    }
                }

                if (KeyInfo.Key.Equals(ConsoleKey.D))
                {
                    if (this.OnRightPressed != null)
                    {
                        this.OnRightPressed(this, new EventArgs());
                    }
                }

                if (KeyInfo.Key.Equals(ConsoleKey.Spacebar))
                {
                    if (this.OnActionPressed != null)
                    {
                        this.OnActionPressed(this, new EventArgs());
                    }
                }
                
            }    
        }

        public event EventHandler OnLeftPressed;

        public event EventHandler OnRightPressed;

        public event EventHandler OnUpPressed;

        public event EventHandler OnDownPressed;

        public event EventHandler OnActionPressed;
    }
}
