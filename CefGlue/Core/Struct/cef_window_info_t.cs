﻿namespace CefGlue.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Class representing window information.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = libcef.StructPack)]
    internal unsafe partial struct cef_window_info_t
    {
        // Standard parameters required by CreateWindowEx()
        public WindowStylesEx m_dwExStyle;
        public cef_string_t m_windowName;
        public WindowStyles m_dwStyle;
        public int m_x;
        public int m_y;
        public int m_nWidth;
        public int m_nHeight;
        public IntPtr m_hWndParent;
        public IntPtr m_hMenu;

        // If window rendering is disabled no browser window will be created. Set
        // |m_hWndParent| to the window that will act as the parent for popup menus,
        // dialog boxes, etc.
        //BOOL m_bWindowRenderingDisabled;
        public int m_bWindowRenderingDisabled;

        // Handle for the new browser window.
        public IntPtr m_hWnd;


        public static void Clear(cef_window_info_t* self)
        {
            cef_string_t.Clear(&self->m_windowName);
        }
    }
}