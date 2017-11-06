/*
 * This file is part of the CatLib package.
 *
 * (c) Yu Bin <support@catlib.io>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Document: http://catlib.io/
 */

namespace CatLib.API.RedDot
{
    /// <summary>
    /// Red Dot Inheritance relationship
    /// </summary>
    public enum TransferTypes
    {
        /// <summary>
        /// Through the callback to decide whether to pass
        /// </summary>
        Customize = 0,

        /// <summary>
        /// Does not pass the state to the parent class 
        /// </summary>
        NotInherit = 10,

        /// <summary>
        /// Pass the current state to the parent class
        /// </summary>
        Inherit = 20,
    }
}
