using System;
using ObjCRuntime;

[assembly: LinkWith ("libMorpginLabel-386-7-64-new.a", LinkTarget.ArmV7 | LinkTarget.Arm64 | LinkTarget.Simulator, SmartLink = true, ForceLoad = true)]
