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
	[Register("SPAsyncLoading", true)]
	public unsafe partial class SPAsyncLoading : NSObject {
		[CompilerGenerated]
		static readonly IntPtr selWaitUntilLoadedTimeoutThen_ = Selector.GetHandle ("waitUntilLoaded:timeout:then:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("SPAsyncLoading");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  SPAsyncLoading () : base (NSObjectFlag.Empty)
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
			block_callback.SetupBlock (static_InnerLoadingCompleteCallback, callback);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_Double_IntPtr (class_ptr, selWaitUntilLoadedTimeoutThen_, track.Handle, timeout, (IntPtr) block_ptr_callback);
			block_ptr_callback->CleanupBlock ();
			
		}
		
		internal delegate void InnerLoadingCompleteCallback (IntPtr block, IntPtr loadedItems, IntPtr notLoadedItems);
		[CompilerGenerated]
		static readonly InnerLoadingCompleteCallback static_InnerLoadingCompleteCallback = TrampolineLoadingCompleteCallback;
		[MonoPInvokeCallback (typeof (InnerLoadingCompleteCallback))]
		static unsafe void TrampolineLoadingCompleteCallback (IntPtr block, IntPtr loadedItems, IntPtr notLoadedItems) {
			var descriptor = (BlockLiteral *) block;
			var del = (global::MonoSpotify.LoadingCompleteCallback) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del (NSArray.ArrayFromHandle<global::MonoSpotify.SPTrack> (loadedItems), NSArray.ArrayFromHandle<global::MonoSpotify.SPTrack> (notLoadedItems));
		}
		
	} /* class SPAsyncLoading */
	public delegate void LoadingCompleteCallback (SPTrack[] loadedItems, SPTrack[] notLoadedItems);
}
