# IQKeyboardManager MAUI Bindings

[original library creator](https://github.com/hackiftekhar/IQKeyboardManager)

### YOU MAY GENERATE A NEW FRAMEWORK BY DOING THE FOLLOWING
1. Clone the original creators repository
2. Open terminal inside the root directory of the project
3. Run a ```pod install``` (assumption is you had cocoapods installed)
4. Run the following commands
   1. ```xcodebuild -target IQKeyboardManager -configuration Release -sdk iphoneos BUILD_DIR=output```
   2. ```xcodebuild -target IQKeyboardManager -configuration Release -sdk iphonesimulator BUILD_DIR=output```
   3. ```xcodebuild -create-xcframework -framework output/Release-iphoneos/IQKeyboardManager.framework -framework output/Release-iphonesimulator/IQKeyboardManager.framework -output output/IQKeyboardManager.xcframework```
5. There will now be an ```output``` folder which will have the updated .xcframework
6. Copy over the generated .xcframework into the .net project, rebuild the library
7. Bindings may change, so you will have to update ```ApiDefinition.cs``` and ```StructsAndEnums.cs``` manually (recommended to do manually).

### YOU MAY TRY TO AUTO REGENERATE THE BINDING FILES USING SHARPIE

[download sharpie](https://learn.microsoft.com/en-us/previous-versions/xamarin/ios/platform/binding-objective-c/walkthrough?tabs=macos)

* run ```sharpie bind -sdk iphoneos -scope IQKeyboardManager.framework/Headers/*.h;```
* this generates a ton of garbage, find IQKeyboardManager in ```ApiDefinitions.cs```, delete the rest. 
* same deal with ```StructsAndEnums.cs```

It may not work as expected, I'm not an expert, in the end I took the ```ApiDefinitions.cs``` from [here](https://github.com/Emtiaz-Tafsir/Maui.IQKeyboardManager/tree/master)

### USAGE
```C#
// in MauiProgram.cs
#if IOS

using Maui.IQKeyboardManager;
using Microsoft.Maui.Platform;
using UIKit;

#endif
...
public static MauiApp CreateMauiApp()
{
    var builder = MauiApp.CreateBuilder();
    builder
        .UseMauiApp<App>()
        .ConfigureLifecycleEvents(events =>
        {
            #if IOS
            events.AddiOS(ios =>
            {
                ios.FinishedLaunching((a, b) =>
                { 
                    // disable MS Version so it doesn't interfere with IQKeyboardManager 
                    KeyboardAutoManagerScroll.Disconnect();
                    IQKeyboardManager.SharedManager.Enable = true;
                    IQKeyboardManager.SharedManager.EnableAutoToolbar = false;
                    
                    return true;
                });
            });
            #endif
        });
    ...
    return builder.Build();
}
...
```
