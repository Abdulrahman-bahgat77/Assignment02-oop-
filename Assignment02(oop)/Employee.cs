using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02_oop_
{
    #region Q3
    enum Gender
    {
        male = 1,
        female = 2
    }
    #endregion

    #region Q4
    enum Securityprivileges
    {
        guest = 1,
        developer = 2,
        secertary = 4,
        DBMA = 8,

    }
    #endregion
    internal class Employee
    {
        #region Q1
        #region Attribute
        int id;
        string name;
        double salary;
        Gender gender;
        Securityprivileges security;
        HiringDate hiringDate;
        #endregion
        #region property
        public int Id { get => id; set => id = value; }
        public string Nmae { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }
        internal Securityprivileges Security { get => security; set => security = value; }
        internal Gender Gender { get => gender; set => gender = value; }
        public HiringDate HiringDate { get => hiringDate; set => hiringDate = value; }
        #endregion

        #region constructor
        public Employee()
        {
            hiringDate = new HiringDate();
        }
        #endregion
        #endregion

        #region Q5
        public override string ToString()
        {
            return $"Id={id}\nName{name}\nSalary={salary:C}\nGender={gender}\nSecur={security}\nHiringDate={hiringDate}";
        }
        #endregion

        #region arraycreation
        public static Employee[] Createmployee(int size)
        {
            if (size > 0)
            {
                Employee[] employee = new Employee[size];
                for (int i = 0; i < size; i++)
                {
                    employee[i] = new Employee();

                }
                return employee;
            }
            throw new ArgumentOutOfRangeException();
        }
        #endregion

        #region insertData
        public static void insertdate(Employee[] employee)
        {
            if (employee is not null)
            {
                for (int i = 0; i < employee.Length; i++)
                {
                    Console.WriteLine($"enter data of epmlyee{i + 1}");
                    bool flag;
                    do
                    {
                        Console.WriteLine($"enter id:");
                        flag = int.TryParse(Console.ReadLine(), out employee[i].id);
                    } while (!flag);

                    do
                    {
                        Console.WriteLine("enter Nmae:");
                        employee[i].name = Console.ReadLine();
                    } while (String.IsNullOrEmpty(employee[i].name));

                    do
                    {
                        Console.WriteLine($"enter salary:");
                        flag = double.TryParse(Console.ReadLine(), out employee[i].salary);
                    } while (!flag);
                    int gender1;
                    Console.WriteLine("male=1 and female=2");
                    do
                    {
                        Console.WriteLine($"enter gender:");
                        flag = int.TryParse(Console.ReadLine(), out gender1);
                    } while (!flag);
                    employee[i].gender = (Gender)gender1;

                    Console.WriteLine(" guest = 1, developer = 2, secertary = 3, DBMA = 4");
                    int secure;
                    do
                    {
                        Console.WriteLine("enter security level");
                        flag = int.TryParse(Console.ReadLine(), out secure);
                    } while (!flag);
                    employee[i].security = (Securityprivileges)secure;

                    Console.WriteLine("enter Hiring Date");
                    int day, month, year;
                    do
                    {
                        Console.WriteLine("Day:");
                        flag = int.TryParse(Console.ReadLine(), out day);
                    } while (!flag);
                    employee[i].HiringDate.Day = day;
                    do
                    {
                        Console.WriteLine("Month:");
                        flag = int.TryParse(Console.ReadLine(), out month);
                    } while (!flag);
                    employee[i].HiringDate.Month = month;

                    do
                    {
                        Console.WriteLine("Year:");
                        flag = int.TryParse(Console.ReadLine(), out year);
                    } while (!flag);
                    employee[i].HiringDate.Year = year;

                }
            }
        }

            #endregion

            #region print
           public static void Print(Employee[] empr) {
            for (int i = 0; i < empr.Length; i++)
            {
                Console.WriteLine($"data of employee{i+1}");

                Console.WriteLine(empr);
            }



        }
            
            #endregion
        }
    }

