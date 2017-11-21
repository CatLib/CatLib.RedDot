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
using CatLib.RedDot.Style;
using System.Collections.Generic;
using System;

namespace CatLib.RedDot.Node
{
    /// <summary>
    /// Base node
    /// </summary>
    public sealed class BaseNode : IRedDot
    {
        /// <summary>
        /// Parent node
        /// </summary>
        private BaseNode parent;

        /// <summary>
        /// Dot style
        /// </summary>
        private IStyle style;

        /// <summary>
        /// Parent node
        /// </summary>
        public IRedDot Parent
        {
            get
            {
                return parent;
            }
        }

        /// <summary>
        /// Transfer
        /// </summary>
        private Predicate<bool> transfer;

        /// <summary>
        /// Number of events
        /// </summary>
        public int Count
        {
            get
            {
                return (int)style.Payload;
            }
        }

        /// <summary>
        /// Mapping for red dot
        /// </summary>
        private readonly IDictionary<string, BaseNode> children;

        /// <summary>
        /// Created new base node instance
        /// </summary>
        /// <param name="parent">parent node</param>
        public BaseNode(BaseNode parent = null)
        {
            this.parent = parent;
            children = new Dictionary<string, BaseNode>();
        }

        #region Numbice interface
        /// <summary>
        /// Increment the number of events
        /// </summary>
        public void Incr(object payload)
        {
            Set(Count + 1);
        }

        /// <summary>
        /// Decrement the number of events
        /// </summary>
        public void Decr()
        {
            Set(Count - 1);
        }
        #endregion

        /// <summary>
        /// Set payload（We will automatically adjust the red dot according to the load）
        /// </summary>
        /// <param name="payload">Set payload</param>
        public void Set(object payload)
        {
            style.Set(payload);
        }

        /// <summary>
        /// Clear the dot status
        /// </summary>
        public void Clear()
        {
            style.Clear();
        }

        /// <summary>
        /// Find the child
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public IRedDot Child(string path)
        {
            return Make(Builder.ToArrayPath(path));
        }

        /// <summary>
        /// Get or Make node with path
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        internal BaseNode Make(string[] path)
        {
            if (path == null || path.Length <= 0)
            {
                return this;
            }

            var key = Arr.Pop(ref path);
            BaseNode node;

            if (!children.TryGetValue(key, out node))
            {
                children[key] = node = new BaseNode(this);
            }

            return node.Make(path);
        }

        /// <summary>
        /// 重新缓存
        /// </summary>
        private void Recache()
        {
        }
    }
}
