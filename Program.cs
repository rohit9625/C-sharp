using System;

namespace Hello
{
    class Program
    {
        // Creating Function || Method
        static void greet(string name)
        {
            Console.WriteLine($"Hello! {name}, Good Morning.");
        }
        // Method to find average or three numbers
        static float Avg(int a, int b, int c)
        {
            return (a + b + c) / 3F;
        }
        // Same Avg method but with 2 parameters
        static float Avg(int a, int b)
        {
            return (a + b) / 2F;
        }

        static void Main(string[] args)
        {
            //Single line comment
            /* Multi-line comment
                          
             Console.WriteLine("Hello, World !"); //WriteLine() prints along with next line
             Console.Write("Hello Rohit, "); //Write() prints without next line
             Console.WriteLine("I am learning C#");
            */

            //Variables
            //->It is a name of a container that stores some data in the memory.
            /*            
             * int rohit = 21; //rohit is variable here ,i.e. of integer data type
             * Console.WriteLine(rohit);
             * //Data types
             * int age = 20; //Integer - 4 bytes
             * //Long - 8 bytes
             * float cgpa = 7.1F; //Floating point number - 4 bytes
             * //Double - 8 bytes
             * char ch = 'R'; //Character - 2 bytes
             * bool isBoy = true; //Boolean - 1 bit
             * string name = "Rohit"; //String - n*2 bytes (n = no. of characters in a string)
             */

            // Typecasting  
            /* There are two types of casting
             * 1. Implicit Typecasting
             * char < int < long < float < double
             * 
             * 2. Explicit Typecasting
             * int x = (int)1.43;
             * float = 3.2F;
             */
            // Typecasting using method
            /*
             * float var = Convert.ToInt32(3.321);
             * Similarly:-
             * Convert.ToDouble();
             * Convert.ToString();
             * Convert.ToFloat();
            
             * Console.WriteLine(var );
             */

            // Taking user input
            // string name;
            // Console.WriteLine("Enter your name : ");
            // name = Console.ReadLine();
            // Console.WriteLine("Hello :), "+name);

            /* ->Operators in C#
             1. Arithmetic Operators (+, -, /, *, %)
             2. Assignment Operators (=, +=, -=, /=, *=, %=)
             3. Logical Operators (&&, ||, !)
             4. Comparison Operators (<, <=, >, >=, ==)
            */
            // Arithmetic & Assignment
            // int a = 5, b = 6;
            // a = a + b; //or a =+ b --> 11
            // a -= b; //11 - 6 = 5;
            // Console.WriteLine(a);

            // Logical (returns boolean value ,i.e. true or false)
            // Console.WriteLine(true && false); //false
            // Console.WriteLine(true && true); //true
            // Console.WriteLine(true || false); //true
            // Console.WriteLine(true || true); //true
            // Console.WriteLine(!true); //false
            // Console.WriteLine(!false); //true;

            // Comparison 
            // Console.WriteLine(143 < 341); //true
            // Console.WriteLine(143 > 341); //false
            // Console.WriteLine(7 <= 7); //true
            // Console.WriteLine(5 == 5); //true

            //->Math class in C#
            // int max = Math.Max(12, 21);
            // int min = Math.Min(12, 21);
            // double sqrt = Math.Sqrt(625);
            // double cbrt = Math.Cbrt(27);
            // int abs = Math.Abs(-1);
            // Console.WriteLine(max);
            // Console.WriteLine(min);
            // Console.WriteLine(sqrt);
            // Console.WriteLine(cbrt);
            // Console.WriteLine(abs);

            // *String methods
            // string greeting = "Hello, Good Morning";
            // Console.WriteLine(greeting.Length);
            // Console.WriteLine(greeting.ToUpper());
            // Console.WriteLine(greeting.ToLower());
            // Console.WriteLine(greeting + " Namaste ");
            // Console.WriteLine(string.Concat(greeting, " Namaste "));

            // String interpullation
            // Console.WriteLine("Enter your name :-");
            // string name = Console.ReadLine();
            // string age = Console.ReadLine();
            // Console.WriteLine($"Your name is {name}. You are {age} years old.");

            // String is an array[0 base indexing]
            // string hello = "Hello";
            // Console.WriteLine(hello[0]); //H
            // Console.WriteLine(hello[1]); //e

            // Substring method
            // string alph = "ABCDEFG";
            // Console.WriteLine(alph.Substring(4));

            // Escape sequence characters
            // ->We can use any character in our string by using \
            // eg.
            // string str = "Message \"Drink Coffee\" \n->Do it now"; // \n use for next line
            // Console.WriteLine(str);

            // if-else statements
            // string ageStr = Console.ReadLine();
            // int age = Convert.ToInt32(ageStr);
            // if(age >= 18) {
            //     Console.WriteLine("You can drive :)");
            // }
            // else if(age < 18 && age > 12) {
            //     Console.WriteLine("You cannot drive :(");
            // }
            // else {
            //     Console.WriteLine("You just borned :|");
            // }

            //Switch case statements
            // switch(age) {
            //     case 18: Console.WriteLine("You are 18");
            //              break;
            //     case 21: Console.WriteLine("Your are 21");
            //              break;

            // }


            // Loops in C#
            /* -> There are three types of loops in C# :-
             * 1. while()
             * 2. do {
             * 
             *    }while()
             * 3. for()
            */

            // >> while()
            // int i = 0;
            //while(i < 10) {
            //     Console.Write(i + " ");
            //     i++;
            // }

            // >> do{ }while()
            // do{
            //     Console.WriteLine(i + " ");
            //     i++;
            // } while (i < 10);

            // >> for()
            // for(i=0; i<100; i++) {
            //     Console.Write(i + " ");
            // }

            /* Note 
             * -> break keyword use to leave the sequence
             * -> continue keyword use to skip current sequence and jumps to next one.
             */

            //Calling User Defined Methods
            // greet("Rohit");
            // greet("Anjali");
            // Console.WriteLine(Avg(1, 4, 3));
            // Console.WriteLine(Avg(1, 4));

            // OOPS - Classes and Objects
            Class1 rohit = new Class1();
            Console.WriteLine(rohit.name);
            Console.WriteLine(rohit.health);
            rohit.setHealth(95);
            Console.WriteLine(rohit.health);


            Console.ReadLine(); //It works is to hold screen
        }

    }

}
