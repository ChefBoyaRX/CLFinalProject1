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

        public string Go(string backwards)
        {
            string originalString = Console.ReadLine();

            char[] stringArray = originalString.ToCharArray();
            Array.Reverse(stringArray);
            string reverseString = new string(stringArray);

            return backwards;
        }

        void IPlugin.Go(string parameters)
        {
            throw new NotImplementedException();
        }
    }
}
