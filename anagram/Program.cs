using System;

namespace anagram
{
    public class Program
    {
        static void Main(string[] args)
        {
            string sentence;

            while (true)
            {   
                Console.WriteLine("Enter your sentence");
                sentence = Console.ReadLine();
                Console.Write("Reverse sentence: "); 
                Console.WriteLine(Anagram.ReverseSentence(sentence));
                Console.WriteLine();
            }            
        }       
    }
}
