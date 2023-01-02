using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {

        static void Main(string[] args)
        {



            /*
            Console.Write("please enter your GPA out of 4 : ");
            try {
                int marks = int.Parse(Console.ReadLine());
                Console.Write("if-else : ");
                if (marks == 4)
                    Console.WriteLine("distinction");
                else if (marks == 3)
                    Console.WriteLine("first class");
                else if (marks == 2)
                    Console.WriteLine("pass");
                else
                    Console.WriteLine("fail");

                Console.Write("switch-case : ");
                switch (marks)
                {
                    case 4:
                        {
                            Console.WriteLine("distinction");
                            break
    ;
                        }
                    case 3:
                        {
                            Console.WriteLine("first class");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("pass");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("fail");
                            break;
                        }
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            */

            /*
            string article = "create a string for article submission. take user input of blocked words. loop through each word check in the article and exit and reject if found. loop until the end and exit with accept if no word found. ask user if he wants to exit or check another set of words";
            bool flag = true;
            while (flag) {
                Console.Write("Enter the number of blocked words = ");
                try
                {
                    int num = int.Parse(Console.ReadLine());
                    string[] blockWords = new string[num];
                    Console.WriteLine("Enter the blocked words :");
                    for (int i = 0; i < num; i++)
                    {
                        blockWords[i] = Console.ReadLine();
                    }

                    bool check = true;
                    foreach (string str in blockWords)
                    {
                        if (article.Contains(str))
                        {
                            Console.WriteLine("article contains a blocked Word");
                            check = false;
                            break;
                        }
                    }
                    
                    if(check)
                        Console.WriteLine("article does not contain any blocked words");
                }
                catch {
                    Console.WriteLine("Enter a valid number : ");
                }
                

                Console.Write("enter \"yes\" to continue and \"no\" to exit : ");
                string option = Console.ReadLine();
                if (option == "no")
                    flag = false;
            }
            */

            /*
            String message = String.Empty;
            int val = 0;
            Console.WriteLine("****for TryParse****");
            Console.Write("please enter a number : ");
            bool check = int.TryParse(Console.ReadLine(), out val);

            if (check)
                message = val == 1 ? "correct value" : "wrong value";
            else
                message = "please enter a valid number";
            Console.WriteLine(message);

            Console.WriteLine("****for try catch****");
            Console.Write("please enter a number : ");
            try{
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("square of the input number : " + (num * num));
            }
            catch(Exception e) {
                Console.WriteLine("enter a valid number : " + "System error : " + e.Message);
            }
            */

            /*
            int? totalTicket = null;
            int avaiTicket = 0;

            avaiTicket = totalTicket ?? 0;
            */
            /*
            Console.Write("Enter the marks out of 100 : ");
            int num = int.Parse(Console.ReadLine());

            if (num >= 90)
                Console.WriteLine("distinction");
            else if(num >= 60 && num <= 89)
                Console.WriteLine("first class");
            else if(num >= 35 && num <= 59)
                Console.WriteLine("pass");
            else if(num < 35)
                   Console.WriteLine("fail");

            string str = num >= 90 ? "distinction" : num >= 60 ? "first class" : num >= 35 ? "pass" : "fail";
            Console.WriteLine(str);
            */


            /*
            float x = -10.178F;
            float y = 10.178F;

            Console.WriteLine(Math.Round(x));
            Console.WriteLine(Math.Round(y));
            Console.WriteLine(Math.Round(x,2));
            Console.WriteLine(Math.Round(y,2));

            Console.WriteLine(Math.Abs(x));
            Console.WriteLine(Math.Abs(y));

            Console.WriteLine(Math.Ceiling(x));
            Console.WriteLine(Math.Ceiling(y));

            Console.WriteLine(Math.Floor(x));
            Console.WriteLine(Math.Floor(y));

            Console.WriteLine(Math.Truncate(x));
            Console.WriteLine(Math.Truncate(y));
            */

            /*
            string str = "my name is Rehan Dilkash";
            Console.WriteLine("length of str : " + str.Length);

            Console.WriteLine("str in upper case : " + str.ToUpper());
            Console.WriteLine("str in lower case : " + str.ToLower());

            string firstName = "Rehan";
            string lastName = "Dilkash";

            string name = firstName + lastName;
            Console.WriteLine("full name using + : " + name);

            string name1 = string.Concat(firstName, lastName);
            Console.WriteLine("full name using concat : " + name1);

            string name2 = $"My full name is {firstName} {lastName}";
            Console.WriteLine("interpolation : " + name2);

            string myString = "Hello";
            Console.WriteLine("access string using [] : " + myString[4]);

            string name3 = firstName + " " + lastName;
            int pos = name3.IndexOf("D");
            Console.WriteLine("index of D : " + pos);
            Console.WriteLine("substring starting at index pos : " + name3.Substring(pos));
            Console.WriteLine(name3.Substring(pos,4));
            */

            /*
            String str = "hello, whats your name? where are you from";
            bool check = str.Contains("name");

            if (check)
                Console.WriteLine("Rejected");
            else
                Console.WriteLine("Accepted");
            */

            /*
            String firstName = "Rehan";
            String lastName = "Dilkash";

            Console.WriteLine("hey" + " " + firstName + " " + lastName + " " + "you are welcome");
            Console.WriteLine("hey {0} {1} you are welcome", firstName, lastName);
            Console.WriteLine($"hey {firstName} {lastName} you are welcome");
            */


            /*
            Console.WriteLine("Enter a number : ");
            int val = int.Parse(Console.ReadLine());
            int radius = 10;
            Multiplier.square(radius);
            Multiplier.square(val);
            */
            Console.ReadLine();
        }
    }

    public class Multiplier
    {
        public int Square(int x)
        {
            return x * x;
        }

        public int Cube(int x)
        {
            return x * x * x;
        }

        public int Quad(int x) 
        {
            return x * x * x * x;
        }

        public int[] MulOperations(int x)
        {
            /*
            Console.WriteLine("square : " + Square(x));
            Console.WriteLine("cube : " + Cube(x));
            Console.WriteLine("quad : " + Quad(x));
            */
            
            int[]ans = new int[3];
            ans[0] = x * x;
            ans[1] = x * x * x;
            ans[2] = x * x * x * x;

            return ans;
        }

        public void calculate (int x, out int square, out int cube, out int quad)
        {
            square = x * x;
            cube = x * x * x;
            quad = x * x * x * x;
        }

        public static void square(int r)
        {
            Console.WriteLine(r * r);
        }
    }
}
