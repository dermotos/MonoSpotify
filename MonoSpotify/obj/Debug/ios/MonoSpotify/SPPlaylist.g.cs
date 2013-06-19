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
	[Register("SPPlaylist", true)]
	public unsafe partial class SPPlaylist : NSObject {
		[CompilerGenerated]
		static readonly IntPtr selIsLoaded = Selector.GetHandle ("isLoaded");
		[CompilerGenerated]
		static readonly IntPtr selSetLoaded_ = Selector.GetHandle ("setLoaded:");
		[CompilerGenerated]
		static readonly IntPtr selDelegate = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		static readonly IntPtr selSetDelegate_ = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		static readonly IntPtr selHasPendingChanges = Selector.GetHandle ("hasPendingChanges");
		[CompilerGenerated]
		static readonly IntPtr selSetHasPendingChanges_ = Selector.GetHandle ("setHasPendingChanges:");
		[CompilerGenerated]
		static readonly IntPtr selIsCollaborative = Selector.GetHandle ("isCollaborative");
		[CompilerGenerated]
		static readonly IntPtr selSetCollaborative_ = Selector.GetHandle ("setCollaborative:");
		[CompilerGenerated]
		static readonly IntPtr selIsMarkedForOfflinePlayback = Selector.GetHandle ("isMarkedForOfflinePlayback");
		[CompilerGenerated]
		static readonly IntPtr selSetMarkedForOfflinePlayback_ = Selector.GetHandle ("setMarkedForOfflinePlayback:");
		[CompilerGenerated]
		static readonly IntPtr selIsUpdating = Selector.GetHandle ("isUpdating");
		[CompilerGenerated]
		static readonly IntPtr selSetUpdating_ = Selector.GetHandle ("setUpdating:");
		[CompilerGenerated]
		static readonly IntPtr selOfflineDownloadProgress = Selector.GetHandle ("offlineDownloadProgress");
		[CompilerGenerated]
		static readonly IntPtr selOwner = Selector.GetHandle ("owner");
		[CompilerGenerated]
		static readonly IntPtr selSession = Selector.GetHandle ("session");
		[CompilerGenerated]
		static readonly IntPtr selSubscribers = Selector.GetHandle ("subscribers");
		[CompilerGenerated]
		static readonly IntPtr selImage = Selector.GetHandle ("Image");
		[CompilerGenerated]
		static readonly IntPtr selPlaylistDescription = Selector.GetHandle ("playlistDescription");
		[CompilerGenerated]
		static readonly IntPtr selItems = Selector.GetHandle ("items");
		[CompilerGenerated]
		static readonly IntPtr selName = Selector.GetHandle ("name");
		[CompilerGenerated]
		static readonly IntPtr selSpotifyURL = Selector.GetHandle ("spotifyURL");
		[CompilerGenerated]
		static readonly IntPtr selStartLoading = Selector.GetHandle ("startLoading");
		[CompilerGenerated]
		static readonly IntPtr selPlaylistWithPlaylistURLInSessionCallback_ = Selector.GetHandle ("playlistWithPlaylistURL:inSession:callback:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("SPPlaylist");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  SPPlaylist () : base (NSObjectFlag.Empty)
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
		public SPPlaylist (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public SPPlaylist (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public SPPlaylist (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}
		[Export ("name")]
		[CompilerGenerated]
		public virtual string Name ()
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selName));
			} else {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selName));
			}
		}
		
		[Export ("spotifyURL")]
		[CompilerGenerated]
		public virtual NSUrl SpotifyURL ()
		{
			if (IsDirectBinding) {
				return (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSpotifyURL));
			} else {
				return (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSpotifyURL));
			}
		}
		
		[Export ("startLoading")]
		[CompilerGenerated]
		public virtual void StartLoading ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStartLoading);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selStartLoading);
			}
		}
		
		[Export ("playlistWithPlaylistURL:inSession:callback:")]
		[CompilerGenerated]
		public unsafe static void PlaylistWithPlaylistURL (NSUrl playlistURL, SPSession aSession, SPCreatePlaylistCallback callback)
		{
			if (playlistURL == null)
				throw new ArgumentNullException ("playlistURL");
			if (aSession == null)
				throw new ArgumentNullException ("aSession");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (static_InnerSPCreatePlaylistCallback, callback);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selPlaylistWithPlaylistURLInSessionCallback_, playlistURL.Handle, aSession.Handle, (IntPtr) block_ptr_callback);
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
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual SPPlaylistDelegate Delegate {
			[Export ("delegate")]
			get {
				SPPlaylistDelegate ret;
				if (IsDirectBinding) {
					ret = (SPPlaylistDelegate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegate));
				} else {
					ret = (SPPlaylistDelegate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegate));
				}
				MarkDirty ();
				__mt_Delegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDelegate_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDelegate_, value.Handle);
				}
				MarkDirty ();
				__mt_Delegate_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool HasPendingChanges {
			[Export ("hasPendingChanges")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasPendingChanges);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selHasPendingChanges);
				}
			}
			
			[Export ("setHasPendingChanges:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetHasPendingChanges_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetHasPendingChanges_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool Collaborative {
			[Export ("isCollaborative")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsCollaborative);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsCollaborative);
				}
			}
			
			[Export ("setCollaborative:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetCollaborative_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetCollaborative_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool MarkedForOfflinePlayback {
			[Export ("isMarkedForOfflinePlayback")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsMarkedForOfflinePlayback);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsMarkedForOfflinePlayback);
				}
			}
			
			[Export ("setMarkedForOfflinePlayback:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetMarkedForOfflinePlayback_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetMarkedForOfflinePlayback_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool Updating {
			[Export ("isUpdating")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsUpdating);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsUpdating);
				}
			}
			
			[Export ("setUpdating:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUpdating_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetUpdating_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool OfflineDownloadProgress {
			[Export ("offlineDownloadProgress")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selOfflineDownloadProgress);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selOfflineDownloadProgress);
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Owner_var;
		[CompilerGenerated]
		public virtual SPUser Owner {
			[Export ("owner")]
			get {
				SPUser ret;
				if (IsDirectBinding) {
					ret = (SPUser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selOwner));
				} else {
					ret = (SPUser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selOwner));
				}
				MarkDirty ();
				__mt_Owner_var = ret;
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
		
		[CompilerGenerated]
		object __mt_Subscribers_var;
		[CompilerGenerated]
		public virtual NSArray Subscribers {
			[Export ("subscribers")]
			get {
				NSArray ret;
				if (IsDirectBinding) {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSubscribers));
				} else {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSubscribers));
				}
				MarkDirty ();
				__mt_Subscribers_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Image_var;
		[CompilerGenerated]
		public virtual SPImage Image {
			[Export ("Image")]
			get {
				SPImage ret;
				if (IsDirectBinding) {
					ret = (SPImage) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selImage));
				} else {
					ret = (SPImage) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selImage));
				}
				MarkDirty ();
				__mt_Image_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string PlaylistDescription {
			[Export ("playlistDescription")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPlaylistDescription));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPlaylistDescription));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Items_var;
		[CompilerGenerated]
		public virtual NSArray Items {
			[Export ("items")]
			get {
				NSArray ret;
				if (IsDirectBinding) {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selItems));
				} else {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selItems));
				}
				MarkDirty ();
				__mt_Items_var = ret;
				return ret;
			}
			
		}
		
		internal delegate void InnerSPCreatePlaylistCallback (IntPtr block, IntPtr playlist);
		[CompilerGenerated]
		static readonly InnerSPCreatePlaylistCallback static_InnerSPCreatePlaylistCallback = TrampolineSPCreatePlaylistCallback;
		[MonoPInvokeCallback (typeof (InnerSPCreatePlaylistCallback))]
		static unsafe void TrampolineSPCreatePlaylistCallback (IntPtr block, IntPtr playlist) {
			var descriptor = (BlockLiteral *) block;
			var del = (global::MonoSpotify.SPCreatePlaylistCallback) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ((MonoSpotify.SPPlaylist) Runtime.GetNSObject (playlist));
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Delegate_var = null;
				__mt_Owner_var = null;
				__mt_Session_var = null;
				__mt_Subscribers_var = null;
				__mt_Image_var = null;
				__mt_Items_var = null;
			}
		}
	} /* class SPPlaylist */
	public delegate void SPCreatePlaylistCallback (SPPlaylist playlist);
}
