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

    public sealed unsafe partial class CefDomDocument : IDisposable
	{
#if DIAGNOSTICS
		internal static int ObjectCt;
#endif

        /// <summary>
        /// Create CefDomDocument proxy from pointer.
        /// </summary>
        internal static CefDomDocument FromPointer(cef_domdocument_t* ptr)
        {
			return new CefDomDocument(ptr, false);
        }

        /// <summary>
        /// Create CefDomDocument proxy from pointer and optionally increments the reference count for the object.
        /// </summary>
        internal static CefDomDocument Create(cef_domdocument_t* ptr, bool addRefCount)
        {
            return new CefDomDocument(ptr, addRefCount);
        }

        private cef_domdocument_t* ptr;

        private CefDomDocument(cef_domdocument_t* ptr, bool addRefCount)
        {
            this.ptr = ptr;

#if DIAGNOSTICS
            Interlocked.Increment(ref ObjectCt);
            Cef.Logger.Trace(LogTarget.CefDomDocument, this.ptr, LogOperation.Create);
#endif

			if (addRefCount) this.AddRef();
        }

        #region IDisposable
        ~CefDomDocument()
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
                Cef.Logger.Trace(LogTarget.CefDomDocument, this.ptr, LogOperation.Dispose, "RefCount=[{0}]", refct);
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

        internal cef_domdocument_t* NativePointer
        {
            get
            {
                return this.ptr;
            }
        }

        internal cef_domdocument_t* GetNativePointerAndAddRef()
        {
            AddRef();
            return this.ptr;
        }

        private cef_domdocument_t.get_type_delegate get_type
        {
            get
            {
                return (cef_domdocument_t.get_type_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->get_type, typeof(cef_domdocument_t.get_type_delegate));
            }
        }

        private cef_domdocument_t.get_document_delegate get_document
        {
            get
            {
                return (cef_domdocument_t.get_document_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->get_document, typeof(cef_domdocument_t.get_document_delegate));
            }
        }

        private cef_domdocument_t.get_body_delegate get_body
        {
            get
            {
                return (cef_domdocument_t.get_body_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->get_body, typeof(cef_domdocument_t.get_body_delegate));
            }
        }

        private cef_domdocument_t.get_head_delegate get_head
        {
            get
            {
                return (cef_domdocument_t.get_head_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->get_head, typeof(cef_domdocument_t.get_head_delegate));
            }
        }

        private cef_domdocument_t.get_title_delegate get_title
        {
            get
            {
                return (cef_domdocument_t.get_title_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->get_title, typeof(cef_domdocument_t.get_title_delegate));
            }
        }

        private cef_domdocument_t.get_element_by_id_delegate get_element_by_id
        {
            get
            {
                return (cef_domdocument_t.get_element_by_id_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->get_element_by_id, typeof(cef_domdocument_t.get_element_by_id_delegate));
            }
        }

        private cef_domdocument_t.get_focused_node_delegate get_focused_node
        {
            get
            {
                return (cef_domdocument_t.get_focused_node_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->get_focused_node, typeof(cef_domdocument_t.get_focused_node_delegate));
            }
        }

        private cef_domdocument_t.has_selection_delegate has_selection
        {
            get
            {
                return (cef_domdocument_t.has_selection_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->has_selection, typeof(cef_domdocument_t.has_selection_delegate));
            }
        }

        private cef_domdocument_t.get_selection_start_node_delegate get_selection_start_node
        {
            get
            {
                return (cef_domdocument_t.get_selection_start_node_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->get_selection_start_node, typeof(cef_domdocument_t.get_selection_start_node_delegate));
            }
        }

        private cef_domdocument_t.get_selection_start_offset_delegate get_selection_start_offset
        {
            get
            {
                return (cef_domdocument_t.get_selection_start_offset_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->get_selection_start_offset, typeof(cef_domdocument_t.get_selection_start_offset_delegate));
            }
        }

        private cef_domdocument_t.get_selection_end_node_delegate get_selection_end_node
        {
            get
            {
                return (cef_domdocument_t.get_selection_end_node_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->get_selection_end_node, typeof(cef_domdocument_t.get_selection_end_node_delegate));
            }
        }

        private cef_domdocument_t.get_selection_end_offset_delegate get_selection_end_offset
        {
            get
            {
                return (cef_domdocument_t.get_selection_end_offset_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->get_selection_end_offset, typeof(cef_domdocument_t.get_selection_end_offset_delegate));
            }
        }

        private cef_domdocument_t.get_selection_as_markup_delegate get_selection_as_markup
        {
            get
            {
                return (cef_domdocument_t.get_selection_as_markup_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->get_selection_as_markup, typeof(cef_domdocument_t.get_selection_as_markup_delegate));
            }
        }

        private cef_domdocument_t.get_selection_as_text_delegate get_selection_as_text
        {
            get
            {
                return (cef_domdocument_t.get_selection_as_text_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->get_selection_as_text, typeof(cef_domdocument_t.get_selection_as_text_delegate));
            }
        }

        private cef_domdocument_t.get_base_url_delegate get_base_url
        {
            get
            {
                return (cef_domdocument_t.get_base_url_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->get_base_url, typeof(cef_domdocument_t.get_base_url_delegate));
            }
        }

        private cef_domdocument_t.get_complete_url_delegate get_complete_url
        {
            get
            {
                return (cef_domdocument_t.get_complete_url_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->get_complete_url, typeof(cef_domdocument_t.get_complete_url_delegate));
            }
        }

    }
}
