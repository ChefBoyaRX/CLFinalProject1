using System;
using System.Linq;

namespace EncoderProjectCL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" *** ENCODER *** ");

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
                    if(line == "exit")
                    {
                        Environment.Exit(0);
                    }
                    IPlugin plugin = EncoderTools.Plugins.Where(p => p.Name == name).FirstOrDefault();

                    // if plugin is found, run each plugin
                    if (plugin != null)
                    {
                        string parameters = line.Replace(string.Format("{0} ", name), string.Empty);
                        plugin.Go(parameters);
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
