//
//  ApiDefinition.cs
//  MonoSpotify binding project
//
//  Created by Dermot on 25/03/13.
//  Copyright (c) 2013 Rocky Desk Creations. All rights reserved. - www.rockydesk.net
//
//
//  Note, this binding library is unfinished. Please
//

using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;


namespace MonoSpotify
{
	
#region Custom Delegates


	delegate void DispatchBlockT();
	delegate void LoginFetcher(string loginUserName);
	delegate void CompletionBlock();

    //callback:(void (^)(SPUser *user))block
    delegate void CreateUserCallback(SPUser user);

   // (void (^)(NSArray *loadedItems, NSArray *notLoadedItems))block;
	delegate void LoadingCompleteCallback(NSObject[] loadedItems, NSObject[] notLoadedItems);

    delegate void TrackForTrackCallback(SPTrack track);
	
	delegate void SPAlbumCallback(SPAlbum album);
	delegate void SPArtistCallback(SPArtist artist);
	delegate void SPImageCallback(SPImage image);
	delegate void SPPlaylistCallback(SPPlaylist playlist);
	delegate void SPSearchCallback(SPSearch search); 
	delegate void SPTrackCallback(SPTrack track);
	delegate void SPUserCallback(SPUser user);
	
	//typedef void (^SPErrorableOperationCallback)(NSError *error);
	delegate void SPErrorableOperationCallback(NSError error);
	
	//(void (^)(sp_linktype linkType, id objectRepresentation))block;
	delegate void SPObjectRepresentationCallback(LinkTypes linkType, NSObject objectRepresentation);


	//(void (^)(SPPlaylist *playlist))block;
    delegate void SPCreatePlaylistCallback(SPPlaylist playlist);

#endregion

	[BaseType(typeof(NSObject))]
	[Model]
	interface SPSignupPageDelegate
	{
		//Stub
	}

	//@protocol SPLoginViewControllerDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface SPLoginViewControllerDelegate
	{
		//-(void)loginViewController:(SPLoginViewController *)controller didCompleteSuccessfully:(BOOL)didLogin;
		[Export("loginViewController:didCompleteSuccessfully:")]
		void LoginComplete(SPLoginViewController controller, bool loginSuccess);
	}

		
		

	//@interface SPLoginViewController : UINavigationController <SPSignupPageDelegate> {
		//SPSession *session;
		//BOOL waitingForFacebookPermissions;
		//id <SPLoginViewControllerDelegate> __unsafe_unretained loginDelegate;
	//}
	[BaseType(typeof(UINavigationController))]
	interface SPLoginViewController
	{
		//+(SPLoginViewController *)loginControllerForSession:(SPSession *)session;
		[Static, Export("loginControllerForSession:")]
		SPLoginViewController LoginControllerForSession(SPSession session);


		/** Returns whether the view controller allows the user to cancel the login process or not. Defaults to `YES`. */
		//@property (nonatomic, readwrite) BOOL allowsCancel;
		[Export("allowsCancel")]
		bool AllowsCancel {get;set;}
		
		/** Returns whether the view controller dismisses itself after the user successfully logs in. Defaults to `YES`. */
		//@property (nonatomic, readwrite) BOOL dismissesAfterLogin;
		[Export("dismissesAfterLogin")]
		bool DismissesAfterLogin {get;set;}
		
		/** Returns the controller's loginDelegate object. */
		//@property (nonatomic, readwrite, unsafe_unretained) id <SPLoginViewControllerDelegate> loginDelegate;
		[Export("loginDelegate")]
		SPLoginViewControllerDelegate LoginDelegate {get;set;}
	}




	#region SPSessionPlaybackProvider


	//@protocol SPSessionPlaybackProvider <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface SPSessionPlaybackProvider
	{

		//@property (nonatomic, readwrite, getter=isPlaying) BOOL playing;
		[Export("playing")]
		bool Playing {[Bind("isPlaying")]get;set;}
		
		
		//@property (nonatomic, readwrite, assign) __unsafe_unretained id <SPSessionPlaybackDelegate> playbackDelegate;
		[Export("playbackDelegate")]
		SPSessionPlaybackDelegate PlaybackDelegate {get;set;}
		
		
		//@property (nonatomic, readwrite, assign) __unsafe_unretained id <SPSessionAudioDeliveryDelegate> audioDeliveryDelegate;
		[Export("audioDeliveryDelegate")]
		SPSessionAudioDeliveryDelegate AudioDeliveryDelegate {get;set;}
		
		
		//-(void)preloadTrackForPlayback:(SPTrack *)aTrack callback:(SPErrorableOperationCallback)block;
		[Export("preloadTrackForPlayback:callback:")]
		void PreloadtrackForPlayback(SPTrack aTrack, SPErrorableOperationCallback callback);
		
		
		//-(void)playTrack:(SPTrack *)aTrack callback:(SPErrorableOperationCallback)block;
		[Export("playTrack:callback:")]
		void PlayTrack(SPTrack aTrack, SPErrorableOperationCallback callback); 
		
		
		//-(void)seekPlaybackToOffset:(NSTimeInterval)offset;
		[Export("seekPlaybackToOffset:")]
		void SeekPlaybackToOffset(double offset);
		
		
		// -(void)unloadPlayback;
		[Export("unloadPlayback")]
		void UnloadPlayback();
	}



	#endregion

		#region SPImage
		
		[BaseType(typeof(NSObject))]
		interface SPImage
	{
		//Stub only.
	}
	
	
	#endregion


	#region SPPostTracksToInboxOperation
	
	[BaseType(typeof(NSObject))]
	interface SPPostTracksToInboxOperation
	{
		//Stub only.
	}
	
	
	#endregion


	//@protocol SPSessionPlaybackDelegate <NSObject>@optional
	[BaseType (typeof (NSObject))]
	[Model]
	interface SPSessionPlaybackDelegate
	{

		// -(void)sessionDidLosePlayToken:(id <SPSessionPlaybackProvider>)aSession;
		[Export ("sessionDidLosePlayToken:")]
		void SessionDidLosePlayToken(SPSessionPlaybackProvider aSession);
		
		
		
		// -(void)sessionDidEndPlayback:(id <SPSessionPlaybackProvider>)aSession;
		[Export ("sessionDidEndPlayback:")]
		void SessionDidEndPlayback(SPSessionPlaybackProvider aSession);
		
		
		
		// -(void)session:(id <SPSessionPlaybackProvider>)aSession didEncounterStreamingError:(NSError *)error;
		[Export ("session:didEncounterStreamingError:")]
		void SessionDidEncounterStreamingError(SPSessionPlaybackProvider aSession, NSError error);
		
		
		
		// -(NSInteger)session:(id <SPSessionPlaybackProvider>)aSession shouldDeliverAudioFrames:(const void *)audioFrames ofCount:(NSInteger)frameCount format:(const sp_audioformat *)audioFormat;
		[Export ("session:shouldDeliverAudioFrames:ofCount:format:")]
		int SessionShouldDeliverAudioFrames(SPSessionPlaybackProvider aSession, NSObject audioFrames, int frameCount, sp_audioformat audioFormat);

	}

#region SPSession

	//@interface SPSession : NSObject <SPSessionPlaybackProvider, SPAsyncLoading>
	[BaseType (typeof (NSObject))]
	interface SPSession
	{

		
	
       		/* -------------------------SPSessionPlaybackProvider------------------------- */

		 //@protocol SPSessionPlaybackProvider <NSObject>
		 
		 //@property (nonatomic, readwrite, getter=isPlaying) BOOL playing;
         //[Export("playing")]
         //bool Playing {[Bind("isPlaying")]get;set;}


		 //@property (nonatomic, readwrite, assign) __unsafe_unretained id <SPSessionPlaybackDelegate> playbackDelegate;
         [Export("playbackDelegate")]
         SPSessionPlaybackDelegate PlaybackDelegate {get;set;}


		 //@property (nonatomic, readwrite, assign) __unsafe_unretained id <SPSessionAudioDeliveryDelegate> audioDeliveryDelegate;
         [Export("audioDeliveryDelegate")]
         SPSessionAudioDeliveryDelegate AudioDeliveryDelegate {get;set;}

		 
		 //-(void)preloadTrackForPlayback:(SPTrack *)aTrack callback:(SPErrorableOperationCallback)block;
         [Export("preloadTrackForPlayback:callback:")]
         void PreloadTrackForPlayback(SPTrack track, SPErrorableOperationCallback callback);



		 //-(void)playTrack:(SPTrack *)aTrack callback:(SPErrorableOperationCallback)block;
         [Export("playTrack:callback:")]
         void PlayTrack(SPTrack track, SPErrorableOperationCallback callback); 
        

		 //-(void)seekPlaybackToOffset:(NSTimeInterval)offset;
         [Export("seekPlaybackToOffset:")]
         void SeekPlaybackToOffset(double offset);


        // -(void)unloadPlayback;
        [Export("unloadPlayback")]
        void UnloadPlayback();
		
		/* --------------------------------------------------------------------------- */



		//+(void)dispatchToLibSpotifyThread:(dispatch_block_t)block;
		[Static, Export ("dispatchToLibSpotifyThread:")]
		void DispatchToLibSpotifyThread(DispatchBlockT block);
		
		
		
		//+(void)dispatchToLibSpotifyThread:(dispatch_block_t)block waitUntilDone:(BOOL)wait;
		[Static, Export ("dispatchToLibSpotifyThread:waitUntilDone:")]
		void DispatchToLibSpotifyThread(DispatchBlockT block, bool wait);
		
		//Not bound
		//+(CFRunLoopRef)libSpotifyRunloop;
		
		
		//+(BOOL)spotifyClientInstalled;
		[Static, Export("spotifyClientInstalled")]
		bool SpotifyClientInstalled();
		
		
		//+(BOOL)launchSpotifyClientIfInstalled;
		[Static, Export("launchSpotifyClientIfInstalled")]
		bool LaunchSpotifyClientIfInstalled();
		
		
		//+(SPSession *)sharedSession;
		[Static, Export("sharedSession")]
		SPSession SharedSession {get;set;}
		
		
		//+(BOOL)initializeSharedSessionWithApplicationKey:(NSData *)appKey
		//							   userAgent:(NSString *)userAgent
		//						   loadingPolicy:(SPAsyncLoadingPolicy)policy
		//								   error:(NSError **)error;
		[Static, Export("initializeSharedSessionWithApplicationKey:userAgent:loadingPolicy:error:")]
		bool InitializeSharedSession(NSData applicationKey, string userAgent, SPAsyncLoadingPolicy loadingPolicy, NSError error);
		
		
		
		//+(NSString *)libSpotifyBuildId;
		[Static, Export("libSpotifyBuildId")]
		string SpotifyBuildID();
		
		
		
		//-(id)initWithApplicationKey:(NSData *)appKey
		//		  userAgent:(NSString *)userAgent
		//	  loadingPolicy:(SPAsyncLoadingPolicy)policy
		//			  error:(NSError **)error;
		[Export("initWithApplicationKey:userAgent:loadingPolicy:error:")]
		NSObject Init(NSData applicationKey, string userAgent, SPAsyncLoadingPolicy loadingPolicy, NSError error);
		
		
		//-(void)attemptLoginWithUserName:(NSString *)userName
		//               password:(NSString *)password;
		[Export("attemptLoginWithUserName:password:")]
		void AttemptLogin(string userName, string password);
		
		

		
		
		
		//-(void)attemptLoginWithUserName:(NSString *)userName
		//      existingCredential:(NSString *)credential;
		[Export("attemptLoginWithUserName:existingCredential:")]
		void AttemptLoginWithCredentials(string userName, string existingCredential);
		
		

      



		//-(void)fetchLoginUserName:(void (^)(NSString *loginUserName))block;
		[Export("fetchLoginUserName:")]
		void FetchLoginUserName(LoginFetcher block);
		
		
		//-(void)flushCaches:(void (^)())completionBlock;
		[Export("flushCaches:")]
		 void FlushCaches(CompletionBlock block);
		 
		 
		 
		 //-(void)logout:(void (^)())completionBlock;
		 [Export("logout:")]
		 void Logout(CompletionBlock block);
		 
		 
		 //@property (nonatomic, readonly) sp_connectionstate connectionState;
		 [Export("connectionState")]
		 ConnectionStates ConnectionState {get;set;}
		 
		 
		 
		 //-(void)setMaximumCacheSizeMB:(size_t)maximumCacheSizeMB;
		 [Export("setMaximumCacheSizeMB:")]
		 void SetMaximumCacheSize(int megaBytes);
		 
		 
		 
		 //-(void)setPreferredBitrate:(sp_bitrate)bitrate;
		 [Export ("setPreferredBitrate:")]
		 void SetPreferredBitrate(Bitrates bitrate);


		//@property (nonatomic, readwrite, assign) __unsafe_unretained id <SPSessionDelegate> delegate;
		[Export("delegate")]
		SPSessionDelegate Delegate {get;set;}
		 
		 //Unbound - Mainly related to direct API usage & offline playback. Currently these features are not requried.
		 
		 //@property (nonatomic, readonly) sp_session *session;
		 //@property (nonatomic, copy, readonly) NSString *userAgent;
		 //@property (nonatomic, readonly) SPAsyncLoadingPolicy loadingPolicy;
		 //@property (nonatomic, readwrite, getter=isPrivateSession) BOOL privateSession;
		 //-(void)setScrobblingState:(sp_scrobbling_state)state forService:(sp_social_provider)service callback:(SPErrorableOperationCallback)block;
		 //-(void)setScrobblingUserName:(NSString *)userName password:(NSString *)password forService:(sp_social_provider)service callback:(SPErrorableOperationCallback)block;
		 //-(void)fetchScrobblingStateForService:(sp_social_provider)service callback:(void (^)(sp_scrobbling_state state, NSError *error))block;
		 //-(void)fetchScrobblingAllowedForService:(sp_social_provider)service callback:(void (^)(BOOL scrobblingAllowed, NSError *error))block;
		 //@property (nonatomic, readonly, getter=isOfflineSyncing) BOOL offlineSyncing;
		 //@property (nonatomic, readonly) NSUInteger offlineTracksRemaining;
		 //@property (nonatomic, readonly) NSUInteger offlinePlaylistsRemaining;
		 //@property (nonatomic, readonly, copy) NSDictionary *offlineStatistics;
		 //-(void)fetchOfflineKeyTimeRemaining:(void (^)(NSTimeInterval remainingTime))block;
		 //@property (nonatomic, readonly, strong) NSError *offlineSyncError;
		 
		 
		 //@property (nonatomic, readonly, getter=isLoaded) BOOL loaded;
		 [Export ("loaded")]
		 bool Loaded { [Bind ("isLoaded")]get;set;}
		 
		 
		 //@property (nonatomic, readonly, strong) NSLocale *locale;
		 [Export ("locale")]
		 NSLocale Locale {get;set;}
		 
		 
		 //@property (nonatomic, readonly, strong) SPPlaylist *inboxPlaylist;
		 [Export ("inboxPlaylist")]
		 SPPlaylist InboxPlaylist {get;set;}
		 
		 
		 //@property (nonatomic, readonly, strong) SPPlaylist *starredPlaylist;
		 [Export ("starredPlaylist")]
		 SPPlaylist StarredPlaylist {get;set;}
		 
		 //@property (nonatomic, readonly, strong) SPUser *user;
		 [Export ("user")]
		 SPUser User {get;set;}
		 
		 
		 //@property (nonatomic, readonly, strong) SPPlaylistContainer *userPlaylists;
		 [Export ("userPlaylists")]
		 SPPlaylistContainer UserPlaylists {get;set;}


		 
		 
		 //-(SPPostTracksToInboxOperation *)postTracks:(NSArray *)tracks 
		 //					  toInboxOfUser:(NSString *)targetUserName
		 //						withMessage:(NSString *)aFriendlyMessage
		 //						   callback:(SPErrorableOperationCallback)block
		 [Export("postTracks:toInboxOfUser:withMessage:callback:")]
		 SPPostTracksToInboxOperation PostTracks(SPTrack[] tracks, string targetUserName, string friendlyMessage, SPErrorableOperationCallback block);
		 
		 
		 
		 //-(void)albumForURL:(NSUrl *)url callback:(void (^)(SPAlbum *album))block;
		 [Export("albumForURL:callback:")]
		 void AlbumForUrl(NSUrl url, SPAlbumCallback callback);
		 
		 
		 //-(void)artistForURL:(NSUrl *)url callback:(void (^)(SPArtist *image))block;
		 [Export("artistForURL:callback:")]
		 void ArtistForUrl(NSUrl url, SPArtistCallback callback);
		 
		 
		 //-(void)imageForURL:(NSUrl *)url callback:(void (^)(SPImage *artist))block;
		 [Export("imageForURL:callback:")]
		 void ImageForUrl(NSUrl url, SPImageCallback callback);
		 
		 
		 //-(void)playlistForURL:(NSUrl *)url callback:(void (^)(SPPlaylist *playlist))block;
		 [Export ("playlistForURL:callback:")]
		 void PlaylistForUrl(NSUrl url, SPPlaylistCallback callback);
		 
		 
		 //-(void)searchForURL:(NSUrl *)url callback:(void (^)(SPSearch *search))block;
		 [Export ("searchForURL:callback:")]
		 void SearchForUrl(NSUrl url, SPSearchCallback callback);
		 
		 
		 //-(void)trackForURL:(NSUrl *)url callback:(void (^)(SPTrack *track))block;
		 [Export ("trackForURL:callback:")]
		 void TrackForUrl(NSUrl url, SPTrackCallback callback);
		 
		 
		 //-(void)userForURL:(NSUrl *)url callback:(void (^)(SPUser *user))block;
		 [Export ("userForURL:callback:")]
		 void UserForUrl(NSUrl url, SPUserCallback callback);
		 
		 
		 // -(id)objectRepresentationForSpotifyURL:(NSUrl *)aSpotifyUrlOfSomeKind linkType:(sp_linktype *)linkType;
		 [Export ("objectRepresentationForSpotifyURL:linkType:")]
		 NSObject ObjectRepresentationForSpotifyUrl(NSUrl spotifyUrl, LinkTypes linkType);
		 
		 
		 //-(void)objectRepresentationForSpotifyURL:(NSUrl *)aSpotifyUrlOfSomeKind callback:(void (^)(sp_linktype linkType, id objectRepresentation))block;
		 [Export ("objectRepresentationForSpotifyURL:callback:")]
		 void ObjectRepresentationForSpotifyUrl(NSUrl url, SPObjectRepresentationCallback callback);
		 
		 
		 //-(SPPlaylist *)playlistForPlaylistStruct:(sp_playlist *)playlist;
		 //-(SPPlaylistFolder *)playlistFolderForFolderId:(sp_uint64)playlistId inContainer:(SPPlaylistContainer *)aContainer;
		 //-(SPUnknownPlaylist *)unknownPlaylistForPlaylistStruct:(sp_playlist *)playlist;
		 //-(SPTrack *)trackForTrackStruct:(sp_track *)track;
		 //-(SPUser *)userForUserStruct:(sp_user *)user;
		 
		 
		 /* Audio Playback */
		 
		 //@property (nonatomic, readwrite, getter=isUsingVolumeNormalization) BOOL usingVolumeNormalization;
		 [Export ("usingVolumeNormalization")]
		 bool UsingVolumeNormalization { [Bind ("isUsingVolumeNormalization")]get;set;}
		 
		 
		 //@property (nonatomic, readwrite, getter=isPlaying) BOOL playing;
		 [Export ("playing")]
		 bool Playing { [Bind ("isUsingVolumeNormalization")]get;set;}
		 
		 
		 //@property (nonatomic, readwrite, assign) __unsafe_unretained id <SPSessionPlaybackDelegate> playbackDelegate;
		// [Export ("playbackDelegate")]
		// SPSessionPlaybackDelegate PlaybackDelegate {get;set;}
		 
		 //Unbound
		 //@property (nonatomic, readwrite, assign) __unsafe_unretained id <SPSessionAudioDeliveryDelegate> audioDeliveryDelegate;
		 
		 
	
		 
		 //-(void)playTrack:(SPTrack *)aTrack callback:(SPErrorableOperationCallback)block;
		 //[Export ("playTrack:callback:")]
		 //void PlayTrack(SPTrack track, SPErrorableOperationCallback callback);
		 
		 
		 //-(void)seekPlaybackToOffset:(NSTimeInterval)offset;
		// [Export ("seekPlaybackToOffset:")]
		// void SeekPlaybackToOffset(double offset);
		 
		 //-(void)unloadPlayback;
		 //[Export("unloadPlayback")]
		 //void UnloadPlayback();
	}
		 
		 
#endregion



		 
#region SPSessionDelegate (Protocol)

		 
		 [BaseType (typeof(NSObject))]
		 [Model]
		 interface SPSessionDelegate
		 { 
			//-(void)sessionDidLoginSuccessfully:(SPSession *)aSession;
			[Export("sessionDidLoginSuccessfully:")]
			void SessionDidLoginSuccessfully(SPSession session);
			
			
			//-(void)session:(SPSession *)aSession didGenerateLoginCredentials:(NSString *)credential forUserName:(NSString *)userName;
			[Export ("session:didGenerateLoginCredentials:forUserName:")]
			void SessionDidGenerateLoginCredentials(SPSession currentSession, string credential, string username);

			
			// -(void)session:(SPSession *)aSession didFailToLoginWithError:(NSError *)error;
			[Export("session:didFailToLoginWithError:")]
			void SessionFailedToLogin(SPSession session, NSError error);
			
			// -(void)sessionDidLogOut:(SPSession *)aSession;
			[Export("sessionDidLogOut:")]
			void SessionLoggedOut(SPSession session);
			
			
			
			// -(void)session:(SPSession *)aSession recievedMessageForUser:(NSString *)aMessage;
			[Export("session:recievedMessageForUser:")]
			void SessionReceivedMessage(SPSession session, string message);
			
			
			
			// -(void)sessionDidChangeMetadata:(SPSession *)aSession;
			[Export("sessionDidChangeMetadata:")]
			void SessionChangedMetaData(SPSession session);
			

			// -(void)session:(SPSession *)aSession didEncounterNetworkError:(NSError *)error;
			[Export("session:didEncounterNetworkError:")]
			void SessionEncounteredNetworkError(SPSession session, NSError error);
			
			
			
			// -(void)session:(SPSession *)aSession didEncounterScrobblingError:(NSError *)error;
			[Export("session:didEncounterScrobblingError:")]
			void SessionEncounteredScrobblingError(SPSession session, NSError error);
			
			
			
			// -(void)session:(SPSession *)aSession didLogMessage:(NSString *)aMessage;
			[Export("session:didLogMessage:")]
			void SessionLoggedMessage(SPSession session, string message);


			//-(UIViewController *)viewControllerToPresentLoginViewForSession:(SPSession *)aSession;
			[Export("viewControllerToPresentLoginViewForSession:")]
			UIViewController ViewControllerToPresentLoginView(SPSession session);
			
			
			
		 }	




#endregion



#region SPPlaylist
		 
    //@interface SPPlaylist : NSObject <SPPlaylistableItem, SPAsyncLoading, SPDelayableAsyncLoading>		 
    [BaseType (typeof (NSObject))]    
    interface SPPlaylist
    {

        /* -------------------------SPPlaylistableItem------------------------- */
  
		 //-(NSString *)name;
         [Export("name")]
		string Name {get;}
     
		 
         //-(NSUrl *)spotifyURL;
         [Export("spotifyURL")]
		NSUrl SpotifyURL {get;}


		 /* --------------------------------------------------------------------------- */

        /* -------------------------SPAsyncLoading------------------------- */
		
		//@property (readonly, nonatomic, getter = isLoaded) BOOL loaded;
		 [Export("loaded")]
         bool Loaded {[Bind("isLoaded")]get;set;}

		/* --------------------------------------------------------------------------- */




        /* -------------------------SPDelayableAsyncLoading------------------------- */

			 //-(void)startLoading;
		 [Export("startLoading")]
         void StartLoading();
		 

		/* --------------------------------------------------------------------------- */



        //Not bound
		 //+(SPPlaylist *)playlistWithPlaylistStruct:(sp_playlist *)pl inSession:(SPSession *)aSession;
		 
	    
		 //+(void)playlistWithPlaylistURL:(NSUrl *)playlistURL inSession:(SPSession *)aSession callback:(void (^)(SPPlaylist *playlist))block;
		 [Static, Export("playlistWithPlaylistURL:inSession:callback:")]
         void PlaylistWithPlaylistURL(NSUrl playlistURL, SPSession aSession, SPCreatePlaylistCallback callback);
		

        //Not bound
		 //-(id)initWithPlaylistStruct:(sp_playlist *)pl inSession:(SPSession *)aSession;
		 
		 
		 //@property (nonatomic, readwrite, assign) __unsafe_unretained id <SPPlaylistDelegate> delegate;
        [Export("delegate")]
		 SPPlaylistDelegate Delegate {get;set;}


		 //@property (nonatomic, readonly) BOOL hasPendingChanges;
		 [Export("hasPendingChanges")]
         bool HasPendingChanges {get;set;}
		

		 //@property (nonatomic, readwrite, getter=isCollaborative) BOOL collaborative;
		 [Export("collaborative")]
         bool Collaborative { [Bind("isCollaborative")]get;set;}
    
		 //@property (nonatomic, readonly, getter=isLoaded) BOOL loaded;
       // [Export("loaded")]
       // bool Loaded {[Bind("isLoaded")]get;set;}
		 
		
		// @property (nonatomic, readwrite, getter=isMarkedForOfflinePlayback) BOOL markedForOfflinePlayback;
         [Export("markedForOfflinePlayback")]
        bool MarkedForOfflinePlayback {[Bind("isMarkedForOfflinePlayback")]get;set;}


		// @property (nonatomic, readonly, getter=isUpdating) BOOL updating;
         [Export("updating")]
        bool Updating {[Bind("isUpdating")]get;set;}
		 

		// @property (nonatomic, readonly) float offlineDownloadProgress;
		 [Export("offlineDownloadProgress")]
        bool OfflineDownloadProgress {get;}
        
		//Not bound
		// @property (nonatomic, readonly) sp_playlist_offline_status offlineStatus;
        


		// @property (nonatomic, readonly, strong) SPUser *owner;
		 [Export("owner")]
        SPUser Owner{get;}
	
        //Unbound
		// @property (nonatomic, readonly) sp_playlist *playlist;
		 
		
		// @property (nonatomic, readonly, assign) __unsafe_unretained SPSession *session;
		 [Export("session")]
        SPSession Session {get;}
		
		 //@property (nonatomic, readonly, copy) NSUrl *spotifyURL;
       // [Export("spotifyURL")]
        //NSUrl SpotifyURL {get;}
		 

		// @property (nonatomic, readonly, strong) NSArray *subscribers;
        [Export("subscribers")]
        NSArray Subscribers {get;}
		 
		
		// @property (nonatomic, readonly, strong) SPImage *image;
        [Export("Image")]
        SPImage Image {get;}
		 

		 //@property (nonatomic, readwrite, copy) NSString *name;
		// [Export("Name")]
        //string Name {get;}
	
		 //@property (nonatomic, readonly, copy) NSString *playlistDescription;
		 [Export("playlistDescription")]
        string PlaylistDescription {get;}
		
		 //@property (atomic, readonly, copy) NSArray *items;
         [Export("items")]
         SPPlaylistItem[] Items {get;}

        //Not bound
		 //-(void)moveItemsAtIndexes:(NSIndexSet *)indexes toIndex:(NSUInteger)newLocation callback:(SPErrorableOperationCallback)block;
		 //[Export("moveItemsAtIndexes:")]

		//Not bound
		 //-(void)addItem:(SPTrack *)item atIndex:(NSUInteger)index callback:(SPErrorableOperationCallback)block;
		 [Export("addItem:atIndex:callback:")]
		 void Add(SPTrack item, int index, SPErrorableOperationCallback callback);

		//Not bound
		 //-(void)addItems:(NSArray *)items atIndex:(NSUInteger)index callback:(SPErrorableOperationCallback)block;
		[Export("addItems:atIndex:callback:")]
		void Add(SPTrack[] items, int index, SPErrorableOperationCallback callback);

        //Not bound
		 //-(void)removeItemAtIndex:(NSUInteger)index callback:(SPErrorableOperationCallback)block;
		[Export("removeItemAtIndex:callback:")]
		void Remove(int itemIndex, SPErrorableOperationCallback callback);
         
    }




#endregion
		



#region SPPlaylistDelegate
		 
		 //@protocol SPPlaylistDelegate <NSObject>
         [BaseType (typeof(NSObject))]
		 [Model]
          interface SPPlaylistDelegate
         {
          
		 //-(void)itemsInPlaylistDidUpdateMetadata:(SPPlaylist *)aPlaylist;
		 [Export("itemsInPlaylistDidUpdateMetadata:")]
         void ItemsInPlaylistDidUpdateMetadata(SPPlaylist aPlaylist);


        //Unbound methods below:

		 //-(void)playlist:(SPPlaylist *)aPlaylist willRemoveItems:(NSArray *)items atIndexes:(NSIndexSet *)outgoingIndexes;
       // [Export("")]


		// -(void)playlist:(SPPlaylist *)aPlaylist didRemoveItems:(NSArray *)items atIndexes:(NSIndexSet *)theseIndexesArentValidAnymore;
          //  [Export("")]

		 //-(void)playlist:(SPPlaylist *)aPlaylist willAddItems:(NSArray *)items atIndexes:(NSIndexSet *)theseIndexesArentYetValid;
           // [Export("")]


		 //-(void)playlist:(SPPlaylist *)aPlaylist didAddItems:(NSArray *)items atIndexes:(NSIndexSet *)newIndexes;
           // [Export("")]

		 //-(void)playlist:(SPPlaylist *)aPlaylist willMoveItems:(NSArray *)items atIndexes:(NSIndexSet *)oldIndexes toIndexes:(NSIndexSet *)newIndexes;

		 //-(void)playlist:(SPPlaylist *)aPlaylist didMoveItems:(NSArray *)items atIndexes:(NSIndexSet *)oldIndexes toIndexes:(NSIndexSet *)newIndexes;

		 //-(void)playlistWillChangeItems:(SPPlaylist *)aPlaylist;

		 //-(void)playlistDidChangeItems:(SPPlaylist *)aPlaylist;


         }

#endregion

		




#region SPSearch

		 
		 

		 //@interface SPSearch : NSObject <SPAsyncLoading>
		 [BaseType (typeof(NSObject))]
        interface SPSearch
         {
         

         /* -------------------------SPAsyncLoading------------------------- */
		
		//@property (readonly, nonatomic, getter = isLoaded) BOOL loaded;
		 [Export("loaded")]
         bool Loaded {[Bind("isLoaded")]get;set;}

		/* --------------------------------------------------------------------------- */


		 //+(SPSearch *)searchWithURL:(NSUrl *)searchURL inSession:(SPSession *)aSession;
         [Static, Export("searchWithURL:inSession:")]
		SPSearch SearchWithUrl(NSUrl searchUrl, SPSession aSession);




		 //+(SPSearch *)searchWithSearchQuery:(NSString *)searchQuery inSession:(SPSession *)aSession;
         [Static, Export("searchWithSearchQuery:inSession:")]
         SPSearch SearchWithSearchQuery(string searchQuery, SPSession aSession);


		 //+(SPSearch *)liveSearchWithSearchQuery:(NSString *)searchQuery inSession:(SPSession *)aSession;
         [Static, Export("liveSearchWithSearchQuery:inSession:")]
         SPSearch LiveSearchWithSearchQuery(string searchQuery, SPSession aSession);

         
		 //-(id)initWithURL:(NSUrl *)searchURL inSession:(SPSession *)aSession;
         [Export("initWithURL:inSession:")]
		IntPtr Constructor(NSUrl searchUrl, SPSession aSession);

		 //-(id)initWithURL:(NSUrl *)searchURL pageSize:(NSInteger)size inSession:(SPSession *)aSession;
         [Export("initWithURL:pageSize:inSession:")]
		IntPtr Constructor(NSUrl searchURL, int pageSize, SPSession aSession);

		 
         //-(id)initWithSearchQuery:(NSString *)searchString inSession:(SPSession *)aSession;
		 [Export("initWithSearchQuery:inSession:")]
         IntPtr Constructor(string searchString, SPSession aSession);

		//Not bound
		 //-(id)initWithSearchQuery:(NSString *)searchString inSession:(SPSession *)aSession type:(sp_search_type)type;
         //[Export("")]


		 //-(id)initWithSearchQuery:(NSString *)searchString pageSize:(NSInteger)size inSession:(SPSession *)aSession;
		 [Export("initWithSearchQuery:pageSize:inSession:")]
         IntPtr Constructor(string searchString, int pageSize, SPSession aSession);
		
         //Not bound
		 //-(id)initWithSearchQuery:(NSString *)searchString pageSize:(NSInteger)size inSession:(SPSession *)aSession type:(sp_search_type)type;
		 //[Export("")]


		 //-(BOOL)addAlbumPage;
		 [Export("addAlbumPage")]
         bool AddAlbumPage {get;set;}
		

		 //-(BOOL)addArtistPage;
		 [Export("addArtistPage")]
         bool AddArtistPage {get;set;}

		
		 //-(BOOL)addTrackPage;
		 [Export("addTrackPage")]
         bool AddTrackPage {get;set;}

		
		 //-(BOOL)addPlaylistPage;
		 [Export("addPlaylistPage")]
         bool AddPlaylistPage {get;set;}



		 //-(BOOL)addPageForArtists:(BOOL)searchArtist albums:(BOOL)searchAlbum tracks:(BOOL)searchTrack playlists:(BOOL)searchPlaylist;
		 [Export("addPageForArtists:albums:tracks:playlists:")]
         bool AddPageForArtists(bool artists, bool albums, bool tracks, bool playlists);

		
		 //@property (nonatomic, readonly, copy) NSString *suggestedSearchQuery;
         [Export("suggestedSearchQuery")]
         string SuggestedSearchQuery {get;}


		 //@property (nonatomic, readonly) BOOL hasExhaustedAlbumResults;
         [Export("hasExhaustedAlbumResults")]
         bool HasExhaustedAlbumResults {get;}
             

		 //@property (nonatomic, readonly) BOOL hasExhaustedArtistResults;
         [Export("hasExhaustedArtistResults")]
         bool HasExhaustedArtistResults {get;}


		 //@property (nonatomic, readonly) BOOL hasExhaustedTrackResults;
         [Export("hasExhaustedTrackResults")]
         bool HasExhaustedTrackResults {get;}


		 //@property (nonatomic, readonly) BOOL hasExhaustedPlaylistResults;
         [Export("hasExhaustedPlaylistResults")]
         bool HasExhaustedPlaylistResults {get;}


		 //@property (nonatomic, readonly, strong) NSArray *albums;
         [Export("albums")]
         NSArray Albums {get;}

		 //@property (nonatomic, readonly, strong) NSArray *artists;
         [Export("artists")]
         NSArray Artists {get;}


		 //@property (nonatomic, readonly, strong) NSArray *tracks;
         [Export("tracks")]
         NSArray Tracks {get;}


		 //@property (nonatomic, readonly, strong) NSArray *playlists;
         [Export("playlists")]
         NSArray Playlists {get;}


		 //@property (nonatomic, readonly, copy) NSError *searchError;
         [Export("searchError")]
         NSError SearchError {get;}


		 //@property (nonatomic, readonly, getter = isLoaded) BOOL loaded;
        // [Export("Loaded")]
        // bool Loaded { [Bind ("isLoaded")]get;set;}


		 //@property (nonatomic, readonly, copy) NSString *searchQuery;
         [Export("searchQuery")]
         string SearchQuery {get;}


		 //@property (nonatomic, readonly, strong) SPSession *session;
         [Export("session")]
         SPSession Session {get;}


		 //@property (nonatomic, readonly, copy) NSUrl *spotifyURL;
         [Export("spotifyURL")]
         NSUrl SpotifyURL {get;}

         //Not bound
		 //@property (nonatomic, readonly) sp_search_type searchType;
         //[Export("")]

         }
		 

#endregion




#region SPTrack
		 
		 //@interface SPTrack : NSObject <SPPlaylistableItem, SPAsyncLoading> 
		 [BaseType(typeof(NSObject))]
         interface SPTrack
         {
    
          /* -------------------------SPAsyncLoading------------------------- */
		
		//@property (readonly, nonatomic, getter = isLoaded) BOOL loaded;
		 [Export("loaded")]
         bool Loaded {[Bind("isLoaded")]get;set;}

		/* --------------------------------------------------------------------------- */





        /* -------------------------SPPlaylistableItem------------------------- */
  
		 //-(NSString *)name;
         [Export("name")]
		string Name {get;set;}
     
		 
         //-(NSUrl *)spotifyURL;
         [Export("spotifyURL")]
		NSUrl SpotifyURL {get;set;}


		 /* --------------------------------------------------------------------------- */


         //BOOL _starred;
		// [Field ("_starred")]
        // int Starred {get;}
		 
		 
		//Not bound
		 //+(SPTrack *)trackForTrackStruct:(sp_track *)spTrack inSession:(SPSession *)aSession;
		 //[Export("")]

		
		 //+(void)trackForTrackURL:(NSUrl *)trackURL inSession:(SPSession *)aSession callback:(void (^)(SPTrack *track))block;
		  [Export("trackForTrackURL:inSession:callback:")]
          void TrackForTrackURL(NSUrl trackURL, SPSession aSession, TrackForTrackCallback block);

		 //Not bound
		 //-(id)initWithTrackStruct:(sp_track *)tr inSession:(SPSession *)aSession;
          //[Export("")]


		 //-(SPTrack *)playableTrack;
		  [Export("playbackTrack")]
          SPTrack PlayableTrack {get;set;}
		


		 //@property (nonatomic, readonly) sp_track_availability availability;
		  //[Export("")]


		 //@property (nonatomic, readonly, getter=isLoaded) BOOL loaded;
		// [Export ("loaded")]
		 //bool Loaded { [Bind ("isLoaded")]get;set;}


		 //@property (nonatomic, readonly, getter = isLocal) BOOL local;
		 [Export ("local")]
		 bool Local { [Bind ("isLocal")]get;set;}


		 //@property (nonatomic, readonly, copy) NSUrl *spotifyURL;
		// [Export("spotifyURL")]
        // NSUrl SpotifyURL {get;}

             //Not bound
		 //@property (nonatomic, readonly) sp_track *track;
		 //[Export("")]


		 //@property (nonatomic, readwrite) BOOL starred;
        // [Export("starred")]
        // bool Starred {get;set;}


		 //@property (nonatomic, readonly, assign) __unsafe_unretained SPSession *session;
         [Export("session")]
         SPSession Session {get;}


		 //@property (nonatomic, readonly, strong) SPAlbum *album;
         [Export("album")]
         SPAlbum Album {get;}


		 //@property (nonatomic, readonly, strong) NSArray *artists;
         [Export("artists")]
         SPArtist[] Artists {get;}


		// @property (nonatomic, readonly, copy) NSString *consolidatedArtists;
         [Export("consolidatedArtists")]
         string ConsolidatedArtists {get;}


		// @property (nonatomic, readonly) NSUInteger discNumber;
         [Export("discNumber")]
         int DiscNumber {get;}


		// @property (nonatomic, readonly) NSTimeInterval duration;
         [Export("duration")]
         double Duration {get;}

		// @property (nonatomic, readonly, copy) NSString *name;
        // [Export("name")]
         //string Name {get;}

		 //@property (nonatomic, readonly) NSUInteger popularity;
         [Export("popularity")]
         int Popularity {get;}

		 //@property (nonatomic, readonly) NSUInteger trackNumber;
         [Export("trackNumber")]
         int TrackNumber {get;}
		 
         }

#endregion

		 

#region SPPlaylistContainer

         //@interface SPPlaylistContainer : NSObject <SPAsyncLoading, SPDelayableAsyncLoading>
		 [BaseType( typeof(NSObject))]
		 interface SPPlaylistContainer
         {

             /* -------------------------SPAsyncLoading------------------------- */
		
		//@property (readonly, nonatomic, getter = isLoaded) BOOL loaded;
		 [Export("loaded")]
         bool Loaded {[Bind("isLoaded")]get;set;}

		/* --------------------------------------------------------------------------- */



		/* -------------------------SPDelayableAsyncLoading------------------------- */

			 //-(void)startLoading;
		 [Export("startLoading")]
         void StartLoading();
		 

		/* --------------------------------------------------------------------------- */





		 
	      //Not bound
		  //@property (nonatomic, readonly, assign) sp_playlistcontainer *container;
          //Export("")



		// @property (nonatomic, readonly, getter=isLoaded) BOOL loaded;
        // [Export("Loaded")]
        // bool Loaded { [Bind ("isLoaded")]get;set;}



		 //@property (nonatomic, readonly, strong) SPUser *owner;
         [Export("owner")]
         SPUser Owner {get;}



		// @property (nonatomic, readonly, strong) NSArray *playlists;
         [Export("playlists")]
         NSObject[] Playlists {get;}


		 
		
		 //-(NSArray *)flattenedPlaylists;
         [Export("flattenedPlaylists")]
         SPPlaylist[] FlattenedPlaylists();



		// @property (nonatomic, readonly, assign) __unsafe_unretained SPSession *session;
         [Export("Session")]
         SPSession Session {get;}


		 
		 // Not Bound
		 //-(void)createFolderWithName:(NSString *)name callback:(void (^)(SPPlaylistFolder *createdFolder, NSError *error))block;
         //Export("")


		 
		 // Not Bound
		 //-(void)createPlaylistWithName:(NSString *)name callback:(void (^)(SPPlaylist *createdPlaylist))block;
         //Export("")


		 
		  // Not Bound
		 //-(void)removeItem:(id)playlistOrFolder callback:(SPErrorableOperationCallback)block;
         //Export("")


          // Not Bound
		 //-(void)moveItem:(id)playlistOrFolder toIndex:(NSUInteger)newIndex ofNewParent:(SPPlaylistFolder *)aParentFolderOrNil callback:(SPErrorableOperationCallback)block;
         //Export("")


          // Not Bound
		 // -(void)subscribeToPlaylist:(SPPlaylist *)playlist callback:(SPErrorableOperationCallback)block;
         //Export("")


		 
         }

#endregion


#region SPUser
		

		 //@interface SPUser : NSObject <SPAsyncLoading>
		 [BaseType (typeof(NSObject))]
         interface SPUser
         {
		

             /* -------------------------SPAsyncLoading------------------------- */
		
		//@property (readonly, nonatomic, getter = isLoaded) BOOL loaded;
		 [Export("loaded")]
         bool Loaded {[Bind("isLoaded")]get;set;}

		/* --------------------------------------------------------------------------- */


             //Not bound
             //+(SPUser *)userWithUserStruct:(sp_user *)spUser inSession:(SPSession *)aSession;
         //[Export

		 
             //+(void)userWithURL:(NSUrl *)userUrl inSession:(SPSession *)aSession callback:(void (^)(SPUser *user))block;
		    [Export("userWithURL:inSession:callback:")]
            void UserWithURL(NSUrl userURL, SPSession inSession, CreateUserCallback callback);

		
		 //-(id)initWithUserStruct:(sp_user *)aUser inSession:(SPSession *)aSession;
		 
		
		 //@property (nonatomic, readonly, copy) NSString *canonicalName;
		 [Export("canoinicalName")]
         string CanonicalName {get;}
		
		 //@property (nonatomic, readonly, copy) NSString *displayName;
         [Export("displayName")]
         string DisplayName {get;}
		 

		 //@property (nonatomic, readonly, getter=isLoaded) BOOL loaded;
        // [Export ("loaded")]
	//	 bool Loaded { [Bind ("isLoaded")]get;set;}

		 //@property (nonatomic, readonly, copy) NSUrl *spotifyURL;
		 [Export("spotifyURL")]
        NSUrl SpotifyURL {get;}
		
		      //Not bound
             //@property (nonatomic, readonly) sp_user *user;

         }

#endregion


#region SPPlaybackManagerDelegate

         //@protocol SPPlaybackManagerDelegate <NSObject>
		 [BaseType(typeof(NSObject))]
         [Model]
		 interface SPPlaybackManagerDelegate
         {
		 

         
		 //-(void)playbackManagerWillStartPlayingAudio:(SPPlaybackManager *)aPlaybackManager;
		 [Export("playbackManagerWillStartPlayingAudio:")]
         void PlaybackManagerWillStartPlayingAudio(SPPlaybackManager aPlaybackManager);


		

         }


#endregion


	#region  SPCoreAudioControllerDelegate
	
	//@protocol SPCoreAudioControllerDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface SPCoreAudioControllerDelegate
	{
	
		//-(void)coreAudioController:(SPCoreAudioController *)controller didOutputAudioOfDuration:(NSTimeInterval)audioDuration;
		[Export("coreAudioController:didOutputAudioOfDuration:")]
		void CoreAudioControllerDidOutputAudio(SPCoreAudioController controller, double duration);
	}
	
#endregion

		 


#region SPPlaybackManager
		 
		 //@interface SPPlaybackManager : NSObject <SPSessionPlaybackDelegate, SPCoreAudioControllerDelegate>
		 [BaseType (typeof(NSObject))]
         interface SPPlaybackManager
         {
	     
         /* -------------------------SPSessionPlaybackDelegate------------------------- */
		 
			// -(void)sessionDidLosePlayToken:(id <SPSessionPlaybackProvider>)aSession;
			[Export ("sessionDidLosePlayToken:")]
			void SessionDidLosePlayToken(NSObject aSession);
			
			
			
			// -(void)sessionDidEndPlayback:(id <SPSessionPlaybackProvider>)aSession;
			[Export ("sessionDidEndPlayback:")]
			void SessionDidEndPlayback(NSObject aSession);
			
			
			
			// -(void)session:(id <SPSessionPlaybackProvider>)aSession didEncounterStreamingError:(NSError *)error;
			[Export ("session:didEncounterStreamingError:")]
			void SessionDidEncounterStreamingError(NSObject aSession, NSError error);
			
			
			
			// -(NSInteger)session:(id <SPSessionPlaybackProvider>)aSession shouldDeliverAudioFrames:(const void *)audioFrames ofCount:(NSInteger)frameCount format:(const sp_audioformat *)audioFormat;
			[Export ("session:shouldDeliverAudioFrames:ofCount:format:")]
			int SessionShouldDeliverAudioFrames(NSObject aSession, NSObject audioFrames, int frameCount, sp_audioformat audioFormat);
			
			
			/* --------------------------------------------------------------------------- */





             /* -------------------------SPCoreAudioControllerDelegate------------------------- */

		 //@protocol SPCoreAudioControllerDelegate <NSObject>

		 //-(void)coreAudioController:(SPCoreAudioController *)controller didOutputAudioOfDuration:(NSTimeInterval)audioDuration;
         [Export("coreAudioController:didOutputAudioOfDuration:")]
         void CoreAudioControllerDidOutputAudio(SPCoreAudioController controller, double duration);
		 
		 /* --------------------------------------------------------------------------- */



		 //-(id)initWithPlaybackSession:(SPSession *)aSession;
         [Export("initWithPlaybackSession:")]
         IntPtr Constructor(SPSession aSession);

		 //-(id)initWithAudioController:(SPCoreAudioController *)aController playbackSession:(SPSession *)aSession;
         [Export("initWithAudioController:playbackSession:")]
         IntPtr Constructor(SPCoreAudioController aController, SPSession aSession);


		 //@property (nonatomic, readonly, strong) SPTrack *currentTrack;
         [Export("currentTrack")]
         SPTrack CurrentTrack {get;}


		 //@property (nonatomic, readwrite, assign) __unsafe_unretained id <SPPlaybackManagerDelegate> delegate;
         [Export("delegate")]
         SPPlaybackManagerDelegate Delegate {get;set;}


		 //@property (nonatomic, readonly, strong) SPSession *playbackSession;
         [Export("playbackSession")]
         SPSession PlaybackSession {get;}


		 // @property (readwrite) BOOL isPlaying;
         [Export("isPlaying")]
         bool IsPlaying {get;set;}


		 //-(void)playTrack:(SPTrack *)aTrack callback:(SPErrorableOperationCallback)block;
         [Export("playTrack:callback:")]
         void PlayTrack(SPTrack aTrack, SPErrorableOperationCallback callback);


		 //-(void)seekToTrackPosition:(NSTimeInterval)newPosition;
         [Export("seekToTrackPosition:")]
         void SeekToTrackPosition(double newPosition);


		 //@property (readonly) NSTimeInterval trackPosition;
         [Export("trackPosition")]
         double TrackPosition {get;}


		// @property (readwrite) double volume;
         [Export("volume")]
         double Volume {get;set;}


         }


#endregion


#region SPPlaylistItem
		


		 //@interface SPPlaylistItem : NSObject
		 [BaseType (typeof(NSObject))]
         interface SPPlaylistItem
         {
    
        //BOOL _unread;
         //[Field ("_unread")]
         //int Unread {get;}



		 //@property (nonatomic, unsafe_unretained, readonly) Class itemClass;
         [Export("itemClass")]
         Class ItemClass {get;}
         
		 

		 //@property (nonatomic, readonly) NSUrl *itemURL;
         [Export("itemURL")]
         NSUrl ItemURL {get;}
		 
		//Not Bound
		 //@property (nonatomic, readonly) sp_linktype itemURLType;
         //[Export("")]
         //ddd
		 
	
		 //@property (nonatomic, readonly, strong) id <SPPlaylistableItem, SPAsyncLoading> item;
         [Export("item")]
         NSObject Item {get;} //TODO: Need to create a class that contains the methods of SPPLaylistableItema nd SPAsyncLoading and set as the return type of this property


		 //@property (nonatomic, readonly, strong) SPUser *creator;
         [Export("creator")]
         SPUser Creator {get;}

		 //@property (nonatomic, readonly, copy) NSDate *dateAdded;
         [Export("dateAdded")]
         NSDate DateAdded {get;}

		 //@property (nonatomic, readonly, copy) NSString *message;
         [Export("message")]
         string Message {get;}

		 //@property (nonatomic, readwrite, getter = isUnread) BOOL unread;
       //  [Export ("unread")]
		// bool Unread { [Bind ("isUnread")]get;set;}

         }


#endregion
		

#region SPDispatch #defines. Not currently bound
		 //NOTE: Already defined as a delegate at top of file
		 //typedef void (^SPErrorableOperationCallback)(NSError *error);


        //TODO: Not bound for now
        //#define SPDispatchSyncIfNeeded(block) if (CFRunLoopGetCurrent() == [SPSession libSpotifyRunloop]) block(); else [SPSession dispatchToLibSpotifyThread:block waitUntilDone:YES];

        //#define SPDispatchAsync(block) [SPSession dispatchToLibSpotifyThread:block];

        //#define SPAssertOnLibSpotifyThread() NSAssert(CFRunLoopGetCurrent() == [SPSession libSpotifyRunloop], @"Not on correct thread!");

#endregion


#region SPPlaylistableItem

		 //@protocol SPPlaylistableItem <NSObject>
         [BaseType (typeof(NSObject))]
         [Model]
         interface SPPlaylistableItem
         {
         
		     //-(NSString *)name;
             [Export("name")]
             string Name();
     
		 
             //-(NSUrl *)spotifyURL;
             [Export("spotifyURL")]
             NSUrl SpotifyURL();
		
         }

#endregion


#region SPPlaylistFolder

		 //@interface SPPlaylistFolder : NSObject
		 [BaseType (typeof(NSObject))]
         interface SPPlaylistFolder
         {

		 //Not bound
         //@property (nonatomic, readonly) sp_uint64 folderId;
		 
		
		 //@property (nonatomic, readonly, copy) NSString *name;
         [Export("name")]
         string Name {get;}

		 //@property (nonatomic, readonly, assign) __unsafe_unretained SPPlaylistContainer *parentContainer;
         [Export("parentContainer")]
         SPPlaylistContainer ParentContainer {get;}


		 // @property (nonatomic, readonly, assign) __unsafe_unretained SPPlaylistFolder *parentFolder;
         [Export("parentFolder")]
         SPPlaylistFolder ParentFolder {get;}
		 
		
		 //-(NSArray *)parentFolders;
         [Export("parentFolders")]
         SPPlaylistFolder [] ParentFolders();


		 //@property (nonatomic, readonly, strong) NSArray *playlists;
         [Export("playlists")]
         NSObject[] Playlists {get;}

		 // @property (nonatomic, readonly, assign) __unsafe_unretained SPSession *session;
         [Export("session")]
         SPSession Session {get;}


         }

#endregion
		 


#region SPErrorExtensions - Not currently bound
		 /* ************************
		  * SPErrorExtensions.h
		  * ************************
		  */


        //public partial class NSError
        //
        //     + (NSError *)spotifyErrorWithDescription:(NSString *)msg code:(NSInteger)code;
        //    + (NSError *)spotifyErrorWithCode:(sp_error)code;
        //    + (NSError *)spotifyErrorWithDescription:(NSString *)msg;
        //    + (NSError *)spotifyErrorWithCode:(NSInteger)code format:(NSString *)format, ...;
        //    + (NSError *)spotifyErrorWithFormat:(NSString *)format, ...;
        //
		 
		 
         //@interface NSError (SPErrorExtensions)
		 
         //+ (NSError *)spotifyErrorWithDescription:(NSString *)msg code:(NSInteger)code;
         //+ (NSError *)spotifyErrorWithCode:(sp_error)code;
         //+ (NSError *)spotifyErrorWithDescription:(NSString *)msg;
         //+ (NSError *)spotifyErrorWithCode:(NSInteger)code format:(NSString *)format, ...;
         //+ (NSError *)spotifyErrorWithFormat:(NSString *)format, ...;
		 
         //@end

#endregion


		 
#region SPUnknownPlaylist

         //@interface SPUnknownPlaylist : SPPlaylist
         [BaseType(typeof(SPPlaylist))]
         interface SPUnknownPlaylist
         {
         }
		 

#endregion


		 
#region SPAlbum

         //@interface SPAlbum : NSObject <SPPlaylistableItem, SPAsyncLoading>
         [BaseType(typeof(NSObject))]
         interface SPAlbum
         {

             
		/* -------------------------SPPlaylistableItem------------------------- */
  
		 //-(NSString *)name;
         [Export("name")]
         string Name();
     
		 
         //-(NSUrl *)spotifyURL;
         [Export("spotifyURL")]
         NSUrl SpotifyURL();


		 /* --------------------------------------------------------------------------- */


        /* -------------------------SPAsyncLoading------------------------- */
		
		//@property (readonly, nonatomic, getter = isLoaded) BOOL loaded;
		 [Export("loaded")]
         bool Loaded {[Bind("isLoaded")]get;set;}

		/* --------------------------------------------------------------------------- */

		 
             //SPAlbum not bound
            
         //+(SPAlbum *)albumWithAlbumStruct:(sp_album *)anAlbum inSession:(SPSession *)aSession;
		 
		
         //+(void)albumWithAlbumURL:(NSUrl *)aURL inSession:(SPSession *)aSession callback:(void (^)(SPAlbum *album))block;
		 
		
         //-(id)initWithAlbumStruct:(sp_album *)anAlbum inSession:(SPSession *)aSession;
		 
		
         //@property (nonatomic, readonly) sp_album *album;
		 
		
         //@property (nonatomic, readonly, getter=isLoaded) BOOL loaded;
		 

         //@property (nonatomic, readonly, strong) SPSession *session;
		 
		
         //@property (nonatomic, readonly, strong) SPArtist *artist; 

         //@property (nonatomic, readonly, strong) SPImage *cover;
		 
         //@property (nonatomic, readonly, strong) SPImage *smallCover;
		 
         //@property (nonatomic, readonly, strong) SPImage *largeCover;
		 
         //@property (nonatomic, readonly, strong) SPImage *largestAvailableCover;
		 
         //@property (nonatomic, readonly, strong) SPImage *smallestAvailableCover;
		 
         //@property (nonatomic, readonly, getter=isAvailable) BOOL available;
		 
         //@property (nonatomic, readonly, copy) NSString *name;
		 
         //@property (nonatomic, readonly, copy) NSUrl *spotifyURL;

         //@property (nonatomic, readonly) sp_albumtype type;

         //@property (nonatomic, readonly) NSUInteger year;

         }


		 
#endregion	 
		  
		 
#region SPArtist
		 //@interface SPArtist : NSObject <SPPlaylistableItem, SPAsyncLoading>
		 [BaseType(typeof(NSObject))]
         interface SPArtist
         {

          /* -------------------------SPPlaylistableItem------------------------- */
  
		 //-(NSString *)name;
         [Export("name")]
         string Name();
     
		 
         //-(NSUrl *)spotifyURL;
         [Export("spotifyURL")]
         NSUrl SpotifyURL();


		 /* --------------------------------------------------------------------------- */



         /* -------------------------SPAsyncLoading------------------------- */
		
		//@property (readonly, nonatomic, getter = isLoaded) BOOL loaded;
		 [Export("loaded")]
         bool Loaded {[Bind("isLoaded")]get;set;}

		/* --------------------------------------------------------------------------- */


           //SPArtist not bound

         //+(SPArtist *)artistWithArtistStruct:(sp_artist *)anArtist inSession:(SPSession *)aSession;
		 
		
         //+(void)artistWithArtistURL:(NSUrl *)aURL inSession:(SPSession *)aSession callback:(void (^)(SPArtist *artist))block;
		 
		
         //-(id)initWithArtistStruct:(sp_artist *)anArtist inSession:(SPSession *)aSession;
		 
	
         //@property (nonatomic, readonly) sp_artist *artist;

         //@property (nonatomic, readonly, copy) NSString *name;

         //@property (nonatomic, readonly, copy) NSUrl *spotifyURL;

         //@property (nonatomic, readonly, getter=isLoaded) BOOL loaded;
		 
		
         }

#endregion


#region SPCircularBuffer


		 //@interface SPCircularBuffer : NSObject 
         [BaseType(typeof(NSObject))]
         interface SPCircularBuffer
         {

			//@private void *buffer;

			//NSUInteger maximumLength;
           // [Field ("maximumLength")]
           // int MaximumLength {get;set;}

            //NSUInteger dataStartOffset;
           // [Field ("dataStartOffset")]
			//int DataStartOffset {get;set;}


			//NSUInteger dataEndOffset;
            //[Field ("dataEndOffset")]
			//int DataEndOffset {get;set;}

            //BOOL empty;
           // [Field ("empty")]
            // bool Empty {get;set;}


            //-(id)initWithMaximumLength:(NSUInteger)size;
		    [Export("initWithMaximumLength:")]
            IntPtr Constructor(uint size);
		
		   //-(void)clear;
           [Export("clear")]
           void Clear();
		 
		
		   //-(NSUInteger)attemptAppendData:(const void *)data ofLength:(NSUInteger)dataLength;
		   [Export ("attemptAppendData:ofLength:")]
		uint AttemptAppendData(NSObject data, uint length);
		
		   //-(NSUInteger)readDataOfLength:(NSUInteger)desiredLength intoAllocatedBuffer:(void **)outBuffer;
           [Export("readDataOfLength:intoAllocatedBuffer:")]
		uint ReadData(uint desiredLength, NSObject outBuffer);

		   //@property (readonly) NSUInteger length;
            [Export("length")]
            uint Length {get;}

		   //@property (readonly) NSUInteger maximumLength;
           //  [Export("maximumLength")]
           // uint MaximumLength {get;}
			
		 }
		 
		
#endregion


#region SPSessionAudioDeliveryDelegate

	[BaseType(typeof(NSObject))]
	[Model]
	interface SPSessionAudioDeliveryDelegate
	{
		//-(NSInteger)session:(id <SPSessionPlaybackProvider>)aSession shouldDeliverAudioFrames:(const void *)audioFrames ofCount:(NSInteger)frameCount streamDescription:(AudioStreamBasicDescription)audioDescription;
		[Export ("session:shouldDeliverAudioFrames:ofCount:streamDescription:")]
		int ShouldDeliverAudioFrames(SPSessionPlaybackProvider aSession, NSObject audioFrames, int frameCount, NSObject audioStreamBasicDescription);

	}


#endregion
		 
#region SPCoreAudioController

		 //@interface SPCoreAudioController : NSObject <SPSessionAudioDeliveryDelegate>
         [BaseType(typeof(NSObject))]
         interface SPCoreAudioController
         {

             /* -------------------------SPSessionAudioDeliveryDelegate------------------------- */
		 
			//-(NSInteger)session:(id <SPSessionPlaybackProvider>)aSession shouldDeliverAudioFrames:(const void *)audioFrames ofCount:(NSInteger)frameCount streamDescription:(AudioStreamBasicDescription)audioDescription;
			[Export ("session:shouldDeliverAudioFrames:ofCount:streamDescription:")]
		int ShouldDeliverAudioFrames(SPSessionPlaybackProvider aSession, NSObject audioFrames, int frameCount, NSObject audioStreamBasicDescription);
			
			
			
			/* --------------------------------------------------------------------------- */



		 //-(void)clearAudioBuffers;
         [Export("clearAudioBuffers")]
         void ClearAudioBuffers();
		 
		 //Not bound
		 //-(BOOL)connectOutputBus:(UInt32)sourceOutputBusNumber ofNode:(AUNode)sourceNode toInputBus:(UInt32)destinationInputBusNumber ofNode:(AUNode)destinationNode inGraph:(AUGraph)graph error:(NSError **)error;
		 
		 //Not bound
		 //-(void)disposeOfCustomNodesInGraph:(AUGraph)graph;

		 //@property (readwrite, nonatomic) double volume;
         [Export("volume")]
         double Volume {get;set;}

		 //@property (readwrite, nonatomic) BOOL audioOutputEnabled;
         [Export("audioOutputEnabled")]
         bool AudioOutputEnabled {get;set;}

		 //@property (readwrite, nonatomic, assign) __unsafe_unretained id <SPCoreAudioControllerDelegate> delegate;
         [Export("delegate")]
         SPCoreAudioControllerDelegate Delegate {get;set;}
		 
			}
		 //@end



#endregion


#region SPURLExtensions - Not currently bound

		 /* ************************
		  * SPURLExtensions.h
		  * ************************
		  */

            //Not Bound
         //@interface NSUrl (SPURLExtensions)

         //+(NSUrl *)urlWithSpotifyLink:(sp_link *)link;

         //-(sp_link *)createSpotifyLink;
		
         //-(sp_linktype)spotifyLinkType;
		 
         //+(NSString *)urlDecodedStringForString:(NSString *)encodedString;
         //+(NSString *)urlEncodedStringForString:(NSString *)plainOldString;


#endregion


#region SPAsyncLoading

		 
		 //@interface SPAsyncLoading : NSObject
         [BaseType(typeof(NSObject))]
         interface SPAsyncLoading
        {


            //+(void)waitUntilLoaded:(id)itemOrItems timeout:(NSTimeInterval)timeout then:(void (^)(NSArray *loadedItems, NSArray *notLoadedItems))block;
		[Static, Export("waitUntilLoaded:timeout:then:")]
		void WaitUntilLoaded(NSObject[] objects, double timeout, LoadingCompleteCallback callback);


		[Static, Export("waitUntilLoaded:timeout:then:")]
		void WaitUntilLoaded(SPTrack track, double timeout, LoadingCompleteCallback callback);

		[Static, Export("waitUntilLoaded:timeout:then:")]
		void WaitUntilLoaded(SPTrack[] tracks, double timeout, LoadingCompleteCallback callback);



		[Static, Export("waitUntilLoaded:timeout:then:")]
		void WaitUntilLoaded(SPPlaylist playlist, double timeout, LoadingCompleteCallback callback);
		
		[Static, Export("waitUntilLoaded:timeout:then:")]
		void WaitUntilLoaded(SPPlaylist[] playlists, double timeout, LoadingCompleteCallback callback);


		[Static, Export("waitUntilLoaded:timeout:then:")]
		void WaitUntilLoaded(SPPlaylistContainer playlistContainer, double timeout, LoadingCompleteCallback callback);

		[Static, Export("waitUntilLoaded:timeout:then:")]
		void WaitUntilLoaded(SPPlaylistContainer[] playlistContainers, double timeout, LoadingCompleteCallback callback);
		


        }

		 
		 
#endregion


}


















