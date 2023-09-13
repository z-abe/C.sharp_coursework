using System;
using System.IO;

namespace Project3_File_InO
{
    class File_InO
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine()!;

            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine()!);

            Console.Write("Is student (true/false): ");
            bool isStudent = bool.Parse(Console.ReadLine()!);

            using (StreamWriter sw = new StreamWriter("person1.txt"))
            {
                sw.WriteLine(name);
                sw.WriteLine(age);
                sw.WriteLine(isStudent);
            }

            Console.Write("Enter another name: ");
            string name2 = Console.ReadLine()!;

            Console.Write("Enter age: ");
            int age2 = int.Parse(Console.ReadLine()!);

            Console.Write("Is student (true/false): ");
            bool isStudent2 = bool.Parse(Console.ReadLine()!);

            using (BinaryWriter bw = new BinaryWriter(File.Open("person2.dat", FileMode.Create)))
            {
                bw.Write(name2);
                bw.Write(age2);
                bw.Write(isStudent2);
            }

            string[] lines = File.ReadAllLines("person1.txt");
            string nameFromText = lines[0];
            int ageFromText = int.Parse(lines[1]);
            bool isStudentFromText = bool.Parse(lines[2]);

            Person personFromText = new Person(nameFromText, ageFromText, isStudentFromText);

            using (BinaryReader br = new BinaryReader(File.Open("person2.dat", FileMode.Open)))
            {
                string nameFromBinary = br.ReadString();
                int ageFromBinary = br.ReadInt32();
                bool isStudentFromBinary = br.ReadBoolean();

                Person personFromBinary = new Person(nameFromBinary, ageFromBinary, isStudentFromBinary);

                Console.WriteLine("Person from text:");
                personFromText.Describe();

                Console.WriteLine("Person from binary:");
                personFromBinary.Describe();
            }
        }
    }

    class Person
    {
        private string name;
        private int age;
        private bool isStudent;

        public Person(string name, int age, bool isStudent)
        {
            this.name = name;
            this.age = age;
            this.isStudent = isStudent;
        }

        public void Describe()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Is student: {isStudent}");
        }
    }
}

