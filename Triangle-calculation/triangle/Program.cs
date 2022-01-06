using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            String s;
            String[] input;

            StreamWriter sw = new StreamWriter("triangle2.csv");
            StreamReader sr = new StreamReader("triangle.csv");
            while (((s = sr.ReadLine()) != null)) //null = all files are read.
            {
                Console.WriteLine(s);

                input = s.Split(','); //allocate variable which are seperated by comma into array
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                int c = int.Parse(input[2]); 
                
                string result = CheckTriangle(a,b,c);
                double area = GetArea(a, b, c);

                sw.WriteLine("{0},{1},{2},{3},{4}", input[0], input[1], input[2], result, area);
            }
            sr.Close();
            sw.Close(); //close before using reader



            Console.ReadKey();
        }

        static string CheckTriangle(int a, int b,int c)
        {
            if( a + b >= c && b+c >= a && c+a >= b){
                return "YES";
            }
            else
            {
                return "NO";
            }
        }
        static double GetArea(int a, int b, int c)
        {
            if (CheckTriangle(a, b, c) == "NO") return -1;
            double s = (a / 1.0 + b / 1.0 + c / 1.0) / 2;
            double area = Math.Pow((s*(s-a)*(s-b)*(s-c)), 0.5);
            return area;
        }
    }
}
