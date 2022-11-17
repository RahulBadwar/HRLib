using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLib;
namespace ConsoleApp1
{
    internal class Program
    {
        private static Dictionary<int, Emp> list = new Dictionary<int, Emp>();
        static void Main(string[] args)
        {
            int ch;


            do
            {
                Console.WriteLine("Enter your choice");
                Console.WriteLine("1.All emp");
                Console.WriteLine("2.Insert Confirm Employee");
                Console.WriteLine("3.Insert Trainee");
                Console.WriteLine("4.Delete Employee");
                Console.WriteLine("5.Display Employee by No");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("All emp");
                        foreach (KeyValuePair<int, Emp> item in list)
                        {
                            Console.WriteLine("id  " + item.Key + "  " + item.Value + " salary" + item.Value.CalculateSalary());
                        }
                        break;
                    case 2:
                        Console.WriteLine("2.Insert Confirm Employee");
                        Console.WriteLine("Enter a name");


                        string name = Console.ReadLine();
                        Console.WriteLine("Enter a city");
                        string city = Console.ReadLine();

                        Console.WriteLine("Enter a basic");
                        int basic = Convert.ToInt32(Console.ReadLine());
                        if (basic < 5000)
                        {
                            try
                            {
                                throw new BasicException("Low basic");
                            }
                            catch
                            {
                                Console.WriteLine("cannot add low basic");
                                break;
                            }
                        }
                        Console.WriteLine("Enter a desingnation");
                        string desingnation = Console.ReadLine();

                        ConfirmEmployee confirmEmployee = new ConfirmEmployee(name, city, basic, desingnation);
                        list.Add(confirmEmployee.Id, confirmEmployee);
                        break;
                    case 3:
                        Console.WriteLine("3.Insert Trainee");
                        Console.WriteLine("Enter a name");


                        name = Console.ReadLine();
                        Console.WriteLine("Enter a city");
                        city = Console.ReadLine();

                        Console.WriteLine("Enter a Noofdays");
                        int days = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter a Rate");
                        double rate = Convert.ToDouble(Console.ReadLine());

                        Trainee trainee = new Trainee(name, city, days, rate);
                        list.Add(trainee.Id, trainee);

                        break;
                    case 4:
                        Console.WriteLine("4.Delete Employee");
                        Console.WriteLine("Enter a emp number to delete");
                        int number = Convert.ToInt32(Console.ReadLine());
                        list.Remove(number);
                        break;
                    case 5:
                        Console.WriteLine("5.Display Employee by No");
                        Console.WriteLine("Enter a emp number to show");
                        number = Convert.ToInt32(Console.ReadLine());
                        Emp emp = list[number];
                        Console.WriteLine(emp);
                        break;
                }


            } while (ch != 6);

        }
    }
}
