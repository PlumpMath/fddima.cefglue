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

    public sealed unsafe partial class CefWebUrlRequest : IDisposable
	{
#if DIAGNOSTICS
		internal static int ObjectCt;
#endif

        /// <summary>
        /// Create CefWebUrlRequest proxy from pointer.
        /// </summary>
        internal static CefWebUrlRequest FromPointer(cef_web_urlrequest_t* ptr)
        {
			return new CefWebUrlRequest(ptr, false);
        }

        /// <summary>
        /// Create CefWebUrlRequest proxy from pointer and optionally increments the reference count for the object.
        /// </summary>
        internal static CefWebUrlRequest Create(cef_web_urlrequest_t* ptr, bool addRefCount)
        {
            return new CefWebUrlRequest(ptr, addRefCount);
        }

        private cef_web_urlrequest_t* ptr;

        private CefWebUrlRequest(cef_web_urlrequest_t* ptr, bool addRefCount)
        {
            this.ptr = ptr;

#if DIAGNOSTICS
            Interlocked.Increment(ref ObjectCt);
            Cef.Logger.Trace(LogTarget.CefWebUrlRequest, this.ptr, LogOperation.Create);
#endif

			if (addRefCount) this.AddRef();
        }

        #region IDisposable
        ~CefWebUrlRequest()
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
                Cef.Logger.Trace(LogTarget.CefWebUrlRequest, this.ptr, LogOperation.Dispose, "RefCount=[{0}]", refct);
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

        internal cef_web_urlrequest_t* NativePointer
        {
            get
            {
                return this.ptr;
            }
        }

        internal cef_web_urlrequest_t* GetNativePointerAndAddRef()
        {
            AddRef();
            return this.ptr;
        }

        private cef_web_urlrequest_t.cancel_delegate cancel
        {
            get
            {
                return (cef_web_urlrequest_t.cancel_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->cancel, typeof(cef_web_urlrequest_t.cancel_delegate));
            }
        }

        private cef_web_urlrequest_t.get_state_delegate get_state
        {
            get
            {
                return (cef_web_urlrequest_t.get_state_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->get_state, typeof(cef_web_urlrequest_t.get_state_delegate));
            }
        }

    }
}
