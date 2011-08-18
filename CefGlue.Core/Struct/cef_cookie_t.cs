﻿namespace CefGlue.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Cookie information.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = libcef.StructPack)]
    internal unsafe partial struct cef_cookie_t
    {
        ///
        // The cookie name.
        ///
        public cef_string_t name;

        ///
        // The cookie value.
        ///
        public cef_string_t value;

        ///
        // If |domain| is empty a host cookie will be created instead of a domain
        // cookie. Domain cookies are stored with a leading "." and are visible to
        // sub-domains whereas host cookies are not.
        ///
        public cef_string_t domain;

        ///
        // If |path| is non-empty only URLs at or below the path will get the cookie
        // value.
        ///
        public cef_string_t path;

        ///
        // If |secure| is true the cookie will only be sent for HTTPS requests.
        ///
        //bool secure;
        public int secure;

        ///
        // If |httponly| is true the cookie will only be sent for HTTP requests.
        ///
        //bool httponly;
        public int httponly;

        ///
        // The cookie creation date. This is automatically populated by the system on
        // cookie creation.
        ///
        public cef_time_t creation;

        ///
        // The cookie last access date. This is automatically populated by the system
        // on access.
        ///
        public cef_time_t last_access;

        ///
        // The cookie expiration date is only valid if |has_expires| is true.
        ///
        //bool has_expires;
        public int has_expires;
        public cef_time_t expires;
    }
}
