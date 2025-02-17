namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bubble Sort: \n");
            BubbleSort();
            Console.WriteLine("-------------");



        }
        static void BubbleSort()
        {
            Student bob = new Student("Bob", 5);
            Student john = new Student("John", 7);
            Student a = new Student("a", 7);
            Student b = new Student("b", 59);
            Student c = new Student("c", 19);
            Student d = new Student("d", 29);
            Student[] students = new Student[] { john, bob, a, c, john, b, d };

            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = 0; j < students.Length - i - 1; j++)
                {
                    if (students[j].Age > students[j + 1].Age)
                    {
                        (students[j], students[j + 1]) = (students[j + 1], students[j]);
                    }
                }
            }
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Name} : {student.Age}");
            }
        }

    }
}
