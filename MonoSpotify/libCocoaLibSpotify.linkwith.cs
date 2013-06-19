using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libCocoaLibSpotify.a", LinkTarget.ArmV7 | LinkTarget.Simulator,  ForceLoad = true, IsCxx=true, Frameworks = "QuartzCore CoreGraphics SystemConfiguration CFNetwork CoreAudio AudioToolbox AVFoundation Security")]



//When including libCocoaLibSpotify in your application, you must also link to the following frameworks:
//	
//	SystemConfiguration.framework
//		CFNetwork.framework
//		libstdc++
//		CoreAudio.framework
//		AudioToolbox.framework
//		AVFoundation.framework
