using System;

namespace LeetSpeak {
   public class Program {
        public static void Main()
        {
            Console.WriteLine("Please enter a string.");
            string userInput = Console.ReadLine();

            LeetSpeakTranslator firstObject = new LeetSpeakTranslator(userInput);

            Console.WriteLine(firstObject.Translator());

        }
    }
}