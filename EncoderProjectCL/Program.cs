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

            Console.WriteLine("Press 'Help' to view all active modifiers and see what they do.");

            Console.WriteLine("Enter the name of the plugin you want to use, then enter the string you want to edit.");

            Console.WriteLine("Enter 'exit' to exit.");

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

                    
                    

                    IPlugin plugin = EncoderTools.Plugins.Where(p => p.Name == name).FirstOrDefault();

                    if(line == "exit")
                    {
                        Environment.Exit(0);
                    }
                    

                    // if plugin is found, run each plugin

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
