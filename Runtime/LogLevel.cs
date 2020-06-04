using System;

namespace Plugins.O.M.A.Games.Logger.Runtime
{
    /// <summary>
    /// TODO: 
    /// </summary>
    [Flags]
    public enum LogLevel
    {
        Off = 0,
        Fatal = 1 << 1,
        Error = 1 << 2,
        Warn = 1 << 3,
        Info = 1 << 4,
        Debug = 1 << 5,
        Trace = 1 << 6
    }
}