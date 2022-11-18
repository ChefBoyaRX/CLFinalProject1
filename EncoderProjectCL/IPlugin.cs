using System;
namespace EncoderProjectCL
{
    public interface IPlugin
    {
        string Name { get; }
        string Explanation { get; }
        void Go(string parameters);
        
    }

    public static class Constants
    {
        //The folder name which contains the plugin DLLs
        public const string FolderName = "Plugins";
    }

    public class Modifiers : IPlugin
    {
        public void Go(string parameters)
        {
            foreach (IPlugin plugin in EncoderTools.Plugins)
            {
               Console.WriteLine("{0}: {1}", plugin.Name, plugin.Explanation);
            }

            
        }

        public string Name
        {
            get
            {
                return "Help";
            }
        }

        public string Explanation
        {
            get
            {
                return "This plugin shows all loaded plugins and their explanations";
            }
        }




    }
}
