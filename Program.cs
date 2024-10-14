namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.datetime = new DateTime(2001, 12, 01);
            Student s = new Student();
            s.GetName = "Togrul";
            s.GetAge = 21;
        }
    }
}
