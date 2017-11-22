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

namespace CatLib.API.RedDot
{
    /// <summary>
    /// 小红点
    /// </summary>
    public interface IRedDot
    {
        /// <summary>
        /// 载荷，表示当前红点应该显示什么数据
        /// <para>如果状态为<code>StyleTypes.Normal</code>那么返回值为<code>bool</code></para>
        /// <para>如果状态为<code>StyleTypes.Numeric</code>那么返回值为<code>int</code></para>
        /// <para>如果状态为<code>StyleTypes.Text</code>那么返回值为<code>string</code></para>
        /// <para>如果状态为<code>StyleTypes.Customize</code>那么返回值为<code>object</code>(载荷为用户设定值)</para>
        /// </summary>
        object Payload { get; }

        /// <summary>
        /// 红点样式状态
        /// </summary>
        StyleTypes StyleType { get; }

        /// <summary>
        /// 获取子红点
        /// </summary>
        /// <param name="path">子红点的路径,允许使用<b>/</b>或者<b>.</b>对深度进行分割</param>
        /// <returns>子红点</returns>
        IRedDot Child(string path);

        /// <summary>
        /// 获取子红点
        /// </summary>
        /// <param name="path">子红点的路径,允许使用<b>/</b>或者<b>.</b>对深度进行分割</param>
        /// <returns>子红点</returns>
        IRedDot this[string path] { get; }

        /// <summary>
        /// 设定一个回调，回调结果决定是否可以将当前红点样式状态传递到父级红点
        /// </summary>
        /// <param name="transfer">返回值决定是否可以将红点样式状态传递到父级</param>
        void Transfer(Predicate<IRedDot> transfer);

        /// <summary>
        /// 设定是否可以将红点样式状态传递到父级
        /// <para>默认值为:<code>true</code>(传递到父级)</para>
        /// </summary>
        /// <param name="transfer">是否可以传递到父级</param>
        void Transfer(bool transfer);

        /// <summary>
        /// 设定载荷，我们会自动根据载荷类型选择红点样式状态
        /// <para>如果传入值为<code>bool</code>，则样式为一个标准红点(<code>StyleTypes.Normal</code>)</para>
        /// <para>如果传入值为<code>int</code>，则样式为一个数字红点(<code>StyleTypes.Numeric</code>)</para>
        /// <para>如果传入值为<code>string</code>，则样式为一个文字红点(<code>StyleTypes.Text</code>)</para>
        /// <para>如果传入值为其他例外值，则样式为一个自定义红点(<code>StyleTypes.Customize</code>)</para>
        /// </summary>
        /// <param name="payload">Set payload</param>
        void Set(object payload);

        /// <summary>
        /// Clear dot style status
        /// </summary>
        /// <param name="halt">Only clear the top</param>
        void Clear(bool halt = false);

        /// <summary>
        /// Increment the number of events
        /// </summary>
        void Incr();

        /// <summary>
        /// Decrement the number of events
        /// </summary>
        void Decr();
    }
}
