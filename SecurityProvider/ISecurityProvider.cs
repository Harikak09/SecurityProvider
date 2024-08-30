/******************************************************************************
 * Filename    = ISecurityProvider.cs
 *
 * Author      = Karumudi Harika
 *
 * Product     = Security
 * 
 * Project     = Security Provider
 *
 * Description = Defines core security operations that any security provider must implement. 
 *****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityProvider
{
    /// <summary>
    /// Contains security operations that a provider must implement.
    /// </summary>
    public interface ISecurityProvider
    {
        /// <summary>
        /// Scans.
        /// </summary>
        void Scan();

        /// <summary>
        /// Cjecks for authentication.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>A bool value for a given username.</returns>
        bool Authenticate(string username, string password);


    }
}
