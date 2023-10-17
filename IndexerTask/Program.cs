using IndexerTask.Models;

namespace IndexerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ListInt list = new ListInt(2, 6, 7, 3, 2, 2);

            int[] remove = { 1, 2, 3, 4, 5, 6 };
            list.RemoveRange(remove);
            Console.WriteLine(list.ToString());
            //list.AddRange(3, 4, 5, 6, 7, 8);
            //Console.WriteLine(list.Contains(-1));
            //Console.WriteLine(list.Sum());
        }
    }
}