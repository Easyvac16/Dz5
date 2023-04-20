namespace Dz5
{

    class Journal
    {
        public string Name { get; set; }
        public int YearFounded { get; set; }
        public string Description { get; set; }
        public string ContactPhone { get; set; }
        public string Email { get; set; }
        public int EmployeesCount { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Year founded: {YearFounded}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Contact phone: {ContactPhone}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Employees count: {EmployeesCount}");
            Console.WriteLine(" ");
        }

        public void EnterDetails()
        {
            Console.Write("Enter name: ");
            Name = Console.ReadLine();

            Console.Write("Enter year founded: ");
            YearFounded = int.Parse(Console.ReadLine());

            Console.Write("Enter description: ");
            Description = Console.ReadLine();

            Console.Write("Enter contact phone: ");
            ContactPhone = Console.ReadLine();

            Console.Write("Enter email: ");
            Email = Console.ReadLine();

            Console.Write("Enter employees count: ");
            EmployeesCount = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");
        }

        public static Journal operator +(Journal journal, int employeesToAdd)
        {
            journal.EmployeesCount += employeesToAdd;
            return journal;
        }

        public static Journal operator -(Journal journal, int employeesToRemove)
        {
            journal.EmployeesCount -= employeesToRemove;
            return journal;
        }

        public static bool operator ==(Journal journal1, Journal journal2)
        {
            return journal1.EmployeesCount == journal2.EmployeesCount;
        }

        public static bool operator !=(Journal journal1, Journal journal2)
        {
            return journal1.EmployeesCount != journal2.EmployeesCount;
        }

        public static bool operator <(Journal journal1, Journal journal2)
        {
            return journal1.EmployeesCount < journal2.EmployeesCount;
        }

        public static bool operator >(Journal journal1, Journal journal2)
        {
            return journal1.EmployeesCount > journal2.EmployeesCount;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Journal))
            {
                return false;
            }

            Journal other = (Journal)obj;

            return EmployeesCount == other.EmployeesCount;
        }
        public override int GetHashCode()
        {

            return base.GetHashCode();

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
