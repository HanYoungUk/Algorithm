using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
             int count = int.Parse(Console.ReadLine());
             StringBuilder sb = new StringBuilder();

             for(int i = 0; i < count; i++)
             {
                 string str = Console.ReadLine();

                 string[] arr = str.Split(" ");

                 string name = arr[0];
                 int score = int.Parse(arr[1]);

                 if(score >= 97)
                 {
                     sb.AppendLine($"{name} A+");
                 }
                 else if (score >= 90 && score <= 96)
                 {        
                     sb.AppendLine($"{name} A");
                 }
                 else if(score >= 87 && score <= 89)
                 {
                     sb.AppendLine($"{name} B+");
                 }
                 else if (score >= 80 && score <= 86)
                 {
                     sb.AppendLine($"{name} B");
                 }
                 else if (score >= 77 && score <= 79)
                 {
                     sb.AppendLine($"{name} C+");
                 }
                 else if (score >= 70 && score <= 76)
                 {
                     sb.AppendLine($"{name} C");
                 }
                 else if (score >= 67 && score <= 69)
                 {
                     sb.AppendLine($"{name} D+");
                 }
                 else if (score >= 60 && score <= 66)
                 {
                     sb.AppendLine($"{name} D");
                 }
                 else
                 {
                     sb.AppendLine($"{name} F");
                 }
             }

             Console.WriteLine( sb.ToString() );
        }
    }
}
