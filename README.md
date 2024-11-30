# repro24240
Repro for issue - https://github.com/dotnet/maui/issues/24240

Repro steps:
- Enable "Common Language Runtime Exceptions"
- Select Android Local device debug profile in Visual Studio 
- use connected to Motorola Moto G54 Android 14.0 API 34.


When using emulator, same Android 14.0 API 34, Pixel 7, I cannot reproduce the issue. So possibly, it only happens when connected to a real device.
