namespace Insphere.Global.Configuration
{
    public static class AddressConfiguration
    {
        private static string api = "";
        public static string API => api;
        private static string reader = "";
        public static string Reader => reader;
        private static string frontend = "";
        public static string Frontend => frontend;

        public static void Initialise(string _api, string _reader, string _frontend)
        {
            api = _api;
            reader = _reader;
            frontend = _frontend;
        }
    }
}
