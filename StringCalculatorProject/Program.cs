using System;


namespace StringCalculatorKata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string numbers = "//;\n4;1";

            var sc = new StringCalculatorService();

            Console.WriteLine(sc.Add(numbers));
        }
    }
}