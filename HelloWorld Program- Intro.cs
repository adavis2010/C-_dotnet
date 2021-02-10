using System;

namespace HelloWorldProject {

    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World in C#!");
            Console.WriteLine("C# by Andrea Davis");
            var counter = 0;
            Console.WriteLine(counter);
            counter = counter + 13;
            Console.WriteLine(counter);
            counter = counter - 3;
            Console.WriteLine(counter);
            counter = counter * 5;
            Console.WriteLine(counter);
            counter = counter / 7;
            Console.WriteLine(counter);


            var numerator = 10.0;
            var denominator = 3.0;
            Console.WriteLine(numerator / denominator);

            var modulo = 10 % 3;
            Console.WriteLine(modulo);

            var firstname = "Andrea";
            var lastname = "Davis";
            var fullname = firstname + " " + lastname;
            Console.WriteLine(fullname);
            fullname = fullname.ToUpper();
            Console.WriteLine(fullname);

            var biggerScopeVariable = 77;
            {
                var scopeVariable = 1;
                Console.WriteLine(scopeVariable);
                biggerScopeVariable = biggerScopeVariable + 1;
            }
            biggerScopeVariable = biggerScopeVariable + 1;
            scopeVariable = scopeVariable + 1;


                ;
        }
    }
}
