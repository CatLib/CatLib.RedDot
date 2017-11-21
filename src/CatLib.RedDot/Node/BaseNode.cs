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
using System;
using System.Collections.Generic;

namespace CatLib.RedDot.Node
{
    /// <summary>
    /// Base node
    /// </summary>
    public class BaseNode : IRedDot
    {
        /// <summary>
        /// Parent node
        /// </summary>
        protected BaseNode parent;

        /// <summary>
        /// Dot style
        /// </summary>
        protected IStyle style;

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
        /// Style resolved
        /// </summary>
        private Func<Type, IStyle> styleResolved;

        /// <summary>
        /// Mapping for red dot
        /// </summary>
        private readonly IDictionary<string, BaseNode> children;

        /// <summary>
        /// Created new base node instance
        /// </summary>
        /// <param name="styleResolved">Style resolved</param>
        /// <param name="parent">parent node</param>
        public BaseNode(Func<Type, IStyle> styleResolved, BaseNode parent = null)
        {
            this.styleResolved = styleResolved;
            this.parent = parent;
            children = new Dictionary<string, BaseNode>();
        }

        #region Numbice interface
        /// <summary>
        /// Set the number of events
        /// </summary>
        /// <param name="count">Number of events</param>
        public void Counted(int count)
        {
            style.Set(Math.Max(0, count));
        }

        /// <summary>
        /// Increment the number of events
        /// </summary>
        public virtual void Incr()
        {
            Counted(Count + 1);
        }

        /// <summary>
        /// Decrement the number of events
        /// </summary>
        public virtual void Decr()
        {
            Counted(Count - 1);
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
        public virtual void Clear()
        {
            style.Clear();
        }

        /// <summary>
        /// Get or Make node with path
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        internal virtual BaseNode Make(string[] path)
        {
            if (path == null || path.Length <= 0)
            {
                return this;
            }

            var key = Arr.Pop(ref path);
            BaseNode node;

            if (!children.TryGetValue(key, out node))
            {
                children[key] = node = Builder.MakeNode((path.Length <= 0) ? NodeTypes.Child : NodeTypes.Parent, this);
            }

            return node.Make(path);
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
        /// 重新缓存
        /// </summary>
        protected virtual void Recache()
        {
        }
    }
}
