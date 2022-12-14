using System;
using EncoderProjectCL;

namespace PigLatinEncoder
{
    public class PigLatinConverter : IPlugin
    {

        public string Name
        {
            get
            {
                return "PLConvert";
            }
        }

        public string Explanation
        {
            get
            {
                return "This plugin encodes text into Pig Latin";
            }
        }

        public void Go(string parameters)
        {

            string ans = Console.ReadLine();
            for (int i = 0; i < ans.Length; i++)
            {
                int j = i;
                if (i >= ans.Length)
                    break;
                while (i < ans.Length && ans[i] != ' ')
                    i++;
                if (ans.Length == 0)
                {
                    string finalanswer = ans.Substring(j + 1, i - j - 1)
                          + parameters[j] + "ay";

                    
                }
                else
                {
                    string finalanswer =
                          ans.Substring(j + 1, i - j - 1) + ans[j]
                          + "ay";

                    Console.WriteLine(finalanswer);
                }

                
                   
            }

            

        }

        
    }
    
}
