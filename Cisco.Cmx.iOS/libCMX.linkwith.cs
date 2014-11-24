using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libCMX.a", LinkTarget.Simulator | LinkTarget.ArmV7, ForceLoad = true)]
