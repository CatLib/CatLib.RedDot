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
        internal static BaseNode MakeNode(NodeTypes type)
        {
            switch (type)
            {
                case NodeTypes.Child:
                    return new ChildNode();
                case NodeTypes.Parent:
                    return new ParentNode();
            }
            throw new RuntimeException("Can not make node");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        internal static string[] ToArrayPath(string path)
        {
            var arrayPath = path.Split('.', '/');
            return Arr.Reverse(arrayPath);
        }
    }
}
