using System;
namespace EncoderProjectCL.Plugins
{
    public class AllCapsTool : IPlugin
    {
        public string Name
        {
            get
            {
                return "AllCapsTool";
            }
        }

        public string Explanation
        {
            get
            {
                return "This plugin capitalizes the output";
            }
        }

        public void Go(string allcaps)
        {
            string str1 = Console.ReadLine();

            string upperstr1 = str1.ToUpper();

            Console.WriteLine(upperstr1);
        }

    }
}
