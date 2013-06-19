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
	[Register("SPSession", true)]
	public unsafe partial class SPSession : NSObject {
		[CompilerGenerated]
		const string selPlaybackDelegate = "playbackDelegate";
		static readonly IntPtr selPlaybackDelegateHandle = Selector.GetHandle ("playbackDelegate");
		[CompilerGenerated]
		const string selSetPlaybackDelegate_ = "setPlaybackDelegate:";
		static readonly IntPtr selSetPlaybackDelegate_Handle = Selector.GetHandle ("setPlaybackDelegate:");
		[CompilerGenerated]
		const string selAudioDeliveryDelegate = "audioDeliveryDelegate";
		static readonly IntPtr selAudioDeliveryDelegateHandle = Selector.GetHandle ("audioDeliveryDelegate");
		[CompilerGenerated]
		const string selSetAudioDeliveryDelegate_ = "setAudioDeliveryDelegate:";
		static readonly IntPtr selSetAudioDeliveryDelegate_Handle = Selector.GetHandle ("setAudioDeliveryDelegate:");
		[CompilerGenerated]
		const string selSharedSession = "sharedSession";
		static readonly IntPtr selSharedSessionHandle = Selector.GetHandle ("sharedSession");
		[CompilerGenerated]
		const string selSetSharedSession_ = "setSharedSession:";
		static readonly IntPtr selSetSharedSession_Handle = Selector.GetHandle ("setSharedSession:");
		[CompilerGenerated]
		const string selConnectionState = "connectionState";
		static readonly IntPtr selConnectionStateHandle = Selector.GetHandle ("connectionState");
		[CompilerGenerated]
		const string selSetConnectionState_ = "setConnectionState:";
		static readonly IntPtr selSetConnectionState_Handle = Selector.GetHandle ("setConnectionState:");
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selIsLoaded = "isLoaded";
		static readonly IntPtr selIsLoadedHandle = Selector.GetHandle ("isLoaded");
		[CompilerGenerated]
		const string selSetLoaded_ = "setLoaded:";
		static readonly IntPtr selSetLoaded_Handle = Selector.GetHandle ("setLoaded:");
		[CompilerGenerated]
		const string selLocale = "locale";
		static readonly IntPtr selLocaleHandle = Selector.GetHandle ("locale");
		[CompilerGenerated]
		const string selSetLocale_ = "setLocale:";
		static readonly IntPtr selSetLocale_Handle = Selector.GetHandle ("setLocale:");
		[CompilerGenerated]
		const string selInboxPlaylist = "inboxPlaylist";
		static readonly IntPtr selInboxPlaylistHandle = Selector.GetHandle ("inboxPlaylist");
		[CompilerGenerated]
		const string selSetInboxPlaylist_ = "setInboxPlaylist:";
		static readonly IntPtr selSetInboxPlaylist_Handle = Selector.GetHandle ("setInboxPlaylist:");
		[CompilerGenerated]
		const string selStarredPlaylist = "starredPlaylist";
		static readonly IntPtr selStarredPlaylistHandle = Selector.GetHandle ("starredPlaylist");
		[CompilerGenerated]
		const string selSetStarredPlaylist_ = "setStarredPlaylist:";
		static readonly IntPtr selSetStarredPlaylist_Handle = Selector.GetHandle ("setStarredPlaylist:");
		[CompilerGenerated]
		const string selUser = "user";
		static readonly IntPtr selUserHandle = Selector.GetHandle ("user");
		[CompilerGenerated]
		const string selSetUser_ = "setUser:";
		static readonly IntPtr selSetUser_Handle = Selector.GetHandle ("setUser:");
		[CompilerGenerated]
		const string selUserPlaylists = "userPlaylists";
		static readonly IntPtr selUserPlaylistsHandle = Selector.GetHandle ("userPlaylists");
		[CompilerGenerated]
		const string selSetUserPlaylists_ = "setUserPlaylists:";
		static readonly IntPtr selSetUserPlaylists_Handle = Selector.GetHandle ("setUserPlaylists:");
		[CompilerGenerated]
		const string selIsUsingVolumeNormalization = "isUsingVolumeNormalization";
		static readonly IntPtr selIsUsingVolumeNormalizationHandle = Selector.GetHandle ("isUsingVolumeNormalization");
		[CompilerGenerated]
		const string selSetUsingVolumeNormalization_ = "setUsingVolumeNormalization:";
		static readonly IntPtr selSetUsingVolumeNormalization_Handle = Selector.GetHandle ("setUsingVolumeNormalization:");
		[CompilerGenerated]
		const string selSetPlaying_ = "setPlaying:";
		static readonly IntPtr selSetPlaying_Handle = Selector.GetHandle ("setPlaying:");
		[CompilerGenerated]
		const string selPreloadTrackForPlaybackCallback_ = "preloadTrackForPlayback:callback:";
		static readonly IntPtr selPreloadTrackForPlaybackCallback_Handle = Selector.GetHandle ("preloadTrackForPlayback:callback:");
		[CompilerGenerated]
		const string selPlayTrackCallback_ = "playTrack:callback:";
		static readonly IntPtr selPlayTrackCallback_Handle = Selector.GetHandle ("playTrack:callback:");
		[CompilerGenerated]
		const string selSeekPlaybackToOffset_ = "seekPlaybackToOffset:";
		static readonly IntPtr selSeekPlaybackToOffset_Handle = Selector.GetHandle ("seekPlaybackToOffset:");
		[CompilerGenerated]
		const string selUnloadPlayback = "unloadPlayback";
		static readonly IntPtr selUnloadPlaybackHandle = Selector.GetHandle ("unloadPlayback");
		[CompilerGenerated]
		const string selDispatchToLibSpotifyThread_ = "dispatchToLibSpotifyThread:";
		static readonly IntPtr selDispatchToLibSpotifyThread_Handle = Selector.GetHandle ("dispatchToLibSpotifyThread:");
		[CompilerGenerated]
		const string selDispatchToLibSpotifyThreadWaitUntilDone_ = "dispatchToLibSpotifyThread:waitUntilDone:";
		static readonly IntPtr selDispatchToLibSpotifyThreadWaitUntilDone_Handle = Selector.GetHandle ("dispatchToLibSpotifyThread:waitUntilDone:");
		[CompilerGenerated]
		const string selSpotifyClientInstalled = "spotifyClientInstalled";
		static readonly IntPtr selSpotifyClientInstalledHandle = Selector.GetHandle ("spotifyClientInstalled");
		[CompilerGenerated]
		const string selLaunchSpotifyClientIfInstalled = "launchSpotifyClientIfInstalled";
		static readonly IntPtr selLaunchSpotifyClientIfInstalledHandle = Selector.GetHandle ("launchSpotifyClientIfInstalled");
		[CompilerGenerated]
		const string selInitializeSharedSessionWithApplicationKeyUserAgentLoadingPolicyError_ = "initializeSharedSessionWithApplicationKey:userAgent:loadingPolicy:error:";
		static readonly IntPtr selInitializeSharedSessionWithApplicationKeyUserAgentLoadingPolicyError_Handle = Selector.GetHandle ("initializeSharedSessionWithApplicationKey:userAgent:loadingPolicy:error:");
		[CompilerGenerated]
		const string selLibSpotifyBuildId = "libSpotifyBuildId";
		static readonly IntPtr selLibSpotifyBuildIdHandle = Selector.GetHandle ("libSpotifyBuildId");
		[CompilerGenerated]
		const string selInitWithApplicationKeyUserAgentLoadingPolicyError_ = "initWithApplicationKey:userAgent:loadingPolicy:error:";
		static readonly IntPtr selInitWithApplicationKeyUserAgentLoadingPolicyError_Handle = Selector.GetHandle ("initWithApplicationKey:userAgent:loadingPolicy:error:");
		[CompilerGenerated]
		const string selAttemptLoginWithUserNamePassword_ = "attemptLoginWithUserName:password:";
		static readonly IntPtr selAttemptLoginWithUserNamePassword_Handle = Selector.GetHandle ("attemptLoginWithUserName:password:");
		[CompilerGenerated]
		const string selAttemptLoginWithUserNameExistingCredential_ = "attemptLoginWithUserName:existingCredential:";
		static readonly IntPtr selAttemptLoginWithUserNameExistingCredential_Handle = Selector.GetHandle ("attemptLoginWithUserName:existingCredential:");
		[CompilerGenerated]
		const string selFetchLoginUserName_ = "fetchLoginUserName:";
		static readonly IntPtr selFetchLoginUserName_Handle = Selector.GetHandle ("fetchLoginUserName:");
		[CompilerGenerated]
		const string selFlushCaches_ = "flushCaches:";
		static readonly IntPtr selFlushCaches_Handle = Selector.GetHandle ("flushCaches:");
		[CompilerGenerated]
		const string selLogout_ = "logout:";
		static readonly IntPtr selLogout_Handle = Selector.GetHandle ("logout:");
		[CompilerGenerated]
		const string selSetMaximumCacheSizeMB_ = "setMaximumCacheSizeMB:";
		static readonly IntPtr selSetMaximumCacheSizeMB_Handle = Selector.GetHandle ("setMaximumCacheSizeMB:");
		[CompilerGenerated]
		const string selSetPreferredBitrate_ = "setPreferredBitrate:";
		static readonly IntPtr selSetPreferredBitrate_Handle = Selector.GetHandle ("setPreferredBitrate:");
		[CompilerGenerated]
		const string selPostTracksToInboxOfUserWithMessageCallback_ = "postTracks:toInboxOfUser:withMessage:callback:";
		static readonly IntPtr selPostTracksToInboxOfUserWithMessageCallback_Handle = Selector.GetHandle ("postTracks:toInboxOfUser:withMessage:callback:");
		[CompilerGenerated]
		const string selAlbumForURLCallback_ = "albumForURL:callback:";
		static readonly IntPtr selAlbumForURLCallback_Handle = Selector.GetHandle ("albumForURL:callback:");
		[CompilerGenerated]
		const string selArtistForURLCallback_ = "artistForURL:callback:";
		static readonly IntPtr selArtistForURLCallback_Handle = Selector.GetHandle ("artistForURL:callback:");
		[CompilerGenerated]
		const string selImageForURLCallback_ = "imageForURL:callback:";
		static readonly IntPtr selImageForURLCallback_Handle = Selector.GetHandle ("imageForURL:callback:");
		[CompilerGenerated]
		const string selPlaylistForURLCallback_ = "playlistForURL:callback:";
		static readonly IntPtr selPlaylistForURLCallback_Handle = Selector.GetHandle ("playlistForURL:callback:");
		[CompilerGenerated]
		const string selSearchForURLCallback_ = "searchForURL:callback:";
		static readonly IntPtr selSearchForURLCallback_Handle = Selector.GetHandle ("searchForURL:callback:");
		[CompilerGenerated]
		const string selTrackForURLCallback_ = "trackForURL:callback:";
		static readonly IntPtr selTrackForURLCallback_Handle = Selector.GetHandle ("trackForURL:callback:");
		[CompilerGenerated]
		const string selUserForURLCallback_ = "userForURL:callback:";
		static readonly IntPtr selUserForURLCallback_Handle = Selector.GetHandle ("userForURL:callback:");
		[CompilerGenerated]
		const string selObjectRepresentationForSpotifyURLLinkType_ = "objectRepresentationForSpotifyURL:linkType:";
		static readonly IntPtr selObjectRepresentationForSpotifyURLLinkType_Handle = Selector.GetHandle ("objectRepresentationForSpotifyURL:linkType:");
		[CompilerGenerated]
		const string selObjectRepresentationForSpotifyURLCallback_ = "objectRepresentationForSpotifyURL:callback:";
		static readonly IntPtr selObjectRepresentationForSpotifyURLCallback_Handle = Selector.GetHandle ("objectRepresentationForSpotifyURL:callback:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("SPSession");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SPSession () : base (NSObjectFlag.Empty)
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
			block_callback.SetupBlock (Trampolines.SDSPErrorableOperationCallback.Handler, callback);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selPreloadTrackForPlaybackCallback_Handle, track.Handle, (IntPtr) block_ptr_callback);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selPreloadTrackForPlaybackCallback_Handle, track.Handle, (IntPtr) block_ptr_callback);
			}
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("playTrack:callback:")]
		[CompilerGenerated]
		public unsafe virtual void PlayTrack (SPTrack track, SPErrorableOperationCallback callback)
		{
			if (track == null)
				throw new ArgumentNullException ("track");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDSPErrorableOperationCallback.Handler, callback);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selPlayTrackCallback_Handle, track.Handle, (IntPtr) block_ptr_callback);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selPlayTrackCallback_Handle, track.Handle, (IntPtr) block_ptr_callback);
			}
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("seekPlaybackToOffset:")]
		[CompilerGenerated]
		public virtual void SeekPlaybackToOffset (global::System.Double offset)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSeekPlaybackToOffset_Handle, offset);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, selSeekPlaybackToOffset_Handle, offset);
			}
		}
		
		[Export ("unloadPlayback")]
		[CompilerGenerated]
		public virtual void UnloadPlayback ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUnloadPlaybackHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selUnloadPlaybackHandle);
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
			block_block.SetupBlock (Trampolines.SDDispatchBlockT.Handler, block);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selDispatchToLibSpotifyThread_Handle, (IntPtr) block_ptr_block);
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
			block_block.SetupBlock (Trampolines.SDDispatchBlockT.Handler, block);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_bool (class_ptr, selDispatchToLibSpotifyThreadWaitUntilDone_Handle, (IntPtr) block_ptr_block, wait);
			block_ptr_block->CleanupBlock ();
			
		}
		
		[Export ("spotifyClientInstalled")]
		[CompilerGenerated]
		public static bool SpotifyClientInstalled ()
		{
			return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selSpotifyClientInstalledHandle);
		}
		
		[Export ("launchSpotifyClientIfInstalled")]
		[CompilerGenerated]
		public static bool LaunchSpotifyClientIfInstalled ()
		{
			return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selLaunchSpotifyClientIfInstalledHandle);
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
			ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_IntPtr_int_IntPtr (class_ptr, selInitializeSharedSessionWithApplicationKeyUserAgentLoadingPolicyError_Handle, applicationKey.Handle, nsuserAgent, (int)loadingPolicy, error.Handle);
			NSString.ReleaseNative (nsuserAgent);
			
			return ret;
		}
		
		[Export ("libSpotifyBuildId")]
		[CompilerGenerated]
		public static string SpotifyBuildID ()
		{
			return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selLibSpotifyBuildIdHandle));
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
				ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_int_IntPtr (this.Handle, selInitWithApplicationKeyUserAgentLoadingPolicyError_Handle, applicationKey.Handle, nsuserAgent, (int)loadingPolicy, error.Handle));
			} else {
				ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_int_IntPtr (this.SuperHandle, selInitWithApplicationKeyUserAgentLoadingPolicyError_Handle, applicationKey.Handle, nsuserAgent, (int)loadingPolicy, error.Handle));
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
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selAttemptLoginWithUserNamePassword_Handle, nsuserName, nspassword);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selAttemptLoginWithUserNamePassword_Handle, nsuserName, nspassword);
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
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selAttemptLoginWithUserNameExistingCredential_Handle, nsuserName, nsexistingCredential);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selAttemptLoginWithUserNameExistingCredential_Handle, nsuserName, nsexistingCredential);
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
			block_block.SetupBlock (Trampolines.SDLoginFetcher.Handler, block);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selFetchLoginUserName_Handle, (IntPtr) block_ptr_block);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selFetchLoginUserName_Handle, (IntPtr) block_ptr_block);
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
			block_block.SetupBlock (Trampolines.SDCompletionBlock.Handler, block);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selFlushCaches_Handle, (IntPtr) block_ptr_block);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selFlushCaches_Handle, (IntPtr) block_ptr_block);
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
			block_block.SetupBlock (Trampolines.SDCompletionBlock.Handler, block);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selLogout_Handle, (IntPtr) block_ptr_block);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selLogout_Handle, (IntPtr) block_ptr_block);
			}
			block_ptr_block->CleanupBlock ();
			
		}
		
		[Export ("setMaximumCacheSizeMB:")]
		[CompilerGenerated]
		public virtual void SetMaximumCacheSize (int megaBytes)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetMaximumCacheSizeMB_Handle, megaBytes);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetMaximumCacheSizeMB_Handle, megaBytes);
			}
		}
		
		[Export ("setPreferredBitrate:")]
		[CompilerGenerated]
		public virtual void SetPreferredBitrate (Bitrates bitrate)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetPreferredBitrate_Handle, (int)bitrate);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetPreferredBitrate_Handle, (int)bitrate);
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
			block_block.SetupBlock (Trampolines.SDSPErrorableOperationCallback.Handler, block);
			
			SPPostTracksToInboxOperation ret;
			if (IsDirectBinding) {
				ret = (SPPostTracksToInboxOperation) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, selPostTracksToInboxOfUserWithMessageCallback_Handle, nsa_tracks.Handle, nstargetUserName, nsfriendlyMessage, (IntPtr) block_ptr_block));
			} else {
				ret = (SPPostTracksToInboxOperation) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, selPostTracksToInboxOfUserWithMessageCallback_Handle, nsa_tracks.Handle, nstargetUserName, nsfriendlyMessage, (IntPtr) block_ptr_block));
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
			block_callback.SetupBlock (Trampolines.SDSPAlbumCallback.Handler, callback);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selAlbumForURLCallback_Handle, url.Handle, (IntPtr) block_ptr_callback);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selAlbumForURLCallback_Handle, url.Handle, (IntPtr) block_ptr_callback);
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
			block_callback.SetupBlock (Trampolines.SDSPArtistCallback.Handler, callback);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selArtistForURLCallback_Handle, url.Handle, (IntPtr) block_ptr_callback);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selArtistForURLCallback_Handle, url.Handle, (IntPtr) block_ptr_callback);
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
			block_callback.SetupBlock (Trampolines.SDSPImageCallback.Handler, callback);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selImageForURLCallback_Handle, url.Handle, (IntPtr) block_ptr_callback);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selImageForURLCallback_Handle, url.Handle, (IntPtr) block_ptr_callback);
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
			block_callback.SetupBlock (Trampolines.SDSPPlaylistCallback.Handler, callback);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selPlaylistForURLCallback_Handle, url.Handle, (IntPtr) block_ptr_callback);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selPlaylistForURLCallback_Handle, url.Handle, (IntPtr) block_ptr_callback);
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
			block_callback.SetupBlock (Trampolines.SDSPSearchCallback.Handler, callback);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSearchForURLCallback_Handle, url.Handle, (IntPtr) block_ptr_callback);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSearchForURLCallback_Handle, url.Handle, (IntPtr) block_ptr_callback);
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
			block_callback.SetupBlock (Trampolines.SDSPTrackCallback.Handler, callback);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selTrackForURLCallback_Handle, url.Handle, (IntPtr) block_ptr_callback);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selTrackForURLCallback_Handle, url.Handle, (IntPtr) block_ptr_callback);
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
			block_callback.SetupBlock (Trampolines.SDSPUserCallback.Handler, callback);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selUserForURLCallback_Handle, url.Handle, (IntPtr) block_ptr_callback);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selUserForURLCallback_Handle, url.Handle, (IntPtr) block_ptr_callback);
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
				return (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_int (this.Handle, selObjectRepresentationForSpotifyURLLinkType_Handle, spotifyUrl.Handle, (int)linkType));
			} else {
				return (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_int (this.SuperHandle, selObjectRepresentationForSpotifyURLLinkType_Handle, spotifyUrl.Handle, (int)linkType));
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
			block_callback.SetupBlock (Trampolines.SDSPObjectRepresentationCallback.Handler, callback);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selObjectRepresentationForSpotifyURLCallback_Handle, url.Handle, (IntPtr) block_ptr_callback);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selObjectRepresentationForSpotifyURLCallback_Handle, url.Handle, (IntPtr) block_ptr_callback);
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
					ret = (SPSessionPlaybackDelegate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPlaybackDelegateHandle));
				} else {
					ret = (SPSessionPlaybackDelegate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPlaybackDelegateHandle));
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
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPlaybackDelegate_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPlaybackDelegate_Handle, value.Handle);
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
					ret = (SPSessionAudioDeliveryDelegate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAudioDeliveryDelegateHandle));
				} else {
					ret = (SPSessionAudioDeliveryDelegate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAudioDeliveryDelegateHandle));
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
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAudioDeliveryDelegate_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetAudioDeliveryDelegate_Handle, value.Handle);
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
				ret = (SPSession) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selSharedSessionHandle));
				__mt_SharedSession_var_static = ret;
				return ret;
			}
			
			[Export ("setSharedSession:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selSetSharedSession_Handle, value.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual ConnectionStates ConnectionState {
			[Export ("connectionState")]
			get {
				if (IsDirectBinding) {
					return (ConnectionStates) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selConnectionStateHandle);
				} else {
					return (ConnectionStates) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selConnectionStateHandle);
				}
			}
			
			[Export ("setConnectionState:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetConnectionState_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetConnectionState_Handle, (int)value);
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
					ret = (SPSessionDelegate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegateHandle));
				} else {
					ret = (SPSessionDelegate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegateHandle));
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
		object __mt_Locale_var;
		[CompilerGenerated]
		public virtual NSLocale Locale {
			[Export ("locale")]
			get {
				NSLocale ret;
				if (IsDirectBinding) {
					ret = (NSLocale) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLocaleHandle));
				} else {
					ret = (NSLocale) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLocaleHandle));
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
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetLocale_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetLocale_Handle, value.Handle);
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
					ret = (SPPlaylist) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selInboxPlaylistHandle));
				} else {
					ret = (SPPlaylist) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selInboxPlaylistHandle));
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
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetInboxPlaylist_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetInboxPlaylist_Handle, value.Handle);
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
					ret = (SPPlaylist) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selStarredPlaylistHandle));
				} else {
					ret = (SPPlaylist) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selStarredPlaylistHandle));
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
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetStarredPlaylist_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetStarredPlaylist_Handle, value.Handle);
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
					ret = (SPUser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUserHandle));
				} else {
					ret = (SPUser) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUserHandle));
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
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUser_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUser_Handle, value.Handle);
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
					ret = (SPPlaylistContainer) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUserPlaylistsHandle));
				} else {
					ret = (SPPlaylistContainer) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUserPlaylistsHandle));
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
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUserPlaylists_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUserPlaylists_Handle, value.Handle);
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
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsUsingVolumeNormalizationHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsUsingVolumeNormalizationHandle);
				}
			}
			
			[Export ("setUsingVolumeNormalization:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUsingVolumeNormalization_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetUsingVolumeNormalization_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool Playing {
			[Export ("isUsingVolumeNormalization")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsUsingVolumeNormalizationHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsUsingVolumeNormalizationHandle);
				}
			}
			
			[Export ("setPlaying:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetPlaying_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetPlaying_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
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
