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

namespace CatLib.RedDot.Style
{
    /// <summary>
    /// Numeric style
    /// </summary>
    public class Numeric : IStyle
    {
        /// <summary>
        /// Number of events
        /// </summary>
        private int count;

        /// <summary>
        /// Number of events
        /// </summary>
        public int Count
        {
            get
            {
                return count;
            }
        }

        /// <summary>
        /// Set the number of events
        /// </summary>
        /// <param name="count">Number of events</param>
        public virtual void Counted(int count)
        {
            this.count = count;
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

        /// <summary>
        /// Clear the number of events
        /// </summary>
        public virtual void Clear()
        {
            Counted(0);
        }
    }
}
