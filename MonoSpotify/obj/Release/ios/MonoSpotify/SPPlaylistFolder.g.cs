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
	[Register("SPPlaylistFolder", true)]
	public unsafe partial class SPPlaylistFolder : NSObject {
		[CompilerGenerated]
		const string selName = "name";
		static readonly IntPtr selNameHandle = Selector.GetHandle ("name");
		[CompilerGenerated]
		const string selParentContainer = "parentContainer";
		static readonly IntPtr selParentContainerHandle = Selector.GetHandle ("parentContainer");
		[CompilerGenerated]
		const string selParentFolder = "parentFolder";
		static readonly IntPtr selParentFolderHandle = Selector.GetHandle ("parentFolder");
		[CompilerGenerated]
		const string selPlaylists = "playlists";
		static readonly IntPtr selPlaylistsHandle = Selector.GetHandle ("playlists");
		[CompilerGenerated]
		const string selSession = "session";
		static readonly IntPtr selSessionHandle = Selector.GetHandle ("session");
		[CompilerGenerated]
		const string selParentFolders = "parentFolders";
		static readonly IntPtr selParentFoldersHandle = Selector.GetHandle ("parentFolders");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("SPPlaylistFolder");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SPPlaylistFolder () : base (NSObjectFlag.Empty)
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
				return NSArray.ArrayFromHandle<MonoSpotify.SPPlaylistFolder>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParentFoldersHandle));
			} else {
				return NSArray.ArrayFromHandle<MonoSpotify.SPPlaylistFolder>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParentFoldersHandle));
			}
		}
		
		[CompilerGenerated]
		public virtual string Name {
			[Export ("name")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNameHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selNameHandle));
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
					ret = (SPPlaylistContainer) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParentContainerHandle));
				} else {
					ret = (SPPlaylistContainer) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParentContainerHandle));
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
					ret = (SPPlaylistFolder) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParentFolderHandle));
				} else {
					ret = (SPPlaylistFolder) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParentFolderHandle));
				}
				MarkDirty ();
				__mt_ParentFolder_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Playlists_var;
		[CompilerGenerated]
		public virtual NSObject[] Playlists {
			[Export ("playlists")]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPlaylistsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPlaylistsHandle));
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
					ret = (SPSession) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSessionHandle));
				} else {
					ret = (SPSession) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSessionHandle));
				}
				MarkDirty ();
				__mt_Session_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
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
