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

    public sealed unsafe partial class CefV8Value : IDisposable
	{
#if DIAGNOSTICS
		internal static int ObjectCt;
#endif

        /// <summary>
        /// Create CefV8Value proxy from pointer.
        /// </summary>
        internal static CefV8Value From(cef_v8value_t* ptr)
        {
			return new CefV8Value(ptr, false);
        }

        /// <summary>
        /// Create CefV8Value proxy from pointer and optionally increments the reference count for the object.
        /// </summary>
        internal static CefV8Value Create(cef_v8value_t* ptr, bool addRefCount)
        {
            return new CefV8Value(ptr, addRefCount);
        }

        private cef_v8value_t* ptr;

        private CefV8Value(cef_v8value_t* ptr, bool addRefCount)
        {
            this.ptr = ptr;

#if DIAGNOSTICS
            Interlocked.Increment(ref ObjectCt);
            Cef.Logger.Trace(LogTarget.CefV8Value, this.ptr, LogOperation.Create);
#endif

			if (addRefCount) this.AddRef();
        }

        #region IDisposable
        ~CefV8Value()
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
                Cef.Logger.Trace(LogTarget.CefV8Value, this.ptr, LogOperation.Dispose, "RefCount=[{0}]", refct);
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

        internal cef_v8value_t* NativePointer
        {
            get
            {
                return this.ptr;
            }
        }

        internal cef_v8value_t* GetNativePointerAndAddRef()
        {
            AddRef();
            return this.ptr;
        }

        private cef_v8value_t.is_undefined_delegate is_undefined
        {
            get
            {
                return (cef_v8value_t.is_undefined_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->is_undefined, typeof(cef_v8value_t.is_undefined_delegate));
            }
        }

        private cef_v8value_t.is_null_delegate is_null
        {
            get
            {
                return (cef_v8value_t.is_null_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->is_null, typeof(cef_v8value_t.is_null_delegate));
            }
        }

        private cef_v8value_t.is_bool_delegate is_bool
        {
            get
            {
                return (cef_v8value_t.is_bool_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->is_bool, typeof(cef_v8value_t.is_bool_delegate));
            }
        }

        private cef_v8value_t.is_int_delegate is_int
        {
            get
            {
                return (cef_v8value_t.is_int_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->is_int, typeof(cef_v8value_t.is_int_delegate));
            }
        }

        private cef_v8value_t.is_double_delegate is_double
        {
            get
            {
                return (cef_v8value_t.is_double_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->is_double, typeof(cef_v8value_t.is_double_delegate));
            }
        }

        private cef_v8value_t.is_date_delegate is_date
        {
            get
            {
                return (cef_v8value_t.is_date_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->is_date, typeof(cef_v8value_t.is_date_delegate));
            }
        }

        private cef_v8value_t.is_string_delegate is_string
        {
            get
            {
                return (cef_v8value_t.is_string_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->is_string, typeof(cef_v8value_t.is_string_delegate));
            }
        }

        private cef_v8value_t.is_object_delegate is_object
        {
            get
            {
                return (cef_v8value_t.is_object_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->is_object, typeof(cef_v8value_t.is_object_delegate));
            }
        }

        private cef_v8value_t.is_array_delegate is_array
        {
            get
            {
                return (cef_v8value_t.is_array_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->is_array, typeof(cef_v8value_t.is_array_delegate));
            }
        }

        private cef_v8value_t.is_function_delegate is_function
        {
            get
            {
                return (cef_v8value_t.is_function_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->is_function, typeof(cef_v8value_t.is_function_delegate));
            }
        }

        private cef_v8value_t.is_same_delegate is_same
        {
            get
            {
                return (cef_v8value_t.is_same_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->is_same, typeof(cef_v8value_t.is_same_delegate));
            }
        }

        private cef_v8value_t.get_bool_value_delegate get_bool_value
        {
            get
            {
                return (cef_v8value_t.get_bool_value_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->get_bool_value, typeof(cef_v8value_t.get_bool_value_delegate));
            }
        }

        private cef_v8value_t.get_int_value_delegate get_int_value
        {
            get
            {
                return (cef_v8value_t.get_int_value_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->get_int_value, typeof(cef_v8value_t.get_int_value_delegate));
            }
        }

        private cef_v8value_t.get_double_value_delegate get_double_value
        {
            get
            {
                return (cef_v8value_t.get_double_value_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->get_double_value, typeof(cef_v8value_t.get_double_value_delegate));
            }
        }

        private cef_v8value_t.get_date_value_delegate get_date_value
        {
            get
            {
                return (cef_v8value_t.get_date_value_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->get_date_value, typeof(cef_v8value_t.get_date_value_delegate));
            }
        }

        private cef_v8value_t.get_string_value_delegate get_string_value
        {
            get
            {
                return (cef_v8value_t.get_string_value_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->get_string_value, typeof(cef_v8value_t.get_string_value_delegate));
            }
        }

        private cef_v8value_t.has_value_bykey_delegate has_value_bykey
        {
            get
            {
                return (cef_v8value_t.has_value_bykey_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->has_value_bykey, typeof(cef_v8value_t.has_value_bykey_delegate));
            }
        }

        private cef_v8value_t.has_value_byindex_delegate has_value_byindex
        {
            get
            {
                return (cef_v8value_t.has_value_byindex_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->has_value_byindex, typeof(cef_v8value_t.has_value_byindex_delegate));
            }
        }

        private cef_v8value_t.delete_value_bykey_delegate delete_value_bykey
        {
            get
            {
                return (cef_v8value_t.delete_value_bykey_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->delete_value_bykey, typeof(cef_v8value_t.delete_value_bykey_delegate));
            }
        }

        private cef_v8value_t.delete_value_byindex_delegate delete_value_byindex
        {
            get
            {
                return (cef_v8value_t.delete_value_byindex_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->delete_value_byindex, typeof(cef_v8value_t.delete_value_byindex_delegate));
            }
        }

        private cef_v8value_t.get_value_bykey_delegate get_value_bykey
        {
            get
            {
                return (cef_v8value_t.get_value_bykey_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->get_value_bykey, typeof(cef_v8value_t.get_value_bykey_delegate));
            }
        }

        private cef_v8value_t.get_value_byindex_delegate get_value_byindex
        {
            get
            {
                return (cef_v8value_t.get_value_byindex_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->get_value_byindex, typeof(cef_v8value_t.get_value_byindex_delegate));
            }
        }

        private cef_v8value_t.set_value_bykey_delegate set_value_bykey
        {
            get
            {
                return (cef_v8value_t.set_value_bykey_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->set_value_bykey, typeof(cef_v8value_t.set_value_bykey_delegate));
            }
        }

        private cef_v8value_t.set_value_byindex_delegate set_value_byindex
        {
            get
            {
                return (cef_v8value_t.set_value_byindex_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->set_value_byindex, typeof(cef_v8value_t.set_value_byindex_delegate));
            }
        }

        private cef_v8value_t.set_value_byaccessor_delegate set_value_byaccessor
        {
            get
            {
                return (cef_v8value_t.set_value_byaccessor_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->set_value_byaccessor, typeof(cef_v8value_t.set_value_byaccessor_delegate));
            }
        }

        private cef_v8value_t.get_keys_delegate get_keys
        {
            get
            {
                return (cef_v8value_t.get_keys_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->get_keys, typeof(cef_v8value_t.get_keys_delegate));
            }
        }

        private cef_v8value_t.get_user_data_delegate get_user_data
        {
            get
            {
                return (cef_v8value_t.get_user_data_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->get_user_data, typeof(cef_v8value_t.get_user_data_delegate));
            }
        }

        private cef_v8value_t.get_array_length_delegate get_array_length
        {
            get
            {
                return (cef_v8value_t.get_array_length_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->get_array_length, typeof(cef_v8value_t.get_array_length_delegate));
            }
        }

        private cef_v8value_t.get_function_name_delegate get_function_name
        {
            get
            {
                return (cef_v8value_t.get_function_name_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->get_function_name, typeof(cef_v8value_t.get_function_name_delegate));
            }
        }

        private cef_v8value_t.get_function_handler_delegate get_function_handler
        {
            get
            {
                return (cef_v8value_t.get_function_handler_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->get_function_handler, typeof(cef_v8value_t.get_function_handler_delegate));
            }
        }

        private cef_v8value_t.execute_function_delegate execute_function
        {
            get
            {
                return (cef_v8value_t.execute_function_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->execute_function, typeof(cef_v8value_t.execute_function_delegate));
            }
        }

        private cef_v8value_t.execute_function_with_context_delegate execute_function_with_context
        {
            get
            {
                return (cef_v8value_t.execute_function_with_context_delegate)Marshal.GetDelegateForFunctionPointer(this.ptr->execute_function_with_context, typeof(cef_v8value_t.execute_function_with_context_delegate));
            }
        }

    }
}
