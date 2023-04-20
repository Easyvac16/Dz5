namespace Dz5
{
    class Shop
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Profile { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public double Area { get; set; }

        public static Shop operator +(Shop shop, double increase)
        {
            shop.Area += increase;
            return shop;
        }

        public static Shop operator -(Shop shop, double decrease)
        {
            shop.Area -= decrease;
            return shop;
        }

        public static bool operator ==(Shop shop1, Shop shop2)
        {
            return shop1.Area == shop2.Area;
        }

        public static bool operator !=(Shop shop1, Shop shop2)
        {
            return shop1.Area != shop2.Area;
        }

        public static bool operator >(Shop shop1, Shop shop2)
        {
            return shop1.Area > shop2.Area;
        }

        public static bool operator <(Shop shop1, Shop shop2)
        {
            return shop1.Area < shop2.Area;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Shop))
            {
                return false;
            }

            Shop other = (Shop)obj;

            return Area == other.Area;
        }
        public override int GetHashCode()
        {

            return base.GetHashCode();

        }

        public void InputData()
        {
            Console.Write("Enter shop name: ");
            Name = Console.ReadLine();
            Console.Write("Enter shop address: ");
            Address = Console.ReadLine();
            Console.Write("Enter shop profile: ");
            Profile = Console.ReadLine();
            Console.Write("Enter shop phone: ");
            Phone = Console.ReadLine();
            Console.Write("Enter shop email: ");
            Email = Console.ReadLine();
            Console.Write("Enter shop area: ");
            Area = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");
        }

        public void OutputData()
        {
            Console.WriteLine($"Shop name: {Name}");
            Console.WriteLine($"Shop address: {Address}");
            Console.WriteLine($"Shop profile: {Profile}");
            Console.WriteLine($"Shop phone: {Phone}");
            Console.WriteLine($"Shop email: {Email}");
            Console.WriteLine($"Shop area: {Area}");
            Console.WriteLine(" ");
        }


    }

    internal class cs2
    {
        public static void task_2()
        {
            Shop shop1 = new Shop();
            shop1.InputData();
            shop1.OutputData();

            Shop shop2 = new Shop();
            shop2.InputData();
            shop2.OutputData();

            shop1 += 10;
            shop1.OutputData();

            shop2 += 5;
            shop2.OutputData();

            shop1 -= 5;
            shop1.OutputData();

            shop2 -= 2;
            shop2.OutputData();



            if (shop1 == shop2)
            {
                Console.WriteLine("shop 1 area = shop 2 area");
            }
            else
            {
                Console.WriteLine("Shop 1 area != Shop 2 area");
            }
            Console.WriteLine(" ");

            if (shop1 != shop2)
            {
                Console.WriteLine("Shop 1 area not equal to Shop 2 area");
            }
            else
            {
                Console.WriteLine("Shop 1 area equal to Shop 2 area");
            }
            Console.WriteLine(" ");

            if (shop1 > shop2)
            {
                Console.WriteLine("Shop 1 area > Shop 2 area");
            }
            else
            {
                Console.WriteLine("Shop 1 area < Shop 2 area");
            }
            Console.WriteLine(" ");


            if (shop1 < shop2)
            {
                Console.WriteLine("Shop 1 area less then Shop 2 area");
            }
            else
            {
                Console.WriteLine("Shop 1 area greater then Shop 2 area");
            }
            Console.WriteLine(" ");

            if (shop1.Equals(shop2))
            {
                Console.WriteLine("Shop 1 area equal to Shop 2 area");
            }
            else
            {
                Console.WriteLine("Shop 1 area not equal to Shop 2 area");
            }
        }
    }
}
