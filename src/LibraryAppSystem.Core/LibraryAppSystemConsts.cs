using LibraryAppSystem.Debugging;

namespace LibraryAppSystem
{
    public class LibraryAppSystemConsts
    {
        public const string LocalizationSourceName = "LibraryAppSystem";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "931273e3bef7435e814f85a2f498f84f";
    }
}
