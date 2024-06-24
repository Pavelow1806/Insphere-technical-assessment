namespace Insphere.Global.Configuration
{
    public static class AddressConfiguration
    {
        private static string api = "";
        public static string API => api;
        private static string reader = "";
        public static string Reader => reader;

        public static void Initialise(string _api, string _reader)
        {
            api = _api;
            reader = _reader;
        }
    }
}
