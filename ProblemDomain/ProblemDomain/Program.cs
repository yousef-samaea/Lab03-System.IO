using System;
using System.IO;
using System.Text;

namespace ProblemDomain
{
    public class Program
    {
        static void Main(string[] args)
        {
            Multiplied();
            Average();
            daimond();
            int[] arr = { 1, 1, 3, 4, 5, 5, 6, 6, 6 };
            Console.WriteLine(appears(arr));
            int[] arr2 = { 55, 4, 99, 18, 9 };
            Console.WriteLine(MaxNumber(arr2));
            String filePath = "words.txt";
            WriteAWord(filePath);
            ReadAWord(filePath);
            DeletAndWrte(filePath);
            Console.WriteLine("please enter a sentence ");
            string input = Console.ReadLine();
            WordsCauntar(input);
        }
        // challenge 1
        public static void Multiplied()
        {
            Console.WriteLine("plese inter three numbers");
            String iput = Console.ReadLine();
            string[] num = iput.Split(" ");
            Multiplied2(num);
            Console.WriteLine(Multiplied2(num));
        }
        public static int Multiplied2(string[] num)
        {
            int product = 1;

            if (num.Length < 3)
                return 0;
            if (num.Length >= 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    int x = Convert.ToInt32(num[i]);
                    product *= x;

                }
            }
            return product;
        }

        // challenge 2
        public static int Average()
        {
                Console.WriteLine("enter a number between 2-10");
                int num = Convert.ToInt32(Console.ReadLine());
                while (num > 10 || num < 2)
                {
                    Console.WriteLine("enter a number between 2-10");
                }
                 
                    int[] array = new int[num];


                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.WriteLine($"{i + 1} of {num} - Enter a number:");
                        int x = Convert.ToInt32(Console.ReadLine());
                        while (x < 0)
                        {
                            x = Convert.ToInt32(Console.ReadLine());
                        }
                        array[i] = x;

                    }
                return calAverage(array);
            
            
        }
        public static int calAverage(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int hold = array[i];
                sum += hold;
            }

            int avg = (sum / array.Length);
            Console.WriteLine($"The average of these inputed {array.Length} numbers is:" + avg);
            return avg;
        }
        // challenge 3
        public static void daimond()
        {
            Console.WriteLine("    *    ");
            Console.WriteLine("   ***   ");
            Console.WriteLine("  *****  ");
            Console.WriteLine(" ******* ");
            Console.WriteLine("*********");
            Console.WriteLine(" ******* ");
            Console.WriteLine("  *****  ");
            Console.WriteLine("   ***   ");
            Console.WriteLine("    *    ");
        }
        // challenge 4
        public static int appears(int[] arr)
        {
            int num = 0;
            int maxnum = 0;
            int cauntar = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        cauntar++;
                    }
                }
                if (cauntar > maxnum)
                {
                    maxnum = cauntar;
                    num = arr[i];
                }
                cauntar = 0;
            }
            return num;

        }
        // challenge 5
        public static int MaxNumber(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }
        // challenge 6
        public static void WriteAWord(String filePath)
        {
            Console.WriteLine("enter a word ");
            string word = Console.ReadLine();
            File.AppendAllText(filePath, word);
        }
        // challenge 7
        public static void ReadAWord(String filePath)
        {
            string fileContent = File.ReadAllText(filePath);
            Console.WriteLine(fileContent);
        }
        //challenge 8
        public static void DeletAndWrte(string filePath)
        {
            string word = File.ReadAllText(filePath);
            string endword = word.Substring(0, word.LastIndexOf(' ')).TrimEnd();
            Console.WriteLine(endword);
        }
        // challenge 9
        public static string[] WordsCauntar(string input)
        {

            string[] arr = input.Split(" ");
            string[] x = new string[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                x[i] = $"{arr[i]}:{arr[i].Length},";
                Console.Write(x[i]);
            }
            return x;
        }



    }
}
