﻿/*
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
using System;

namespace CatLib.RedDot
{
    /// <summary>
    /// Red dot manager
    /// </summary>
    public class RedDotManager
    {
        /// <summary>
        /// The root node
        /// </summary>
        private readonly BaseNode root;
    
        /// <summary>
        /// Make a new instance of the red dot manager
        /// </summary>
        public RedDotManager()
        {
            root = new ParentNode();
        }

        /// <summary>
        /// Customize red dot
        /// </summary>
        /// <param name="type">Resolved style</param>
        /// <param name="styleResolved">Style resolved</param>
        public void Extend(Type type, Func<Type, IStyle> styleResolved)
        {

        }

        /// <summary>
        /// Make the red dot with path
        /// <para>Path support use dots to flatten a multi-dimensional associative array</para>
        /// </summary>
        /// <param name="path">string path</param>
        public IRedDot Make(string path)
        {
            return root.Child(path);
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
                return Make(path);
            }
        }
    }
}
