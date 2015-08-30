using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler18
{
    class Program
    {
        static List<List<int>> numbers;

        static void Main(string[] args)
        {
            numbers = new List<List<int>>();
            numbers.Add(new List<int>() { 75 });
            numbers.Add(new List<int>() { 95, 64});
            numbers.Add(new List<int>() { 17, 47, 82 });
            numbers.Add(new List<int>() { 18, 35, 87, 10 });
            numbers.Add(new List<int>() { 20, 4, 82, 47, 65 });
            numbers.Add(new List<int>() { 19, 1, 23, 75, 3, 34 });
            numbers.Add(new List<int>() { 88, 2, 77, 73, 7, 63, 67 });
            numbers.Add(new List<int>() { 99, 65, 4, 28, 6, 16, 70, 92 });
            numbers.Add(new List<int>() { 41, 41, 26, 56, 83, 40, 80, 70, 33 });
            numbers.Add(new List<int>() { 41, 48, 72, 33, 47, 32, 37, 16, 94, 29 });
            numbers.Add(new List<int>() { 53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14 });
            numbers.Add(new List<int>() { 70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57 });
            numbers.Add(new List<int>() { 91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48 });
            numbers.Add(new List<int>() { 63, 66, 4, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31 });
            numbers.Add(new List<int>() { 4, 62, 98, 27, 23, 9, 70, 98, 73, 93, 38, 53, 60, 4, 23 });

            numbers.Reverse();

            for(int i = 1; i < numbers.Count(); i++)
            {
                for(int j = 0; j < numbers[i].Count(); j++)
                {
                    numbers[i][j] = numbers[i][j] + Math.Max(numbers[i - 1][j], numbers[i - 1][j +1]);
                }
            }
            Console.WriteLine(numbers[numbers.Count() - 1][0]);
            Console.ReadLine();
        }
    }
}
