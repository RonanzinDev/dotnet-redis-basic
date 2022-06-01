using redis;
using ServiceStack.Redis;
var host = "localhost:6379";
var client1 = new Client { Name = "Gabriel", Document = "123" };
var client2 = new Client { Name = "Daniel", Document = "3455234" };
using (var redisClient = new RedisClient(host))
{
    // storage on redis
    redisClient.Set<Client>(client1.Key.ToString(), client1);
    redisClient.Set<Client>(client2.Key.ToString(), client2);
    // Get a data from redis
    var clientX = redisClient.Get<Client>(client1.Key.ToString());
}
