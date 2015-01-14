using System;
using ObjCRuntime;

[assembly: LinkWith ("libZipArchive.a", LinkTarget.Simulator | LinkTarget.ArmV7, SmartLink = true, ForceLoad = true)]
