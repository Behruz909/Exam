using System.ComponentModel.Design;
using System.Net.Http.Headers;

namespace _1modulImtihon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            List<int> numbers = new List<int> { 1, 2, 4, 7, 10 };
            Console.WriteLine(CountEvenNumbers(numbers));

            // 2
            List<string> words = new List<string> { "hello", "world", "apple" };
            Console.WriteLine(ElementUzunligi words));

            // 3
            Console.WriteLine(BoshidagiElement("SalomDunyo"));

            // 4
            string result = "PDP";
            Console.WriteLine(PDP(result));

            // 5
            Console.WriteLine(("Salom g13"));


        }

        // 1
        static int CountEvenNumbers(List<int> list)
        {
            int count = 0;
            foreach (int item in list)
            {
                if (item % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }

        //2
        static bool ElementUzunligi(List<string> list)
        {
            foreach (string item in list)
            {
                if (item.Length <= 5)
                {
                    return false;
                }
            }
            return true;
        }

        //3
        static string BoshidagiElement(string text)
        {
            if (text.Length < 3)
            {
                return text;
            }
            return text.Substring(0, 3);
        }

        //4
        static bool PDP(string pdp)
        {
            var res string = pdp.Substring(startIndex0, length3);
            return res == "PDP";
        }

        //5
        static bool G13(string text)
        {
            if (text.Contains("g13"))
            {
                return true;
            }
            else
            {
                return false;
            }














        }
    }
}

