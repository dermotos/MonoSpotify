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
	[Register("SPAsyncLoading", true)]
	public unsafe partial class SPAsyncLoading : NSObject {
		[CompilerGenerated]
		const string selWaitUntilLoadedTimeoutThen_ = "waitUntilLoaded:timeout:then:";
		static readonly IntPtr selWaitUntilLoadedTimeoutThen_Handle = Selector.GetHandle ("waitUntilLoaded:timeout:then:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("SPAsyncLoading");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SPAsyncLoading () : base (NSObjectFlag.Empty)
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
		public SPAsyncLoading (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public SPAsyncLoading (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public SPAsyncLoading (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("waitUntilLoaded:timeout:then:")]
		[CompilerGenerated]
		public unsafe static void WaitUntilLoaded (NSObject[] objects, global::System.Double timeout, LoadingCompleteCallback callback)
		{
			if (objects == null)
				throw new ArgumentNullException ("objects");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			var nsa_objects = NSArray.FromNSObjects (objects);
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDLoadingCompleteCallback.Handler, callback);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_Double_IntPtr (class_ptr, selWaitUntilLoadedTimeoutThen_Handle, nsa_objects.Handle, timeout, (IntPtr) block_ptr_callback);
			nsa_objects.Dispose ();
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("waitUntilLoaded:timeout:then:")]
		[CompilerGenerated]
		public unsafe static void WaitUntilLoaded (SPTrack track, global::System.Double timeout, LoadingCompleteCallback callback)
		{
			if (track == null)
				throw new ArgumentNullException ("track");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDLoadingCompleteCallback.Handler, callback);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_Double_IntPtr (class_ptr, selWaitUntilLoadedTimeoutThen_Handle, track.Handle, timeout, (IntPtr) block_ptr_callback);
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("waitUntilLoaded:timeout:then:")]
		[CompilerGenerated]
		public unsafe static void WaitUntilLoaded (SPTrack[] tracks, global::System.Double timeout, LoadingCompleteCallback callback)
		{
			if (tracks == null)
				throw new ArgumentNullException ("tracks");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			var nsa_tracks = NSArray.FromNSObjects (tracks);
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDLoadingCompleteCallback.Handler, callback);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_Double_IntPtr (class_ptr, selWaitUntilLoadedTimeoutThen_Handle, nsa_tracks.Handle, timeout, (IntPtr) block_ptr_callback);
			nsa_tracks.Dispose ();
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("waitUntilLoaded:timeout:then:")]
		[CompilerGenerated]
		public unsafe static void WaitUntilLoaded (SPPlaylist playlist, global::System.Double timeout, LoadingCompleteCallback callback)
		{
			if (playlist == null)
				throw new ArgumentNullException ("playlist");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDLoadingCompleteCallback.Handler, callback);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_Double_IntPtr (class_ptr, selWaitUntilLoadedTimeoutThen_Handle, playlist.Handle, timeout, (IntPtr) block_ptr_callback);
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("waitUntilLoaded:timeout:then:")]
		[CompilerGenerated]
		public unsafe static void WaitUntilLoaded (SPPlaylist[] playlists, global::System.Double timeout, LoadingCompleteCallback callback)
		{
			if (playlists == null)
				throw new ArgumentNullException ("playlists");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			var nsa_playlists = NSArray.FromNSObjects (playlists);
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDLoadingCompleteCallback.Handler, callback);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_Double_IntPtr (class_ptr, selWaitUntilLoadedTimeoutThen_Handle, nsa_playlists.Handle, timeout, (IntPtr) block_ptr_callback);
			nsa_playlists.Dispose ();
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("waitUntilLoaded:timeout:then:")]
		[CompilerGenerated]
		public unsafe static void WaitUntilLoaded (SPPlaylistContainer playlistContainer, global::System.Double timeout, LoadingCompleteCallback callback)
		{
			if (playlistContainer == null)
				throw new ArgumentNullException ("playlistContainer");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDLoadingCompleteCallback.Handler, callback);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_Double_IntPtr (class_ptr, selWaitUntilLoadedTimeoutThen_Handle, playlistContainer.Handle, timeout, (IntPtr) block_ptr_callback);
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("waitUntilLoaded:timeout:then:")]
		[CompilerGenerated]
		public unsafe static void WaitUntilLoaded (SPPlaylistContainer[] playlistContainers, global::System.Double timeout, LoadingCompleteCallback callback)
		{
			if (playlistContainers == null)
				throw new ArgumentNullException ("playlistContainers");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			var nsa_playlistContainers = NSArray.FromNSObjects (playlistContainers);
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDLoadingCompleteCallback.Handler, callback);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_Double_IntPtr (class_ptr, selWaitUntilLoadedTimeoutThen_Handle, nsa_playlistContainers.Handle, timeout, (IntPtr) block_ptr_callback);
			nsa_playlistContainers.Dispose ();
			block_ptr_callback->CleanupBlock ();
			
		}
		
	} /* class SPAsyncLoading */
	public delegate void LoadingCompleteCallback (NSObject[] loadedItems, NSObject[] notLoadedItems);
}
