//
//  StructsAndEnums.cs
//  MonoSpotify binding project
//
//  Created by Dermot on 25/03/13.
//  Copyright (c) 2013 Rocky Desk Creations. All rights reserved. - www.rockydesk.net
//

using System;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;

namespace MonoSpotify
{

    public class SPConstants
    {
        static int  kSPSearchDefaultSearchPageSize = 75;
		 static int  kSPSearchDoNotSearchPageSize = 0;

         static string SPOfflineStatisticsCopiedTrackCountKey = "SPOfflineStatisticsCopiedTrackCount";
         static string SPOfflineStatisticsDoneTrackCountKey = "SPOfflineStatisticsDoneTrackCount";
         static string SPOfflineStatisticsDoneTrackSizeKey = "SPOfflineStatisticsDoneTrackSize";
         static string SPOfflineStatisticsQueuedTrackCountKey = "SPOfflineStatisticsQueuedTrackCount";
         static string SPOfflineStatisticsQueuedTrackSizeKey = "SPOfflineStatisticsQueuedTrackSize";
         static string SPOfflineStatisticsFailedTrackCountKey = "SPOfflineStatisticsFailedTrackCount";
         static string SPOfflineStatisticsWillNotCopyTrackCountKey = "SPOfflineStatisticsWillNotCopyTrackCount";
         static string SPOfflineStatisticsIsSyncingKey = "SPOfflineStatisticsIsSyncing";

         static string SPSessionLoginDidFailNotification = "SPSessionLoginDidFailNotification";
         static string SPSessionLoginDidFailErrorKey = "error";
         static string SPSessionLoginDidSucceedNotification = "SPSessionLoginDidSucceedNotification";
         static string SPSessionDidLogoutNotification = "SPSessionDidLogoutNotification";
         static string SPSessionDidUpdateMetadataNotification = "SPSPSessionDidUpdateMetadataNotification";

         static string kCocoaLibSpotifyErrorDomain = @"com.spotify.CocoaLibSpotify.error";

         static double kSPAsyncLoadingDefaultTimeout = 20.0;
    }




	/*
 * Audio format descriptor

	typedef struct sp_audioformat {
		sp_sampletype sample_type;   // Sample type enum
		int sample_rate;             // Audio sample rate, in samples per second.
		int channels;                // Number of channels. Currently 1 or 2.
	} sp_audioformat;

*/

	//typedef enum sp_sampletype {
	//	SP_SAMPLETYPE_INT16_NATIVE_ENDIAN = 0, ///< 16-bit signed integer samples
	//} sp_sampletype;

	public enum sp_sampletype{
		SP_SAMPLETYPE_INT16_NATIVE_ENDIAN = 0
	}

	public struct sp_audioformat
	{
		sp_sampletype sample_type;
		int sample_rate;
		int channels;
	}




     //typedef enum SPAsyncLoadingPolicy {
     //       SPAsyncLoadingImmediate = 0, /* Immediately load items on login. */
     //       SPAsyncLoadingManual /* Only load items when -startLoading is called. */
     //    } SPAsyncLoadingPolicy;
    public enum SPAsyncLoadingPolicy
    {
        SPAsyncLoadingImmediate = 0,
        SPAsyncLoadingManual = 1,
    }
	
	//typedef enum sp_connectionstate {
	//SP_CONNECTION_STATE_LOGGED_OUT   = 0, ///< User not yet logged in
	//SP_CONNECTION_STATE_LOGGED_IN    = 1, ///< Logged in against a Spotify access point
	//SP_CONNECTION_STATE_DISCONNECTED = 2, ///< Was logged in, but has now been disconnected
	//SP_CONNECTION_STATE_UNDEFINED    = 3, ///< The connection state is undefined
	//SP_CONNECTION_STATE_OFFLINE		 = 4  ///< Logged in in offline mode
	//} sp_connectionstate;
	public enum ConnectionStates
	{
		SP_CONNECTION_STATE_LOGGED_OUT = 0,
		SP_CONNECTION_STATE_LOGGED_IN = 1,
		SP_CONNECTION_STATE_DISCONNECTED = 2,
		SP_CONNECTION_STATE_UNDEFINED = 3,
		SP_CONNECTION_STATE_OFFLINE = 4
		
	}
	
	// typedef enum {
	// SP_LINKTYPE_INVALID  = 0, ///< Link type not valid - default until the library has parsed the link, or when parsing failed
	// SP_LINKTYPE_TRACK    = 1, ///< Link type is track
	// SP_LINKTYPE_ALBUM    = 2, ///< Link type is album
	// SP_LINKTYPE_ARTIST   = 3, ///< Link type is artist
	// SP_LINKTYPE_SEARCH   = 4, ///< Link type is search
	// SP_LINKTYPE_PLAYLIST = 5, ///< Link type is playlist
	// SP_LINKTYPE_PROFILE  = 6, ///< Link type is profile
	// SP_LINKTYPE_STARRED  = 7, ///< Link type is starred
	// SP_LINKTYPE_LOCALTRACK  = 8, ///< Link type is a local file	
	// SP_LINKTYPE_IMAGE = 9, ///< Link type is an image
	// } sp_linktype;
	
	public enum LinkTypes
	{
		SP_LINKTYPE_INVALID  = 0, //< Link type not valid - default until the library has parsed the link, or when parsing failed
		SP_LINKTYPE_TRACK    = 1, //< Link type is track
		SP_LINKTYPE_ALBUM    = 2, //< Link type is album
		SP_LINKTYPE_ARTIST   = 3, //< Link type is artist
		SP_LINKTYPE_SEARCH   = 4, //< Link type is search
		SP_LINKTYPE_PLAYLIST = 5, //< Link type is playlist
		SP_LINKTYPE_PROFILE  = 6, //< Link type is profile
		SP_LINKTYPE_STARRED  = 7, //< Link type is starred
		SP_LINKTYPE_LOCALTRACK  = 8, //< Link type is a local file	
		SP_LINKTYPE_IMAGE = 9, //< Link type is an image
	}
	
	
	//typedef enum sp_bitrate {
	//SP_BITRATE_160k      = 0, ///< Bitrate 160kbps
	//SP_BITRATE_320k      = 1, ///< Bitrate 320kbps
	// SP_BITRATE_96k       = 2, ///< Bitrate 96kbps
	//} sp_bitrate;
	public enum Bitrates
	{
		SP_BITRATE_160k = 0,
		SP_BITRATE_320k = 1,
		SP_BITRATE_96k = 2
		
	}
	
	
	
	
	
	
	
	
	
}

