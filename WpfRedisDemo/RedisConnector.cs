using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfRedisDemo
{
    public class RedisConnector
    {
        public static IDatabase GetRedisInstance()
        {
            return ConnectionMultiplexer.Connect("localhost").GetDatabase();
        }
    }
}
