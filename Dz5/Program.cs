namespace Dz5
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Write what program you need 1 - Journal , 2 - Shop , 3 - Books:");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    cs1.task_1();
                    break;
                case 2:
                    cs2.task_2();
                    break;
                case 3:
                    cs3.task_3();
                    break;
            }
            
            
        }
    }
}