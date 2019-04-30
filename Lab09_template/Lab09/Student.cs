using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab09
{

    [Serializable]
    abstract class Student
    {
        //Sadece get methodları olacak.
        protected string name { get; }
        protected string surname { get; }
        protected int no { get; }
        public Student(string name, string surname, int no)
        {
            this.name = name;
            this.surname = surname;
            this.no = no;
        }
        public int getNo()
        {
            return no;
        }
        public string getName()
        {
            return name;
        }

        public override string ToString()
        {
            return "\nAd: " + name + " Soyad: " + surname + "   No:" + no + " Tip: " + this.GetType().Name + "\n";
        }

    }
}
