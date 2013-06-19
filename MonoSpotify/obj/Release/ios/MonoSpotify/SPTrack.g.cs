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
	[Register("SPTrack", true)]
	public unsafe partial class SPTrack : NSObject {
		[CompilerGenerated]
		const string selIsLoaded = "isLoaded";
		static readonly IntPtr selIsLoadedHandle = Selector.GetHandle ("isLoaded");
		[CompilerGenerated]
		const string selSetLoaded_ = "setLoaded:";
		static readonly IntPtr selSetLoaded_Handle = Selector.GetHandle ("setLoaded:");
		[CompilerGenerated]
		const string selName = "name";
		static readonly IntPtr selNameHandle = Selector.GetHandle ("name");
		[CompilerGenerated]
		const string selSetName_ = "setName:";
		static readonly IntPtr selSetName_Handle = Selector.GetHandle ("setName:");
		[CompilerGenerated]
		const string selSpotifyURL = "spotifyURL";
		static readonly IntPtr selSpotifyURLHandle = Selector.GetHandle ("spotifyURL");
		[CompilerGenerated]
		const string selSetSpotifyURL_ = "setSpotifyURL:";
		static readonly IntPtr selSetSpotifyURL_Handle = Selector.GetHandle ("setSpotifyURL:");
		[CompilerGenerated]
		const string selPlaybackTrack = "playbackTrack";
		static readonly IntPtr selPlaybackTrackHandle = Selector.GetHandle ("playbackTrack");
		[CompilerGenerated]
		const string selSetPlaybackTrack_ = "setPlaybackTrack:";
		static readonly IntPtr selSetPlaybackTrack_Handle = Selector.GetHandle ("setPlaybackTrack:");
		[CompilerGenerated]
		const string selIsLocal = "isLocal";
		static readonly IntPtr selIsLocalHandle = Selector.GetHandle ("isLocal");
		[CompilerGenerated]
		const string selSetLocal_ = "setLocal:";
		static readonly IntPtr selSetLocal_Handle = Selector.GetHandle ("setLocal:");
		[CompilerGenerated]
		const string selSession = "session";
		static readonly IntPtr selSessionHandle = Selector.GetHandle ("session");
		[CompilerGenerated]
		const string selAlbum = "album";
		static readonly IntPtr selAlbumHandle = Selector.GetHandle ("album");
		[CompilerGenerated]
		const string selArtists = "artists";
		static readonly IntPtr selArtistsHandle = Selector.GetHandle ("artists");
		[CompilerGenerated]
		const string selConsolidatedArtists = "consolidatedArtists";
		static readonly IntPtr selConsolidatedArtistsHandle = Selector.GetHandle ("consolidatedArtists");
		[CompilerGenerated]
		const string selDiscNumber = "discNumber";
		static readonly IntPtr selDiscNumberHandle = Selector.GetHandle ("discNumber");
		[CompilerGenerated]
		const string selDuration = "duration";
		static readonly IntPtr selDurationHandle = Selector.GetHandle ("duration");
		[CompilerGenerated]
		const string selPopularity = "popularity";
		static readonly IntPtr selPopularityHandle = Selector.GetHandle ("popularity");
		[CompilerGenerated]
		const string selTrackNumber = "trackNumber";
		static readonly IntPtr selTrackNumberHandle = Selector.GetHandle ("trackNumber");
		[CompilerGenerated]
		const string selTrackForTrackURLInSessionCallback_ = "trackForTrackURL:inSession:callback:";
		static readonly IntPtr selTrackForTrackURLInSessionCallback_Handle = Selector.GetHandle ("trackForTrackURL:inSession:callback:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("SPTrack");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SPTrack () : base (NSObjectFlag.Empty)
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
		public SPTrack (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public SPTrack (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public SPTrack (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("trackForTrackURL:inSession:callback:")]
		[CompilerGenerated]
		public unsafe virtual void TrackForTrackURL (NSUrl trackURL, SPSession aSession, TrackForTrackCallback block)
		{
			if (trackURL == null)
				throw new ArgumentNullException ("trackURL");
			if (aSession == null)
				throw new ArgumentNullException ("aSession");
			if (block == null)
				throw new ArgumentNullException ("block");
			BlockLiteral *block_ptr_block;
			BlockLiteral block_block;
			block_block = new BlockLiteral ();
			block_ptr_block = &block_block;
			block_block.SetupBlock (Trampolines.SDTrackForTrackCallback.Handler, block);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, selTrackForTrackURLInSessionCallback_Handle, trackURL.Handle, aSession.Handle, (IntPtr) block_ptr_block);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, selTrackForTrackURLInSessionCallback_Handle, trackURL.Handle, aSession.Handle, (IntPtr) block_ptr_block);
			}
			block_ptr_block->CleanupBlock ();
			
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
		public virtual string Name {
			[Export ("name")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNameHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selNameHandle));
				}
			}
			
			[Export ("setName:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetName_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetName_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
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
			
			[Export ("setSpotifyURL:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSpotifyURL_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSpotifyURL_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_SpotifyURL_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_PlayableTrack_var;
		[CompilerGenerated]
		public virtual SPTrack PlayableTrack {
			[Export ("playbackTrack")]
			get {
				SPTrack ret;
				if (IsDirectBinding) {
					ret = (SPTrack) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPlaybackTrackHandle));
				} else {
					ret = (SPTrack) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPlaybackTrackHandle));
				}
				MarkDirty ();
				__mt_PlayableTrack_var = ret;
				return ret;
			}
			
			[Export ("setPlaybackTrack:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPlaybackTrack_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPlaybackTrack_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_PlayableTrack_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool Local {
			[Export ("isLocal")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsLocalHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsLocalHandle);
				}
			}
			
			[Export ("setLocal:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetLocal_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetLocal_Handle, value);
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
		object __mt_Album_var;
		[CompilerGenerated]
		public virtual SPAlbum Album {
			[Export ("album")]
			get {
				SPAlbum ret;
				if (IsDirectBinding) {
					ret = (SPAlbum) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAlbumHandle));
				} else {
					ret = (SPAlbum) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAlbumHandle));
				}
				MarkDirty ();
				__mt_Album_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Artists_var;
		[CompilerGenerated]
		public virtual SPArtist[] Artists {
			[Export ("artists")]
			get {
				SPArtist[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoSpotify.SPArtist>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selArtistsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoSpotify.SPArtist>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selArtistsHandle));
				}
				MarkDirty ();
				__mt_Artists_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string ConsolidatedArtists {
			[Export ("consolidatedArtists")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selConsolidatedArtistsHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selConsolidatedArtistsHandle));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int DiscNumber {
			[Export ("discNumber")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selDiscNumberHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selDiscNumberHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.Double Duration {
			[Export ("duration")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selDurationHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.Double_objc_msgSendSuper (this.SuperHandle, selDurationHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int Popularity {
			[Export ("popularity")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selPopularityHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selPopularityHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int TrackNumber {
			[Export ("trackNumber")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selTrackNumberHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selTrackNumberHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_SpotifyURL_var = null;
				__mt_PlayableTrack_var = null;
				__mt_Session_var = null;
				__mt_Album_var = null;
				__mt_Artists_var = null;
			}
		}
	} /* class SPTrack */
	public delegate void TrackForTrackCallback (SPTrack track);
}
