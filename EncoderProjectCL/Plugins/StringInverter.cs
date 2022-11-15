using System;
namespace EncoderProjectCL.Plugins
{
    public class StringInverter : IPlugin
    {
        public string Name
        {
            get
            {
                return "StringInverter";
            }
        }

        public string Explanation
        {
            get
            {
                return "This plugin outputs a string backwards";
            }
        }

        public void Go(string backwards)
        {
            string originalString = Console.ReadLine();

            char[] stringArray = originalString.ToCharArray();
            Array.Reverse(stringArray);
            string reverseString = new string(stringArray);

            Console.WriteLine($"Reverse String is : {reverseString} ");
            Console.ReadLine();        }
    }
}
