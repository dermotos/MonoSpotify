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
	[Register("SPPlaylistFolder", true)]
	public unsafe partial class SPPlaylistFolder : NSObject {
		[CompilerGenerated]
		static readonly IntPtr selName = Selector.GetHandle ("name");
		[CompilerGenerated]
		static readonly IntPtr selParentContainer = Selector.GetHandle ("parentContainer");
		[CompilerGenerated]
		static readonly IntPtr selParentFolder = Selector.GetHandle ("parentFolder");
		[CompilerGenerated]
		static readonly IntPtr selPlaylists = Selector.GetHandle ("playlists");
		[CompilerGenerated]
		static readonly IntPtr selSession = Selector.GetHandle ("session");
		[CompilerGenerated]
		static readonly IntPtr selParentFolders = Selector.GetHandle ("parentFolders");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("SPPlaylistFolder");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  SPPlaylistFolder () : base (NSObjectFlag.Empty)
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
		public SPPlaylistFolder (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public SPPlaylistFolder (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public SPPlaylistFolder (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}
		[Export ("parentFolders")]
		[CompilerGenerated]
		public virtual SPPlaylistFolder[] ParentFolders ()
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<MonoSpotify.SPPlaylistFolder>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParentFolders));
			} else {
				return NSArray.ArrayFromHandle<MonoSpotify.SPPlaylistFolder>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParentFolders));
			}
		}
		
		[CompilerGenerated]
		public virtual string Name {
			[Export ("name")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selName));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selName));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_ParentContainer_var;
		[CompilerGenerated]
		public virtual SPPlaylistContainer ParentContainer {
			[Export ("parentContainer")]
			get {
				SPPlaylistContainer ret;
				if (IsDirectBinding) {
					ret = (SPPlaylistContainer) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParentContainer));
				} else {
					ret = (SPPlaylistContainer) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParentContainer));
				}
				MarkDirty ();
				__mt_ParentContainer_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_ParentFolder_var;
		[CompilerGenerated]
		public virtual SPPlaylistFolder ParentFolder {
			[Export ("parentFolder")]
			get {
				SPPlaylistFolder ret;
				if (IsDirectBinding) {
					ret = (SPPlaylistFolder) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParentFolder));
				} else {
					ret = (SPPlaylistFolder) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParentFolder));
				}
				MarkDirty ();
				__mt_ParentFolder_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Playlists_var;
		[CompilerGenerated]
		public virtual SPPlaylist[] Playlists {
			[Export ("playlists")]
			get {
				SPPlaylist[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoSpotify.SPPlaylist>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPlaylists));
				} else {
					ret = NSArray.ArrayFromHandle<MonoSpotify.SPPlaylist>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPlaylists));
				}
				MarkDirty ();
				__mt_Playlists_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Session_var;
		[CompilerGenerated]
		public virtual SPSession Session {
			[Export ("session")]
			get {
				SPSession ret;
				if (IsDirectBinding) {
					ret = (SPSession) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSession));
				} else {
					ret = (SPSession) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSession));
				}
				MarkDirty ();
				__mt_Session_var = ret;
				return ret;
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ParentContainer_var = null;
				__mt_ParentFolder_var = null;
				__mt_Playlists_var = null;
				__mt_Session_var = null;
			}
		}
	} /* class SPPlaylistFolder */
}
