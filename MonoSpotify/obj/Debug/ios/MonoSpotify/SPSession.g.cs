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
	[Register("SPSession", true)]
	public unsafe partial class SPSession : NSObject {
		[CompilerGenerated]
		static readonly IntPtr selPlaybackDelegate = Selector.GetHandle ("playbackDelegate");
		[CompilerGenerated]
		static readonly IntPtr selSetPlaybackDelegate_ = Selector.GetHandle ("setPlaybackDelegate:");
		[CompilerGenerated]
		static readonly IntPtr selAudioDeliveryDelegate = Selector.GetHandle ("audioDeliveryDelegate");
		[CompilerGenerated]
		static readonly IntPtr selSetAudioDeliveryDelegate_ = Selector.GetHandle ("setAudioDeliveryDelegate:");
		[CompilerGenerated]
		static readonly IntPtr selSharedSession = Selector.GetHandle ("sharedSession");
		[CompilerGenerated]
		static readonly IntPtr selSetSharedSession_ = Selector.GetHandle ("setSharedSession:");
		[CompilerGenerated]
		static readonly IntPtr selConnectionState = Selector.GetHandle ("connectionState");
		[CompilerGenerated]
		static readonly IntPtr selSetConnectionState_ = Selector.GetHandle ("setConnectionState:");
		[CompilerGenerated]
		static readonly IntPtr selDelegate = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		static readonly IntPtr selSetDelegate_ = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		static readonly IntPtr selIsLoaded = Selector.GetHandle ("isLoaded");
		[CompilerGenerated]
		static readonly IntPtr selSetLoaded_ = Selector.GetHandle ("setLoaded:");
		[CompilerGenerated]
		static readonly IntPtr selLocale = Selector.GetHandle ("locale");
		[CompilerGenerated]
		static readonly IntPtr selSetLocale_ = Selector.GetHandle ("setLocale:");
		[CompilerGenerated]
		static readonly IntPtr selInboxPlaylist = Selector.GetHandle ("inboxPlaylist");
		[CompilerGenerated]
		static readonly IntPtr selSetInboxPlaylist_ = Selector.GetHandle ("setInboxPlaylist:");
		[CompilerGenerated]
		static readonly IntPtr selStarredPlaylist = Selector.GetHandle ("starredPlaylist");
		[CompilerGenerated]
		static readonly IntPtr selSetStarredPlaylist_ = Selector.GetHandle ("setStarredPlaylist:");
		[CompilerGenerated]
		static readonly IntPtr selUser = Selector.GetHandle ("user");
		[CompilerGenerated]
		static readonly IntPtr selSetUser_ = Selector.GetHandle ("setUser:");
		[CompilerGenerated]
		static readonly IntPtr selUserPlaylists = Selector.GetHandle ("userPlaylists");
		[CompilerGenerated]
		static readonly IntPtr selSetUserPlaylists_ = Selector.GetHandle ("setUserPlaylists:");
		[CompilerGenerated]
		static readonly IntPtr selIsUsingVolumeNormalization = Selector.GetHandle ("isUsingVolumeNormalization");
		[CompilerGenerated]
		static readonly IntPtr selSetUsingVolumeNormalization_ = Selector.GetHandle ("setUsingVolumeNormalization:");
		[CompilerGenerated]
		static readonly IntPtr selSetPlaying_ = Selector.GetHandle ("setPlaying:");
		[CompilerGenerated]
		static readonly IntPtr selPreloadTrackForPlaybackCallback_ = Selector.GetHandle ("preloadTrackForPlayback:callback:");
		[CompilerGenerated]
		static readonly IntPtr selPlayTrackCallback_ = Selector.GetHandle ("playTrack:callback:");
		[CompilerGenerated]
		static readonly IntPtr selSeekPlaybackToOffset_ = Selector.GetHandle ("seekPlaybackToOffset:");
		[CompilerGenerated]
		static readonly IntPtr selUnloadPlayback = Selector.GetHandle ("unloadPlayback");
		[CompilerGenerated]
		static readonly IntPtr selDispatchToLibSpotifyThread_ = Selector.GetHandle ("dispatchToLibSpotifyThread:");
		[CompilerGenerated]
		static readonly IntPtr selDispatchToLibSpotifyThreadWaitUntilDone_ = Selector.GetHandle ("dispatchToLibSpotifyThread:waitUntilDone:");
		[CompilerGenerated]
		static readonly IntPtr selSpotifyClientInstalled = Selector.GetHandle ("spotifyClientInstalled");
		[CompilerGenerated]
		static readonly IntPtr selLaunchSpotifyClientIfInstalled = Selector.GetHandle ("launchSpotifyClientIfInstalled");
		[CompilerGenerated]
		static readonly IntPtr selInitializeSharedSessionWithApplicationKeyUserAgentLoadingPolicyError_ = Selector.GetHandle ("initializeSharedSessionWithApplicationKey:userAgent:loadingPolicy:error:");
		[CompilerGenerated]
		static readonly IntPtr selLibSpotifyBuildId = Selector.GetHandle ("libSpotifyBuildId");
		[CompilerGenerated]
		static readonly IntPtr selInitWithApplicationKeyUserAgentLoadingPolicyError_ = Selector.GetHandle ("initWithApplicationKey:userAgent:loadingPolicy:error:");
		[CompilerGenerated]
		static readonly IntPtr selAttemptLoginWithUserNamePassword_ = Selector.GetHandle ("attemptLoginWithUserName:password:");
		[CompilerGenerated]
		static readonly IntPtr selAttemptLoginWithUserNameExistingCredential_ = Selector.GetHandle ("attemptLoginWithUserName:existingCredential:");
		[CompilerGenerated]
		static readonly IntPtr selFetchLoginUserName_ = Selector.GetHandle ("fetchLoginUserName:");
		[CompilerGenerated]
		static readonly IntPtr selFlushCaches_ = Selector.GetHandle ("flushCaches:");
		[CompilerGenerated]
		static readonly IntPtr selLogout_ = Selector.GetHandle ("logout:");
		[CompilerGenerated]
		static readonly IntPtr selSetMaximumCacheSizeMB_ = Selector.GetHandle ("setMaximumCacheSizeMB:");
		[CompilerGenerated]
		static readonly IntPtr selSetPreferredBitrate_ = Selector.GetHandle ("setPreferredBitrate:");
		[CompilerGenerated]
		static readonly IntPtr selPostTracksToInboxOfUserWithMessageCallback_ = Selector.GetHandle ("postTracks:toInboxOfUser:withMessage:callback:");
		[CompilerGenerated]
		static readonly IntPtr selAlbumForURLCallback_ = Selector.GetHandle ("albumForURL:callback:");
		[CompilerGenerated]
		static readonly IntPtr selArtistForURLCallback_ = Selector.GetHandle ("artistForURL:callback:");
		[CompilerGenerated]
		static readonly IntPtr selImageForURLCallback_ = Selector.GetHandle ("imageForURL:callback:");
		[CompilerGenerated]
		static readonly IntPtr selPlaylistForURLCallback_ = Selector.GetHandle ("playlistForURL:callback:");
		[CompilerGenerated]
		static readonly IntPtr selSearchForURLCallback_ = Selector.GetHandle ("searchForURL:callback:");
		[CompilerGenerated]
		static readonly IntPtr selTrackForURLCallback_ = Selector.GetHandle ("trackForURL:callback:");
		[CompilerGenerated]
		static readonly IntPtr selUserForURLCallback_ = Selector.GetHandle ("userForURL:callback:");
		[CompilerGenerated]
		static readonly IntPtr selObjectRepresentationForSpotifyURLLinkType_ = Selector.GetHandle ("objectRepresentationForSpotifyURL:linkType:");
		[CompilerGenerated]
		static readonly IntPtr selObjectRepresentationForSpotifyURLCallback_ = Selector.GetHandle ("objectRepresentationForSpotifyURL:callback:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("SPSession");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  SPSession () : base (NSObjectFlag.Empty)
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
		public SPSession (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public SPSession (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public SPSession (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}
		[Export ("preloadTrackForPlayback:callback:")]
		[CompilerGenerated]
		public unsafe virtual void PreloadtrackForPlayback (SPTrack aTrack, SPErrorableOperationCallback callback)
		{
			if (aTrack == null)
				throw new ArgumentNullException ("aTrack");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (static_InnerSPErrorableOperationCallback, callback);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selPreloadTrackForPlaybackCallback_, aTrack.Handle, (IntPtr) block_ptr_callback);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selPreloadTrackForPlaybackCallback_, aTrack.Handle, (IntPtr) block_ptr_callback);
			}
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("playTrack:callback:")]
		[CompilerGenerated]
		public unsafe virtual void PlayTrack (SPTrack aTrack, SPErrorableOperationCallback callback)
		{
			if (aTrack == null)
				throw new ArgumentNullException ("aTrack");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (static_InnerSPErrorableOperationCallback, callback);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selPlayTrackCallback_, aTrack.Handle, (IntPtr) block_ptr_callback);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selPlayTrackCallback_, aTrack.Handle, (IntPtr) block_ptr_callback);
			}
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("seekPlaybackToOffset:")]
		[CompilerGenerated]
		public virtual void SeekPlaybackToOffset (global::System.Double offset)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSeekPlaybackToOffset_, offset);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, selSeekPlaybackToOffset_, offset);
			}
		}
		
		[Export ("unloadPlayback")]
		[CompilerGenerated]
		public virtual void UnloadPlayback ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUnloadPlayback);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selUnloadPlayback);
			}
		}
		
		[Export ("dispatchToLibSpotifyThread:")]
		[CompilerGenerated]
		public unsafe static void DispatchToLibSpotifyThread (DispatchBlockT block)
		{
			if (block == null)
				throw new ArgumentNullException ("block");
			BlockLiteral *block_ptr_block;
			BlockLiteral block_block;
			block_block = new BlockLiteral ();
			block_ptr_block = &block_block;
			block_block.SetupBlock (static_InnerDispatchBlockT, block);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selDispatchToLibSpotifyThread_, (IntPtr) block_ptr_block);
			block_ptr_block->CleanupBlock ();
			
		}
		
		[Export ("dispatchToLibSpotifyThread:waitUntilDone:")]
		[CompilerGenerated]
		public unsafe static void DispatchToLibSpotifyThread (DispatchBlockT block, bool wait)
		{
			if (block == null)
				throw new ArgumentNullException ("block");
			BlockLiteral *block_ptr_block;
			BlockLiteral block_block;
			block_block = new BlockLiteral ();
			block_ptr_block = &block_block;
			block_block.SetupBlock (static_InnerDispatchBlockT, block);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_bool (class_ptr, selDispatchToLibSpotifyThreadWaitUntilDone_, (IntPtr) block_ptr_block, wait);
			block_ptr_block->CleanupBlock ();
			
		}
		
		[Export ("spotifyClientInstalled")]
		[CompilerGenerated]
		public static bool SpotifyClientInstalled ()
		{
			return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selSpotifyClientInstalled);
		}
		
		[Export ("launchSpotifyClientIfInstalled")]
		[CompilerGenerated]
		public static bool LaunchSpotifyClientIfInstalled ()
		{
			return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selLaunchSpotifyClientIfInstalled);
		}
		
		[Export ("initializeSharedSessionWithApplicationKey:userAgent:loadingPolicy:error:")]
		[CompilerGenerated]
		public static bool InitializeSharedSession (NSData applicationKey, string userAgent, SPAsyncLoadingPolicy loadingPolicy, NSError error)
		{
			if (applicationKey == null)
				throw new ArgumentNullException ("applicationKey");
			if (userAgent == null)
				throw new ArgumentNullException ("userAgent");
			if (error == null)
				throw new ArgumentNullException ("error");
			var nsuserAgent = NSString.CreateNative (userAgent);
			
			bool ret;
			ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_IntPtr_int_IntPtr (class_ptr, selInitializeSharedSessionWithApplicationKeyUserAgentLoadingPolicyError_, applicationKey.Handle, nsuserAgent, (int)loadingPolicy, error.Handle);
			NSString.ReleaseNative (nsuserAgent);
			
			return ret;
		}
		
		[Export ("libSpotifyBuildId")]
		[CompilerGenerated]
		public static string SpotifyBuildID ()
		{
			return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selLibSpotifyBuildId));
		}
		
		[Export ("initWithApplicationKey:userAgent:loadingPolicy:error:")]
		[CompilerGenerated]
		public virtual NSObject Init (NSData applicationKey, string userAgent, SPAsyncLoadingPolicy loadingPolicy, NSError error)
		{
			if (applicationKey == null)
				throw new ArgumentNullException ("applicationKey");
			if (userAgent == null)
				throw new ArgumentNullException ("userAgent");
			if (error == null)
				throw new ArgumentNullException ("error");
			var nsuserAgent = NSString.CreateNative (userAgent);
			
			NSObject ret;
			if (IsDirectBinding) {
				ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_int_IntPtr (this.Handle, selInitWithApplicationKeyUserAgentLoadingPolicyError_, applicationKey.Handle, nsuserAgent, (int)loadingPolicy, error.Handle));
			} else {
				ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_int_IntPtr (this.SuperHandle, selInitWithApplicationKeyUserAgentLoadingPolicyError_, applicationKey.Handle, nsuserAgent, (int)loadingPolicy, error.Handle));
			}
			NSString.ReleaseNative (nsuserAgent);
			
			return ret;
		}
		
		[Export ("attemptLoginWithUserName:password:")]
		[CompilerGenerated]
		public virtual void AttemptLogin (string userName, string password)
		{
			if (userName == null)
				throw new ArgumentNullException ("userName");
			if (password == null)
				throw new ArgumentNullException ("password");
			var nsuserName = NSString.CreateNative (userName);
			var nspassword = NSString.CreateNative (password);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selAttemptLoginWithUserNamePassword_, nsuserName, nspassword);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selAttemptLoginWithUserNamePassword_, nsuserName, nspassword);
			}
			NSString.ReleaseNative (nsuserName);
			NSString.ReleaseNative (nspassword);
			
		}
		
		[Export ("attemptLoginWithUserName:existingCredential:")]
		[CompilerGenerated]
		public virtual void AttemptLoginWithCredentials (string userName, string existingCredential)
		{
			if (userName == null)
				throw new ArgumentNullException ("userName");
			if (existingCredential == null)
				throw new ArgumentNullException ("existingCredential");
			var nsuserName = NSString.CreateNative (userName);
			var nsexistingCredential = NSString.CreateNative (existingCredential);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selAttemptLoginWithUserNameExistingCredential_, nsuserName, nsexistingCredential);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selAttemptLoginWithUserNameExistingCredential_, nsuserName, nsexistingCredential);
			}
			NSString.ReleaseNative (nsuserName);
			NSString.ReleaseNative (nsexistingCredential);
			
		}
		
		[Export ("fetchLoginUserName:")]
		[CompilerGenerated]
		public unsafe virtual void FetchLoginUserName (LoginFetcher block)
		{
			if (block == null)
				throw new ArgumentNullException ("block");
			BlockLiteral *block_ptr_block;
			BlockLiteral block_block;
			block_block = new BlockLiteral ();
			block_ptr_block = &block_block;
			block_block.SetupBlock (static_InnerLoginFetcher, block);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selFetchLoginUserName_, (IntPtr) block_ptr_block);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selFetchLoginUserName_, (IntPtr) block_ptr_block);
			}
			block_ptr_block->CleanupBlock ();
			
		}
		
		[Export ("flushCaches:")]
		[CompilerGenerated]
		public unsafe virtual void FlushCaches (CompletionBlock block)
		{
			if (block == null)
				throw new ArgumentNullException ("block");
			BlockLiteral *block_ptr_block;
			BlockLiteral block_block;
			block_block = new BlockLiteral ();
			block_ptr_block = &block_block;
			block_block.SetupBlock (static_InnerCompletionBlock, block);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selFlushCaches_, (IntPtr) block_ptr_block);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selFlushCaches_, (IntPtr) block_ptr_block);
			}
			block_ptr_block->CleanupBlock ();
			
		}
		
		[Export ("logout:")]
		[CompilerGenerated]
		public unsafe virtual void Logout (CompletionBlock block)
		{
			if (block == null)
				throw new ArgumentNullException ("block");
			BlockLiteral *block_ptr_block;
			BlockLiteral block_block;
			block_block = new BlockLiteral ();
			block_ptr_block = &block_block;
			block_block.SetupBlock (static_InnerCompletionBlock, block);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selLogout_, (IntPtr) block_ptr_block);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selLogout_, (IntPtr) block_ptr_block);
			}
			block_ptr_block->CleanupBlock ();
			
		}
		
		[Export ("setMaximumCacheSizeMB:")]
		[CompilerGenerated]
		public virtual void SetMaximumCacheSize (int megaBytes)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetMaximumCacheSizeMB_, megaBytes);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetMaximumCacheSizeMB_, megaBytes);
			}
		}
		
		[Export ("setPreferredBitrate:")]
		[CompilerGenerated]
		public virtual void SetPreferredBitrate (Bitrates bitrate)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetPreferredBitrate_, (int)bitrate);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetPreferredBitrate_, (int)bitrate);
			}
		}
		
		[Export ("postTracks:toInboxOfUser:withMessage:callback:")]
		[CompilerGenerated]
		public unsafe virtual SPPostTracksToInboxOperation PostTracks (SPTrack[] tracks, string targetUserName, string friendlyMessage, SPErrorableOperationCallback block)
		{
			if (tracks == null)
				throw new ArgumentNullException ("tracks");
			if (targetUserName == null)
				throw new ArgumentNullException ("targetUserName");
			if (friendlyMessage == null)
				throw new ArgumentNullException ("friendlyMessage");
			if (block == null)
				throw new ArgumentNullException ("block");
			var nsa_tracks = NSArray.FromNSObjects (tracks);
			var nstargetUserName = NSString.CreateNative (targetUserName);
			var nsfriendlyMessage = NSString.CreateNative (friendlyMessage);
			BlockLiteral *block_ptr_block;
			BlockLiteral block_block;
			block_block = new BlockLiteral ();
			block_ptr_block = &block_block;
			block_block.SetupBlock (static_InnerSPErrorableOperationCallback, block);
			
			SPPostTracksToInboxOperation ret;
			if (IsDirectBinding) {
				ret = (SPPostTracksToInboxOperation) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, selPostTracksToInboxOfUserWithMessageCallback_, nsa_tracks.Handle, nstargetUserName, nsfriendlyMessage, (IntPtr) block_ptr_block));
			} else {
				ret = (SPPostTracksToInboxOperation) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, selPostTracksToInboxOfUserWithMessageCallback_, nsa_tracks.Handle, nstargetUserName, nsfriendlyMessage, (IntPtr) block_ptr_block));
			}
			nsa_tracks.Dispose ();
			NSString.ReleaseNative (nstargetUserName);
			NSString.ReleaseNative (nsfriendlyMessage);
			block_ptr_block->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("albumForURL:callback:")]
		[CompilerGenerated]
		public unsafe virtual void AlbumForUrl (NSUrl url, SPAlbumCallback callback)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (static_InnerSPAlbumCallback, callback);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selAlbumForURLCallback_, url.Handle, (IntPtr) block_ptr_callback);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selAlbumForURLCallback_, url.Handle, (IntPtr) block_ptr_callback);
			}
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("artistForURL:callback:")]
		[CompilerGenerated]
		public unsafe virtual void ArtistForUrl (NSUrl url, SPArtistCallback callback)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (static_InnerSPArtistCallback, callback);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selArtistForURLCallback_, url.Handle, (IntPtr) block_ptr_callback);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selArtistForURLCallback_, url.Handle, (IntPtr) block_ptr_callback);
			}
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("imageForURL:callback:")]
		[CompilerGenerated]
		public unsafe virtual void ImageForUrl (NSUrl url, SPImageCallback callback)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (static_InnerSPImageCallback, callback);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selImageForURLCallback_, url.Handle, (IntPtr) block_ptr_callback);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selImageForURLCallback_, url.Handle, (IntPtr) block_ptr_callback);
			}
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("playlistForURL:callback:")]
		[CompilerGenerated]
		public unsafe virtual void PlaylistForUrl (NSUrl url, SPPlaylistCallback callback)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (static_InnerSPPlaylistCallback, callback);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selPlaylistForURLCallback_, url.Handle, (IntPtr) block_ptr_callback);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selPlaylistForURLCallback_, url.Handle, (IntPtr) block_ptr_callback);
			}
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("searchForURL:callback:")]
		[CompilerGenerated]
		public unsafe virtual void SearchForUrl (NSUrl url, SPSearchCallback callback)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (static_InnerSPSearchCallback, callback);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSearchForURLCallback_, url.Handle, (IntPtr) block_ptr_callback);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSearchForURLCallback_, url.Handle, (IntPtr) block_ptr_callback);
			}
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("trackForURL:callback:")]
		[CompilerGenerated]
		public unsafe virtual void TrackForUrl (NSUrl url, SPTrackCallback callback)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (static_InnerSPTrackCallback, callback);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selTrackForURLCallback_, url.Handle, (IntPtr) block_ptr_callback);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selTrackForURLCallback_, url.Handle, (IntPtr) block_ptr_callback);
			}
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("userForURL:callback:")]
		[CompilerGenerated]
		public unsafe virtual void UserForUrl (NSUrl url, SPUserCallback callback)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (static_InnerSPUserCallback, callback);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selUserForURLCallback_, url.Handle, (IntPtr) block_ptr_callback);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selUserForURLCallback_, url.Handle, (IntPtr) block_ptr_callback);
			}
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("objectRepresentationForSpotifyURL:linkType:")]
		[CompilerGenerated]
		public virtual NSObject ObjectRepresentationForSpotifyUrl (NSUrl spotifyUrl, LinkTypes linkType)
		{
			if (spotifyUrl == null)
				throw new ArgumentNullException ("spotifyUrl");
			if (IsDirectBinding) {
				return (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_int (this.Handle, selObjectRepresentationForSpotifyURLLinkType_, spotifyUrl.Handle, (int)linkType));
			} else {
				return (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_int (this.SuperHandle, selObjectRepresentationForSpotifyURLLinkType_, spotifyUrl.Handle, (int)linkType));
			}
		}
		
		[Export ("objectRepresentationForSpotifyURL:callback:")]
		[CompilerGenerated]
		public unsafe virtual void ObjectRepresentationForSpotifyUrl (NSUrl url, SPObjectRepresentationCallback callback)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (static_InnerSPObjectRepresentationCallback, callback);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selObjectRepresentationForSpotifyURLCallback_, url.Handle, (IntPtr) block_ptr_callback);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selObjectRepresentationForSpotifyURLCallback_, url.Handle, (IntPtr) block_ptr_callback);
			}
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("preloadTrackForPlayback:callback:")]
		[CompilerGenerated]
		public unsafe virtual void PreloadTrackForPlayback (SPTrack track, SPErrorableOperationCallback callback)
		{
			if (track == null)
				throw new ArgumentNullException ("track");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (static_InnerSPErrorableOperationCallback, callback);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selPreloadTrackForPlaybackCallback_, track.Handle, (IntPtr) block_ptr_callback);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selPreloadTrackForPlaybackCallback_, track.Handle, (IntPtr) block_ptr_callback);
			}
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		object __mt_PlaybackDelegate_var;
		[CompilerGenerated]
		public virtual SPSessionPlaybackDelegate PlaybackDelegate {
			[Export ("playbackDelegate")]
			get {
				SPSessionPlaybackDelegate ret;
				if (IsDirectBinding) {
					ret = (SPSessionPlaybackDelegate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPlaybackDelegate));
				} else {
					ret = (SPSessionPlaybackDelegate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPlaybackDelegate));
				}
				MarkDirty ();
				__mt_PlaybackDelegate_var = ret;
				return ret;
			}
			
			[Export ("setPlaybackDelegate:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPlaybackDelegate_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPlaybackDelegate_, value.Handle);
				}
				MarkDirty ();
				__mt_PlaybackDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_AudioDeliveryDelegate_var;
		[CompilerGenerated]
		public virtual SPSessionAudioDeliveryDelegate AudioDeliveryDelegate {
			[Export ("audioDeliveryDelegate")]
			get {
				SPSessionAudioDeliveryDelegate ret;
				if (IsDirectBinding) {
					ret = (SPSessionAudioDeliveryDelegate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAudioDeliveryDelegate));
				} else {
					ret = (SPSessionAudioDeliveryDelegate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAudioDeliveryDelegate));
				}
				MarkDirty ();
				__mt_AudioDeliveryDelegate_var = ret;
				return ret;
			}
			
			[Export ("setAudioDeliveryDelegate:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAudioDeliveryDelegate_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetAudioDeliveryDelegate_, value.Handle);
				}
				MarkDirty ();
				__mt_AudioDeliveryDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		static object __mt_SharedSession_var_static;
		[CompilerGenerated]
		public static SPSession SharedSession {
			[Export ("sharedSession")]
			get {
				SPSession ret;
				ret = (SPSession) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selSharedSession));
				__mt_SharedSession_var_static = ret;
				return ret;
			}
			
			[Export ("setSharedSession:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selSetSharedSession_, value.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual ConnectionStates ConnectionState {
			[Export ("connectionState")]
			get {
				if (IsDirectBinding) {
					return (ConnectionStates) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selConnectionState);
				} else {
					return (ConnectionStates) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selConnectionState);
				}
			}
			
			[Export ("setConnectionState:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetConnectionState_, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetConnectionState_, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual SPSessionDelegate Delegate {
			[Export ("delegate")]
			get {
				SPSessionDelegate ret;
				if (IsDirectBinding) {
					ret = (SPSessionDelegate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegate));
				} else {
					ret = (SPSessionDelegate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegate));
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
		object __mt_Locale_var;
		[CompilerGenerated]
		public virtual NSLocale Locale {
			[Export ("locale")]
			get {
				NSLocale ret;
				if (IsDirectBinding) {
					ret = (NSLocale) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLocale));
				} else {
					ret = (NSLocale) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLocale));
				}
				MarkDirty ();
				__mt_Locale_var = ret;
				return ret;
			}
			
			[Export ("setLocale:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetLocale_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetLocale_, value.Handle);
				}
				MarkDirty ();
				__mt_Locale_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_InboxPlaylist_var;
		[CompilerGenerated]
		public virtual SPPlaylist InboxPlaylist {
			[Export ("inboxPlaylist")]
			get {
				SPPlaylist ret;
				if (IsDirectBinding) {
					ret = (SPPlaylist) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selInboxPlaylist));
				} else {
					ret = (SPPlaylist) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selInboxPlaylist));
				}
				MarkDirty ();
				__mt_InboxPlaylist_var = ret;
				return ret;
			}
			
			[Export ("setInboxPlaylist:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetInboxPlaylist_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetInboxPlaylist_, value.Handle);
				}
				MarkDirty ();
				__mt_InboxPlaylist_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_StarredPlaylist_var;
		[CompilerGenerated]
		public virtual SPPlaylist StarredPlaylist {
			[Export ("starredPlaylist")]
			get {
				SPPlaylist ret;
				if (IsDirectBinding) {
					ret = (SPPlaylist) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selStarredPlaylist));
				} else {
					ret = (SPPlaylist) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selStarredPlaylist));
				}
				MarkDirty ();
				__mt_StarredPlaylist_var = ret;
				return ret;
			}
			
			[Export ("setStarredPlaylist:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetStarredPlaylist_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetStarredPlaylist_, value.Handle);
				}
				MarkDirty ();
				__mt_StarredPlaylist_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_User_var;
		[CompilerGenerated]
		public virtual SPUser User {
			[Export ("user")]
			get {
				SPUser ret;
				if (IsDirectBinding) {
					ret = (SPUser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUser));
				} else {
					ret = (SPUser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUser));
				}
				MarkDirty ();
				__mt_User_var = ret;
				return ret;
			}
			
			[Export ("setUser:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUser_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUser_, value.Handle);
				}
				MarkDirty ();
				__mt_User_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_UserPlaylists_var;
		[CompilerGenerated]
		public virtual SPPlaylistContainer UserPlaylists {
			[Export ("userPlaylists")]
			get {
				SPPlaylistContainer ret;
				if (IsDirectBinding) {
					ret = (SPPlaylistContainer) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUserPlaylists));
				} else {
					ret = (SPPlaylistContainer) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUserPlaylists));
				}
				MarkDirty ();
				__mt_UserPlaylists_var = ret;
				return ret;
			}
			
			[Export ("setUserPlaylists:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUserPlaylists_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUserPlaylists_, value.Handle);
				}
				MarkDirty ();
				__mt_UserPlaylists_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool UsingVolumeNormalization {
			[Export ("isUsingVolumeNormalization")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsUsingVolumeNormalization);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsUsingVolumeNormalization);
				}
			}
			
			[Export ("setUsingVolumeNormalization:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUsingVolumeNormalization_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetUsingVolumeNormalization_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool Playing {
			[Export ("isUsingVolumeNormalization")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsUsingVolumeNormalization);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsUsingVolumeNormalization);
				}
			}
			
			[Export ("setPlaying:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetPlaying_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetPlaying_, value);
				}
			}
		}
		
		internal delegate void InnerSPErrorableOperationCallback (IntPtr block, IntPtr error);
		[CompilerGenerated]
		static readonly InnerSPErrorableOperationCallback static_InnerSPErrorableOperationCallback = TrampolineSPErrorableOperationCallback;
		[MonoPInvokeCallback (typeof (InnerSPErrorableOperationCallback))]
		static unsafe void TrampolineSPErrorableOperationCallback (IntPtr block, IntPtr error) {
			var descriptor = (BlockLiteral *) block;
			var del = (global::MonoSpotify.SPErrorableOperationCallback) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ((MonoTouch.Foundation.NSError) Runtime.GetNSObject (error));
		}
		
		internal delegate void InnerDispatchBlockT (IntPtr block);
		[CompilerGenerated]
		static readonly InnerDispatchBlockT static_InnerDispatchBlockT = TrampolineDispatchBlockT;
		[MonoPInvokeCallback (typeof (InnerDispatchBlockT))]
		static unsafe void TrampolineDispatchBlockT (IntPtr block) {
			var descriptor = (BlockLiteral *) block;
			var del = (global::MonoSpotify.DispatchBlockT) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ();
		}
		
		internal delegate void InnerLoginFetcher (IntPtr block, IntPtr loginUserName);
		[CompilerGenerated]
		static readonly InnerLoginFetcher static_InnerLoginFetcher = TrampolineLoginFetcher;
		[MonoPInvokeCallback (typeof (InnerLoginFetcher))]
		static unsafe void TrampolineLoginFetcher (IntPtr block, IntPtr loginUserName) {
			var descriptor = (BlockLiteral *) block;
			var del = (global::MonoSpotify.LoginFetcher) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del (NSString.FromHandle (loginUserName));
		}
		
		internal delegate void InnerCompletionBlock (IntPtr block);
		[CompilerGenerated]
		static readonly InnerCompletionBlock static_InnerCompletionBlock = TrampolineCompletionBlock;
		[MonoPInvokeCallback (typeof (InnerCompletionBlock))]
		static unsafe void TrampolineCompletionBlock (IntPtr block) {
			var descriptor = (BlockLiteral *) block;
			var del = (global::MonoSpotify.CompletionBlock) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ();
		}
		
		internal delegate void InnerSPAlbumCallback (IntPtr block, IntPtr album);
		[CompilerGenerated]
		static readonly InnerSPAlbumCallback static_InnerSPAlbumCallback = TrampolineSPAlbumCallback;
		[MonoPInvokeCallback (typeof (InnerSPAlbumCallback))]
		static unsafe void TrampolineSPAlbumCallback (IntPtr block, IntPtr album) {
			var descriptor = (BlockLiteral *) block;
			var del = (global::MonoSpotify.SPAlbumCallback) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ((MonoSpotify.SPAlbum) Runtime.GetNSObject (album));
		}
		
		internal delegate void InnerSPArtistCallback (IntPtr block, IntPtr artist);
		[CompilerGenerated]
		static readonly InnerSPArtistCallback static_InnerSPArtistCallback = TrampolineSPArtistCallback;
		[MonoPInvokeCallback (typeof (InnerSPArtistCallback))]
		static unsafe void TrampolineSPArtistCallback (IntPtr block, IntPtr artist) {
			var descriptor = (BlockLiteral *) block;
			var del = (global::MonoSpotify.SPArtistCallback) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ((MonoSpotify.SPArtist) Runtime.GetNSObject (artist));
		}
		
		internal delegate void InnerSPImageCallback (IntPtr block, IntPtr image);
		[CompilerGenerated]
		static readonly InnerSPImageCallback static_InnerSPImageCallback = TrampolineSPImageCallback;
		[MonoPInvokeCallback (typeof (InnerSPImageCallback))]
		static unsafe void TrampolineSPImageCallback (IntPtr block, IntPtr image) {
			var descriptor = (BlockLiteral *) block;
			var del = (global::MonoSpotify.SPImageCallback) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ((MonoSpotify.SPImage) Runtime.GetNSObject (image));
		}
		
		internal delegate void InnerSPPlaylistCallback (IntPtr block, IntPtr playlist);
		[CompilerGenerated]
		static readonly InnerSPPlaylistCallback static_InnerSPPlaylistCallback = TrampolineSPPlaylistCallback;
		[MonoPInvokeCallback (typeof (InnerSPPlaylistCallback))]
		static unsafe void TrampolineSPPlaylistCallback (IntPtr block, IntPtr playlist) {
			var descriptor = (BlockLiteral *) block;
			var del = (global::MonoSpotify.SPPlaylistCallback) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ((MonoSpotify.SPPlaylist) Runtime.GetNSObject (playlist));
		}
		
		internal delegate void InnerSPSearchCallback (IntPtr block, IntPtr search);
		[CompilerGenerated]
		static readonly InnerSPSearchCallback static_InnerSPSearchCallback = TrampolineSPSearchCallback;
		[MonoPInvokeCallback (typeof (InnerSPSearchCallback))]
		static unsafe void TrampolineSPSearchCallback (IntPtr block, IntPtr search) {
			var descriptor = (BlockLiteral *) block;
			var del = (global::MonoSpotify.SPSearchCallback) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ((MonoSpotify.SPSearch) Runtime.GetNSObject (search));
		}
		
		internal delegate void InnerSPTrackCallback (IntPtr block, IntPtr track);
		[CompilerGenerated]
		static readonly InnerSPTrackCallback static_InnerSPTrackCallback = TrampolineSPTrackCallback;
		[MonoPInvokeCallback (typeof (InnerSPTrackCallback))]
		static unsafe void TrampolineSPTrackCallback (IntPtr block, IntPtr track) {
			var descriptor = (BlockLiteral *) block;
			var del = (global::MonoSpotify.SPTrackCallback) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ((MonoSpotify.SPTrack) Runtime.GetNSObject (track));
		}
		
		internal delegate void InnerSPUserCallback (IntPtr block, IntPtr user);
		[CompilerGenerated]
		static readonly InnerSPUserCallback static_InnerSPUserCallback = TrampolineSPUserCallback;
		[MonoPInvokeCallback (typeof (InnerSPUserCallback))]
		static unsafe void TrampolineSPUserCallback (IntPtr block, IntPtr user) {
			var descriptor = (BlockLiteral *) block;
			var del = (global::MonoSpotify.SPUserCallback) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ((MonoSpotify.SPUser) Runtime.GetNSObject (user));
		}
		
		internal delegate void InnerSPObjectRepresentationCallback (IntPtr block, global::MonoSpotify.LinkTypes linkType, IntPtr objectRepresentation);
		[CompilerGenerated]
		static readonly InnerSPObjectRepresentationCallback static_InnerSPObjectRepresentationCallback = TrampolineSPObjectRepresentationCallback;
		[MonoPInvokeCallback (typeof (InnerSPObjectRepresentationCallback))]
		static unsafe void TrampolineSPObjectRepresentationCallback (IntPtr block, global::MonoSpotify.LinkTypes linkType, IntPtr objectRepresentation) {
			var descriptor = (BlockLiteral *) block;
			var del = (global::MonoSpotify.SPObjectRepresentationCallback) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del (linkType, (MonoTouch.Foundation.NSObject) Runtime.GetNSObject (objectRepresentation));
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_PlaybackDelegate_var = null;
				__mt_AudioDeliveryDelegate_var = null;
				__mt_Delegate_var = null;
				__mt_Locale_var = null;
				__mt_InboxPlaylist_var = null;
				__mt_StarredPlaylist_var = null;
				__mt_User_var = null;
				__mt_UserPlaylists_var = null;
			}
		}
	} /* class SPSession */
	public delegate void SPErrorableOperationCallback (NSError error);
	public delegate void DispatchBlockT ();
	public delegate void LoginFetcher (string loginUserName);
	public delegate void CompletionBlock ();
	public delegate void SPAlbumCallback (SPAlbum album);
	public delegate void SPArtistCallback (SPArtist artist);
	public delegate void SPImageCallback (SPImage image);
	public delegate void SPPlaylistCallback (SPPlaylist playlist);
	public delegate void SPSearchCallback (SPSearch search);
	public delegate void SPTrackCallback (SPTrack track);
	public delegate void SPUserCallback (SPUser user);
	public delegate void SPObjectRepresentationCallback (LinkTypes linkType, NSObject objectRepresentation);
}
