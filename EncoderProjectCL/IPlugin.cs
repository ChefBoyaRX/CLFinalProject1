using System;
namespace EncoderProjectCL
{
    public interface IPlugin
    {
        string Name { get; }
        string Explanation { get; }
        void Go(string parameters);
<<<<<<< HEAD
        
=======
>>>>>>> 73d6ba53d86472666211689a62d8ce8d68926367
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
<<<<<<< HEAD
               Console.WriteLine("{0}: {1}", plugin.Name, plugin.Explanation);
            }

            
=======
                Console.WriteLine("{0}: {1}", plugin.Name, plugin.Explanation);
            }
>>>>>>> 73d6ba53d86472666211689a62d8ce8d68926367
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
