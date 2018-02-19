using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static int GetMyAge()
        {
            return 23;
        }
        static void Main(string[] args)
        {
            //string myStringA = "shag-academy";
            //string myStringB = new string(new char [] { 'S', 'E', 'P' });

            //// UpperCase and LowerCase
            ////string upperVersion = myStringA.ToUpper();
            ////Console.WriteLine(upperVersion);
            ////Console.WriteLine(myStringA.ToUpper());

            ////Console.WriteLine(myStringA);

            ////Console.WriteLine(myStringA.Count().ToString().ToLower());

            //string myStringC = "..!!!..!. ...#iskander-raimbayev-c#-lecturer...!...";

            ////int splittedResult = myStringC.Split('-').Count();

            ////Console.WriteLine(splittedResult);

            ////string replacement = myStringC.Replace('#', '+');
            ////string replacement = myStringC.Replace("#", "++");

            //Console.WriteLine(myStringC.Trim(new char[] { '.', '!', ' ' }));

            //string myNewString = "ab"; // Concatenation
            //myNewString += "b";

            //var result = String.Concat("wwwww", "qqqqq");

            //string mainString = "hello_my_dear_beer";

            //bool isContainsBeerWord = mainString.ToLower().Contains("beer");

            //int indexOfBeer = mainString.IndexOf("beer");
            //Console.WriteLine(mainString);
            //Console.WriteLine(indexOfBeer);

            //string a = "AAAA";
            //string b = "BBBB";
            //string c = "CCCC";

            ////Console.WriteLine(a);
            ////Console.WriteLine(a + " " + b);
            //// Console.WriteLine("{1}\n{1}\n{2}-{2}-{3}", a, b, c, DateTime.Now);

            ////var result = String.Format("{1}\n{1}\n{2}-{2}-{3}", a, b, c, DateTime.Now);
            //// Console.WriteLine(result);

            //// Interpolation of Strings
            ////string This = "this";

            ////Console.WriteLine($"{This} is my {GetMyAge()} - {GetMyAge()} - {b} adawdaw {c} dadawd {c}");

            //int mySalary = 2000;

            //Console.OutputEncoding = UTF8Encoding.UTF8;

            //CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture("ru-KZ");

            //Console.WriteLine(String.Format(cultureInfo, "{0:X}", mySalary)); // Currency

            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            //StringBuilder sb = new StringBuilder();
            //sb.Append("aaaa");
            //stopwatch.Stop();
            //Console.WriteLine(stopwatch.Elapsed);

            //Stopwatch stopwatch2 = new Stopwatch();
            //stopwatch2.Start();
            //string a = "aaaa";
            //stopwatch2.Stop();
            //Console.WriteLine(stopwatch2.Elapsed);

            //sb.Append(" ");

            //string emptyString = "";

            //for (int i = 0; i < 1000000; i++)
            //{
            //    //emptyString += "a";
            //    //sb.Append("a");
            //}
            ////Console.WriteLine(sb.ToString().Count());


            string myString = "apple_tree";

            foreach (var item in myString)
            {
                Console.WriteLine((int)item);
            }

        
            Console.ReadLine();
        }
    }
}
