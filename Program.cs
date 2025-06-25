namespace C_Sharp_A03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            //Console.Write("Enter a Number: ");
            //int number = int.Parse(Console.ReadLine()!);
            //if(number % 3 == 0 && number % 4 == 0)
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No");
            #endregion

            #region Q02
            //Console.Write("Enter a Number: ");
            //int number = int.Parse(Console.ReadLine()!);
            //if(number >= 0)
            //    Console.WriteLine("Positive");
            //else
            //    Console.WriteLine("Negative");
            #endregion

            #region Q03
            //Console.Write("Enter First number : ");
            //int num1 = int.Parse(Console.ReadLine()!);

            //Console.Write("Enter Second number : ");
            //int num2 = int.Parse(Console.ReadLine()!);

            //Console.Write("Enter Third number : ");
            //int num3 = int.Parse(Console.ReadLine()!);

            //Console.WriteLine("Max Element = " + (Math.Max(num1, Math.Max(num2, num3))));
            //Console.WriteLine("Min Element = " + (Math.Min(num1, Math.Min(num2, num3))));
            #endregion

            #region Q04
            //Console.Write("Enter First number : ");
            //int number = int.Parse(Console.ReadLine()!);
            //if(number % 2 == 0)
            //    Console.WriteLine("Even Number");
            //else
            //    Console.WriteLine("Odd Number");
            #endregion

            #region Q05
            //Console.Write("Enter a Character : ");
            //char inputChar = char.Parse(Console.ReadLine()!);
            //if (Array.IndexOf(['a', 'e', 'i', 'o', 'u'], inputChar) == -1)
            //    Console.WriteLine("Consonant");
            //else                 
            //    Console.WriteLine("Vowel");
            #endregion

            #region Q06
            //Console.Write("Enter a Number : ");
            //int number = int.Parse(Console.ReadLine()!);
            //int[] arr = new int[number];
            //for (int i = 1; i <= number; i++)
            //    arr[i - 1] = i;
            //Console.WriteLine(string.Join(", ", arr));
            #endregion

            #region Q07
            //Console.Write("Enter a Number : ");
            //int num = int.Parse(Console.ReadLine()!);
            //for (int i = num; i <= num * 12; i += num)
            //    Console.Write($"{i} ");
            #endregion

            #region Q08
            //Console.Write("Enter a Number : ");
            //int number = int.Parse(Console.ReadLine()!);
            //for (int i = 2; i <= number; i += 2) 
            //    Console.Write($"{i} ");
            #endregion

            #region Q09
            //Console.Write("Enter First Number : ");
            //int num1 = int.Parse(Console.ReadLine()!);
            //Console.Write("Enter Second Number : ");
            //int num2 = int.Parse(Console.ReadLine()!);
            //int result = num1;
            //for (int i = 1; i < num2; i++)
            //    result *= num1;
            //Console.WriteLine(result);
            #endregion

            #region Q10
            //int[] marks = new int[5];
            //int total = 0;
            //Console.WriteLine("Enter marks of five subjects : ");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write($"Subject {i + 1} = ");
            //    marks[i] = int.Parse(Console.ReadLine()!);
            //    total += marks[i];
            //}
            //Console.WriteLine("total marks = " + total);
            //Console.WriteLine("average marks= " + (int)(total / 5.0));
            //Console.WriteLine("Percentage = " + (int)((total / 500.0) * 100) + " %");
            #endregion

            #region Q11
            //Console.Write("Enter Month Number : ");
            //int month = int.Parse(Console.ReadLine()!);
            //switch (month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine("Days in Month: 31");
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine("Days in Month: 30");
            //        break;
            //    case 2:
            //        Console.WriteLine("Days in Month: 28");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid month number!");
            //        return;
            //}
            #endregion

            #region Q12
            //Console.Write("Enter a Number : ");
            //int n = int.Parse(Console.ReadLine()!);
            //for (int row = 0; row < n; row++)
            //{
            //    for (int col = 0; col < n; col++) 
            //    {
            //        if (row == col)
            //            Console.Write("1 ");
            //        else
            //            Console.Write("0 ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Q13
            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int sum = 0;
            //foreach (var num in arr)
            //    sum += num;
            //Console.WriteLine("Sum = " + sum);
            #endregion

            #region Q14
            //int[] arr = { 1, 2, 2, 3, 5, 3, 3, 4, 2, 2, 5 };
            //int[] uniqueValues = arr.Distinct().ToArray(); 
            //int[] freq = new int[uniqueValues.Length];

            //for (int i = 0; i < uniqueValues.Length; i++)
            //{
            //    freq[i] = 0;
            //    if (Array.IndexOf(arr, uniqueValues[i]) != Array.LastIndexOf(arr, uniqueValues[i]))
            //    {
            //        for (int j = 0; j < arr.Length; j++)
            //            if (arr[j] == uniqueValues[i])
            //                freq[i]++;
            //    }
            //    else
            //        freq[i] = 1;
            //}
            //for (int i = 0; i < uniqueValues.Length; i++)
            //{
            //    Console.WriteLine($"{uniqueValues[i]} => {freq[i]} times.");
            //}
            #endregion

            #region Q15
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int min = arr[0];
            //int max = arr[0];
            //foreach (var num in arr)
            //{
            //    min = Math.Min(min, num);
            //    max = Math.Max(max, num);
            //}
            //Console.WriteLine($"Maximum = {max}");
            //Console.WriteLine($"Minimum = {min}");
            #endregion

            #region Q16
            //int[] arr = { 4, 6, 1, 3, 5, 2, 9, 7, 8, 10 };
            //Array.Sort(arr);
            //Console.WriteLine($"second largest element = {arr[arr.Length - 2]}");
            #endregion

            Console.ReadLine();
        }
    }
}
