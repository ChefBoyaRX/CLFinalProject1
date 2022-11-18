using System;
using System.Linq;
<<<<<<< HEAD
using System.Reflection.Metadata;
=======
>>>>>>> 73d6ba53d86472666211689a62d8ce8d68926367

namespace EncoderProjectCL
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" *** ENCODER *** ");
<<<<<<< HEAD
            Console.WriteLine("Enter a string below that you would like to translate, or press 'Help' to view the list of active modifiers and what they do.");
=======
>>>>>>> 73d6ba53d86472666211689a62d8ce8d68926367

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
<<<<<<< HEAD
                    
                    if (line == "Modify")
                    {
                        {
                            
                        }
                        

                    }

                    IPlugin plugin = EncoderTools.Plugins.Where(p => p.Name == name).FirstOrDefault();
=======
                    if(line == "exit")
                    {
                        Environment.Exit(0);
                    }
                    IPlugin plugin = EncoderTools.Plugins.Where(p => p.Name == name).FirstOrDefault();

                    // if plugin is found, run each plugin
>>>>>>> 73d6ba53d86472666211689a62d8ce8d68926367
                    if (plugin != null)
                    {
                        string parameters = line.Replace(string.Format("{0} ", name), string.Empty);
                        plugin.Go(parameters);
                    }
<<<<<<< HEAD
                    else
                    {
                        Console.WriteLine(string.Format("No plugin found with name '{0}'", name));
                    }
                    
=======
>>>>>>> 73d6ba53d86472666211689a62d8ce8d68926367
                }
                catch(Exception e)
                {
                    Console.WriteLine(string.Format("Caught exception: {0}", e.Message));
                }

            }



        }

        



    }
}
