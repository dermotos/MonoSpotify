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
	[Register("SPPlaylist", true)]
	public unsafe partial class SPPlaylist : NSObject {
		[CompilerGenerated]
		const string selName = "name";
		static readonly IntPtr selNameHandle = Selector.GetHandle ("name");
		[CompilerGenerated]
		const string selSpotifyURL = "spotifyURL";
		static readonly IntPtr selSpotifyURLHandle = Selector.GetHandle ("spotifyURL");
		[CompilerGenerated]
		const string selIsLoaded = "isLoaded";
		static readonly IntPtr selIsLoadedHandle = Selector.GetHandle ("isLoaded");
		[CompilerGenerated]
		const string selSetLoaded_ = "setLoaded:";
		static readonly IntPtr selSetLoaded_Handle = Selector.GetHandle ("setLoaded:");
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selHasPendingChanges = "hasPendingChanges";
		static readonly IntPtr selHasPendingChangesHandle = Selector.GetHandle ("hasPendingChanges");
		[CompilerGenerated]
		const string selSetHasPendingChanges_ = "setHasPendingChanges:";
		static readonly IntPtr selSetHasPendingChanges_Handle = Selector.GetHandle ("setHasPendingChanges:");
		[CompilerGenerated]
		const string selIsCollaborative = "isCollaborative";
		static readonly IntPtr selIsCollaborativeHandle = Selector.GetHandle ("isCollaborative");
		[CompilerGenerated]
		const string selSetCollaborative_ = "setCollaborative:";
		static readonly IntPtr selSetCollaborative_Handle = Selector.GetHandle ("setCollaborative:");
		[CompilerGenerated]
		const string selIsMarkedForOfflinePlayback = "isMarkedForOfflinePlayback";
		static readonly IntPtr selIsMarkedForOfflinePlaybackHandle = Selector.GetHandle ("isMarkedForOfflinePlayback");
		[CompilerGenerated]
		const string selSetMarkedForOfflinePlayback_ = "setMarkedForOfflinePlayback:";
		static readonly IntPtr selSetMarkedForOfflinePlayback_Handle = Selector.GetHandle ("setMarkedForOfflinePlayback:");
		[CompilerGenerated]
		const string selIsUpdating = "isUpdating";
		static readonly IntPtr selIsUpdatingHandle = Selector.GetHandle ("isUpdating");
		[CompilerGenerated]
		const string selSetUpdating_ = "setUpdating:";
		static readonly IntPtr selSetUpdating_Handle = Selector.GetHandle ("setUpdating:");
		[CompilerGenerated]
		const string selOfflineDownloadProgress = "offlineDownloadProgress";
		static readonly IntPtr selOfflineDownloadProgressHandle = Selector.GetHandle ("offlineDownloadProgress");
		[CompilerGenerated]
		const string selOwner = "owner";
		static readonly IntPtr selOwnerHandle = Selector.GetHandle ("owner");
		[CompilerGenerated]
		const string selSession = "session";
		static readonly IntPtr selSessionHandle = Selector.GetHandle ("session");
		[CompilerGenerated]
		const string selSubscribers = "subscribers";
		static readonly IntPtr selSubscribersHandle = Selector.GetHandle ("subscribers");
		[CompilerGenerated]
		const string selImage = "Image";
		static readonly IntPtr selImageHandle = Selector.GetHandle ("Image");
		[CompilerGenerated]
		const string selPlaylistDescription = "playlistDescription";
		static readonly IntPtr selPlaylistDescriptionHandle = Selector.GetHandle ("playlistDescription");
		[CompilerGenerated]
		const string selItems = "items";
		static readonly IntPtr selItemsHandle = Selector.GetHandle ("items");
		[CompilerGenerated]
		const string selStartLoading = "startLoading";
		static readonly IntPtr selStartLoadingHandle = Selector.GetHandle ("startLoading");
		[CompilerGenerated]
		const string selPlaylistWithPlaylistURLInSessionCallback_ = "playlistWithPlaylistURL:inSession:callback:";
		static readonly IntPtr selPlaylistWithPlaylistURLInSessionCallback_Handle = Selector.GetHandle ("playlistWithPlaylistURL:inSession:callback:");
		[CompilerGenerated]
		const string selAddItemAtIndexCallback_ = "addItem:atIndex:callback:";
		static readonly IntPtr selAddItemAtIndexCallback_Handle = Selector.GetHandle ("addItem:atIndex:callback:");
		[CompilerGenerated]
		const string selAddItemsAtIndexCallback_ = "addItems:atIndex:callback:";
		static readonly IntPtr selAddItemsAtIndexCallback_Handle = Selector.GetHandle ("addItems:atIndex:callback:");
		[CompilerGenerated]
		const string selRemoveItemAtIndexCallback_ = "removeItemAtIndex:callback:";
		static readonly IntPtr selRemoveItemAtIndexCallback_Handle = Selector.GetHandle ("removeItemAtIndex:callback:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("SPPlaylist");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SPPlaylist () : base (NSObjectFlag.Empty)
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

		[Export ("startLoading")]
		[CompilerGenerated]
		public virtual void StartLoading ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStartLoadingHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selStartLoadingHandle);
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
			block_callback.SetupBlock (Trampolines.SDSPCreatePlaylistCallback.Handler, callback);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selPlaylistWithPlaylistURLInSessionCallback_Handle, playlistURL.Handle, aSession.Handle, (IntPtr) block_ptr_callback);
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("addItem:atIndex:callback:")]
		[CompilerGenerated]
		public unsafe virtual void Add (SPTrack item, int index, SPErrorableOperationCallback callback)
		{
			if (item == null)
				throw new ArgumentNullException ("item");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDSPErrorableOperationCallback.Handler, callback);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_int_IntPtr (this.Handle, selAddItemAtIndexCallback_Handle, item.Handle, index, (IntPtr) block_ptr_callback);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_int_IntPtr (this.SuperHandle, selAddItemAtIndexCallback_Handle, item.Handle, index, (IntPtr) block_ptr_callback);
			}
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("addItems:atIndex:callback:")]
		[CompilerGenerated]
		public unsafe virtual void Add (SPTrack[] items, int index, SPErrorableOperationCallback callback)
		{
			if (items == null)
				throw new ArgumentNullException ("items");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			var nsa_items = NSArray.FromNSObjects (items);
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDSPErrorableOperationCallback.Handler, callback);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_int_IntPtr (this.Handle, selAddItemsAtIndexCallback_Handle, nsa_items.Handle, index, (IntPtr) block_ptr_callback);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_int_IntPtr (this.SuperHandle, selAddItemsAtIndexCallback_Handle, nsa_items.Handle, index, (IntPtr) block_ptr_callback);
			}
			nsa_items.Dispose ();
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("removeItemAtIndex:callback:")]
		[CompilerGenerated]
		public unsafe virtual void Remove (int itemIndex, SPErrorableOperationCallback callback)
		{
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDSPErrorableOperationCallback.Handler, callback);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int_IntPtr (this.Handle, selRemoveItemAtIndexCallback_Handle, itemIndex, (IntPtr) block_ptr_callback);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int_IntPtr (this.SuperHandle, selRemoveItemAtIndexCallback_Handle, itemIndex, (IntPtr) block_ptr_callback);
			}
			block_ptr_callback->CleanupBlock ();
			
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
		object __mt_SpotifyURL_var;
		[CompilerGenerated]
		public virtual NSUrl SpotifyURL {
			[Export ("spotifyURL")]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret = (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSpotifyURLHandle));
				} else {
					ret = (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSpotifyURLHandle));
				}
				MarkDirty ();
				__mt_SpotifyURL_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool Loaded {
			[Export ("isLoaded")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsLoadedHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsLoadedHandle);
				}
			}
			
			[Export ("setLoaded:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetLoaded_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetLoaded_Handle, value);
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
					ret = (SPPlaylistDelegate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegateHandle));
				} else {
					ret = (SPPlaylistDelegate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegateHandle));
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
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDelegate_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDelegate_Handle, value.Handle);
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
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasPendingChangesHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selHasPendingChangesHandle);
				}
			}
			
			[Export ("setHasPendingChanges:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetHasPendingChanges_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetHasPendingChanges_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool Collaborative {
			[Export ("isCollaborative")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsCollaborativeHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsCollaborativeHandle);
				}
			}
			
			[Export ("setCollaborative:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetCollaborative_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetCollaborative_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool MarkedForOfflinePlayback {
			[Export ("isMarkedForOfflinePlayback")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsMarkedForOfflinePlaybackHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsMarkedForOfflinePlaybackHandle);
				}
			}
			
			[Export ("setMarkedForOfflinePlayback:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetMarkedForOfflinePlayback_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetMarkedForOfflinePlayback_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool Updating {
			[Export ("isUpdating")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsUpdatingHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsUpdatingHandle);
				}
			}
			
			[Export ("setUpdating:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUpdating_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetUpdating_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool OfflineDownloadProgress {
			[Export ("offlineDownloadProgress")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selOfflineDownloadProgressHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selOfflineDownloadProgressHandle);
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
					ret = (SPUser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selOwnerHandle));
				} else {
					ret = (SPUser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selOwnerHandle));
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
		object __mt_Subscribers_var;
		[CompilerGenerated]
		public virtual NSArray Subscribers {
			[Export ("subscribers")]
			get {
				NSArray ret;
				if (IsDirectBinding) {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSubscribersHandle));
				} else {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSubscribersHandle));
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
					ret = (SPImage) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selImageHandle));
				} else {
					ret = (SPImage) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selImageHandle));
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
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPlaylistDescriptionHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPlaylistDescriptionHandle));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Items_var;
		[CompilerGenerated]
		public virtual SPPlaylistItem[] Items {
			[Export ("items")]
			get {
				SPPlaylistItem[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoSpotify.SPPlaylistItem>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selItemsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoSpotify.SPPlaylistItem>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selItemsHandle));
				}
				MarkDirty ();
				__mt_Items_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_SpotifyURL_var = null;
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
