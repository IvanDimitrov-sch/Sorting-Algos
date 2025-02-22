﻿namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
            new Student("Иван", 13,5.50),
            new Student("Александър",27, 5.50),
            new Student("Георги",18, 6.00),
            new Student("Мария",29, 5.75),
            new Student("Николай",21, 5.75),
            new Student("Анна", 22,4.80)
            };

            Console.WriteLine("Bubble Sort: \n");
            BubbleSort();
            Console.WriteLine();
            Console.WriteLine("-------------");
            Console.WriteLine();
            Console.WriteLine("Selection Sort: \n");
            SelectionSort();
            Console.WriteLine();
            Console.WriteLine("-------------");
            Console.WriteLine("Insertion Sort: \n");
            InsertionSort(students);
            Console.WriteLine();
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
        static void SelectionSort()
        {
            Book a = new Book("1", "a");
            Book b = new Book("2", "b");
            Book c = new Book("3", "c");
            Book d = new Book("4", "d");
            Book f = new Book("5", "f");
            Book g = new Book("6", "g");

            Book[] books = new Book[] { a, g, c,f,g, b , d};
            for(int i = 0; i < books.Length - 1;i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < books.Length; j++)
                {
                    if (string.Compare(books[j].Title, books[minIndex].Title, StringComparison.Ordinal) < 0)
                    {
                        minIndex = j; 
                    }
                }
                (books[minIndex], books[i]) = (books[i], books[minIndex]);
            }

            
            foreach (Book book in books)
            {
                Console.WriteLine($"{book.Author} : {book.Title}");
            }
        }
        static void InsertionSort(List<Student> students)
        {
            for (int i = 1; i < students.Count; i++)
            {
                Student currentStudent = students[i];
                int j = i - 1;

                
                while (j >= 0 && (students[j].Grade < currentStudent.Grade ||
                                  (students[j].Grade == currentStudent.Grade && students[j].Name.CompareTo(currentStudent.Name) < 0)))
                {
                    students[j + 1] = students[j];
                    j--;
                }
                students[j + 1] = currentStudent;
            }
            foreach(Student s in students)
            {
                Console.WriteLine($"{s.Name} - Grade: {s.Grade}");
            }
        }
    }
}
