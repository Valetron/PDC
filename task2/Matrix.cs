using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Matrix
    {
        public Matrix(int size)
        {
            this.rank = size;
            data = new int[rank, rank];

            for (int i = 0; i < rank; ++i)
                for (int j = 0; j < rank; ++j)
                    data[i, j] = num.Next(0, 101);
        }

        public static Matrix operator *(Matrix A, Matrix B)
        {
            Matrix result = new Matrix(A.rank);

            for (int i = 0; i < result.rank; ++i)
            {
                for (int j = 0; j < result.rank; ++j)
                {
                    result.data[i, j] = 0;
                    for (int k = 0; k < result.rank; ++k)
                        result.data[i, j] += A.data[i, k] * B.data[k, j];
                }
            }

            return result;
        }

        public int getRank()
        {
            return this.rank;
        }

        public int[,] data;

        private static Random num = new Random();
        private int rank;
    }
}
