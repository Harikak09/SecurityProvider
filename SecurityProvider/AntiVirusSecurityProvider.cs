/******************************************************************************
 * Filename    = AntiVirusSecurityProvider.cs
 *
 * Author      = Karumudi Harika
 *
 * Product     = Security
 * 
 * Project     = Security Provider
 *
 * Description = Contains security operations for AntiVirus. 
 *****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityProvider
{
    /// <summary>
    /// Contains security operations.
    /// </summary>
    public class AntiVirusSecurityProvider: ISecurityProvider
    {
        /// <summary>
        /// Performs scan operation on input.
        /// </summary>
        /// <returns>NA</returns>
        public void Scan() { 

        }
        /// <summary>
        /// Performs authenticate operation.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>A bool value either user exists or not.</returns>
        public bool Authenticate(string username, string password) {
            //If user with username and password exists it return true.
            //Default returns false.
            return false;
        }

        

    }
}
