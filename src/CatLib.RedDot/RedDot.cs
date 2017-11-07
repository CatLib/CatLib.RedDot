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

namespace CatLib.RedDot
{
    /// <summary>
    /// Red dot
    /// </summary>
    public class RedDot : IRedDot
    {
        /// <summary>
        /// Parent dot
        /// </summary>
        private RedDot parent;

        /// <summary>
        /// Children dot
        /// </summary>
        private SortSet<RedDot, int> children;

        /// <summary>
        ///  Red Dot Inheritance relationship
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
        private RedDot masterChildren;

        /// <summary>
        /// Triggered when the red dot status changed
        /// </summary>
        private event Action<RedDot> onRedDotStatusChanage;

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
            
        }

        /// <summary>
        /// Recache the all status
        /// </summary>
        protected void Recache()
        {

        }
    }
}
