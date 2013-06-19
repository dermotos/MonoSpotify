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
		static readonly IntPtr selAllowsCancel = Selector.GetHandle ("allowsCancel");
		[CompilerGenerated]
		static readonly IntPtr selSetAllowsCancel_ = Selector.GetHandle ("setAllowsCancel:");
		[CompilerGenerated]
		static readonly IntPtr selDismissesAfterLogin = Selector.GetHandle ("dismissesAfterLogin");
		[CompilerGenerated]
		static readonly IntPtr selSetDismissesAfterLogin_ = Selector.GetHandle ("setDismissesAfterLogin:");
		[CompilerGenerated]
		static readonly IntPtr selLoginDelegate = Selector.GetHandle ("loginDelegate");
		[CompilerGenerated]
		static readonly IntPtr selSetLoginDelegate_ = Selector.GetHandle ("setLoginDelegate:");
		[CompilerGenerated]
		static readonly IntPtr selLoginControllerForSession_ = Selector.GetHandle ("loginControllerForSession:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("SPLoginViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  SPLoginViewController () : base (NSObjectFlag.Empty)
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
			return (SPLoginViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selLoginControllerForSession_, session.Handle));
		}
		
		[CompilerGenerated]
		public virtual bool AllowsCancel {
			[Export ("allowsCancel")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsCancel);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selAllowsCancel);
				}
			}
			
			[Export ("setAllowsCancel:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsCancel_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetAllowsCancel_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool DismissesAfterLogin {
			[Export ("dismissesAfterLogin")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selDismissesAfterLogin);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selDismissesAfterLogin);
				}
			}
			
			[Export ("setDismissesAfterLogin:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDismissesAfterLogin_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetDismissesAfterLogin_, value);
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
					ret = (SPLoginViewControllerDelegate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLoginDelegate));
				} else {
					ret = (SPLoginViewControllerDelegate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLoginDelegate));
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
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetLoginDelegate_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetLoginDelegate_, value.Handle);
				}
				MarkDirty ();
				__mt_LoginDelegate_var = value;
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_LoginDelegate_var = null;
			}
		}
	} /* class SPLoginViewController */
}
