using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculations cal = new Calculations();

            bool flag = true;
            bool resultFlag = false;
            double result = 0;
            while (flag)
            {
                Console.WriteLine("****** MENU ******");
                Console.WriteLine("1 : Addition");
                Console.WriteLine("2 : Substraction");
                Console.WriteLine("3 : Multiplication");
                Console.WriteLine("4 : Division");
                Console.WriteLine("5 : Modulus");
                Console.WriteLine("6 : Square of a number");
                Console.WriteLine("7 : Square Root of a number");
                Console.WriteLine("8 : Power function");
                Console.WriteLine("9 : Exit");
                Console.Write("Choose an Option from MENU : ");
                int choice = int.Parse(Console.ReadLine());
                
                

                switch(choice)
                {
                    case 1:
                        {
                            double x;
                            if (resultFlag == false)
                            {
                                Console.Write("Enter the first number : ");
                                x = double.Parse(Console.ReadLine());
                            }
                            else
                                x = result;
                            Console.Write("Enter the second number : ");
                            double y = double.Parse(Console.ReadLine());

                            result = cal.Add(x, y);
                            Console.WriteLine("result : " + result);
                            Console.Write("Do you want to perform operations on result (y/n) : ");
                            string str = Console.ReadLine();
                            if(str == "y")
                                resultFlag = true;
                            else
                                resultFlag = false;
                            break;
                        }
                    case 2:
                        {
                            double x;
                            if (!resultFlag)
                            {
                                Console.Write("Enter the first number : ");
                                x = double.Parse(Console.ReadLine());
                            }
                            else
                                x = result;
                            Console.Write("Enter the second number : ");
                            double y = double.Parse(Console.ReadLine());

                            result = cal.Substract(x, y);
                            Console.WriteLine("result : " + result);
                            Console.Write("Do you want to perform operations on result (y/n) : ");
                            string str = Console.ReadLine();
                            if (str == "y")
                                resultFlag = true;
                            else
                                resultFlag = false;
                            break;
                        }
                    case 3:
                        {
                            double x;
                            if (!resultFlag)
                            {
                                Console.Write("Enter the first number : ");
                                x = double.Parse(Console.ReadLine());
                            }
                            else
                                x = result;
                            Console.Write("Enter the second number : ");
                            double y = double.Parse(Console.ReadLine());

                            result = cal.Multiplication(x, y);
                            Console.WriteLine("result : " + result);
                            Console.Write("Do you want to perform operations on result (y/n) : ");
                            string str = Console.ReadLine();
                            if (str == "y")
                                resultFlag = true;
                            else
                                resultFlag = false;
                            break;
                        }
                    case 4:
                        {
                            double x;
                            if (!resultFlag)
                            {
                                Console.Write("Enter the first number : ");
                                x = double.Parse(Console.ReadLine());
                            }
                            else
                                x = result;
                            Console.Write("Enter the second number : ");
                            double y = double.Parse(Console.ReadLine());

                            if(y == 0)
                            {
                                Console.WriteLine("invalid operation");
                                break;
                            }

                            result = cal.Divide(x, y);
                            Console.WriteLine("result : " + result);
                            Console.Write("Do you want to perform operations on result (y/n) : ");
                            string str = Console.ReadLine();
                            if (str == "y")
                                resultFlag = true;
                            else
                                resultFlag = false;
                            break;
                        }
                    case 5:
                        {
                            double x;
                            if (!resultFlag)
                            {
                                Console.Write("Enter the first number : ");
                                x = double.Parse(Console.ReadLine());
                            }
                            else
                                x = result;
                            Console.Write("Enter the second number : ");
                            double y = double.Parse(Console.ReadLine());

                            result = cal.Modulus(x, y);
                            Console.WriteLine("result : " + result);
                            Console.Write("Do you want to perform operations on result (y/n) : ");
                            string str = Console.ReadLine();
                            if (str == "y")
                                resultFlag = true;
                            else
                                resultFlag = false;
                            break;
                        }
                    case 6:
                        {
                            double x;
                            if (!resultFlag)
                            {
                                Console.Write("Enter the first number : ");
                                x = double.Parse(Console.ReadLine());
                            }
                            else
                                x = result;

                            result = cal.Square(x);
                            Console.WriteLine("result : " + result);
                            Console.Write("Do you want to perform operations on result (y/n) : ");
                            string str = Console.ReadLine();
                            if (str == "y")
                                resultFlag = true;
                            else
                                resultFlag = false;
                            break;
                        }
                    case 7:
                        {
                            double x;
                            if (!resultFlag)
                            {
                                Console.Write("Enter the first number : ");
                                x = double.Parse(Console.ReadLine());
                            }
                            else
                                x = result;
                            
                            result = cal.SqRoot(x);
                            Console.WriteLine("result : " + result);
                            Console.Write("Do you want to perform operations on result (y/n) : ");
                            string str = Console.ReadLine();
                            if (str == "y")
                                resultFlag = true;
                            else
                                resultFlag = false;
                            break;
                        }
                    case 8:
                        {
                            double x;
                            if (!resultFlag)
                            {
                                Console.Write("Enter the first number : ");
                                x = double.Parse(Console.ReadLine());
                            }
                            else
                                x = result;
                            Console.WriteLine("Enter the second number : ");
                            double y = double.Parse(Console.ReadLine());

                            result = cal.PowerFunction(x, y);
                            Console.WriteLine("result : " + result);
                            Console.Write("Do you want to perform operations on result (y/n) : ");
                            string str = Console.ReadLine();
                            if (str == "y")
                                resultFlag = true;
                            else
                                resultFlag = false;
                            break;
                        }
                    case 9:
                        {
                            flag = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid option");
                            break;
                        }
                }
            }
        }
    }
}
