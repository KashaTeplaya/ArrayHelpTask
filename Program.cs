using System;
using System.IO;

namespace ArrayHelpTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Bacha\source\repos\ArrayHelpTask\1.txt";
            int[,] array = new int[,] { { 5, 4, 6 }, { 2, 4, 3 }, { 3, 2, 1 } };
            using (StreamWriter sw = new StreamWriter(filePath, false, System.Text.Encoding.Default))
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        string emptyPlace = " ";
                        if(j!=2)
                        sw.Write(array[i, j]+emptyPlace);
                        else
                            sw.Write(array[i, j]);
                        if (j == 2) { sw.WriteLine(); }
                    }
                }
            }
        
            string[] lines = File.ReadAllLines(filePath);
            int[,] num = new int[lines.Length, lines[0].Split(' ').Length];
            for (int i = 0; i < lines.Length; i++)
            {
                string[] temp = lines[i].Split(' ');
                for (int j = 0; j < temp.Length; j++)
                    if (!String.IsNullOrEmpty(temp[j]))
                        num[i, j] = int.Parse(temp[j]);
            }

            Random rn = new Random();
            using (StreamWriter sw = new StreamWriter(filePath, false, System.Text.Encoding.Default))
            {
                for (int i = 0; i < num.GetLength(0); i++)
                {
                    for (int j = 0; j < num.GetLength(1); j++)
                    {
                        if (i == j)
                        {
                            num[i, j] = num[i, j];
                        }
                        else
                        {
                            num[i, j] = rn.Next(0, 19);
                        }
                        string emptyPlace = " ";
                        if (j != 2)
                            sw.Write(num[i, j] + emptyPlace);
                        else
                            sw.Write(num[i, j]);
                        if (j == 2)
                        {
                            sw.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
