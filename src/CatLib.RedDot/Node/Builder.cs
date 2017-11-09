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
    /// Builder helper
    /// </summary>
    internal static class Builder
    {
        /// <summary>
        /// Make node
        /// </summary>
        /// <param name="type">What type of red dot needs to be built</param>
        /// <param name="parent">Parent node</param>
        internal static BaseNode MakeNode(NodeTypes type, BaseNode parent = null)
        {
            switch (type)
            {
                case NodeTypes.Child:
                    return new ChildNode(parent);
                case NodeTypes.Parent:
                    return new ParentNode(parent);
            }
            throw new RuntimeException("Can not make node");
        }

        /// <summary>
        /// Split a string into an array based on the dot and slash of the string
        /// </summary>
        /// <param name="path">string path</param>
        /// <returns>array</returns>
        internal static string[] ToArrayPath(string path)
        {
            var arrayPath = path.Split('.', '/');
            return Arr.Reverse(arrayPath);
        }
    }
}
