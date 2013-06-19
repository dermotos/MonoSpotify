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
	[Register("SPCircularBuffer", true)]
	public unsafe partial class SPCircularBuffer : NSObject {
		[CompilerGenerated]
		const string selLength = "length";
		static readonly IntPtr selLengthHandle = Selector.GetHandle ("length");
		[CompilerGenerated]
		const string selInitWithMaximumLength_ = "initWithMaximumLength:";
		static readonly IntPtr selInitWithMaximumLength_Handle = Selector.GetHandle ("initWithMaximumLength:");
		[CompilerGenerated]
		const string selClear = "clear";
		static readonly IntPtr selClearHandle = Selector.GetHandle ("clear");
		[CompilerGenerated]
		const string selAttemptAppendDataOfLength_ = "attemptAppendData:ofLength:";
		static readonly IntPtr selAttemptAppendDataOfLength_Handle = Selector.GetHandle ("attemptAppendData:ofLength:");
		[CompilerGenerated]
		const string selReadDataOfLengthIntoAllocatedBuffer_ = "readDataOfLength:intoAllocatedBuffer:";
		static readonly IntPtr selReadDataOfLengthIntoAllocatedBuffer_Handle = Selector.GetHandle ("readDataOfLength:intoAllocatedBuffer:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("SPCircularBuffer");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SPCircularBuffer () : base (NSObjectFlag.Empty)
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
		public SPCircularBuffer (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public SPCircularBuffer (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public SPCircularBuffer (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithMaximumLength:")]
		[CompilerGenerated]
		public SPCircularBuffer (global::System.UInt32 size)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selInitWithMaximumLength_Handle, size);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selInitWithMaximumLength_Handle, size);
			}
		}
		
		[Export ("clear")]
		[CompilerGenerated]
		public virtual void Clear ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selClearHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selClearHandle);
			}
		}
		
		[Export ("attemptAppendData:ofLength:")]
		[CompilerGenerated]
		public virtual global::System.UInt32 AttemptAppendData (NSObject data, global::System.UInt32 length)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.UInt32_objc_msgSend_IntPtr_UInt32 (this.Handle, selAttemptAppendDataOfLength_Handle, data.Handle, length);
			} else {
				return ApiDefinition.Messaging.UInt32_objc_msgSendSuper_IntPtr_UInt32 (this.SuperHandle, selAttemptAppendDataOfLength_Handle, data.Handle, length);
			}
		}
		
		[Export ("readDataOfLength:intoAllocatedBuffer:")]
		[CompilerGenerated]
		public virtual global::System.UInt32 ReadData (global::System.UInt32 desiredLength, NSObject outBuffer)
		{
			if (outBuffer == null)
				throw new ArgumentNullException ("outBuffer");
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.UInt32_objc_msgSend_UInt32_IntPtr (this.Handle, selReadDataOfLengthIntoAllocatedBuffer_Handle, desiredLength, outBuffer.Handle);
			} else {
				return ApiDefinition.Messaging.UInt32_objc_msgSendSuper_UInt32_IntPtr (this.SuperHandle, selReadDataOfLengthIntoAllocatedBuffer_Handle, desiredLength, outBuffer.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 Length {
			[Export ("length")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selLengthHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selLengthHandle);
				}
			}
			
		}
		
	} /* class SPCircularBuffer */
}
