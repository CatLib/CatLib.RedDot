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
    /// Red dot interface
    /// </summary>
    public interface IRedDot
    {
        /// <summary>
        /// Red dot payload
        /// </summary>
        object Payload { get; }

        /// <summary>
        /// According to the path to get the red dot
        /// </summary>
        /// <param name="path">String path</param>
        /// <returns>Red dot</returns>
        IRedDot Child(string path);

        /// <summary>
        /// According to the path to get the red dot
        /// </summary>
        /// <param name="path">String path</param>
        /// <returns>Red dot</returns>
        IRedDot this[string path] { get; }

        /// <summary>
        /// Set payload（We will automatically adjust the red dot according to the load）
        /// </summary>
        /// <param name="payload">Set payload</param>
        void Set(object payload);

        /// <summary>
        /// Clear dot style status
        /// </summary>
        /// <param name="halt">Only clear the top</param>
        void Clear(bool halt = false);

        /// <summary>
        /// Increment the number of events
        /// </summary>
        void Incr();

        /// <summary>
        /// Decrement the number of events
        /// </summary>
        void Decr();
    }
}
