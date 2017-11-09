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
        /// Number of events
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Get child red dot
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        IRedDot Child(string path);
    }
}
