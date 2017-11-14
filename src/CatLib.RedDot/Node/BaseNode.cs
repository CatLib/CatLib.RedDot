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
    /// Base node
    /// </summary>
    public abstract class BaseNode : IRedDot
    {
        /// <summary>
        /// Parent node
        /// </summary>
        protected BaseNode parent;

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
        public abstract int Count { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parent"></param>
        protected BaseNode(BaseNode parent = null)
        {
            this.parent = parent;
        }

        /// <summary>
        /// Set the number of events
        /// </summary>
        /// <param name="count">Number of events</param>
        public abstract void Counted(int count);

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

        /// <summary>
        /// Clear the number of events
        /// </summary>
        public virtual void Clear()
        {
            Counted(0);
        }

        /// <summary>
        /// Get or Make node with path
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        internal virtual BaseNode Make(string[] path)
        {
            return this;
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
