/******************************************************************************
 * Filename    = Program.cs
 *
 * Author      = Karumudi Harika
 *
 * Product     = Security
 * 
 * Project     = UXModule
 *
 * Description = Reads the inputs from console and implements corresponding function. 
 *****************************************************************************/

using SecurityProvider;
using ControllerModule;
using static SecurityProvider.ISecurityNotifier;
namespace UXModule
{
    public class Program
    {
        /// <summary>
        /// Reads from console either scan or exit.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //A new instance of class ConsoleNotifier.
            //A new instance of controller.
            ISecurityNotifier notifier = new ConsoleNotifier();

            Controller controller = new Controller(notifier);

            //Listing all the security providers of the environment.
            string environment = "organisation";
            List<ISecurityProvider> allProviders = controller.Initialize(environment);
            for (int i = 0; i < allProviders.Count; i++)
            {
                Console.WriteLine(allProviders[i] + "/");
            }
            string input;

            //console reads scan to perform scan and exit to exit from the module.
            while (true) {
                
                Console.WriteLine("Enter one of the command in the console:");
                Console.WriteLine("1. scan");
                Console.WriteLine("2. exit");
                input = Console.ReadLine();

                if (input == "scan")
                {
                    controller.ScanCheck();                
                }
                else if (input!="exit" )
                {
                    Console.WriteLine("Incorrect Command");
                }
                else
                {
                    break;
                }

            }
            Console.WriteLine("Successfully exited!");
                
  

        }
    }
}
