using StackExchange.Redis;

namespace Backend_SoftGNet.Services
{
    public class ConnectionHelper
    {
#pragma warning disable CS8604 // Posible argumento de referencia nulo
        static ConnectionHelper()
        {
            ConnectionHelper.lazyConnection = new Lazy<ConnectionMultiplexer>(() =>
            {
                return ConnectionMultiplexer.Connect(ConfigurationManager.AppSetting["RedisURL"]);
            });
        }
        private static Lazy<ConnectionMultiplexer> lazyConnection;
        public static ConnectionMultiplexer Connection
        {
            get
            {
                return lazyConnection.Value;
            }
        }
#pragma warning restore CS8604 // Posible argumento de referencia nulo
    }
}
