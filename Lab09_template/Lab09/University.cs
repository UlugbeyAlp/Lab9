using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab09
{
    [Serializable]
    class University
    {
        private string name;
        private List<Student> students;

        
        public string Name { get { return name; } set { name =value; } }
        public List<Student> Students
        {
            get { return students; }
        }
            
            
     
        public University(string name)
        {
            name=Name;
            students = new List<Student>();
        }

        public void AddStudent(Student s)
        {
            students.Add(s);
        }

        public Student SearchStudent(string name)
        {
            Student t = null;
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].getName().Equals(name))
                {
                    t = students[i];
                    break;
                }
            }
            if (t==null)
            { throw (new StudentNotFound("Giridiginiz isim ile kayitli ogrenci yok.")); }
            return t;
        }
     
        
        public Student SearchStudent(int no)
        {
            Student t = null;
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].getNo() == no)
                {
                    t = students[i];
                    break;
                }
            }
            if (t == null)
            {
                Console.WriteLine($"Girilen numara:{0}\n",no);
                throw (new StudentNotFound("Giridiginiz numaraya kayitli ogrenci yok."));
                
            }
            return t;
        }

       
    }
}
