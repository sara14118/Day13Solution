namespace Day13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("sara", 28, 12343534, "Muscat", "Trainee" , 9 , 10.3);

            Console.WriteLine(emp1);


            emp1.Move();
        }
    }
}