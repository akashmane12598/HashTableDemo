using System;

namespace HashTableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To HashTable Code!");
            MyMapNode<string, string> hashset = new MyMapNode<string, string>(5);
            hashset.Add("0", "To");
            hashset.Add("1", "be");
            hashset.Add("2", "or");
            hashset.Add("3", "not");
            hashset.Add("4", "to");
            hashset.Add("5", "be");

            Console.WriteLine("Frequency :" + hashset.GetFrequencyOfWords("be"));
        }
    }
}
