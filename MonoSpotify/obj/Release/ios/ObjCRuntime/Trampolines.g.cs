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

namespace MonoTouch {
	
	[CompilerGenerated]
	static class Trampolines {
		
		internal delegate void DSPErrorableOperationCallback (IntPtr block, IntPtr error);
		
		static internal class SDSPErrorableOperationCallback {
			
			static internal readonly DSPErrorableOperationCallback Handler = TSPErrorableOperationCallback;
			
			[MonoPInvokeCallback (typeof (DSPErrorableOperationCallback))]
			static unsafe void TSPErrorableOperationCallback (IntPtr block, IntPtr error) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::MonoSpotify.SPErrorableOperationCallback) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
				if (del != null)
					del ((MonoTouch.Foundation.NSError) Runtime.GetNSObject (error));
			}
		}
		
		internal delegate void DDispatchBlockT (IntPtr block);
		
		static internal class SDDispatchBlockT {
			
			static internal readonly DDispatchBlockT Handler = TDispatchBlockT;
			
			[MonoPInvokeCallback (typeof (DDispatchBlockT))]
			static unsafe void TDispatchBlockT (IntPtr block) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::MonoSpotify.DispatchBlockT) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
				if (del != null)
					del ();
			}
		}
		
		internal delegate void DLoginFetcher (IntPtr block, IntPtr loginUserName);
		
		static internal class SDLoginFetcher {
			
			static internal readonly DLoginFetcher Handler = TLoginFetcher;
			
			[MonoPInvokeCallback (typeof (DLoginFetcher))]
			static unsafe void TLoginFetcher (IntPtr block, IntPtr loginUserName) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::MonoSpotify.LoginFetcher) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
				if (del != null)
					del (NSString.FromHandle (loginUserName));
			}
		}
		
		internal delegate void DCompletionBlock (IntPtr block);
		
		static internal class SDCompletionBlock {
			
			static internal readonly DCompletionBlock Handler = TCompletionBlock;
			
			[MonoPInvokeCallback (typeof (DCompletionBlock))]
			static unsafe void TCompletionBlock (IntPtr block) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::MonoSpotify.CompletionBlock) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
				if (del != null)
					del ();
			}
		}
		
		internal delegate void DSPAlbumCallback (IntPtr block, IntPtr album);
		
		static internal class SDSPAlbumCallback {
			
			static internal readonly DSPAlbumCallback Handler = TSPAlbumCallback;
			
			[MonoPInvokeCallback (typeof (DSPAlbumCallback))]
			static unsafe void TSPAlbumCallback (IntPtr block, IntPtr album) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::MonoSpotify.SPAlbumCallback) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
				if (del != null)
					del ((MonoSpotify.SPAlbum) Runtime.GetNSObject (album));
			}
		}
		
		internal delegate void DSPArtistCallback (IntPtr block, IntPtr artist);
		
		static internal class SDSPArtistCallback {
			
			static internal readonly DSPArtistCallback Handler = TSPArtistCallback;
			
			[MonoPInvokeCallback (typeof (DSPArtistCallback))]
			static unsafe void TSPArtistCallback (IntPtr block, IntPtr artist) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::MonoSpotify.SPArtistCallback) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
				if (del != null)
					del ((MonoSpotify.SPArtist) Runtime.GetNSObject (artist));
			}
		}
		
		internal delegate void DSPImageCallback (IntPtr block, IntPtr image);
		
		static internal class SDSPImageCallback {
			
			static internal readonly DSPImageCallback Handler = TSPImageCallback;
			
			[MonoPInvokeCallback (typeof (DSPImageCallback))]
			static unsafe void TSPImageCallback (IntPtr block, IntPtr image) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::MonoSpotify.SPImageCallback) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
				if (del != null)
					del ((MonoSpotify.SPImage) Runtime.GetNSObject (image));
			}
		}
		
		internal delegate void DSPPlaylistCallback (IntPtr block, IntPtr playlist);
		
		static internal class SDSPPlaylistCallback {
			
			static internal readonly DSPPlaylistCallback Handler = TSPPlaylistCallback;
			
			[MonoPInvokeCallback (typeof (DSPPlaylistCallback))]
			static unsafe void TSPPlaylistCallback (IntPtr block, IntPtr playlist) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::MonoSpotify.SPPlaylistCallback) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
				if (del != null)
					del ((MonoSpotify.SPPlaylist) Runtime.GetNSObject (playlist));
			}
		}
		
		internal delegate void DSPSearchCallback (IntPtr block, IntPtr search);
		
		static internal class SDSPSearchCallback {
			
			static internal readonly DSPSearchCallback Handler = TSPSearchCallback;
			
			[MonoPInvokeCallback (typeof (DSPSearchCallback))]
			static unsafe void TSPSearchCallback (IntPtr block, IntPtr search) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::MonoSpotify.SPSearchCallback) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
				if (del != null)
					del ((MonoSpotify.SPSearch) Runtime.GetNSObject (search));
			}
		}
		
		internal delegate void DSPTrackCallback (IntPtr block, IntPtr track);
		
		static internal class SDSPTrackCallback {
			
			static internal readonly DSPTrackCallback Handler = TSPTrackCallback;
			
			[MonoPInvokeCallback (typeof (DSPTrackCallback))]
			static unsafe void TSPTrackCallback (IntPtr block, IntPtr track) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::MonoSpotify.SPTrackCallback) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
				if (del != null)
					del ((MonoSpotify.SPTrack) Runtime.GetNSObject (track));
			}
		}
		
		internal delegate void DSPUserCallback (IntPtr block, IntPtr user);
		
		static internal class SDSPUserCallback {
			
			static internal readonly DSPUserCallback Handler = TSPUserCallback;
			
			[MonoPInvokeCallback (typeof (DSPUserCallback))]
			static unsafe void TSPUserCallback (IntPtr block, IntPtr user) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::MonoSpotify.SPUserCallback) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
				if (del != null)
					del ((MonoSpotify.SPUser) Runtime.GetNSObject (user));
			}
		}
		
		internal delegate void DSPObjectRepresentationCallback (IntPtr block, global::MonoSpotify.LinkTypes linkType, IntPtr objectRepresentation);
		
		static internal class SDSPObjectRepresentationCallback {
			
			static internal readonly DSPObjectRepresentationCallback Handler = TSPObjectRepresentationCallback;
			
			[MonoPInvokeCallback (typeof (DSPObjectRepresentationCallback))]
			static unsafe void TSPObjectRepresentationCallback (IntPtr block, global::MonoSpotify.LinkTypes linkType, IntPtr objectRepresentation) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::MonoSpotify.SPObjectRepresentationCallback) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
				if (del != null)
					del (linkType, (MonoTouch.Foundation.NSObject) Runtime.GetNSObject (objectRepresentation));
			}
		}
		
		internal delegate void DSPCreatePlaylistCallback (IntPtr block, IntPtr playlist);
		
		static internal class SDSPCreatePlaylistCallback {
			
			static internal readonly DSPCreatePlaylistCallback Handler = TSPCreatePlaylistCallback;
			
			[MonoPInvokeCallback (typeof (DSPCreatePlaylistCallback))]
			static unsafe void TSPCreatePlaylistCallback (IntPtr block, IntPtr playlist) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::MonoSpotify.SPCreatePlaylistCallback) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
				if (del != null)
					del ((MonoSpotify.SPPlaylist) Runtime.GetNSObject (playlist));
			}
		}
		
		internal delegate void DTrackForTrackCallback (IntPtr block, IntPtr track);
		
		static internal class SDTrackForTrackCallback {
			
			static internal readonly DTrackForTrackCallback Handler = TTrackForTrackCallback;
			
			[MonoPInvokeCallback (typeof (DTrackForTrackCallback))]
			static unsafe void TTrackForTrackCallback (IntPtr block, IntPtr track) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::MonoSpotify.TrackForTrackCallback) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
				if (del != null)
					del ((MonoSpotify.SPTrack) Runtime.GetNSObject (track));
			}
		}
		
		internal delegate void DCreateUserCallback (IntPtr block, IntPtr user);
		
		static internal class SDCreateUserCallback {
			
			static internal readonly DCreateUserCallback Handler = TCreateUserCallback;
			
			[MonoPInvokeCallback (typeof (DCreateUserCallback))]
			static unsafe void TCreateUserCallback (IntPtr block, IntPtr user) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::MonoSpotify.CreateUserCallback) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
				if (del != null)
					del ((MonoSpotify.SPUser) Runtime.GetNSObject (user));
			}
		}
		
		internal delegate void DLoadingCompleteCallback (IntPtr block, IntPtr loadedItems, IntPtr notLoadedItems);
		
		static internal class SDLoadingCompleteCallback {
			
			static internal readonly DLoadingCompleteCallback Handler = TLoadingCompleteCallback;
			
			[MonoPInvokeCallback (typeof (DLoadingCompleteCallback))]
			static unsafe void TLoadingCompleteCallback (IntPtr block, IntPtr loadedItems, IntPtr notLoadedItems) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::MonoSpotify.LoadingCompleteCallback) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
				if (del != null)
					del (NSArray.ArrayFromHandle<NSObject> (loadedItems), NSArray.ArrayFromHandle<NSObject> (notLoadedItems));
			}
		}
	}
}
