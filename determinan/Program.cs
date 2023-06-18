using System;
namespace Project
{
    class test_1
    {
        public static void Main()
        {

            double[,] det = new double[3, 3]; //for describe a matrix you should go on this way

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                { det[i, j] = Convert.ToDouble(Console.ReadLine()); }
            }
            double determinan = det[0, 0] * (det[1, 1] * det[2, 2] - det[1, 2] * det[2, 1]) - det[0, 1] * (det[1, 2] * det[0, 2] - det[1, 0] * det[2, 2]) + det[0, 2] * (det[1, 1] * det[0, 2] - det[1, 0] * det[2, 2]);
            Console.WriteLine(determinan); //you should out name of matrix before [] (so important
        }
    }
}
