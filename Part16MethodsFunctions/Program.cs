using System;

namespace Part16MethodsFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Enter no to get upto even numbers:");
            int d = int.Parse(Console.ReadLine());
            p.EvenNumbers(d);
            Console.WriteLine("Enter First No For Add:");
            int j=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second No For Add:");
            int k = int.Parse(Console.ReadLine());
            int l=Program.Add(j,k);
            Console.WriteLine("Addition of {0} + {1} ={2}", j, k, l);
           
        }
        //this is the static method using class name we can access
        public static int Add(int a,int b)
        {
            return a + b;
        }
        //this is the instance method
        public void EvenNumbers(int target)
        {
            int start = 0;
            while (start <= target)
            {
                Console.WriteLine(start + "");
                start = start + 2;

            }
        }
    
}
}
