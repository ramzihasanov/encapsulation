using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    public class person
    {
        public person(string fullName,byte age,string phoneNumber)
        {
            FullName = fullName;
            Age = age;


        }
        private string _fullName;
        public string PhoneNumber { get; set; }

        public string FullName {
            get=>_fullName;
            set
            {
                
                if (IsFullName(value))
                {
                    _fullName = value;
                }
                else
                {
                    Console.WriteLine("fulname duzgun deyil");
                }
                

            }
        }


        public bool IsFullName(string fulname)
        {
            string[] words = fulname.Split(' ');

            if (words.Length >= 2)
            {
                foreach (string word in words)
                {
                    if (string.IsNullOrWhiteSpace(word) || !char.IsUpper(word[0]))
                    {
                        return false;
                    }
                }
                return true;
            }

            return false;
        }
        private byte _age;
        public byte Age { get=>_age; set { if (value > 0&& value <150) _age = value; } }


        public void ShowFullName()
        {
            Console.WriteLine($"fullname:{_fullName}\nage:{_age}");
        }

    }
}
