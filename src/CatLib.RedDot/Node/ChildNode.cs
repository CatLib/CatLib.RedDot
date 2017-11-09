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

using System;

namespace CatLib.RedDot.Node
{
    /// <summary>
    /// Child Node
    /// </summary>
    public class ChildNode : BaseNode
    {
        /// <summary>
        /// Number of events
        /// </summary>
        private int count;

        /// <summary>
        /// Number of events
        /// </summary>
        public override int Count
        {
            get
            {
                return count;
            }
        }

        /// <summary>
        /// Set the number of events
        /// </summary>
        /// <param name="count">number of events</param>
        public void Counted(int count)
        {
            count = Math.Max(0, count);
        }

        /// <summary>
        /// Increment the number of events
        /// </summary>
        public void Incr()
        {
            Counted(Count + 1);
        }

        /// <summary>
        /// Decrement the number of events
        /// </summary>
        public void Decr()
        {
            Counted(Count - 1);
        }

        /*
        /// <summary>
        ///  Red dot Inheritance relationship
        /// </summary>
        private TransferTypes transferType;

        /// <summary>
        /// The style of the red dot
        /// </summary>
        private StyleTypes styleType;

        /// <summary>
        /// object payload
        /// </summary>
        private object payload;

        /// <summary>
        /// The Count of all the active children cache
        /// </summary>
        private int cacheCount;

        /// <summary>
        /// The main state is taken from master children
        /// </summary>
        private ChildNode masterChildren;

        /// <summary>
        /// Triggered when the red dot status changed
        /// </summary>
        private event Action<ChildNode> onRedDotStatusChanage;

        /// <summary>
        /// A processor is set up to handle whether red dots should be passed to the parent
        /// </summary>
        /// <param name="processor">Processor for transfer</param>
        public void SetCustomizeTransfer(Func<IRedDot, bool> processor)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="style"></param>
        /// <param name="priority"></param>
        public void SetCustomizeStyle(string style, int priority)
        {
        }

        /// <summary>
        /// Active current red dot
        /// </summary>
        /// <param name="isActive">the bool said active status</param>
        public void Active(bool isActive)
        {
        }*/
    }
}
