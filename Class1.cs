using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_work
{
    public class Student
    {
        public delegate void StudentDetails<L>(L inpi);

        private static string Name;
        private static int Id;
        private string StudentAddress;

        public string getAddress()
        {
            return StudentAddress;
        }
         public void setAddress(string studentAddress)
        {
            StudentAddress = studentAddress;
        }

        public static void getStudentName(string name)
        {
            Name = name;
            Console.WriteLine("Name:" + name);
        }

        public static void getStudentId(int id)
        {
            Id = id;
            Console.WriteLine("Id :" + id);

        }

        public void storeDictionary()
        {
            Dictionary<int , string> dic = new Dictionary<int, string>();
            dic.Add(1, Id.ToString());
            dic.Add(2, Name);
            dic.Add(3, StudentAddress);

            Console.WriteLine("\n");
            foreach (KeyValuePair<int , string>i in dic)
            {
                Console.WriteLine("" + i.Value);
            }

        }

        static void Main(string[] args)
        {
            StudentDetails<string> std = new StudentDetails<string>(getStudentName);
            std.Invoke("lucas");
            StudentDetails<int> st = new StudentDetails<int>(getStudentId);
            st.Invoke(23);

            Student sdt = new Student();
            sdt.setAddress("kampala");
            sdt.storeDictionary();

        }
    }
}