using System.Diagnostics;

namespace MauiCollectionView;

internal static class Logger
{
    public static void Log(string message)
    {
#if IOS || ANDROID
        Console.WriteLine(message);
#elif WINDOWS10_0_17763_0_OR_GREATER
        Trace.WriteLine(message);
#endif
    }
}