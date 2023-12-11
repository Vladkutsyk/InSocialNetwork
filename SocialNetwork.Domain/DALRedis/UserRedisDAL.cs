using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.Redis;
using ServiceStack.Text;
using SocialNetwork.DTO;

namespace SocialNetwork.Domain.DALRedis
{
    public class UserRedisDAL
    {
        static string host = "localhost";
        static int port = 6379;
        public static bool dbIsNotEmpty()
        {
            using (RedisClient client = new RedisClient(host, port))
            {
                return Convert.ToBoolean(client.Exists("0"));
            }
        }

        public static void WriteUsersToRedis(List<User> users)
        {
            using (RedisClient client = new RedisClient(host, port))
            {
                DateTime now = DateTime.Now;
                for(int i=0; i<users.Count; i++)
                {
                    client.HSet(i.ToString(), Encoding.UTF8.GetBytes("Id"), Encoding.UTF8.GetBytes(users[i].Id));
                    client.HSet(i.ToString(), Encoding.UTF8.GetBytes("FirstName"), Encoding.UTF8.GetBytes(users[i].FirstName));
                    client.HSet(i.ToString(), Encoding.UTF8.GetBytes("LastName"), Encoding.UTF8.GetBytes(users[i].LastName));
                    client.HSet(i.ToString(), Encoding.UTF8.GetBytes("Username"), Encoding.UTF8.GetBytes(users[i].Username));
                    client.HSet(i.ToString(), Encoding.UTF8.GetBytes("Email"), Encoding.UTF8.GetBytes(users[i].Email));
                    client.HSet(i.ToString(), Encoding.UTF8.GetBytes("Password"), Encoding.UTF8.GetBytes(users[i].Password));
                    client.HSet(i.ToString(), Encoding.UTF8.GetBytes("InterestLength"), Encoding.UTF8.GetBytes(users[i].Interests.Count.ToString()));
                    for(int j=0; j<users[i].Interests.Count; j++)
                    {
                        client.HSet(i.ToString(), Encoding.UTF8.GetBytes("Interest"+j.ToString()), Encoding.UTF8.GetBytes(users[i].Interests[j]));
                    }
                    client.HSet(i.ToString(), Encoding.UTF8.GetBytes("FriendsLength"), Encoding.UTF8.GetBytes(users[i].Friends.Count.ToString()));
                    for (int j = 0; j < users[i].Friends.Count; j++)
                    {
                        client.HSet(i.ToString(), Encoding.UTF8.GetBytes("Friend" + j.ToString()), Encoding.UTF8.GetBytes(users[i].Friends[j]));
                    }

                    client.ExpireAt(i.ToString(), now.ToUnixTime() + 30);
                }
            }
        }

        public static List<User> ReadUsersFromRedis()
        {
            List <User> users = new List<User>();
            using (RedisClient client = new RedisClient(host, port))
            {
                List<string> keys = client.GetAllKeys();
                for (int i = 0; i < keys.Count; i++)
                {
                    User user = new User();
                    user.Id = Encoding.UTF8.GetString(client.HGet(keys[i], Encoding.UTF8.GetBytes("Id")));
                    user.FirstName = Encoding.UTF8.GetString(client.HGet(keys[i], Encoding.UTF8.GetBytes("FirstName")));
                    user.LastName = Encoding.UTF8.GetString(client.HGet(keys[i], Encoding.UTF8.GetBytes("Lastname")));
                    user.Username = Encoding.UTF8.GetString(client.HGet(keys[i], Encoding.UTF8.GetBytes("Username")));
                    user.Email = Encoding.UTF8.GetString(client.HGet(keys[i], Encoding.UTF8.GetBytes("Email")));
                    user.Password = Encoding.UTF8.GetString(client.HGet(keys[i], Encoding.UTF8.GetBytes("Password")));

                    List<string> interests = new List<string>();
                    List<string> friends = new List<string>();
                    int interestLength = Convert.ToInt32(Encoding.UTF8.GetString(client.HGet(keys[i], Encoding.UTF8.GetBytes("InterestLength"))));
                    for(int j=0; j<interestLength; j++)
                    {
                        interests.Add(Encoding.UTF8.GetString(client.HGet(keys[i], Encoding.UTF8.GetBytes("Interest" +j.ToString()))));
                    }
                    user.Interests = interests; 
                    int friendLength = Convert.ToInt32(Encoding.UTF8.GetString(client.HGet(keys[i], Encoding.UTF8.GetBytes("FriendsLength"))));
                    for (int j = 0; j < friendLength; j++)
                    {
                        interests.Add(Encoding.UTF8.GetString(client.HGet(keys[i], Encoding.UTF8.GetBytes("Friend" + j.ToString()))));
                    }
                    user.Friends = friends;
                    users.Add(user);
                }
            }

            return users;
        }
    }
}