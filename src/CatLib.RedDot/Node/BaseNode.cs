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
    /// Base of the node
    /// </summary>
    public abstract class BaseNode : IRedDot
    {
        /// <summary>
        /// Get or Make Node with path
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        internal BaseNode Make(string[] path)
        {
            if(path.Length <= 0)
            {
                return this;
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        internal static BaseNode MakeNode(NodeTypes type)
        {
            return null;
        }
    }
}
