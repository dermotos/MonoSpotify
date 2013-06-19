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
	[Register("SPPlaybackManager", true)]
	public unsafe partial class SPPlaybackManager : NSObject {
		[CompilerGenerated]
		static readonly IntPtr selCurrentTrack = Selector.GetHandle ("currentTrack");
		[CompilerGenerated]
		static readonly IntPtr selDelegate = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		static readonly IntPtr selSetDelegate_ = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		static readonly IntPtr selPlaybackSession = Selector.GetHandle ("playbackSession");
		[CompilerGenerated]
		static readonly IntPtr selIsPlaying = Selector.GetHandle ("isPlaying");
		[CompilerGenerated]
		static readonly IntPtr selSetIsPlaying_ = Selector.GetHandle ("setIsPlaying:");
		[CompilerGenerated]
		static readonly IntPtr selTrackPosition = Selector.GetHandle ("trackPosition");
		[CompilerGenerated]
		static readonly IntPtr selVolume = Selector.GetHandle ("volume");
		[CompilerGenerated]
		static readonly IntPtr selSetVolume_ = Selector.GetHandle ("setVolume:");
		[CompilerGenerated]
		static readonly IntPtr selSessionDidLosePlayToken_ = Selector.GetHandle ("sessionDidLosePlayToken:");
		[CompilerGenerated]
		static readonly IntPtr selSessionDidEndPlayback_ = Selector.GetHandle ("sessionDidEndPlayback:");
		[CompilerGenerated]
		static readonly IntPtr selSessionDidEncounterStreamingError_ = Selector.GetHandle ("session:didEncounterStreamingError:");
		[CompilerGenerated]
		static readonly IntPtr selSessionShouldDeliverAudioFramesOfCountFormat_ = Selector.GetHandle ("session:shouldDeliverAudioFrames:ofCount:format:");
		[CompilerGenerated]
		static readonly IntPtr selCoreAudioControllerDidOutputAudioOfDuration_ = Selector.GetHandle ("coreAudioController:didOutputAudioOfDuration:");
		[CompilerGenerated]
		static readonly IntPtr selInitWithPlaybackSession_ = Selector.GetHandle ("initWithPlaybackSession:");
		[CompilerGenerated]
		static readonly IntPtr selInitWithAudioControllerPlaybackSession_ = Selector.GetHandle ("initWithAudioController:playbackSession:");
		[CompilerGenerated]
		static readonly IntPtr selPlayTrackCallback_ = Selector.GetHandle ("playTrack:callback:");
		[CompilerGenerated]
		static readonly IntPtr selSeekToTrackPosition_ = Selector.GetHandle ("seekToTrackPosition:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("SPPlaybackManager");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  SPPlaybackManager () : base (NSObjectFlag.Empty)
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
		public SPPlaybackManager (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public SPPlaybackManager (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public SPPlaybackManager (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}
		[Export ("sessionDidLosePlayToken:")]
		[CompilerGenerated]
		public virtual void SessionDidLosePlayToken (NSObject aSession)
		{
			if (aSession == null)
				throw new ArgumentNullException ("aSession");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSessionDidLosePlayToken_, aSession.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSessionDidLosePlayToken_, aSession.Handle);
			}
		}
		
		[Export ("sessionDidEndPlayback:")]
		[CompilerGenerated]
		public virtual void SessionDidEndPlayback (NSObject aSession)
		{
			if (aSession == null)
				throw new ArgumentNullException ("aSession");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSessionDidEndPlayback_, aSession.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSessionDidEndPlayback_, aSession.Handle);
			}
		}
		
		[Export ("session:didEncounterStreamingError:")]
		[CompilerGenerated]
		public virtual void SessionDidEncounterStreamingError (NSObject aSession, NSError error)
		{
			if (aSession == null)
				throw new ArgumentNullException ("aSession");
			if (error == null)
				throw new ArgumentNullException ("error");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSessionDidEncounterStreamingError_, aSession.Handle, error.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSessionDidEncounterStreamingError_, aSession.Handle, error.Handle);
			}
		}
		
		[Export ("session:shouldDeliverAudioFrames:ofCount:format:")]
		[CompilerGenerated]
		public virtual int SessionShouldDeliverAudioFrames (NSObject aSession, NSObject audioFrames, int frameCount, sp_audioformat audioFormat)
		{
			if (aSession == null)
				throw new ArgumentNullException ("aSession");
			if (audioFrames == null)
				throw new ArgumentNullException ("audioFrames");
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.int_objc_msgSend_IntPtr_IntPtr_int_sp_audioformat (this.Handle, selSessionShouldDeliverAudioFramesOfCountFormat_, aSession.Handle, audioFrames.Handle, frameCount, audioFormat);
			} else {
				return ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr_IntPtr_int_sp_audioformat (this.SuperHandle, selSessionShouldDeliverAudioFramesOfCountFormat_, aSession.Handle, audioFrames.Handle, frameCount, audioFormat);
			}
		}
		
		[Export ("coreAudioController:didOutputAudioOfDuration:")]
		[CompilerGenerated]
		public virtual void CoreAudioControllerDidOutputAudio (SPCoreAudioController controller, global::System.Double duration)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_Double (this.Handle, selCoreAudioControllerDidOutputAudioOfDuration_, controller.Handle, duration);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_Double (this.SuperHandle, selCoreAudioControllerDidOutputAudioOfDuration_, controller.Handle, duration);
			}
		}
		
		[Export ("initWithPlaybackSession:")]
		[CompilerGenerated]
		public SPPlaybackManager (SPSession aSession)
			: base (NSObjectFlag.Empty)
		{
			if (aSession == null)
				throw new ArgumentNullException ("aSession");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithPlaybackSession_, aSession.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithPlaybackSession_, aSession.Handle);
			}
		}
		
		[Export ("initWithAudioController:playbackSession:")]
		[CompilerGenerated]
		public SPPlaybackManager (SPCoreAudioController aController, SPSession aSession)
			: base (NSObjectFlag.Empty)
		{
			if (aController == null)
				throw new ArgumentNullException ("aController");
			if (aSession == null)
				throw new ArgumentNullException ("aSession");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithAudioControllerPlaybackSession_, aController.Handle, aSession.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithAudioControllerPlaybackSession_, aController.Handle, aSession.Handle);
			}
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
		
		[Export ("seekToTrackPosition:")]
		[CompilerGenerated]
		public virtual void SeekToTrackPosition (global::System.Double newPosition)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSeekToTrackPosition_, newPosition);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, selSeekToTrackPosition_, newPosition);
			}
		}
		
		[CompilerGenerated]
		object __mt_CurrentTrack_var;
		[CompilerGenerated]
		public virtual SPTrack CurrentTrack {
			[Export ("currentTrack")]
			get {
				SPTrack ret;
				if (IsDirectBinding) {
					ret = (SPTrack) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCurrentTrack));
				} else {
					ret = (SPTrack) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCurrentTrack));
				}
				MarkDirty ();
				__mt_CurrentTrack_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual SPPlaybackManagerDelegate Delegate {
			[Export ("delegate")]
			get {
				SPPlaybackManagerDelegate ret;
				if (IsDirectBinding) {
					ret = (SPPlaybackManagerDelegate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegate));
				} else {
					ret = (SPPlaybackManagerDelegate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegate));
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
		object __mt_PlaybackSession_var;
		[CompilerGenerated]
		public virtual SPSession PlaybackSession {
			[Export ("playbackSession")]
			get {
				SPSession ret;
				if (IsDirectBinding) {
					ret = (SPSession) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPlaybackSession));
				} else {
					ret = (SPSession) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPlaybackSession));
				}
				MarkDirty ();
				__mt_PlaybackSession_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsPlaying {
			[Export ("isPlaying")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsPlaying);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsPlaying);
				}
			}
			
			[Export ("setIsPlaying:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetIsPlaying_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetIsPlaying_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Double TrackPosition {
			[Export ("trackPosition")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selTrackPosition);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.Double_objc_msgSendSuper (this.SuperHandle, selTrackPosition);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.Double Volume {
			[Export ("volume")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selVolume);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.Double_objc_msgSendSuper (this.SuperHandle, selVolume);
				}
			}
			
			[Export ("setVolume:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetVolume_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, selSetVolume_, value);
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
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_CurrentTrack_var = null;
				__mt_Delegate_var = null;
				__mt_PlaybackSession_var = null;
			}
		}
	} /* class SPPlaybackManager */
}
