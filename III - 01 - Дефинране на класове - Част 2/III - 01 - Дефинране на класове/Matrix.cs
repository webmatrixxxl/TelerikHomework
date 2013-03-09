using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace III___01___Дефинране_на_класове
{
    class Matrix<T>
    {
        //<fields>
        private int row = 0;
        private int col = 0;
        public T[,] array;
        //</fields>

        //<constructors>
        public Matrix(int row, int col)
        {
            this.row = row;
            this.col = col;
            array = new T[row, col];
        }
        //</constructors>

        //<indexers>
        public T this[int row, int col]
        {
            get
            {
                return array[row, col];
            }
            set
            {
                array[row, col] = value;
            }
        }
        //</indexers>

        //<overloadingoperators>

        public static T operator *(T m1, T m2)
        {
            if (m1)
            {
                
            }
        }
        //</overloadingoperators>

        //<property>
        public int Row
        {
            get
            {
               return array.GetLength(0);
            }
        }
        public int Col
        {
            get
            {
                return array.GetLength(1);
            }
        }
        //</property>

        //<methods>
        public void Add(int row, int col, T value)
        {
            array[row, col] = value;
        }
        //</methods>

    }
}
