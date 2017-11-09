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
    /// Parent node
    /// </summary>
    public class ParentNode : BaseNode
    {
        /// <summary>
        /// Parent node
        /// </summary>
        private ParentNode parent;

        /// <summary>
        /// Children dot
        /// </summary>
        private SortSet<IRedDot, int> children;

        /// <summary>
        /// Number of events
        /// </summary>
        public override int Count
        {
            get
            {
                return 0;
            }
        }

        /// <summary>
        /// Find the child
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public override IRedDot Child(string path)
        {
            return this;
        }
    }
}
