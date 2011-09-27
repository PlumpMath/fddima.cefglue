﻿namespace CefGlue.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    ///
    // DOM event category flags.
    ///
    internal enum cef_dom_event_category_t : int
    {
        DOM_EVENT_CATEGORY_UNKNOWN = 0x0,
        DOM_EVENT_CATEGORY_UI = 0x1,
        DOM_EVENT_CATEGORY_MOUSE = 0x2,
        DOM_EVENT_CATEGORY_MUTATION = 0x4,
        DOM_EVENT_CATEGORY_KEYBOARD = 0x8,
        DOM_EVENT_CATEGORY_TEXT = 0x10,
        DOM_EVENT_CATEGORY_COMPOSITION = 0x20,
        DOM_EVENT_CATEGORY_DRAG = 0x40,
        DOM_EVENT_CATEGORY_CLIPBOARD = 0x80,
        DOM_EVENT_CATEGORY_MESSAGE = 0x100,
        DOM_EVENT_CATEGORY_WHEEL = 0x200,
        DOM_EVENT_CATEGORY_BEFORE_TEXT_INSERTED = 0x400,
        DOM_EVENT_CATEGORY_OVERFLOW = 0x800,
        DOM_EVENT_CATEGORY_PAGE_TRANSITION = 0x1000,
        DOM_EVENT_CATEGORY_POPSTATE = 0x2000,
        DOM_EVENT_CATEGORY_PROGRESS = 0x4000,
        DOM_EVENT_CATEGORY_XMLHTTPREQUEST_PROGRESS = 0x8000,
        DOM_EVENT_CATEGORY_WEBKIT_ANIMATION = 0x10000,
        DOM_EVENT_CATEGORY_WEBKIT_TRANSITION = 0x20000,
        DOM_EVENT_CATEGORY_BEFORE_LOAD = 0x40000,
    }
}
