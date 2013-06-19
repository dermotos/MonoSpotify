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
	[Register("SPUser", true)]
	public unsafe partial class SPUser : NSObject {
		[CompilerGenerated]
		static readonly IntPtr selIsLoaded = Selector.GetHandle ("isLoaded");
		[CompilerGenerated]
		static readonly IntPtr selSetLoaded_ = Selector.GetHandle ("setLoaded:");
		[CompilerGenerated]
		static readonly IntPtr selCanoinicalName = Selector.GetHandle ("canoinicalName");
		[CompilerGenerated]
		static readonly IntPtr selDisplayName = Selector.GetHandle ("displayName");
		[CompilerGenerated]
		static readonly IntPtr selSpotifyURL = Selector.GetHandle ("spotifyURL");
		[CompilerGenerated]
		static readonly IntPtr selUserWithURLInSessionCallback_ = Selector.GetHandle ("userWithURL:inSession:callback:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("SPUser");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  SPUser () : base (NSObjectFlag.Empty)
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
		public SPUser (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public SPUser (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public SPUser (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}
		[Export ("userWithURL:inSession:callback:")]
		[CompilerGenerated]
		public unsafe virtual void UserWithURL (NSUrl userURL, SPSession inSession, CreateUserCallback callback)
		{
			if (userURL == null)
				throw new ArgumentNullException ("userURL");
			if (inSession == null)
				throw new ArgumentNullException ("inSession");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (static_InnerCreateUserCallback, callback);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, selUserWithURLInSessionCallback_, userURL.Handle, inSession.Handle, (IntPtr) block_ptr_callback);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, selUserWithURLInSessionCallback_, userURL.Handle, inSession.Handle, (IntPtr) block_ptr_callback);
			}
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		public virtual bool Loaded {
			[Export ("isLoaded")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsLoaded);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsLoaded);
				}
			}
			
			[Export ("setLoaded:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetLoaded_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetLoaded_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string CanonicalName {
			[Export ("canoinicalName")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCanoinicalName));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCanoinicalName));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string DisplayName {
			[Export ("displayName")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDisplayName));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDisplayName));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_SpotifyURL_var;
		[CompilerGenerated]
		public virtual NSUrl SpotifyURL {
			[Export ("spotifyURL")]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret = (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSpotifyURL));
				} else {
					ret = (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSpotifyURL));
				}
				MarkDirty ();
				__mt_SpotifyURL_var = ret;
				return ret;
			}
			
		}
		
		internal delegate void InnerCreateUserCallback (IntPtr block, IntPtr user);
		[CompilerGenerated]
		static readonly InnerCreateUserCallback static_InnerCreateUserCallback = TrampolineCreateUserCallback;
		[MonoPInvokeCallback (typeof (InnerCreateUserCallback))]
		static unsafe void TrampolineCreateUserCallback (IntPtr block, IntPtr user) {
			var descriptor = (BlockLiteral *) block;
			var del = (global::MonoSpotify.CreateUserCallback) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ((MonoSpotify.SPUser) Runtime.GetNSObject (user));
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_SpotifyURL_var = null;
			}
		}
	} /* class SPUser */
	public delegate void CreateUserCallback (SPUser user);
}
