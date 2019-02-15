using System;

namespace Task2
{

    class Student
    {//Class s parametrom studenta
        public string Name;
        public string id;
        public int year;
        //public Retake rtk;
        public Student(string Name, string id)//Construct
        {
            this.Name = Name;//vvedenie ego imeni
            this.id = id;//vvedenie ego ID
           
        }
        public void Cout()//vyvod classa student
        {
            Console.WriteLine("Student's name: " + Name + Environment.NewLine + "Student's ID: " + id + Environment.NewLine + "Sudent's year increased: " + ++year);
        }

    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Student Bekzat = new Student("Bekzat", "18BD11111");
            Bekzat.year = 0;
            Bekzat.Cout();
        }
    }
}