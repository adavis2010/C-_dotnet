using System;

namespace Statements_Tutorial {
    class Program {
        static void Main(string[] args) {
            // Console.WriteLine("Enter a number");
            //var anbr = Console.ReadLine();
            // var nbr = Convert.ToInt32(anbr);
            // if (nbr % 2 == 0) { 
            //Console.WriteLine($"the number {nbr} is even");

            //else
            //Console. WriteLine($"the number {nbr} is odd");

            //}

            var ints = new[] { 77, 32, 94, 46, 28 };
            for (var idx = 0; idx < 5; idx++) {
                Console.WriteLine($"idx is {idx} and {ints[idx]}");
            }

        }

    }

}





