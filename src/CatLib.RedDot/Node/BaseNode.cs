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

using CatLib.API.RedDot;

namespace CatLib.RedDot.Node
{
    /// <summary>
    /// Base node
    /// </summary>
    public abstract class BaseNode : IRedDot
    {
        /// <summary>
        /// Number of events
        /// </summary>
        public abstract int Count { get; }

        /// <summary>
        /// Get or Make node with path
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public virtual BaseNode Make(string[] path)
        {
            return this;
        }

        /// <summary>
        /// Find the child
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public virtual IRedDot Child(string path)
        {
            return Make(RedDotManager.ToArrayPath(path));
        }
    }
}
