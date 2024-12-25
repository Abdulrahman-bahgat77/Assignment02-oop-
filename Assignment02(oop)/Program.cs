namespace Assignment02_oop_
{
    internal class Program
    {
       
        static void Main(string[] args)
        {


            #region Q6
            Employee[] employee = Employee.Createmployee(4);
            Employee.insertdate(employee);
            Employee.Print(employee);

            #endregion

        

        }
    }
}
