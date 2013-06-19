//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using MonoTouch;
using MonoTouch.CoreFoundation;
using MonoTouch.CoreMedia;
using MonoTouch.CoreMotion;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreLocation;
using MonoTouch.MapKit;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;
using MonoTouch.NewsstandKit;
using MonoTouch.GLKit;
using MonoTouch.CoreVideo;
using OpenTK;

namespace MonoSpotify {
	[Register("SPLoginViewController", true)]
	public unsafe partial class SPLoginViewController : global::MonoTouch.UIKit.UINavigationController {
		[CompilerGenerated]
		const string selAllowsCancel = "allowsCancel";
		static readonly IntPtr selAllowsCancelHandle = Selector.GetHandle ("allowsCancel");
		[CompilerGenerated]
		const string selSetAllowsCancel_ = "setAllowsCancel:";
		static readonly IntPtr selSetAllowsCancel_Handle = Selector.GetHandle ("setAllowsCancel:");
		[CompilerGenerated]
		const string selDismissesAfterLogin = "dismissesAfterLogin";
		static readonly IntPtr selDismissesAfterLoginHandle = Selector.GetHandle ("dismissesAfterLogin");
		[CompilerGenerated]
		const string selSetDismissesAfterLogin_ = "setDismissesAfterLogin:";
		static readonly IntPtr selSetDismissesAfterLogin_Handle = Selector.GetHandle ("setDismissesAfterLogin:");
		[CompilerGenerated]
		const string selLoginDelegate = "loginDelegate";
		static readonly IntPtr selLoginDelegateHandle = Selector.GetHandle ("loginDelegate");
		[CompilerGenerated]
		const string selSetLoginDelegate_ = "setLoginDelegate:";
		static readonly IntPtr selSetLoginDelegate_Handle = Selector.GetHandle ("setLoginDelegate:");
		[CompilerGenerated]
		const string selLoginControllerForSession_ = "loginControllerForSession:";
		static readonly IntPtr selLoginControllerForSession_Handle = Selector.GetHandle ("loginControllerForSession:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("SPLoginViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SPLoginViewController () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.Init);
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public SPLoginViewController (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public SPLoginViewController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public SPLoginViewController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("loginControllerForSession:")]
		[CompilerGenerated]
		public static SPLoginViewController LoginControllerForSession (SPSession session)
		{
			if (session == null)
				throw new ArgumentNullException ("session");
			return (SPLoginViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selLoginControllerForSession_Handle, session.Handle));
		}
		
		[CompilerGenerated]
		public virtual bool AllowsCancel {
			[Export ("allowsCancel")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsCancelHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selAllowsCancelHandle);
				}
			}
			
			[Export ("setAllowsCancel:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsCancel_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetAllowsCancel_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool DismissesAfterLogin {
			[Export ("dismissesAfterLogin")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selDismissesAfterLoginHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selDismissesAfterLoginHandle);
				}
			}
			
			[Export ("setDismissesAfterLogin:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDismissesAfterLogin_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetDismissesAfterLogin_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_LoginDelegate_var;
		[CompilerGenerated]
		public virtual SPLoginViewControllerDelegate LoginDelegate {
			[Export ("loginDelegate")]
			get {
				SPLoginViewControllerDelegate ret;
				if (IsDirectBinding) {
					ret = (SPLoginViewControllerDelegate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLoginDelegateHandle));
				} else {
					ret = (SPLoginViewControllerDelegate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLoginDelegateHandle));
				}
				MarkDirty ();
				__mt_LoginDelegate_var = ret;
				return ret;
			}
			
			[Export ("setLoginDelegate:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetLoginDelegate_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetLoginDelegate_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_LoginDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_LoginDelegate_var = null;
			}
		}
	} /* class SPLoginViewController */
}
