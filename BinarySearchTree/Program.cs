using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            BST binarysearch = new BST();

            for (int i = 1; i <= 10; i++)
            {
                int randomNumber = random.Next(1, 101);
                binarysearch.Add(randomNumber);
                Console.WriteLine($"#{i} is {randomNumber}");
            }
            Console.ReadLine();
        }
    }
}
