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
    /// How does red dot style 
    /// </summary>
    public enum StyleTypes
    {
        /// <summary>
        /// Normal Red dot , just red dot no tip
        /// </summary>
        Normal = 40,

        /// <summary>
        /// Red dot with numbers
        /// </summary>
        Numeric = 30,

        /// <summary>
        /// Red dot with texts
        /// </summary>
        Text = 20,

        /// <summary>
        /// Customize red dot , For different shapes of red dots
        /// </summary>
        Customize = 10
    }
}
