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
using CatLib.RedDot.Node;
using System.Collections.Generic;

namespace CatLib.RedDot
{
    /// <summary>
    /// Red dot manager
    /// </summary>
    public class RedDotManager
    {
        /// <summary>
        /// Mapping for red dot
        /// </summary>
        private IDictionary<string, BaseNode> mapping;

        /// <summary>
        /// Make a new instance of the red dot manager
        /// </summary>
        public RedDotManager()
        {
            mapping = new Dictionary<string, BaseNode>();
        }

        /// <summary>
        /// Get the red dot with path
        /// <para>Path support use dots to flatten a multi-dimensional associative array</para>
        /// <para>When the path is empty, an exception is thrown</para>
        /// </summary>
        /// <param name="path"></param>
        public IRedDot Get(string path)
        {
            return null;
        }

        /// <summary>
        /// Make the red dot with path
        /// <para>Path support use dots to flatten a multi-dimensional associative array</para>
        /// </summary>
        /// <param name="path"></param>
        public IRedDot Make(string path)
        {
            var arrayPath = Builder.ToArrayPath(path);
            var key = Arr.Pop(ref arrayPath);

            BaseNode result;
            if(!mapping.TryGetValue(key, out result))
            {
                mapping[key] = Builder.MakeNode(arrayPath.Length <= 0 
                                                  ? NodeTypes.Child 
                                                  : NodeTypes.Parent);
            }

            return result.Make(arrayPath);
        }

        /// <summary>
        /// Get the red dot with path
        /// <para>Path support use dots to flatten a multi-dimensional associative array</para>
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public IRedDot this[string path]
        {
            get
            {
                return Get(path);
            }
        }
    }
}
