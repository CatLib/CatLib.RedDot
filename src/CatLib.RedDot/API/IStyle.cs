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
    /// Style interface
    /// </summary>
    public interface IStyle
    {
        /// <summary>
        /// When set the style payload
        /// </summary>
        /// <param name="payload"></param>
        void Set(object payload);

        /// <summary>
        /// Get settled payload
        /// </summary>
        object Payload { get; }

        /// <summary>
        /// Priority with display level (Small priority)
        /// </summary>
        int Priority { get; }
    }
}
