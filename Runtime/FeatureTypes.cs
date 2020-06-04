using System;

namespace Plugins.O.M.A.Games.Logger.Runtime
{
    /// <summary>
    /// TODO: 
    /// </summary>
    [Flags]
    public enum FeatureTypes : long
    {
        Default = 1L,
        Services = 1L << 2,
        Models = 1L << 4,
        Views = 1L << 4
    }
}