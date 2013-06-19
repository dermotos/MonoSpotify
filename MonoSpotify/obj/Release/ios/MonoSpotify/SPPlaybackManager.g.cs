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
	[Register("SPPlaybackManager", true)]
	public unsafe partial class SPPlaybackManager : NSObject {
		[CompilerGenerated]
		const string selCurrentTrack = "currentTrack";
		static readonly IntPtr selCurrentTrackHandle = Selector.GetHandle ("currentTrack");
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selPlaybackSession = "playbackSession";
		static readonly IntPtr selPlaybackSessionHandle = Selector.GetHandle ("playbackSession");
		[CompilerGenerated]
		const string selIsPlaying = "isPlaying";
		static readonly IntPtr selIsPlayingHandle = Selector.GetHandle ("isPlaying");
		[CompilerGenerated]
		const string selSetIsPlaying_ = "setIsPlaying:";
		static readonly IntPtr selSetIsPlaying_Handle = Selector.GetHandle ("setIsPlaying:");
		[CompilerGenerated]
		const string selTrackPosition = "trackPosition";
		static readonly IntPtr selTrackPositionHandle = Selector.GetHandle ("trackPosition");
		[CompilerGenerated]
		const string selVolume = "volume";
		static readonly IntPtr selVolumeHandle = Selector.GetHandle ("volume");
		[CompilerGenerated]
		const string selSetVolume_ = "setVolume:";
		static readonly IntPtr selSetVolume_Handle = Selector.GetHandle ("setVolume:");
		[CompilerGenerated]
		const string selSessionDidLosePlayToken_ = "sessionDidLosePlayToken:";
		static readonly IntPtr selSessionDidLosePlayToken_Handle = Selector.GetHandle ("sessionDidLosePlayToken:");
		[CompilerGenerated]
		const string selSessionDidEndPlayback_ = "sessionDidEndPlayback:";
		static readonly IntPtr selSessionDidEndPlayback_Handle = Selector.GetHandle ("sessionDidEndPlayback:");
		[CompilerGenerated]
		const string selSessionDidEncounterStreamingError_ = "session:didEncounterStreamingError:";
		static readonly IntPtr selSessionDidEncounterStreamingError_Handle = Selector.GetHandle ("session:didEncounterStreamingError:");
		[CompilerGenerated]
		const string selSessionShouldDeliverAudioFramesOfCountFormat_ = "session:shouldDeliverAudioFrames:ofCount:format:";
		static readonly IntPtr selSessionShouldDeliverAudioFramesOfCountFormat_Handle = Selector.GetHandle ("session:shouldDeliverAudioFrames:ofCount:format:");
		[CompilerGenerated]
		const string selCoreAudioControllerDidOutputAudioOfDuration_ = "coreAudioController:didOutputAudioOfDuration:";
		static readonly IntPtr selCoreAudioControllerDidOutputAudioOfDuration_Handle = Selector.GetHandle ("coreAudioController:didOutputAudioOfDuration:");
		[CompilerGenerated]
		const string selInitWithPlaybackSession_ = "initWithPlaybackSession:";
		static readonly IntPtr selInitWithPlaybackSession_Handle = Selector.GetHandle ("initWithPlaybackSession:");
		[CompilerGenerated]
		const string selInitWithAudioControllerPlaybackSession_ = "initWithAudioController:playbackSession:";
		static readonly IntPtr selInitWithAudioControllerPlaybackSession_Handle = Selector.GetHandle ("initWithAudioController:playbackSession:");
		[CompilerGenerated]
		const string selPlayTrackCallback_ = "playTrack:callback:";
		static readonly IntPtr selPlayTrackCallback_Handle = Selector.GetHandle ("playTrack:callback:");
		[CompilerGenerated]
		const string selSeekToTrackPosition_ = "seekToTrackPosition:";
		static readonly IntPtr selSeekToTrackPosition_Handle = Selector.GetHandle ("seekToTrackPosition:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("SPPlaybackManager");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SPPlaybackManager () : base (NSObjectFlag.Empty)
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
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSessionDidLosePlayToken_Handle, aSession.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSessionDidLosePlayToken_Handle, aSession.Handle);
			}
		}
		
		[Export ("sessionDidEndPlayback:")]
		[CompilerGenerated]
		public virtual void SessionDidEndPlayback (NSObject aSession)
		{
			if (aSession == null)
				throw new ArgumentNullException ("aSession");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSessionDidEndPlayback_Handle, aSession.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSessionDidEndPlayback_Handle, aSession.Handle);
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
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSessionDidEncounterStreamingError_Handle, aSession.Handle, error.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSessionDidEncounterStreamingError_Handle, aSession.Handle, error.Handle);
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
				return ApiDefinition.Messaging.int_objc_msgSend_IntPtr_IntPtr_int_sp_audioformat (this.Handle, selSessionShouldDeliverAudioFramesOfCountFormat_Handle, aSession.Handle, audioFrames.Handle, frameCount, audioFormat);
			} else {
				return ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr_IntPtr_int_sp_audioformat (this.SuperHandle, selSessionShouldDeliverAudioFramesOfCountFormat_Handle, aSession.Handle, audioFrames.Handle, frameCount, audioFormat);
			}
		}
		
		[Export ("coreAudioController:didOutputAudioOfDuration:")]
		[CompilerGenerated]
		public virtual void CoreAudioControllerDidOutputAudio (SPCoreAudioController controller, global::System.Double duration)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_Double (this.Handle, selCoreAudioControllerDidOutputAudioOfDuration_Handle, controller.Handle, duration);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_Double (this.SuperHandle, selCoreAudioControllerDidOutputAudioOfDuration_Handle, controller.Handle, duration);
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
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithPlaybackSession_Handle, aSession.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithPlaybackSession_Handle, aSession.Handle);
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
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithAudioControllerPlaybackSession_Handle, aController.Handle, aSession.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithAudioControllerPlaybackSession_Handle, aController.Handle, aSession.Handle);
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
			block_callback.SetupBlock (Trampolines.SDSPErrorableOperationCallback.Handler, callback);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selPlayTrackCallback_Handle, aTrack.Handle, (IntPtr) block_ptr_callback);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selPlayTrackCallback_Handle, aTrack.Handle, (IntPtr) block_ptr_callback);
			}
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("seekToTrackPosition:")]
		[CompilerGenerated]
		public virtual void SeekToTrackPosition (global::System.Double newPosition)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSeekToTrackPosition_Handle, newPosition);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, selSeekToTrackPosition_Handle, newPosition);
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
					ret = (SPTrack) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCurrentTrackHandle));
				} else {
					ret = (SPTrack) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCurrentTrackHandle));
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
					ret = (SPPlaybackManagerDelegate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegateHandle));
				} else {
					ret = (SPPlaybackManagerDelegate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegateHandle));
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
		object __mt_PlaybackSession_var;
		[CompilerGenerated]
		public virtual SPSession PlaybackSession {
			[Export ("playbackSession")]
			get {
				SPSession ret;
				if (IsDirectBinding) {
					ret = (SPSession) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPlaybackSessionHandle));
				} else {
					ret = (SPSession) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPlaybackSessionHandle));
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
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsPlayingHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsPlayingHandle);
				}
			}
			
			[Export ("setIsPlaying:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetIsPlaying_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetIsPlaying_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Double TrackPosition {
			[Export ("trackPosition")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selTrackPositionHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.Double_objc_msgSendSuper (this.SuperHandle, selTrackPositionHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.Double Volume {
			[Export ("volume")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selVolumeHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.Double_objc_msgSendSuper (this.SuperHandle, selVolumeHandle);
				}
			}
			
			[Export ("setVolume:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetVolume_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, selSetVolume_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
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
