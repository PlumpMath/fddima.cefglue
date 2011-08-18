﻿namespace CefGlue.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Runtime.InteropServices;

    ///
    // Structure representing a rectangle.
    ///
    [StructLayout(LayoutKind.Sequential, Pack = libcef.StructPack)]
    internal unsafe partial struct cef_rect_t
    {
        public int x;
        public int y;
        public int width;
        public int height;
    }
}
