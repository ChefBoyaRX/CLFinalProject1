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

        public string Go(string allcaps)
        {
            string str1 = Console.ReadLine();

            string upperstr1 = str1.ToUpper();

            return upperstr1;
        }

        void IPlugin.Go(string parameters)
        {
            throw new NotImplementedException();
        }
    }
}
