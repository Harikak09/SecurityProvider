/******************************************************************************
 * Filename    = ISecurityNotifier.cs
 *
 * Author      = Karumudi Harika
 *
 * Product     = Security
 * 
 * Project     = Security Provider
 *
 * Description = Notifies the clients or systems about security events. 
 *****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityProvider
{
    /// <summary>
    /// Notifies the users.
    /// </summary>
    public interface ISecurityNotifier
    {   
        /// <summary>
        /// A function to notify users.
        /// </summary>
        /// <param name="Message"></param>
        public void Notify(string Message);

        public class ConsoleNotifier: ISecurityNotifier
        {
            /// <summary>
            /// This inherits the IsecurityNotifier.
            /// A console write class.
            /// </summary>
            /// <param name="message"></param>
            /// <returns>Writes message to console.</returns>
            public void Notify(string message)
            {
                //Writes back to the console.
                Console.WriteLine(message);
            }
        }
    }
}
