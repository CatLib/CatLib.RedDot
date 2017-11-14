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
        /// Customize red dot
        /// </summary>
        /// <param name="style">Style</param>
        IRedDot Extend(IStyle style);

        /// <summary>
        /// Set payload（We will automatically adjust the red dot according to the load）
        /// </summary>
        /// <param name="payload">Set payload</param>
        void Set(object payload);

        /// <summary>
        /// Set the number of events
        /// </summary>
        /// <param name="count">Number of events</param>
        void Counted(int count);

        /// <summary>
        /// Increment the number of events
        /// </summary>
        void Incr();

        /// <summary>
        /// Decrement the number of events
        /// </summary>
        void Decr();

        /// <summary>
        /// Clear the number of events
        /// </summary>
        void Clear();
    }
}
