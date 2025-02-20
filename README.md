# IQKeyboardManager MAUI Slim Binding

[original person](https://github.com/hackiftekhar/IQKeyboardManager)

[slim binding documentation article](https://devblogs.microsoft.com/dotnet/native-library-interop-dotnet-maui/)

### YOU NEED THE FOLLOWING FEED IN YOUR NUGET.CONFIG TO BUILD

```
https://pkgs.dev.azure.com/xamarin/public/_packaging/maui-nativelibraryinterop/nuget/v3/index.json
```

### USAGE
```C#
// in MauiProgram.cs
#if IOS

using Maui.IQKeyboardManager;
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
                    IQKBW.EnableKB();
                    
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