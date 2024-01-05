using Facil.Erp.Debugging;

namespace Facil.Erp
{
    public class ErpConsts
    {
        public const string LocalizationSourceName = "Erp";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "a937963868b04a5eaf9183e5c774bf77";
    }
}
