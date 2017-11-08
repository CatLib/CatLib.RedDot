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

namespace CatLib.RedDot.Node
{
    /// <summary>
    /// Node Types
    /// </summary>
    public enum NodeTypes
    {
        /// <summary>
        /// Parent node can accommodate de entity
        /// </summary>
        Parent,

        /// <summary>
        /// Unable to mount child node again
        /// </summary>
        Entity
    }
}
