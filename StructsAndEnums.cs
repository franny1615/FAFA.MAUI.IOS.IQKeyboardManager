using System;
using ObjCRuntime;

namespace Maui.IQKB;

[Native]
public enum IQAutoToolbarManageBehaviour : long
{
	Subviews,
	Tag,
	Position
}

[Native]
public enum IQAutoToolbarManageBehavior : long
{
	Subviews,
	Tag,
	Position
}

[Native]
public enum IQPreviousNextDisplayMode : ulong
{
	Default,
	AlwaysHide,
	AlwaysShow
}

[Native]
public enum IQEnableMode : ulong
{
	Default,
	Enabled,
	Disabled
}