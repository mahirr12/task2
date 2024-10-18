namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1

            //int num = Convert.ToInt32(Console.ReadLine());
            //bool prime = true;
            //for (int i = 2; i <= num / 2; i++)
            //{
            //    if (num%i==0)
            //    {
            //        prime = false;
            //        break;
            //    }
            //}
            //if (prime) Console.WriteLine("Sadə");
            //else Console.WriteLine("Mürəkkəb");
            #endregion

            #region task2

            int num = Convert.ToInt32(Console.ReadLine());
            int lenght = 0;
            do
            {
                num /= 10;
                lenght++;
            }while (num != 0);
            Console.WriteLine(lenght);
            #endregion
        }
    }
}
