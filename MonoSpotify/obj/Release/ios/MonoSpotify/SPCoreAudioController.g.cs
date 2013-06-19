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
	[Register("SPCoreAudioController", true)]
	public unsafe partial class SPCoreAudioController : NSObject {
		[CompilerGenerated]
		const string selVolume = "volume";
		static readonly IntPtr selVolumeHandle = Selector.GetHandle ("volume");
		[CompilerGenerated]
		const string selSetVolume_ = "setVolume:";
		static readonly IntPtr selSetVolume_Handle = Selector.GetHandle ("setVolume:");
		[CompilerGenerated]
		const string selAudioOutputEnabled = "audioOutputEnabled";
		static readonly IntPtr selAudioOutputEnabledHandle = Selector.GetHandle ("audioOutputEnabled");
		[CompilerGenerated]
		const string selSetAudioOutputEnabled_ = "setAudioOutputEnabled:";
		static readonly IntPtr selSetAudioOutputEnabled_Handle = Selector.GetHandle ("setAudioOutputEnabled:");
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selSessionShouldDeliverAudioFramesOfCountStreamDescription_ = "session:shouldDeliverAudioFrames:ofCount:streamDescription:";
		static readonly IntPtr selSessionShouldDeliverAudioFramesOfCountStreamDescription_Handle = Selector.GetHandle ("session:shouldDeliverAudioFrames:ofCount:streamDescription:");
		[CompilerGenerated]
		const string selClearAudioBuffers = "clearAudioBuffers";
		static readonly IntPtr selClearAudioBuffersHandle = Selector.GetHandle ("clearAudioBuffers");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("SPCoreAudioController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SPCoreAudioController () : base (NSObjectFlag.Empty)
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
		public SPCoreAudioController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public SPCoreAudioController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public SPCoreAudioController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("session:shouldDeliverAudioFrames:ofCount:streamDescription:")]
		[CompilerGenerated]
		public virtual int ShouldDeliverAudioFrames (SPSessionPlaybackProvider aSession, NSObject audioFrames, int frameCount, NSObject audioStreamBasicDescription)
		{
			if (aSession == null)
				throw new ArgumentNullException ("aSession");
			if (audioFrames == null)
				throw new ArgumentNullException ("audioFrames");
			if (audioStreamBasicDescription == null)
				throw new ArgumentNullException ("audioStreamBasicDescription");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend_IntPtr_IntPtr_int_IntPtr (this.Handle, selSessionShouldDeliverAudioFramesOfCountStreamDescription_Handle, aSession.Handle, audioFrames.Handle, frameCount, audioStreamBasicDescription.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper_IntPtr_IntPtr_int_IntPtr (this.SuperHandle, selSessionShouldDeliverAudioFramesOfCountStreamDescription_Handle, aSession.Handle, audioFrames.Handle, frameCount, audioStreamBasicDescription.Handle);
			}
		}
		
		[Export ("clearAudioBuffers")]
		[CompilerGenerated]
		public virtual void ClearAudioBuffers ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selClearAudioBuffersHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selClearAudioBuffersHandle);
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
		public virtual bool AudioOutputEnabled {
			[Export ("audioOutputEnabled")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAudioOutputEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selAudioOutputEnabledHandle);
				}
			}
			
			[Export ("setAudioOutputEnabled:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAudioOutputEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetAudioOutputEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual SPCoreAudioControllerDelegate Delegate {
			[Export ("delegate")]
			get {
				SPCoreAudioControllerDelegate ret;
				if (IsDirectBinding) {
					ret = (SPCoreAudioControllerDelegate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegateHandle));
				} else {
					ret = (SPCoreAudioControllerDelegate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegateHandle));
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
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Delegate_var = null;
			}
		}
	} /* class SPCoreAudioController */
}
