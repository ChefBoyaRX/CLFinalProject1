using System;
using System.Linq;
using System.Reflection.Metadata;

namespace EncoderProjectCL
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" *** ENCODER *** ");
            Console.WriteLine("Enter a string below that you would like to translate, or press 'Help' to view the list of active modifiers and what they do.");

            try
            {
                EncoderTools loader = new EncoderTools();
                loader.LoadPlugins();
            }
            catch(Exception e)
            {
                Console.WriteLine(string.Format("Plugins couldn't be loaded: {0}", e.Message));
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                Environment.Exit(0);
            }
            while (true)
            {
                try
                {
                    Console.Write("> ");
                    string line = Console.ReadLine();

                    string name = line.Split(new char[] { ' ' }).FirstOrDefault();
                    
                    if (line == "Modify")
                    {
                        {
                            
                        }
                        

                    }

                    IPlugin plugin = EncoderTools.Plugins.Where(p => p.Name == name).FirstOrDefault();
                    if (plugin != null)
                    {
                        string parameters = line.Replace(string.Format("{0} ", name), string.Empty);
                        plugin.Go(parameters);
                    }
                    else
                    {
                        Console.WriteLine(string.Format("No plugin found with name '{0}'", name));
                    }
                    
                }
                catch(Exception e)
                {
                    Console.WriteLine(string.Format("Caught exception: {0}", e.Message));
                }

            }



        }

        



    }
}
