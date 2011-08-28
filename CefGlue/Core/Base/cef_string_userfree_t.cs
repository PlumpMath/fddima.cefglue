﻿namespace CefGlue.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Runtime.InteropServices;

    /// <summary>
    /// It is sometimes necessary for the system to allocate string structures with
    /// the expectation that the user will free them. The userfree types act as a
    /// hint that the user is responsible for freeing the structure.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = libcef.StructPack)]
    internal unsafe struct cef_string_userfree_t
    {
        private cef_string_t* str;

        public void Free()
        {
            cef_string_userfree_free(this);
        }

        public string GetString()
        {
            return cef_string_t.ToString(str);
        }

        public string GetStringAndFree()
        {
            var result = cef_string_t.ToString(str);
            cef_string_userfree_free(this);
            return result;
        }

        #region LibCef UserFreeString NativeMethods

        /// <summary>
        /// These functions allocate a new string structure.
        /// They must be freed by calling the associated free function.
        /// </summary>
        /// <remarks>
        /// CEF_EXPORT cef_string_userfree_utf16_t cef_string_userfree_utf16_alloc();
        /// </remarks>
        [DllImport(libcef.DllName, EntryPoint = "cef_string_userfree_utf16_alloc", CallingConvention = libcef.Call)]
        private static extern cef_string_userfree_t cef_string_userfree_alloc();

        /// <summary>
        /// These functions free the string structure allocated by the associated alloc function.
        /// Any string contents will first be cleared.
        /// </summary>
        /// <remarks>
        /// CEF_EXPORT void cef_string_userfree_utf16_free(cef_string_userfree_utf16_t str);
        /// </remarks>
        [DllImport(libcef.DllName, EntryPoint = "cef_string_userfree_utf16_free", CallingConvention = libcef.Call)]
        private static extern void cef_string_userfree_free(cef_string_userfree_t str);

        #endregion
    }
}