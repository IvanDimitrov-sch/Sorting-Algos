namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student bob = new Student("Bob", 5);
            Student john = new Student("John", 7);
            Student a = new Student("a", 7);
            Student b = new Student("b", 59);
            Student c = new Student("c", 19);
            Student d = new Student("d", 29);
            Student[] students= new Student[] { bob, john, a, b, c, d };

            for(int i =0; i<students.Length; i++)
            {
                
            }




        }
    }
}
