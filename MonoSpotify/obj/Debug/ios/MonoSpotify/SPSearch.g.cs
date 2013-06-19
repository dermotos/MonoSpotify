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
	[Register("SPSearch", true)]
	public unsafe partial class SPSearch : NSObject {
		[CompilerGenerated]
		static readonly IntPtr selIsLoaded = Selector.GetHandle ("isLoaded");
		[CompilerGenerated]
		static readonly IntPtr selSetLoaded_ = Selector.GetHandle ("setLoaded:");
		[CompilerGenerated]
		static readonly IntPtr selAddAlbumPage = Selector.GetHandle ("addAlbumPage");
		[CompilerGenerated]
		static readonly IntPtr selSetAddAlbumPage_ = Selector.GetHandle ("setAddAlbumPage:");
		[CompilerGenerated]
		static readonly IntPtr selAddArtistPage = Selector.GetHandle ("addArtistPage");
		[CompilerGenerated]
		static readonly IntPtr selSetAddArtistPage_ = Selector.GetHandle ("setAddArtistPage:");
		[CompilerGenerated]
		static readonly IntPtr selAddTrackPage = Selector.GetHandle ("addTrackPage");
		[CompilerGenerated]
		static readonly IntPtr selSetAddTrackPage_ = Selector.GetHandle ("setAddTrackPage:");
		[CompilerGenerated]
		static readonly IntPtr selAddPlaylistPage = Selector.GetHandle ("addPlaylistPage");
		[CompilerGenerated]
		static readonly IntPtr selSetAddPlaylistPage_ = Selector.GetHandle ("setAddPlaylistPage:");
		[CompilerGenerated]
		static readonly IntPtr selSuggestedSearchQuery = Selector.GetHandle ("suggestedSearchQuery");
		[CompilerGenerated]
		static readonly IntPtr selHasExhaustedAlbumResults = Selector.GetHandle ("hasExhaustedAlbumResults");
		[CompilerGenerated]
		static readonly IntPtr selHasExhaustedArtistResults = Selector.GetHandle ("hasExhaustedArtistResults");
		[CompilerGenerated]
		static readonly IntPtr selHasExhaustedTrackResults = Selector.GetHandle ("hasExhaustedTrackResults");
		[CompilerGenerated]
		static readonly IntPtr selHasExhaustedPlaylistResults = Selector.GetHandle ("hasExhaustedPlaylistResults");
		[CompilerGenerated]
		static readonly IntPtr selAlbums = Selector.GetHandle ("albums");
		[CompilerGenerated]
		static readonly IntPtr selArtists = Selector.GetHandle ("artists");
		[CompilerGenerated]
		static readonly IntPtr selTracks = Selector.GetHandle ("tracks");
		[CompilerGenerated]
		static readonly IntPtr selPlaylists = Selector.GetHandle ("playlists");
		[CompilerGenerated]
		static readonly IntPtr selSearchError = Selector.GetHandle ("searchError");
		[CompilerGenerated]
		static readonly IntPtr selSearchQuery = Selector.GetHandle ("searchQuery");
		[CompilerGenerated]
		static readonly IntPtr selSession = Selector.GetHandle ("session");
		[CompilerGenerated]
		static readonly IntPtr selSpotifyURL = Selector.GetHandle ("spotifyURL");
		[CompilerGenerated]
		static readonly IntPtr selSearchWithURLInSession_ = Selector.GetHandle ("searchWithURL:inSession:");
		[CompilerGenerated]
		static readonly IntPtr selSearchWithSearchQueryInSession_ = Selector.GetHandle ("searchWithSearchQuery:inSession:");
		[CompilerGenerated]
		static readonly IntPtr selLiveSearchWithSearchQueryInSession_ = Selector.GetHandle ("liveSearchWithSearchQuery:inSession:");
		[CompilerGenerated]
		static readonly IntPtr selInitWithURLInSession_ = Selector.GetHandle ("initWithURL:inSession:");
		[CompilerGenerated]
		static readonly IntPtr selInitWithURLPageSizeInSession_ = Selector.GetHandle ("initWithURL:pageSize:inSession:");
		[CompilerGenerated]
		static readonly IntPtr selInitWithSearchQueryInSession_ = Selector.GetHandle ("initWithSearchQuery:inSession:");
		[CompilerGenerated]
		static readonly IntPtr selInitWithSearchQueryPageSizeInSession_ = Selector.GetHandle ("initWithSearchQuery:pageSize:inSession:");
		[CompilerGenerated]
		static readonly IntPtr selAddPageForArtistsAlbumsTracksPlaylists_ = Selector.GetHandle ("addPageForArtists:albums:tracks:playlists:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("SPSearch");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  SPSearch () : base (NSObjectFlag.Empty)
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
			return (SPSearch) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selSearchWithURLInSession_, searchUrl.Handle, aSession.Handle));
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
			ret = (SPSearch) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selSearchWithSearchQueryInSession_, nssearchQuery, aSession.Handle));
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
			ret = (SPSearch) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selLiveSearchWithSearchQueryInSession_, nssearchQuery, aSession.Handle));
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
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithURLInSession_, searchUrl.Handle, aSession.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithURLInSession_, searchUrl.Handle, aSession.Handle);
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
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_int_IntPtr (this.Handle, selInitWithURLPageSizeInSession_, searchURL.Handle, pageSize, aSession.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_int_IntPtr (this.SuperHandle, selInitWithURLPageSizeInSession_, searchURL.Handle, pageSize, aSession.Handle);
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
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithSearchQueryInSession_, nssearchString, aSession.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithSearchQueryInSession_, nssearchString, aSession.Handle);
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
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_int_IntPtr (this.Handle, selInitWithSearchQueryPageSizeInSession_, nssearchString, pageSize, aSession.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_int_IntPtr (this.SuperHandle, selInitWithSearchQueryPageSizeInSession_, nssearchString, pageSize, aSession.Handle);
			}
			NSString.ReleaseNative (nssearchString);
			
		}
		
		[Export ("addPageForArtists:albums:tracks:playlists:")]
		[CompilerGenerated]
		public virtual bool AddPageForArtists (bool artists, bool albums, bool tracks, bool playlists)
		{
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.bool_objc_msgSend_bool_bool_bool_bool (this.Handle, selAddPageForArtistsAlbumsTracksPlaylists_, artists, albums, tracks, playlists);
			} else {
				return ApiDefinition.Messaging.bool_objc_msgSendSuper_bool_bool_bool_bool (this.SuperHandle, selAddPageForArtistsAlbumsTracksPlaylists_, artists, albums, tracks, playlists);
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
		public virtual bool AddAlbumPage {
			[Export ("addAlbumPage")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAddAlbumPage);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selAddAlbumPage);
				}
			}
			
			[Export ("setAddAlbumPage:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAddAlbumPage_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetAddAlbumPage_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool AddArtistPage {
			[Export ("addArtistPage")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAddArtistPage);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selAddArtistPage);
				}
			}
			
			[Export ("setAddArtistPage:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAddArtistPage_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetAddArtistPage_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool AddTrackPage {
			[Export ("addTrackPage")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAddTrackPage);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selAddTrackPage);
				}
			}
			
			[Export ("setAddTrackPage:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAddTrackPage_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetAddTrackPage_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool AddPlaylistPage {
			[Export ("addPlaylistPage")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAddPlaylistPage);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selAddPlaylistPage);
				}
			}
			
			[Export ("setAddPlaylistPage:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAddPlaylistPage_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetAddPlaylistPage_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string SuggestedSearchQuery {
			[Export ("suggestedSearchQuery")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSuggestedSearchQuery));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSuggestedSearchQuery));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool HasExhaustedAlbumResults {
			[Export ("hasExhaustedAlbumResults")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasExhaustedAlbumResults);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selHasExhaustedAlbumResults);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool HasExhaustedArtistResults {
			[Export ("hasExhaustedArtistResults")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasExhaustedArtistResults);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selHasExhaustedArtistResults);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool HasExhaustedTrackResults {
			[Export ("hasExhaustedTrackResults")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasExhaustedTrackResults);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selHasExhaustedTrackResults);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool HasExhaustedPlaylistResults {
			[Export ("hasExhaustedPlaylistResults")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasExhaustedPlaylistResults);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selHasExhaustedPlaylistResults);
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
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAlbums));
				} else {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAlbums));
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
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selArtists));
				} else {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selArtists));
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
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTracks));
				} else {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTracks));
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
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPlaylists));
				} else {
					ret = (NSArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPlaylists));
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
					ret = (NSError) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSearchError));
				} else {
					ret = (NSError) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSearchError));
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
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSearchQuery));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSearchQuery));
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
