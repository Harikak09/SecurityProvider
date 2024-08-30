/******************************************************************************
 * Filename    = Controller.cs
 *
 * Author      = Karumudi Harika
 *
 * Product     = Security
 * 
 * Project     = ControllerModule
 *
 * Description = Inputs from UI and decides which security provider to use. 
 *****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using SecurityProvider;

namespace ControllerModule
{
    /// <summary>
    /// Gets list of security providers for the environment and passes that to ISecurityProvider.
    /// </summary>
    public class Controller:ISecurityNotifier
    {
        /// <summary>
        /// Creating a list of type ISecurityProvider.
        /// And a variable to Notify.
        /// </summary>
        private List<ISecurityProvider> _securityProvider;
        private ISecurityNotifier _securityNotifier;

        public Controller(ISecurityNotifier Notifier) { 
            _securityProvider = new List<ISecurityProvider>();
            _securityNotifier = Notifier;
        }
        /// <summary>
        /// Notifier function.
        /// </summary>
        /// <param name="message"></param>
        /// Writes to console.
        public void Notify(string message)
        {
            Console.WriteLine(message);
        }

        /// <summary>
        /// Adding security provides to the list which matches for the environment.
        /// </summary>
        /// <param name="environment"></param>
        /// <returns>A list of type ISecurityProvider</returns>
        /// <exception cref="ArgumentException"></exception>
        public List<ISecurityProvider> Initialize(string environment)
        {
            _securityProvider.Clear();

            if (environment == "organisation")
            {
                _securityProvider.Add(new AntiVirusSecurityProvider());
                _securityProvider.Add(new AccountSecurityProvider());

            }
            else if (environment == "home") {

                _securityProvider.Add(new AntiVirusSecurityProvider());
            }
            else
            {
                throw new ArgumentException("Environment Not Identified");
            }
            return _securityProvider;
        }

        /// <summary>
        /// A function to perform Scan on the input file.
        /// </summary>
        public void ScanCheck()
        {
            //Iterates through each security provider and implements scan.
            foreach (var securityProvider in _securityProvider)
            {
                securityProvider.Scan();
            }
            _securityNotifier.Notify("Scanning is Done");
        }

        public bool AuthenticationCheck(string username, string password){
            //Iterates through each security provider and implements authentication check.

            foreach (var securityProvider in _securityProvider)
            {
                if (securityProvider.Authenticate(username, password))
                {
                    _securityNotifier.Notify(username + ":" + "Sucessful");
                    return true;
                }
                
            }
            _securityNotifier.Notify(username + ":" + "Failed");
            return false;

        }

        

        }
}
