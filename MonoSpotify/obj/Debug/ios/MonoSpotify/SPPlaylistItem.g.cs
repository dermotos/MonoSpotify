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
	[Register("SPPlaylistItem", true)]
	public unsafe partial class SPPlaylistItem : NSObject {
		[CompilerGenerated]
		static readonly IntPtr selItemClass = Selector.GetHandle ("itemClass");
		[CompilerGenerated]
		static readonly IntPtr selItemURL = Selector.GetHandle ("itemURL");
		[CompilerGenerated]
		static readonly IntPtr selItem = Selector.GetHandle ("item");
		[CompilerGenerated]
		static readonly IntPtr selCreator = Selector.GetHandle ("creator");
		[CompilerGenerated]
		static readonly IntPtr selDateAdded = Selector.GetHandle ("dateAdded");
		[CompilerGenerated]
		static readonly IntPtr selMessage = Selector.GetHandle ("message");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("SPPlaylistItem");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  SPPlaylistItem () : base (NSObjectFlag.Empty)
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
		public SPPlaylistItem (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public SPPlaylistItem (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public SPPlaylistItem (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}
		[CompilerGenerated]
		public virtual Class ItemClass {
			[Export ("itemClass")]
			get {
				if (IsDirectBinding) {
					return new Class (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selItemClass));
				} else {
					return new Class (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selItemClass));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_ItemURL_var;
		[CompilerGenerated]
		public virtual NSUrl ItemURL {
			[Export ("itemURL")]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret = (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selItemURL));
				} else {
					ret = (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selItemURL));
				}
				MarkDirty ();
				__mt_ItemURL_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Item_var;
		[CompilerGenerated]
		public virtual NSObject Item {
			[Export ("item")]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selItem));
				} else {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selItem));
				}
				MarkDirty ();
				__mt_Item_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Creator_var;
		[CompilerGenerated]
		public virtual SPUser Creator {
			[Export ("creator")]
			get {
				SPUser ret;
				if (IsDirectBinding) {
					ret = (SPUser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCreator));
				} else {
					ret = (SPUser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCreator));
				}
				MarkDirty ();
				__mt_Creator_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_DateAdded_var;
		[CompilerGenerated]
		public virtual NSDate DateAdded {
			[Export ("dateAdded")]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret = (NSDate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDateAdded));
				} else {
					ret = (NSDate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDateAdded));
				}
				MarkDirty ();
				__mt_DateAdded_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Message {
			[Export ("message")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMessage));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selMessage));
				}
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ItemURL_var = null;
				__mt_Item_var = null;
				__mt_Creator_var = null;
				__mt_DateAdded_var = null;
			}
		}
	} /* class SPPlaylistItem */
}
