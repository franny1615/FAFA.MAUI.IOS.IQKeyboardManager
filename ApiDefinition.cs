using Foundation;

namespace Maui.IQKeyboardManager;

[BaseType(typeof(NSObject))]
interface IQKBW
{
    [Static]
    [Export("enableKB")]
    void EnableKB();
}