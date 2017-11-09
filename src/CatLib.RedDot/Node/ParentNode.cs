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

using System.Collections.Generic;

namespace CatLib.RedDot.Node
{
    /// <summary>
    /// Parent node
    /// </summary>
    public class ParentNode : BaseNode
    {
        /// <summary>
        /// Mapping for red dot
        /// </summary>
        private IDictionary<string, BaseNode> children;

        /// <summary>
        /// Create new parent node instance
        /// </summary>
        /// <param name="parent">parent node</param>
        public ParentNode(BaseNode parent = null) 
            : base(parent)
        {
        }

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
        /// Set the number of events
        /// </summary>
        /// <param name="count">Number of events</param>
        public override void Counted(int count)
        {

        }

        /// <summary>
        /// Get or Make node with path
        /// </summary>
        /// <param name="path">Path array</param>
        /// <returns>node of the path</returns>
        internal override BaseNode Make(string[] path)
        {
            if(path == null || path.Length <= 0)
            {
                return this;
            }

            return this;
        }
    }
}
