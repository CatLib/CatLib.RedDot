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
    public class ParentNode
    {
        /// <summary>
        /// Parent node
        /// </summary>
        private ParentNode parent;

        /// <summary>
        /// Children dot
        /// </summary>
        private SortSet<IRedDot, int> children;


    }
}
