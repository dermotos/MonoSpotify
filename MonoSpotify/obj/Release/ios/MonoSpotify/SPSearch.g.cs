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
	[Register("SPSearch", true)]
	public unsafe partial class SPSearch : NSObject {
		[CompilerGenerated]
		const string selIsLoaded = "isLoaded";
		static readonly IntPtr selIsLoadedHandle = Selector.GetHandle ("isLoaded");
		[CompilerGenerated]
		const string selSetLoaded_ = "setLoaded:";
		static readonly IntPtr selSetLoaded_Handle = Selector.GetHandle ("setLoaded:");
		[CompilerGenerated]
		const string selAddAlbumPage = "addAlbumPage";
		static readonly IntPtr selAddAlbumPageHandle = Selector.GetHandle ("addAlbumPage");
		[CompilerGenerated]
		const string selSetAddAlbumPage_ = "setAddAlbumPage:";
		static readonly IntPtr selSetAddAlbumPage_Handle = Selector.GetHandle ("setAddAlbumPage:");
		[CompilerGenerated]
		const string selAddArtistPage = "addArtistPage";
		static readonly IntPtr selAddArtistPageHandle = Selector.GetHandle ("addArtistPage");
		[CompilerGenerated]
		const string selSetAddArtistPage_ = "setAddArtistPage:";
		static readonly IntPtr selSetAddArtistPage_Handle = Selector.GetHandle ("setAddArtistPage:");
		[CompilerGenerated]
		const string selAddTrackPage = "addTrackPage";
		static readonly IntPtr selAddTrackPageHandle = Selector.GetHandle ("addTrackPage");
		[CompilerGenerated]
		const string selSetAddTrackPage_ = "setAddTrackPage:";
		static readonly IntPtr selSetAddTrackPage_Handle = Selector.GetHandle ("setAddTrackPage:");
		[CompilerGenerated]
		const string selAddPlaylistPage = "addPlaylistPage";
		static readonly IntPtr selAddPlaylistPageHandle = Selector.GetHandle ("addPlaylistPage");
		[CompilerGenerated]
		const string selSetAddPlaylistPage_ = "setAddPlaylistPage:";
		static readonly IntPtr selSetAddPlaylistPage_Handle = Selector.GetHandle ("setAddPlaylistPage:");
		[CompilerGenerated]
		const string selSuggestedSearchQuery = "suggestedSearchQuery";
		static readonly IntPtr selSuggestedSearchQueryHandle = Selector.GetHandle ("suggestedSearchQuery");
		[CompilerGenerated]
		const string selHasExhaustedAlbumResults = "hasExhaustedAlbumResults";
		static readonly IntPtr selHasExhaustedAlbumResultsHandle = Selector.GetHandle ("hasExhaustedAlbumResults");
		[CompilerGenerated]
		const string selHasExhaustedArtistResults = "hasExhaustedArtistResults";
		static readonly IntPtr selHasExhaustedArtistResultsHandle = Selector.GetHandle ("hasExhaustedArtistResults");
		[CompilerGenerated]
		const string selHasExhaustedTrackResults = "hasExhaustedTrackResults";
		static readonly IntPtr selHasExhaustedTrackResultsHandle = Selector.GetHandle ("hasExhaustedTrackResults");
		[CompilerGenerated]
		const string selHasExhaustedPlaylistResults = "hasExhaustedPlaylistResults";
		static readonly IntPtr selHasExhaustedPlaylistResultsHandle = Selector.GetHandle ("hasExhaustedPlaylistResults");
		[CompilerGenerated]
		const string selAlbums = "albums";
		static readonly IntPtr selAlbumsHandle = Selector.GetHandle ("albums");
		[CompilerGenerated]
		const string selArtists = "artists";
		static readonly IntPtr selArtistsHandle = Selector.GetHandle ("artists");
		[CompilerGenerated]
		const string selTracks = "tracks";
		static readonly IntPtr selTracksHandle = Selector.GetHandle ("tracks");
		[CompilerGenerated]
		const string selPlaylists = "playlists";
		static readonly IntPtr selPlaylistsHandle = Selector.GetHandle ("playlists");
		[CompilerGenerated]
		const string selSearchError = "searchError";
		static readonly IntPtr selSearchErrorHandle = Selector.GetHandle ("searchError");
		[CompilerGenerated]
		const string selSearchQuery = "searchQuery";
		static readonly IntPtr selSearchQueryHandle = Selector.GetHandle ("searchQuery");
		[CompilerGenerated]
		const string selSession = "session";
		static readonly IntPtr selSessionHandle = Selector.GetHandle ("session");
		[CompilerGenerated]
		const string selSpotifyURL = "spotifyURL";
		static readonly IntPtr selSpotifyURLHandle = Selector.GetHandle ("spotifyURL");
		[CompilerGenerated]
		const string selSearchWithURLInSession_ = "searchWithURL:inSession:";
		static readonly IntPtr selSearchWithURLInSession_Handle = Selector.GetHandle ("searchWithURL:inSession:");
		[CompilerGenerated]
		const string selSearchWithSearchQueryInSession_ = "searchWithSearchQuery:inSession:";
		static readonly IntPtr selSearchWithSearchQueryInSession_Handle = Selector.GetHandle ("searchWithSearchQuery:inSession:");
		[CompilerGenerated]
		const string selLiveSearchWithSearchQueryInSession_ = "liveSearchWithSearchQuery:inSession:";
		static readonly IntPtr selLiveSearchWithSearchQueryInSession_Handle = Selector.GetHandle ("liveSearchWithSearchQuery:inSession:");
		[CompilerGenerated]
		const string selInitWithURLInSession_ = "initWithURL:inSession:";
		static readonly IntPtr selInitWithURLInSession_Handle = Selector.GetHandle ("initWithURL:inSession:");
		[CompilerGenerated]
		const string selInitWithURLPageSizeInSession_ = "initWithURL:pageSize:inSession:";
		static readonly IntPtr selInitWithURLPageSizeInSession_Handle = Selector.GetHandle ("initWithURL:pageSize:inSession:");
		[CompilerGenerated]
		const string selInitWithSearchQueryInSession_ = "initWithSearchQuery:inSession:";
		static readonly IntPtr selInitWithSearchQueryInSession_Handle = Selector.GetHandle ("initWithSearchQuery:inSession:");
		[CompilerGenerated]
		const string selInitWithSearchQueryPageSizeInSession_ = "initWithSearchQuery:pageSize:inSession:";
		static readonly IntPtr selInitWithSearchQueryPageSizeInSession_Handle = Selector.GetHandle ("initWithSearchQuery:pageSize:inSession:");
		[CompilerGenerated]
		const string selAddPageForArtistsAlbumsTracksPlaylists_ = "addPageForArtists:albums:tracks:playlists:";
		static readonly IntPtr selAddPageForArtistsAlbumsTracksPlaylists_Handle = Selector.GetHandle ("addPageForArtists:albums:tracks:playlists:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("SPSearch");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SPSearch () : base (NSObjectFlag.Empty)
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
		public SPSearch (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public SPSearch (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public SPSearch (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("searchWithURL:inSession:")]
		[CompilerGenerated]
		public static SPSearch SearchWithUrl (NSUrl searchUrl, SPSession aSession)
		{
			if (searchUrl == null)
				throw new ArgumentNullException ("searchUrl");
			if (aSession == null)
				throw new ArgumentNullException ("aSession");
			return (SPSearch) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selSearchWithURLInSession_Handle, searchUrl.Handle, aSession.Handle));
		}
		
		[Export ("searchWithSearchQuery:inSession:")]
		[CompilerGenerated]
		public static SPSearch SearchWithSearchQuery (string searchQuery, SPSession aSession)
		{
			if (searchQuery == null)
				throw new ArgumentNullException ("searchQuery");
			if (aSession == null)
				throw new ArgumentNullException ("aSession");
			var nssearchQuery = NSString.CreateNative (searchQuery);
			
			SPSearch ret;
			ret = (SPSearch) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selSearchWithSearchQueryInSession_Handle, nssearchQuery, aSession.Handle));
			NSString.ReleaseNative (nssearchQuery);
			
			return ret;
		}
		
		[Export ("liveSearchWithSearchQuery:inSession:")]
		[CompilerGenerated]
		public static SPSearch LiveSearchWithSearchQuery (string searchQuery, SPSession aSession)
		{
			if (searchQuery == null)
				throw new ArgumentNullException ("searchQuery");
			if (aSession == null)
				throw new ArgumentNullException ("aSession");
			var nssearchQuery = NSString.CreateNative (searchQuery);
			
			SPSearch ret;
			ret = (SPSearch) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selLiveSearchWithSearchQueryInSession_Handle, nssearchQuery, aSession.Handle));
			NSString.ReleaseNative (nssearchQuery);
			
			return ret;
		}
		
		[Export ("initWithURL:inSession:")]
		[CompilerGenerated]
		public SPSearch (NSUrl searchUrl, SPSession aSession)
			: base (NSObjectFlag.Empty)
		{
			if (searchUrl == null)
				throw new ArgumentNullException ("searchUrl");
			if (aSession == null)
				throw new ArgumentNullException ("aSession");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithURLInSession_Handle, searchUrl.Handle, aSession.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithURLInSession_Handle, searchUrl.Handle, aSession.Handle);
			}
		}
		
		[Export ("initWithURL:pageSize:inSession:")]
		[CompilerGenerated]
		public SPSearch (NSUrl searchURL, int pageSize, SPSession aSession)
			: base (NSObjectFlag.Empty)
		{
			if (searchURL == null)
				throw new ArgumentNullException ("searchURL");
			if (aSession == null)
				throw new ArgumentNullException ("aSession");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_int_IntPtr (this.Handle, selInitWithURLPageSizeInSession_Handle, searchURL.Handle, pageSize, aSession.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_int_IntPtr (this.SuperHandle, selInitWithURLPageSizeInSession_Handle, searchURL.Handle, pageSize, aSession.Handle);
			}
		}
		
		[Export ("initWithSearchQuery:inSession:")]
		[CompilerGenerated]
		public SPSearch (string searchString, SPSession aSession)
			: base (NSObjectFlag.Empty)
		{
			if (searchString == null)
				throw new ArgumentNullException ("searchString");
			if (aSession == null)
				throw new ArgumentNullException ("aSession");
			var nssearchString = NSString.CreateNative (searchString);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithSearchQueryInSession_Handle, nssearchString, aSession.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithSearchQueryInSession_Handle, nssearchString, aSession.Handle);
			}
			NSString.ReleaseNative (nssearchString);
			
		}
		
		[Export ("initWithSearchQuery:pageSize:inSession:")]
		[CompilerGenerated]
		public SPSearch (string searchString, int pageSize, SPSession aSession)
			: base (NSObjectFlag.Empty)
		{
			if (searchString == null)
				throw new ArgumentNullException ("searchString");
			if (aSession == null)
				throw new ArgumentNullException ("aSession");
			var nssearchString = NSString.CreateNative (searchString);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_int_IntPtr (this.Handle, selInitWithSearchQueryPageSizeInSession_Handle, nssearchString, pageSize, aSession.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_int_IntPtr (this.SuperHandle, selInitWithSearchQueryPageSizeInSession_Handle, nssearchString, pageSize, aSession.Handle);
			}
			NSString.ReleaseNative (nssearchString);
			
		}
		
		[Export ("addPageForArtists:albums:tracks:playlists:")]
		[CompilerGenerated]
		public virtual bool AddPageForArtists (bool artists, bool albums, bool tracks, bool playlists)
		{
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.bool_objc_msgSend_bool_bool_bool_bool (this.Handle, selAddPageForArtistsAlbumsTracksPlaylists_Handle, artists, albums, tracks, playlists);
			} else {
				return ApiDefinition.Messaging.bool_objc_msgSendSuper_bool_bool_bool_bool (this.SuperHandle, selAddPageForArtistsAlbumsTracksPlaylists_Handle, artists, albums, tracks, playlists);
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
		public virtual bool AddAlbumPage {
			[Export ("addAlbumPage")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAddAlbumPageHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selAddAlbumPageHandle);
				}
			}
			
			[Export ("setAddAlbumPage:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAddAlbumPage_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetAddAlbumPage_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool AddArtistPage {
			[Export ("addArtistPage")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAddArtistPageHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selAddArtistPageHandle);
				}
			}
			
			[Export ("setAddArtistPage:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAddArtistPage_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetAddArtistPage_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool AddTrackPage {
			[Export ("addTrackPage")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAddTrackPageHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selAddTrackPageHandle);
				}
			}
			
			[Export ("setAddTrackPage:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAddTrackPage_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetAddTrackPage_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool AddPlaylistPage {
			[Export ("addPlaylistPage")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAddPlaylistPageHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selAddPlaylistPageHandle);
				}
			}
			
			[Export ("setAddPlaylistPage:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAddPlaylistPage_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetAddPlaylistPage_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string SuggestedSearchQuery {
			[Export ("suggestedSearchQuery")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSuggestedSearchQueryHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSuggestedSearchQueryHandle));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool HasExhaustedAlbumResults {
			[Export ("hasExhaustedAlbumResults")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasExhaustedAlbumResultsHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selHasExhaustedAlbumResultsHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool HasExhaustedArtistResults {
			[Export ("hasExhaustedArtistResults")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasExhaustedArtistResultsHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selHasExhaustedArtistResultsHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool HasExhaustedTrackResults {
			[Export ("hasExhaustedTrackResults")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasExhaustedTrackResultsHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selHasExhaustedTrackResultsHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool HasExhaustedPlaylistResults {
			[Export ("hasExhaustedPlaylistResults")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasExhaustedPlaylistResultsHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selHasExhaustedPlaylistResultsHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Albums_var;
		[CompilerGenerated]
		public virtual NSArray Albums {
			[Export ("albums")]
			get {
				NSArray ret;
				if (IsDirectBinding) {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAlbumsHandle));
				} else {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAlbumsHandle));
				}
				MarkDirty ();
				__mt_Albums_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Artists_var;
		[CompilerGenerated]
		public virtual NSArray Artists {
			[Export ("artists")]
			get {
				NSArray ret;
				if (IsDirectBinding) {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selArtistsHandle));
				} else {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selArtistsHandle));
				}
				MarkDirty ();
				__mt_Artists_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Tracks_var;
		[CompilerGenerated]
		public virtual NSArray Tracks {
			[Export ("tracks")]
			get {
				NSArray ret;
				if (IsDirectBinding) {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTracksHandle));
				} else {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTracksHandle));
				}
				MarkDirty ();
				__mt_Tracks_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Playlists_var;
		[CompilerGenerated]
		public virtual NSArray Playlists {
			[Export ("playlists")]
			get {
				NSArray ret;
				if (IsDirectBinding) {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPlaylistsHandle));
				} else {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPlaylistsHandle));
				}
				MarkDirty ();
				__mt_Playlists_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_SearchError_var;
		[CompilerGenerated]
		public virtual NSError SearchError {
			[Export ("searchError")]
			get {
				NSError ret;
				if (IsDirectBinding) {
					ret = (NSError) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSearchErrorHandle));
				} else {
					ret = (NSError) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSearchErrorHandle));
				}
				MarkDirty ();
				__mt_SearchError_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string SearchQuery {
			[Export ("searchQuery")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSearchQueryHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSearchQueryHandle));
				}
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
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Albums_var = null;
				__mt_Artists_var = null;
				__mt_Tracks_var = null;
				__mt_Playlists_var = null;
				__mt_SearchError_var = null;
				__mt_Session_var = null;
				__mt_SpotifyURL_var = null;
			}
		}
	} /* class SPSearch */
}
