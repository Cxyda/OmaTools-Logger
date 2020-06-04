using System.Linq;
using System.Runtime.CompilerServices;

namespace Plugins.O.M.A.Games.Logger.Runtime
{
    /// <summary>
    /// TODO:
    /// </summary>
    public interface ILogger
    {
        void Fatal(string message, FeatureTypes featureType = FeatureTypes.Default, object[] args = null,
            [CallerMemberName] string caller = "");

        void Error(string message, FeatureTypes featureType = FeatureTypes.Default, object[] args = null,
            [CallerMemberName] string caller = "");

        void Warn(string message, FeatureTypes featureType = FeatureTypes.Default, object[] args = null,
            [CallerMemberName] string caller = "");
 
        void Info(string message, FeatureTypes featureType = FeatureTypes.Default, object[] args = null,
            [CallerMemberName] string caller = "");
        
        void Debug(string message, FeatureTypes featureType = FeatureTypes.Default, object[] args = null,
            [CallerMemberName] string caller = "");

        void Trace(string message, FeatureTypes featureType = FeatureTypes.Default, object[] args = null,
            [CallerMemberName] string caller = "");

    }
    public class Log : ILogger
    {
        public void Info(string message, FeatureTypes featureType = FeatureTypes.Default, object[] args = null, string caller = "")
        {
            UnityEngine.Debug.Log($"{featureType.ToString().ToUpper()} ({caller}) :: {message}; args: {JoinArgs(args)}");
        }

        public void Debug(string message, FeatureTypes featureType = FeatureTypes.Default, object[] args = null,
            [CallerMemberName] string caller = "")
        {
            UnityEngine.Debug.Log($"{featureType.ToString().ToUpper()} ({caller}) :: {message}; args: {JoinArgs(args)}");
        }

        public void Trace(string message, FeatureTypes featureType = FeatureTypes.Default, object[] args = null, string caller = "")
        {
            UnityEngine.Debug.Log($"{featureType.ToString().ToUpper()} ({caller}) :: {message}; args: {JoinArgs(args)}");
        }

        public void Fatal(string message, FeatureTypes featureType = FeatureTypes.Default, object[] args = null,
            [CallerMemberName] string caller = "")
        {
            UnityEngine.Debug.LogError($"{featureType.ToString().ToUpper()} ({caller}) :: {message}; args: {JoinArgs(args)}");
            // TODO: Add stacktrace
        }

        public void Error(string message, FeatureTypes featureType = FeatureTypes.Default, object[] args = null, string caller = "")
        {
            UnityEngine.Debug.LogError($"{featureType.ToString().ToUpper()} ({caller}) :: {message}; args: {JoinArgs(args)}");
        }

        public void Warn(string message, FeatureTypes featureType = FeatureTypes.Default, object[] args = null, string caller = "")
        {
            UnityEngine.Debug.LogWarning($"{featureType.ToString().ToUpper()} ({caller}) :: {message}; args: {JoinArgs(args)}");
        }

        private static string JoinArgs(params object[] args)
        {
            var stringArgs = string.Empty;
            if (args != null)
            {
                stringArgs = args.Aggregate("", (current, arg) => current + $" {arg}; ");
            }
            stringArgs = $"[{stringArgs}]";

            return stringArgs;
        }
    }
}