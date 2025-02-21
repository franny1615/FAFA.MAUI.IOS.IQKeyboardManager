using UIKit;
using Foundation;
using ObjCRuntime;
using System;
using CoreGraphics;
using System.ComponentModel;

namespace Maui.IQKeyboardManager;

// @interface IQKeyboardManager : NSObject
[BaseType(typeof(NSObject))]
[DisableDefaultCtor]
interface IQKeyboardManager
{
	// +(instancetype _Nonnull)sharedManager;
	[Static]
	[Export("sharedManager")]
	IQKeyboardManager SharedManager();

	// @property (getter = isEnabled, assign, nonatomic) BOOL enable;
	[Export("enable")]
	bool Enable { [Bind("isEnabled")] get; set; }

	// @property (assign, nonatomic) CGFloat keyboardDistanceFromTextField;
	[Export("keyboardDistanceFromTextField")]
	nfloat KeyboardDistanceFromTextField { get; set; }

	// -(void)reloadLayoutIfNeeded;
	[Export("reloadLayoutIfNeeded")]
	void ReloadLayoutIfNeeded();

	// @property (readonly, getter = isKeyboardShowing, assign, nonatomic) BOOL keyboardShowing;
	[Export("keyboardShowing")]
	bool KeyboardShowing { [Bind("isKeyboardShowing")] get; }

	// @property (readonly, assign, nonatomic) CGFloat movedDistance;
	[Export("movedDistance")]
	nfloat MovedDistance { get; }

	// @property (copy, nonatomic) void (^ _Nullable)(CGFloat) movedDistanceChanged;
	[NullAllowed, Export("movedDistanceChanged", ArgumentSemantic.Copy)]
	Action<nfloat> MovedDistanceChanged { get; set; }

	// @property (getter = isEnableAutoToolbar, assign, nonatomic) BOOL enableAutoToolbar;
	[Export("enableAutoToolbar")]
	bool EnableAutoToolbar { [Bind("isEnableAutoToolbar")] get; set; }

	// @property (assign, nonatomic) IQAutoToolbarManageBehavior toolbarManageBehavior;
	[Export("toolbarManageBehavior", ArgumentSemantic.Assign)]
	IQAutoToolbarManageBehavior ToolbarManageBehavior { get; set; }

	// @property (assign, nonatomic) BOOL shouldToolbarUsesTextFieldTintColor;
	[Export("shouldToolbarUsesTextFieldTintColor")]
	bool ShouldToolbarUsesTextFieldTintColor { get; set; }

	// @property (nonatomic, strong) UIColor * _Nullable toolbarTintColor;
	[NullAllowed, Export("toolbarTintColor", ArgumentSemantic.Strong)]
	UIColor ToolbarTintColor { get; set; }

	// @property (nonatomic, strong) UIColor * _Nullable toolbarBarTintColor;
	[NullAllowed, Export("toolbarBarTintColor", ArgumentSemantic.Strong)]
	UIColor ToolbarBarTintColor { get; set; }

	// @property (assign, nonatomic) IQPreviousNextDisplayMode previousNextDisplayMode;
	[Export("previousNextDisplayMode", ArgumentSemantic.Assign)]
	IQPreviousNextDisplayMode PreviousNextDisplayMode { get; set; }

	// @property (nonatomic, strong) UIImage * _Nullable toolbarPreviousBarButtonItemImage;
	[NullAllowed, Export("toolbarPreviousBarButtonItemImage", ArgumentSemantic.Strong)]
	UIImage ToolbarPreviousBarButtonItemImage { get; set; }

	// @property (nonatomic, strong) UIImage * _Nullable toolbarNextBarButtonItemImage;
	[NullAllowed, Export("toolbarNextBarButtonItemImage", ArgumentSemantic.Strong)]
	UIImage ToolbarNextBarButtonItemImage { get; set; }

	// @property (nonatomic, strong) UIImage * _Nullable toolbarDoneBarButtonItemImage;
	[NullAllowed, Export("toolbarDoneBarButtonItemImage", ArgumentSemantic.Strong)]
	UIImage ToolbarDoneBarButtonItemImage { get; set; }

	// @property (nonatomic, strong) NSString * _Nullable toolbarPreviousBarButtonItemText;
	[NullAllowed, Export("toolbarPreviousBarButtonItemText", ArgumentSemantic.Strong)]
	string ToolbarPreviousBarButtonItemText { get; set; }

	// @property (nonatomic, strong) NSString * _Nullable toolbarPreviousBarButtonItemAccessibilityLabel;
	[NullAllowed, Export("toolbarPreviousBarButtonItemAccessibilityLabel", ArgumentSemantic.Strong)]
	string ToolbarPreviousBarButtonItemAccessibilityLabel { get; set; }

	// @property (nonatomic, strong) NSString * _Nullable toolbarNextBarButtonItemText;
	[NullAllowed, Export("toolbarNextBarButtonItemText", ArgumentSemantic.Strong)]
	string ToolbarNextBarButtonItemText { get; set; }

	// @property (nonatomic, strong) NSString * _Nullable toolbarNextBarButtonItemAccessibilityLabel;
	[NullAllowed, Export("toolbarNextBarButtonItemAccessibilityLabel", ArgumentSemantic.Strong)]
	string ToolbarNextBarButtonItemAccessibilityLabel { get; set; }

	// @property (nonatomic, strong) NSString * _Nullable toolbarDoneBarButtonItemText;
	[NullAllowed, Export("toolbarDoneBarButtonItemText", ArgumentSemantic.Strong)]
	string ToolbarDoneBarButtonItemText { get; set; }

	// @property (nonatomic, strong) NSString * _Nullable toolbarDoneBarButtonItemAccessibilityLabel;
	[NullAllowed, Export("toolbarDoneBarButtonItemAccessibilityLabel", ArgumentSemantic.Strong)]
	string ToolbarDoneBarButtonItemAccessibilityLabel { get; set; }

	// @property (assign, nonatomic) BOOL shouldShowToolbarPlaceholder;
	[Export("shouldShowToolbarPlaceholder")]
	bool ShouldShowToolbarPlaceholder { get; set; }

	// @property (nonatomic, strong) UIFont * _Nullable placeholderFont;
	[NullAllowed, Export("placeholderFont", ArgumentSemantic.Strong)]
	UIFont PlaceholderFont { get; set; }

	// @property (nonatomic, strong) UIColor * _Nullable placeholderColor;
	[NullAllowed, Export("placeholderColor", ArgumentSemantic.Strong)]
	UIColor PlaceholderColor { get; set; }

	// @property (nonatomic, strong) UIColor * _Nullable placeholderButtonColor;
	[NullAllowed, Export("placeholderButtonColor", ArgumentSemantic.Strong)]
	UIColor PlaceholderButtonColor { get; set; }

	// -(void)reloadInputViews;
	[Export("reloadInputViews")]
	void ReloadInputViews();

	// @property (assign, nonatomic) BOOL overrideKeyboardAppearance;
	[Export("overrideKeyboardAppearance")]
	bool OverrideKeyboardAppearance { get; set; }

	// @property (assign, nonatomic) UIKeyboardAppearance keyboardAppearance;
	[Export("keyboardAppearance", ArgumentSemantic.Assign)]
	UIKeyboardAppearance KeyboardAppearance { get; set; }

	// @property (assign, nonatomic) BOOL shouldResignOnTouchOutside;
	[Export("shouldResignOnTouchOutside")]
	bool ShouldResignOnTouchOutside { get; set; }

	// @property (readonly, nonatomic, strong) UITapGestureRecognizer * _Nonnull resignFirstResponderGesture;
	[Export("resignFirstResponderGesture", ArgumentSemantic.Strong)]
	UITapGestureRecognizer ResignFirstResponderGesture { get; }

	// -(BOOL)resignFirstResponder;
	[Export("resignFirstResponder")]
	bool ResignFirstResponder { get; }

	// @property (readonly, nonatomic) BOOL canGoPrevious;
	[Export("canGoPrevious")]
	bool CanGoPrevious { get; }

	// @property (readonly, nonatomic) BOOL canGoNext;
	[Export("canGoNext")]
	bool CanGoNext { get; }

	// -(BOOL)goPrevious;
	[Export("goPrevious")]
	bool GoPrevious { get; }

	// -(BOOL)goNext;
	[Export("goNext")]
	bool GoNext { get; }

	// @property (assign, nonatomic) BOOL shouldPlayInputClicks;
	[Export("shouldPlayInputClicks")]
	bool ShouldPlayInputClicks { get; set; }

	// @property (assign, nonatomic) BOOL layoutIfNeededOnUpdate;
	[Export("layoutIfNeededOnUpdate")]
	bool LayoutIfNeededOnUpdate { get; set; }

	// @property (readonly, nonatomic, strong) NSMutableSet<Class> * _Nonnull disabledDistanceHandlingClasses;
	[Export("disabledDistanceHandlingClasses", ArgumentSemantic.Strong)]
	NSMutableSet<Class> DisabledDistanceHandlingClasses { get; }

	// @property (readonly, nonatomic, strong) NSMutableSet<Class> * _Nonnull enabledDistanceHandlingClasses;
	[Export("enabledDistanceHandlingClasses", ArgumentSemantic.Strong)]
	NSMutableSet<Class> EnabledDistanceHandlingClasses { get; }

	// @property (readonly, nonatomic, strong) NSMutableSet<Class> * _Nonnull disabledToolbarClasses;
	[Export("disabledToolbarClasses", ArgumentSemantic.Strong)]
	NSMutableSet<Class> DisabledToolbarClasses { get; }

	// @property (readonly, nonatomic, strong) NSMutableSet<Class> * _Nonnull enabledToolbarClasses;
	[Export("enabledToolbarClasses", ArgumentSemantic.Strong)]
	NSMutableSet<Class> EnabledToolbarClasses { get; }

	// @property (readonly, nonatomic, strong) NSMutableSet<Class> * _Nonnull toolbarPreviousNextAllowedClasses;
	[Export("toolbarPreviousNextAllowedClasses", ArgumentSemantic.Strong)]
	NSMutableSet<Class> ToolbarPreviousNextAllowedClasses { get; }

	// @property (readonly, nonatomic, strong) NSMutableSet<Class> * _Nonnull disabledTouchResignedClasses;
	[Export("disabledTouchResignedClasses", ArgumentSemantic.Strong)]
	NSMutableSet<Class> DisabledTouchResignedClasses { get; }

	// @property (readonly, nonatomic, strong) NSMutableSet<Class> * _Nonnull enabledTouchResignedClasses;
	[Export("enabledTouchResignedClasses", ArgumentSemantic.Strong)]
	NSMutableSet<Class> EnabledTouchResignedClasses { get; }

	// @property (readonly, nonatomic, strong) NSMutableSet<Class> * _Nonnull touchResignedGestureIgnoreClasses;
	[Export("touchResignedGestureIgnoreClasses", ArgumentSemantic.Strong)]
	NSMutableSet<Class> TouchResignedGestureIgnoreClasses { get; }

	// -(void)registerKeyboardSizeChangeWithIdentifier:(id<NSCopying> _Nonnull)identifier sizeHandler:(void (^ _Nonnull)(CGSize))sizeHandler;
	[Export("registerKeyboardSizeChangeWithIdentifier:sizeHandler:")]
	void RegisterKeyboardSizeChangeWithIdentifier(NSCopying identifier, Action<CGSize> sizeHandler);

	// -(void)unregisterKeyboardSizeChangeWithIdentifier:(id<NSCopying> _Nonnull)identifier;
	[Export("unregisterKeyboardSizeChangeWithIdentifier:")]
	void UnregisterKeyboardSizeChangeWithIdentifier(NSCopying identifier);

	// -(void)registerTextFieldViewClass:(Class _Nonnull)aClass didBeginEditingNotificationName:(NSString * _Nonnull)didBeginEditingNotificationName didEndEditingNotificationName:(NSString * _Nonnull)didEndEditingNotificationName;
	[Export("registerTextFieldViewClass:didBeginEditingNotificationName:didEndEditingNotificationName:")]
	void RegisterTextFieldViewClass(Class aClass, string didBeginEditingNotificationName, string didEndEditingNotificationName);

	// -(void)unregisterTextFieldViewClass:(Class _Nonnull)aClass didBeginEditingNotificationName:(NSString * _Nonnull)didBeginEditingNotificationName didEndEditingNotificationName:(NSString * _Nonnull)didEndEditingNotificationName;
	[Export("unregisterTextFieldViewClass:didBeginEditingNotificationName:didEndEditingNotificationName:")]
	void UnregisterTextFieldViewClass(Class aClass, string didBeginEditingNotificationName, string didEndEditingNotificationName);

	// @property (assign, nonatomic) BOOL enableDebugging;
	[Export("enableDebugging")]
	bool EnableDebugging { get; set; }

	// -(void)registerAllNotifications;
	[Export("registerAllNotifications")]
	void RegisterAllNotifications();

	// -(void)unregisterAllNotifications;
	[Export("unregisterAllNotifications")]
	void UnregisterAllNotifications();
}