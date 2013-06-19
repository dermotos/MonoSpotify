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
	[Register("SPSessionDelegate", true)]
	[Model]
	public unsafe partial class SPSessionDelegate : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("NSObject");
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SPSessionDelegate () : base (NSObjectFlag.Empty)
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
		public SPSessionDelegate (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public SPSessionDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public SPSessionDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("sessionDidLoginSuccessfully:")]
		[CompilerGenerated]
		public virtual void SessionDidLoginSuccessfully (SPSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("session:didGenerateLoginCredentials:forUserName:")]
		[CompilerGenerated]
		public virtual void SessionDidGenerateLoginCredentials (SPSession currentSession, string credential, string username)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("session:didFailToLoginWithError:")]
		[CompilerGenerated]
		public virtual void SessionFailedToLogin (SPSession session, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("sessionDidLogOut:")]
		[CompilerGenerated]
		public virtual void SessionLoggedOut (SPSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("session:recievedMessageForUser:")]
		[CompilerGenerated]
		public virtual void SessionReceivedMessage (SPSession session, string message)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("sessionDidChangeMetadata:")]
		[CompilerGenerated]
		public virtual void SessionChangedMetaData (SPSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("session:didEncounterNetworkError:")]
		[CompilerGenerated]
		public virtual void SessionEncounteredNetworkError (SPSession session, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("session:didEncounterScrobblingError:")]
		[CompilerGenerated]
		public virtual void SessionEncounteredScrobblingError (SPSession session, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("session:didLogMessage:")]
		[CompilerGenerated]
		public virtual void SessionLoggedMessage (SPSession session, string message)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("viewControllerToPresentLoginViewForSession:")]
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIViewController ViewControllerToPresentLoginView (SPSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class SPSessionDelegate */
}
