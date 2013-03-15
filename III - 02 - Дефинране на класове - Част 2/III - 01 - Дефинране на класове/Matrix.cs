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
        public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
        {
            if (first.Row == second.Row && first.Col == second.Col)
            {
                Matrix<T> tempArr = new Matrix<T>(first.Row, first.Col);
                for (int i = 0; i < first.Row; i++)
                {
                    for (int j = 0; j < first.Col; j++)
                    {
                        checked
                        {
                            tempArr[i, j] = (dynamic)first[i, j] + second[i, j];
                        }
                    }
                }
                return tempArr;
            }
            else throw new Exception("The given matrix are not with the same Col and Row size");
        }

        public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
        {
            if (first.Row == second.Row && first.Col == second.Col)
            {
                Matrix<T> tempArr = new Matrix<T>(first.Row, first.Col);
                for (int i = 0; i < first.Row; i++)
                {
                    for (int j = 0; j < first.Col; j++)
                    {
                        checked
                        {
                            tempArr[i, j] = (dynamic)first[i, j] - second[i, j];
                        }
                    }
                }
                return tempArr;
            }
            else throw new Exception("The given matrix are not with the same Col and Row size");
        }

        public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
        {
            if (first.Col == second.Row && (first.Row > 0 && second.Col > 0 && first.Col > 0))
            {
                Matrix<T> final = new Matrix<T>(first.Row, second.Col);
                for (int i = 0; i < final.Row; i++)
                {
                    for (int j = 0; j < final.Col; j++)
                    {
                        final[i, j] = (dynamic)0;
                        for (int k = 0; k < first.Col; k++)
                        {
                            checked
                            {
                                final[i, j] = final[i, j] + (dynamic)first[i, k] * second[k, j];
                            }
                        }
                    }
                }
                return final;
            }
            else
            {
                throw new Exception("Row on the first matrix and col on the second matrix, are with different size, multiplication cannot be done.");
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
