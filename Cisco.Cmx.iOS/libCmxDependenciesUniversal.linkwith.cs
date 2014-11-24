using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libCmxDependenciesUniversal.a", LinkTarget.Simulator | LinkTarget.ArmV7, ForceLoad = true, SmartLink = true)]
