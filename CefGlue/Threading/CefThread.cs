﻿namespace CefGlue.Threading
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;

    public static class CefThread
    {
        private static SynchronizationContext platformUI;
        private static SynchronizationContext ui;
        private static SynchronizationContext io;
        private static SynchronizationContext file;

        static CefThread()
        {
            platformUI = null;
            ui = new CefThreadSynchronizationContext(CefThreadId.UI);
            io = new CefThreadSynchronizationContext(CefThreadId.IO);
            file = new CefThreadSynchronizationContext(CefThreadId.File);
        }

        // TODO: Remove CefThread.PlatformUI -> never use it -> managing of this it is end-user code zone
        public static SynchronizationContext PlatformUI
        {
            get { return platformUI; }
        }

        public static SynchronizationContext UI
        {
            get { return ui; }
        }

        public static SynchronizationContext IO
        {
            get { return io; }
        }

        public static SynchronizationContext File
        {
            get { return file; }
        }

        internal static void InitPlatformUI()
        {
            if (platformUI == null)
            {
                platformUI = SynchronizationContext.Current;
                if (platformUI == null) throw new InvalidOperationException();
            }
        }
    }
}