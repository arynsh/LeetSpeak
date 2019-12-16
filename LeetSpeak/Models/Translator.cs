using System;


namespace LeetSpeak.Tests {

    public class LeetSpeakTranslator {
        public string UserInput { get; set; }

        public LeetSpeakTranslator(string input)
        {
            UserInput = input;
        }
           
              
              
        public string Translator()
        {
         UserInput = UserInput.Replace("e", "3");
         UserInput = UserInput.Replace("o", "0");
         UserInput = UserInput.Replace("i", "1");
         UserInput = UserInput.Replace("t", "7");
         if (UserInput[0] == 's')
         {
             return UserInput;
         }
         else       
         {
             UserInput = UserInput.Replace("s", "z");
         }
         return UserInput;
        }
        
    }
}