using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz5
{
    
    class Journal
    {
        private string _name { get; set; }
        private int _yearFounded { get; set; }
        private string _description { get; set; }
        private string _contactPhone { get; set; }
        private string _email { get; set; }
        private int _employeesCount { get; set; }

        public void SetName(string name)
        {
            this._name = name;
        }

        public void SetYearFounded(int yearFounded)
        {
            this._yearFounded = yearFounded;
        }

        public void SetDescription(string description)
        {
            this._description = description;
        }

        public void SetContactPhone(string contactPhone)
        {
            this._contactPhone = contactPhone;
        }

        public void SetEmail(string email)
        {
            this._email = email;
        }
        public void SetEmployeesCount(int employeesCount)
        {
            this._employeesCount = employeesCount;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetYearFounded()
        {
            return _yearFounded;
        }

        public string GetDescription()
        {
            return _description;
        }

        public string GetContactPhone()
        {
            return _contactPhone;
        }

        public string GetEmail()
        {
            return _email;
        }
        public int GetEmployeesCount()
        {
            return _employeesCount;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Year founded: {_yearFounded}");
            Console.WriteLine($"Description: {_description}");
            Console.WriteLine($"Contact phone: {_contactPhone}");
            Console.WriteLine($"Email: {_email}");
            Console.WriteLine($"Employees count: {_employeesCount}");
            Console.WriteLine(" ");
        }

        public void EnterDetails()
        {
            Console.Write("Enter name: ");
            _name = Console.ReadLine();

            Console.Write("Enter year founded: ");
            _yearFounded = int.Parse(Console.ReadLine());

            Console.Write("Enter description: ");
            _description = Console.ReadLine();

            Console.Write("Enter contact phone: ");
            _contactPhone = Console.ReadLine();

            Console.Write("Enter email: ");
            _email = Console.ReadLine();

            Console.Write("Enter employees count: ");
            _employeesCount = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");
        }

        public static Journal operator +(Journal journal, int employeesToAdd)
        {
            journal._employeesCount += employeesToAdd;
            return journal;
        }

        public static Journal operator -(Journal journal, int employeesToRemove)
        {
            journal._employeesCount -= employeesToRemove;
            return journal;
        }

        public static bool operator ==(Journal journal1, Journal journal2)
        {
            return journal1._employeesCount == journal2._employeesCount;
        }

        public static bool operator !=(Journal journal1, Journal journal2)
        {
            return journal1._employeesCount != journal2._employeesCount;
        }

        public static bool operator <(Journal journal1, Journal journal2)
        {
            return journal1._employeesCount < journal2._employeesCount;
        }

        public static bool operator >(Journal journal1, Journal journal2)
        {
            return journal1._employeesCount > journal2._employeesCount;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Journal))
            {
                return false;
            }

            Journal other = (Journal)obj;

            return _employeesCount == other._employeesCount;
        }
    }
    internal class cs1
    {
        public static void task_1()
        {
            Journal myJournal1 = new Journal();
            myJournal1.EnterDetails();
            myJournal1.DisplayDetails();
            
            Journal myJournal2 = new Journal();
            myJournal2.EnterDetails();
            myJournal2.DisplayDetails();

            myJournal1 += 5;
            myJournal1.DisplayDetails();

            myJournal2 += 3;
            myJournal2.DisplayDetails();

            myJournal1 -= 2;
            myJournal1.DisplayDetails();

            myJournal2 -= 1;
            myJournal2.DisplayDetails();

            if (myJournal1 == myJournal2)
            {
                Console.WriteLine("Journal 1 = Journal 2");
            }
            else
            {
                Console.WriteLine("Journal 1 != Journal 2");
            }
            Console.WriteLine(" ");

            if (myJournal1 != myJournal2)
            {
                Console.WriteLine("Journal 1 not equal to Journal 2");
            }
            else
            {
                Console.WriteLine("Journal 1 equal to Journal 2");
            }
            Console.WriteLine(" ");

            if (myJournal1 > myJournal2)
            {
                Console.WriteLine("Journal 1 > Journal 2");
            }
            else
            {
                Console.WriteLine("Journal 1 < Journal 2");
            }
            Console.WriteLine(" ");

            
            if (myJournal1 < myJournal2)
            {
                Console.WriteLine("Journal 1 less then Journal 2");
            }
            else
            {
                Console.WriteLine("Journal 1 greater then Journal 2");
            }
            Console.WriteLine(" ");

            if (myJournal1.Equals(myJournal2))
            {
                Console.WriteLine("Journal 1 equal to Journal 2");
            }
            else
            {
                Console.WriteLine("Journal 1 not equal to Journal 2");
            }
        }
    }
}
