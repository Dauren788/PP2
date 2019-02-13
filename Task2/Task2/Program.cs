using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    { public string name;
        public string id;
        public int year;
        public Student(string name, string id, int year)
        {
            this.name = name;
            this.id = id;
            this.year = year;
        }
        static void Main(string[] args)
            {
                Student s1 = new Student("Dauren", "18BD111158", 1);
                Console.WriteLine(s1.name + " " + s1.id + " " + s1.year);
                Console.ReadKey();
            }
        }
    } 

