using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OperatorsAndControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {

           




            // Arithmetic Operators

            const int a = 10;
            const int b = 3;

            const string name = "showit";

            const int add = a + b;
            Console.WriteLine(add);

            const int sub = a - b;
            Console.WriteLine(sub);

            const int multiply = a * b;
            Console.WriteLine(multiply);

            const int divide = a / b;
            Console.WriteLine(divide);

            const int mod = a % b;
            Console.WriteLine(mod);


            //Console.ReadLine();



            // Relational Operators

            // == 
            // !=
            // >
            // <
            // >=
            // <=

            //Console.WriteLine(a == b);
            //Console.WriteLine(a != b);
            //Console.WriteLine(a > b);
            //Console.WriteLine(a >= b);



            // Logical Operators

            // Logical AND ->  &&
            // Logical OR -> ||
            // Logical NOT -> !


            //                  OR      AND
            // true false       true    false
            // false true       true    false
            // false false      false   false
            // true true        true    true

            // if every condition is true, Output => True
            if (a > b && name == "showit" && a == 10)
            {
                Console.WriteLine("True");
            }


            // if any condition is true, Output => True

            if (a == b || name == "showit")
            {
                Console.WriteLine("Logical OR");
            }

            // 

            //  (a == b && a != 10)  || (b > 1)
            //  (a == b) && (a != 10 || b > 1)

                   // false || true
            if ((a == b && a != 10) || (b > 1))
            {
                Console.WriteLine("AND OR 1");
            }

                // false    // false || true
                // false      true
            if ((a == b) && (a != 10 || b > 1))
            {
                Console.WriteLine("AND OR 2");
            }


            // false || true
            if (!((a == b && a != 10) || (b > 1)))
            {
                Console.WriteLine("AND OR 1");
            }

            // false    // false || true
            // false      true
            if (!((a == b) && (a != 10 || b > 1)))
            {
                Console.WriteLine("AND OR 2");
            }

            //Console.WriteLine(!false);


            //if(a > b)
            //{
            //    Console.WriteLine("a is greater than b");
            //}else
            //{
            //    Console.WriteLine("a is smaller than b");
            //}

            //string output = (a > b) ? "a is greater than b" : a == 10 ? "a is 10 " : "a is not 10";


            //if (a > b)
            //{
            //    Console.WriteLine("a is greater than b");
            //}
            //else
            //{
            //    if(a == 10)
            //    {
            //        Console.WriteLine("a is 10");
            //    }
            //    else{
            //        Console.WriteLine("a is not 10");

            //    }
            //}

            var color = "Red";

            if(color == "Red")
            {
                Console.WriteLine("My Color is Red");
            } else if (color == "Blue")
            {
                Console.WriteLine("My Color is Blue");
            }
            else if (color == "Yellow")
            {
                Console.WriteLine("My Color is Yellow");
            }


            // Unary Operators

            int x = 10;

            x = --x;
            Console.WriteLine(x);
            x = x++;
            Console.WriteLine(x);

            //Console.WriteLine(output);

            // Control Flow Statements
            // If Else
            // Switch Case

            switch (color)
            {
                case "Red":
                    Console.WriteLine("My Color is Red");
                    break;

                case "Blue":
                    Console.WriteLine("My Color is Blue");
                    break;

                case "Yellow":
                    Console.WriteLine("My Color is Yellow");
                    break;

                default:
                    break;
            }


            // Print 1 to 100

            
            // Entry Controlled Loops
            for (int i = 10; i > 5; --i)
            {
                Console.WriteLine(i);
            }

            var list = new List<int>();
            list.Add(5);
            list.Add(8);
            list.Add(11);
            list.Add(15);

            for (int i = 0; i < list.Count; i ++)
            {
                Console.WriteLine(list[i]);
            }


            for (int i = 10; i > 5; i--)
            {
                Console.WriteLine(i);
            }

            int count = 0;
            while (count < 5)
            {
                Console.WriteLine(true);
                count++;
            }

            do
            {
                Console.WriteLine(true);
                count++;
            } while (count < 5);

            Console.ReadLine();




            // Type Casting OR Type Conversion

            // 2 Types Of Casting

            // Implicit Type Casting
            // Explicit Type Casting


            // byte => short, int, long, float, double
            // short => int, long, float, double
            // int => long, float, double
            // long => float, double
            // float => double


            //int numInt = 1500;

            //Type numIntType = numInt.GetType();

            //double numDouble = numInt;

            //Type numDoubleType = numDouble.GetType();


            //double numDouble = 10;

            //int numInt = (int)numDouble;

            //int var2 = Convert.ToInt32(numDouble);


            //double numDouble = 10.34;

            //int numInt = (int)numDouble;


            // 0 to 255 

            //int num1 = 500;
            //byte byteNum = (byte)num1;


            string num = "100";

            int aa = int.Parse(num);
            var bb = Convert.ToInt16(num);



            string cc = "True";
            bool dd = Convert.ToBoolean(cc);



            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(i);
                if(i == 5)
                {
                    break;
                }
            }



            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    continue;
                }

                Console.WriteLine(i);

            }

            Console.ReadLine();

        }
    }
}
