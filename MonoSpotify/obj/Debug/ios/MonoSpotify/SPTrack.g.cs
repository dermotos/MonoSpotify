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
	[Register("SPTrack", true)]
	public unsafe partial class SPTrack : NSObject {
		[CompilerGenerated]
		static readonly IntPtr selIsLoaded = Selector.GetHandle ("isLoaded");
		[CompilerGenerated]
		static readonly IntPtr selSetLoaded_ = Selector.GetHandle ("setLoaded:");
		[CompilerGenerated]
		static readonly IntPtr selName = Selector.GetHandle ("name");
		[CompilerGenerated]
		static readonly IntPtr selSetName_ = Selector.GetHandle ("setName:");
		[CompilerGenerated]
		static readonly IntPtr selSpotifyURL = Selector.GetHandle ("spotifyURL");
		[CompilerGenerated]
		static readonly IntPtr selSetSpotifyURL_ = Selector.GetHandle ("setSpotifyURL:");
		[CompilerGenerated]
		static readonly IntPtr selPlaybackTrack = Selector.GetHandle ("playbackTrack");
		[CompilerGenerated]
		static readonly IntPtr selSetPlaybackTrack_ = Selector.GetHandle ("setPlaybackTrack:");
		[CompilerGenerated]
		static readonly IntPtr selIsLocal = Selector.GetHandle ("isLocal");
		[CompilerGenerated]
		static readonly IntPtr selSetLocal_ = Selector.GetHandle ("setLocal:");
		[CompilerGenerated]
		static readonly IntPtr selSession = Selector.GetHandle ("session");
		[CompilerGenerated]
		static readonly IntPtr selAlbum = Selector.GetHandle ("album");
		[CompilerGenerated]
		static readonly IntPtr selArtists = Selector.GetHandle ("artists");
		[CompilerGenerated]
		static readonly IntPtr selConsolidatedArtists = Selector.GetHandle ("consolidatedArtists");
		[CompilerGenerated]
		static readonly IntPtr selDiscNumber = Selector.GetHandle ("discNumber");
		[CompilerGenerated]
		static readonly IntPtr selDuration = Selector.GetHandle ("duration");
		[CompilerGenerated]
		static readonly IntPtr selPopularity = Selector.GetHandle ("popularity");
		[CompilerGenerated]
		static readonly IntPtr selTrackNumber = Selector.GetHandle ("trackNumber");
		[CompilerGenerated]
		static readonly IntPtr selTrackForTrackURLInSessionCallback_ = Selector.GetHandle ("trackForTrackURL:inSession:callback:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("SPTrack");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  SPTrack () : base (NSObjectFlag.Empty)
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
			block_block.SetupBlock (static_InnerTrackForTrackCallback, block);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, selTrackForTrackURLInSessionCallback_, trackURL.Handle, aSession.Handle, (IntPtr) block_ptr_block);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, selTrackForTrackURLInSessionCallback_, trackURL.Handle, aSession.Handle, (IntPtr) block_ptr_block);
			}
			block_ptr_block->CleanupBlock ();
			
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
		public virtual string Name {
			[Export ("name")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selName));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selName));
				}
			}
			
			[Export ("setName:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetName_, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetName_, nsvalue);
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
					ret = (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSpotifyURL));
				} else {
					ret = (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSpotifyURL));
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
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSpotifyURL_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSpotifyURL_, value.Handle);
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
					ret = (SPTrack) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPlaybackTrack));
				} else {
					ret = (SPTrack) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPlaybackTrack));
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
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPlaybackTrack_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPlaybackTrack_, value.Handle);
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
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsLocal);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsLocal);
				}
			}
			
			[Export ("setLocal:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetLocal_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetLocal_, value);
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
		object __mt_Album_var;
		[CompilerGenerated]
		public virtual SPAlbum Album {
			[Export ("album")]
			get {
				SPAlbum ret;
				if (IsDirectBinding) {
					ret = (SPAlbum) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAlbum));
				} else {
					ret = (SPAlbum) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAlbum));
				}
				MarkDirty ();
				__mt_Album_var = ret;
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
		public virtual string ConsolidatedArtists {
			[Export ("consolidatedArtists")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selConsolidatedArtists));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selConsolidatedArtists));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int DiscNumber {
			[Export ("discNumber")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selDiscNumber);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selDiscNumber);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.Double Duration {
			[Export ("duration")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selDuration);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.Double_objc_msgSendSuper (this.SuperHandle, selDuration);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int Popularity {
			[Export ("popularity")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selPopularity);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selPopularity);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int TrackNumber {
			[Export ("trackNumber")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selTrackNumber);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selTrackNumber);
				}
			}
			
		}
		
		internal delegate void InnerTrackForTrackCallback (IntPtr block, IntPtr track);
		[CompilerGenerated]
		static readonly InnerTrackForTrackCallback static_InnerTrackForTrackCallback = TrampolineTrackForTrackCallback;
		[MonoPInvokeCallback (typeof (InnerTrackForTrackCallback))]
		static unsafe void TrampolineTrackForTrackCallback (IntPtr block, IntPtr track) {
			var descriptor = (BlockLiteral *) block;
			var del = (global::MonoSpotify.TrackForTrackCallback) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ((MonoSpotify.SPTrack) Runtime.GetNSObject (track));
		}
		
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
