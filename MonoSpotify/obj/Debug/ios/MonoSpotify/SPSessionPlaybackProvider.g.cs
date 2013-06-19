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
	[Register("SPSessionPlaybackProvider", true)]
	[Model]
	public unsafe partial class SPSessionPlaybackProvider : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("NSObject");
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  SPSessionPlaybackProvider () : base (NSObjectFlag.Empty)
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
		public SPSessionPlaybackProvider (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public SPSessionPlaybackProvider (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public SPSessionPlaybackProvider (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}
		[Export ("preloadTrackForPlayback:callback:")]
		[CompilerGenerated]
		public unsafe virtual void PreloadtrackForPlayback (SPTrack aTrack, SPErrorableOperationCallback callback)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("playTrack:callback:")]
		[CompilerGenerated]
		public unsafe virtual void PlayTrack (SPTrack aTrack, SPErrorableOperationCallback callback)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("seekPlaybackToOffset:")]
		[CompilerGenerated]
		public virtual void SeekPlaybackToOffset (global::System.Double offset)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("unloadPlayback")]
		[CompilerGenerated]
		public virtual void UnloadPlayback ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[CompilerGenerated]
		public virtual bool Playing {
			[Export ("isPlaying")]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setPlaying:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
		[CompilerGenerated]
		public virtual SPSessionPlaybackDelegate PlaybackDelegate {
			[Export ("playbackDelegate")]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setPlaybackDelegate:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
		[CompilerGenerated]
		public virtual SPSessionAudioDeliveryDelegate AudioDeliveryDelegate {
			[Export ("audioDeliveryDelegate")]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setAudioDeliveryDelegate:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
	} /* class SPSessionPlaybackProvider */
}
