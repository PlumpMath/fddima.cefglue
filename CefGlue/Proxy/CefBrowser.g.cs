//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace CefGlue
{
    using System;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using System.Threading;
    using Core;
	using Diagnostics;

    public sealed unsafe partial class CefBrowser : IDisposable
	{
#if DIAGNOSTICS
		internal static int ObjectCt;
#endif

        /// <summary>
        /// Create CefBrowser proxy from pointer.
        /// </summary>
        internal static CefBrowser FromPointer(cef_browser_t* ptr)
        {
			return new CefBrowser(ptr, false);
        }

        /// <summary>
        /// Create CefBrowser proxy from pointer and optionally increments the reference count for the object.
        /// </summary>
        internal static CefBrowser Create(cef_browser_t* ptr, bool addRefCount)
        {
            return new CefBrowser(ptr, addRefCount);
        }

        private cef_browser_t* ptr;

        private CefBrowser(cef_browser_t* ptr, bool addRefCount)
        {
            this.ptr = ptr;

#if DIAGNOSTICS
            Interlocked.Increment(ref ObjectCt);
            Cef.Logger.Trace(LogTarget.CefBrowser, this.ptr, LogOperation.Create);
#endif

			if (addRefCount) this.AddRef();
        }

        #region IDisposable
        ~CefBrowser()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (this.ptr != null)
            {
                var refct = ReleaseRef();
#if DIAGNOSTICS
                var total = Interlocked.Decrement(ref ObjectCt);
                Cef.Logger.Trace(LogTarget.CefBrowser, this.ptr, LogOperation.Dispose, "RefCount=[{0}]", refct);
#endif
                this.ptr = null;
            }
        }
        #endregion

        private cef_base_t.add_ref_delegate add_ref
        {
            get
            {
                return (cef_base_t.add_ref_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->@base.add_ref, typeof(cef_base_t.add_ref_delegate));
            }
        }

        private cef_base_t.release_delegate release
        {
            get
            {
                return (cef_base_t.release_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->@base.release, typeof(cef_base_t.release_delegate));
            }
        }

        private cef_base_t.get_refct_delegate get_refct
        {
            get
            {
                return (cef_base_t.get_refct_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->@base.get_refct, typeof(cef_base_t.get_refct_delegate));
            }
        }

        /// <summary>
        /// The AddRef method increments the reference count for the object. It should
        /// be called for every new copy of a pointer to a given object. The resulting
        /// reference count value is returned and should be used for diagnostic/testing
        /// purposes only.
        /// </summary>
        internal int AddRef()
        {
            return add_ref(&this.ptr->@base);
        }

        /// <summary>
        /// The Release method decrements the reference count for the object. If the
        /// reference count on the object falls to 0, then the object should free
        /// itself from memory.  The resulting reference count value is returned and
        /// should be used for diagnostic/testing purposes only.
        /// </summary>
        internal int ReleaseRef()
        {
            return release(&this.ptr->@base);
        }

        /// <summary>
        /// Return the current number of references.
        /// </summary>
        internal int RefCount
        {
            get { return get_refct(&this.ptr->@base); }
        }

        internal cef_browser_t* NativePointer
        {
            get
            {
                return this.ptr;
            }
        }

        internal cef_browser_t* GetNativePointerAndAddRef()
        {
            AddRef();
            return this.ptr;
        }

        private cef_browser_t.close_browser_delegate close_browser
        {
            get
            {
                return (cef_browser_t.close_browser_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->close_browser, typeof(cef_browser_t.close_browser_delegate));
            }
        }

        private cef_browser_t.can_go_back_delegate can_go_back
        {
            get
            {
                return (cef_browser_t.can_go_back_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->can_go_back, typeof(cef_browser_t.can_go_back_delegate));
            }
        }

        private cef_browser_t.go_back_delegate go_back
        {
            get
            {
                return (cef_browser_t.go_back_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->go_back, typeof(cef_browser_t.go_back_delegate));
            }
        }

        private cef_browser_t.can_go_forward_delegate can_go_forward
        {
            get
            {
                return (cef_browser_t.can_go_forward_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->can_go_forward, typeof(cef_browser_t.can_go_forward_delegate));
            }
        }

        private cef_browser_t.go_forward_delegate go_forward
        {
            get
            {
                return (cef_browser_t.go_forward_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->go_forward, typeof(cef_browser_t.go_forward_delegate));
            }
        }

        private cef_browser_t.reload_delegate reload
        {
            get
            {
                return (cef_browser_t.reload_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->reload, typeof(cef_browser_t.reload_delegate));
            }
        }

        private cef_browser_t.reload_ignore_cache_delegate reload_ignore_cache
        {
            get
            {
                return (cef_browser_t.reload_ignore_cache_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->reload_ignore_cache, typeof(cef_browser_t.reload_ignore_cache_delegate));
            }
        }

        private cef_browser_t.stop_load_delegate stop_load
        {
            get
            {
                return (cef_browser_t.stop_load_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->stop_load, typeof(cef_browser_t.stop_load_delegate));
            }
        }

        private cef_browser_t.set_focus_delegate set_focus
        {
            get
            {
                return (cef_browser_t.set_focus_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->set_focus, typeof(cef_browser_t.set_focus_delegate));
            }
        }

        private cef_browser_t.get_window_handle_delegate get_window_handle
        {
            get
            {
                return (cef_browser_t.get_window_handle_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->get_window_handle, typeof(cef_browser_t.get_window_handle_delegate));
            }
        }

        private cef_browser_t.get_opener_window_handle_delegate get_opener_window_handle
        {
            get
            {
                return (cef_browser_t.get_opener_window_handle_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->get_opener_window_handle, typeof(cef_browser_t.get_opener_window_handle_delegate));
            }
        }

        private cef_browser_t.is_popup_delegate is_popup
        {
            get
            {
                return (cef_browser_t.is_popup_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->is_popup, typeof(cef_browser_t.is_popup_delegate));
            }
        }

        private cef_browser_t.get_client_delegate get_client
        {
            get
            {
                return (cef_browser_t.get_client_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->get_client, typeof(cef_browser_t.get_client_delegate));
            }
        }

        private cef_browser_t.get_main_frame_delegate get_main_frame
        {
            get
            {
                return (cef_browser_t.get_main_frame_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->get_main_frame, typeof(cef_browser_t.get_main_frame_delegate));
            }
        }

        private cef_browser_t.get_focused_frame_delegate get_focused_frame
        {
            get
            {
                return (cef_browser_t.get_focused_frame_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->get_focused_frame, typeof(cef_browser_t.get_focused_frame_delegate));
            }
        }

        private cef_browser_t.get_frame_delegate get_frame
        {
            get
            {
                return (cef_browser_t.get_frame_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->get_frame, typeof(cef_browser_t.get_frame_delegate));
            }
        }

        private cef_browser_t.get_frame_names_delegate get_frame_names
        {
            get
            {
                return (cef_browser_t.get_frame_names_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->get_frame_names, typeof(cef_browser_t.get_frame_names_delegate));
            }
        }

        private cef_browser_t.find_delegate find
        {
            get
            {
                return (cef_browser_t.find_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->find, typeof(cef_browser_t.find_delegate));
            }
        }

        private cef_browser_t.stop_finding_delegate stop_finding
        {
            get
            {
                return (cef_browser_t.stop_finding_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->stop_finding, typeof(cef_browser_t.stop_finding_delegate));
            }
        }

        private cef_browser_t.get_zoom_level_delegate get_zoom_level
        {
            get
            {
                return (cef_browser_t.get_zoom_level_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->get_zoom_level, typeof(cef_browser_t.get_zoom_level_delegate));
            }
        }

        private cef_browser_t.set_zoom_level_delegate set_zoom_level
        {
            get
            {
                return (cef_browser_t.set_zoom_level_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->set_zoom_level, typeof(cef_browser_t.set_zoom_level_delegate));
            }
        }

        private cef_browser_t.show_dev_tools_delegate show_dev_tools
        {
            get
            {
                return (cef_browser_t.show_dev_tools_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->show_dev_tools, typeof(cef_browser_t.show_dev_tools_delegate));
            }
        }

        private cef_browser_t.close_dev_tools_delegate close_dev_tools
        {
            get
            {
                return (cef_browser_t.close_dev_tools_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->close_dev_tools, typeof(cef_browser_t.close_dev_tools_delegate));
            }
        }

        private cef_browser_t.is_window_rendering_disabled_delegate is_window_rendering_disabled
        {
            get
            {
                return (cef_browser_t.is_window_rendering_disabled_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->is_window_rendering_disabled, typeof(cef_browser_t.is_window_rendering_disabled_delegate));
            }
        }

        private cef_browser_t.get_size_delegate get_size
        {
            get
            {
                return (cef_browser_t.get_size_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->get_size, typeof(cef_browser_t.get_size_delegate));
            }
        }

        private cef_browser_t.set_size_delegate set_size
        {
            get
            {
                return (cef_browser_t.set_size_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->set_size, typeof(cef_browser_t.set_size_delegate));
            }
        }

        private cef_browser_t.is_popup_visible_delegate is_popup_visible
        {
            get
            {
                return (cef_browser_t.is_popup_visible_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->is_popup_visible, typeof(cef_browser_t.is_popup_visible_delegate));
            }
        }

        private cef_browser_t.hide_popup_delegate hide_popup
        {
            get
            {
                return (cef_browser_t.hide_popup_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->hide_popup, typeof(cef_browser_t.hide_popup_delegate));
            }
        }

        private cef_browser_t.invalidate_delegate invalidate
        {
            get
            {
                return (cef_browser_t.invalidate_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->invalidate, typeof(cef_browser_t.invalidate_delegate));
            }
        }

        private cef_browser_t.get_image_delegate get_image
        {
            get
            {
                return (cef_browser_t.get_image_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->get_image, typeof(cef_browser_t.get_image_delegate));
            }
        }

        private cef_browser_t.send_key_event_delegate send_key_event
        {
            get
            {
                return (cef_browser_t.send_key_event_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->send_key_event, typeof(cef_browser_t.send_key_event_delegate));
            }
        }

        private cef_browser_t.send_mouse_click_event_delegate send_mouse_click_event
        {
            get
            {
                return (cef_browser_t.send_mouse_click_event_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->send_mouse_click_event, typeof(cef_browser_t.send_mouse_click_event_delegate));
            }
        }

        private cef_browser_t.send_mouse_move_event_delegate send_mouse_move_event
        {
            get
            {
                return (cef_browser_t.send_mouse_move_event_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->send_mouse_move_event, typeof(cef_browser_t.send_mouse_move_event_delegate));
            }
        }

        private cef_browser_t.send_mouse_wheel_event_delegate send_mouse_wheel_event
        {
            get
            {
                return (cef_browser_t.send_mouse_wheel_event_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->send_mouse_wheel_event, typeof(cef_browser_t.send_mouse_wheel_event_delegate));
            }
        }

        private cef_browser_t.send_focus_event_delegate send_focus_event
        {
            get
            {
                return (cef_browser_t.send_focus_event_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->send_focus_event, typeof(cef_browser_t.send_focus_event_delegate));
            }
        }

        private cef_browser_t.send_capture_lost_event_delegate send_capture_lost_event
        {
            get
            {
                return (cef_browser_t.send_capture_lost_event_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->send_capture_lost_event, typeof(cef_browser_t.send_capture_lost_event_delegate));
            }
        }

    }
}
