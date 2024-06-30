using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Home_Work_Group
{
    abstract class Person
    {
        private string surname;
        private string name;
        private string lastname;
        private DateTime birthday;
        private string adress;
        private int phonenumber;

        public void SetPhonenumber(int phonenumber)
        {
            this.phonenumber = phonenumber;
        }

        public int GetPhonenumber()
        {
            return phonenumber;
        }

        public void SetAdress(string adress)
        {
            this.adress = adress;
        }

        public string GetAdress()
        {
            return adress;
        }

        public void SetBirthday(DateTime birthday)
        {
            this.birthday = birthday;
        }

        public DateTime GetBirthday()
        {
            return birthday;
        }

        public void SetLastname(string lastname)
        {
            this.lastname = lastname;
        }

        public string GetLastname()
        {
            return lastname;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetSurname(string surname)
        {
            this.surname = surname;
        }

        public string GetSurname()
        {
            return surname;
        }

        public Person(string surname, string name, string lastname, DateTime birthday, string adress, int phonenumber)
        {
            SetSurname(surname);
            SetName(name);
            SetLastname(lastname);
            SetBirthday(birthday);
            SetAdress(adress);
            SetPhonenumber(phonenumber);
        }
        //я переопределил ToString() для корректного вывода информации во время "распечатки" группы 
        public override string ToString()
        {
            return $"Name: {GetName()} {GetSurname()}, \nAddress: {GetAdress()}, \nPhone: {GetPhonenumber()}";
        }
    }
}
