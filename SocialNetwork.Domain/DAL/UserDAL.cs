using MongoDB.Bson;
using MongoDB.Driver;
using SocialNetwork.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.DAL
{
    public class UserDAL
    {
        static MongoClient client = new MongoClient("mongodb://localhost:27017/");
        static IMongoDatabase database = client.GetDatabase("Test");
        static IMongoCollection<User> users = database.GetCollection<User>("User");

        public static List<User> GetUsers()
        {
            return users.Find(x => x.Id.ToString().GetType()=="".GetType()).ToList();
        }
        public static string CheckLogin(string username, string password)
        {
            var foundUsername = users.Find(x => x.Username == username).FirstOrDefault();

            if (foundUsername == null)
            {
                throw new Exception("Not correct username");
            }
            else if (foundUsername.Password == password)
            {
                return foundUsername.Id;
            }
            else
            {
                throw new Exception("Not correct password");
            }
        }

        public static User FindUserProfile(string username)
        {
            var foundUser = users.Find(x => x.Username == username).FirstOrDefault(); ;

            if (foundUser == null)
            {
                throw new Exception("No user with this name");
            }
            else
            {
                return foundUser;
            }
        }

        public static User GetUserById(string userId)
        {
            return users.Find(x => x.Id == userId).FirstOrDefault();
        }

        public static List<User> GetFriends(string userId)
        {
            List<User> friends = new List<User>();

            var friendsInfo = GetUserById(userId).Friends;

            foreach (var f in friendsInfo)
            {
                friends.Add(GetUserById(f));
            }
            return friends;
        }
        public static bool IsFriend(string userId, string friendId)
        {
            return (users.Find(x => x.Id == userId).FirstOrDefault().Friends.Contains(friendId)) ? true : false;
        }

        public static void NewFriend(string userId, string targetUsername)
        {
            var friends = users.Find(x => x.Id == userId).Project("{_id:0,followers:1}").FirstOrDefault().First().Value.AsBsonArray;
            var targetId = users.Find(x=> x.Username==targetUsername).Project("{_id:1}").FirstOrDefault().ToString();
            if (!IsFriend(userId, targetId))
                friends.Add(targetId);
            else
                return;

            var filter = Builders<User>.Filter.Eq(x => x.Id, userId);
            var update = Builders<User>.Update.Set("friends", friends);
            users.UpdateOne(filter, update);
        }

        public static void DeleteFriend(string userId, string targetUsername)
        {
            var followArray = users.Find(x => x.Id == userId).Project("{_id:0,followers:1}").FirstOrDefault().First().Value.AsBsonArray;
            var targetId = users.Find(x => x.Username == targetUsername).Project("{_id:1}").FirstOrDefault().ToString();
            if (IsFriend(userId, targetId))
                followArray.Remove(targetId);
            else
                return;

            var filter = Builders<User>.Filter.Eq(x => x.Id, userId);
            var update = Builders<User>.Update.Set("followers", followArray.AsObjectId);
            users.UpdateOne(filter, update);

        }

        public static string AddUser(string firstname, string lastname, string username, string password, string email)
        {
            User ins = new User();
            ins.FirstName = firstname;
            ins.LastName = lastname;
            ins.Username = username;
            ins.Password = password;
            ins.Email = email;
            ins.Interests = new List<string> { };
            ins.Friends = new List<string> { };
            users.InsertOneAsync(ins);
            return username;
        }

        public static void DeleteUser(string username, string password)
        {
             var userId = CheckLogin(username, password);
             var documentIdToDelete = ObjectId.Parse(userId).ToString();
             var deleteResult = users.DeleteOne(Builders<User>.Filter.Eq(u => u.Id, documentIdToDelete));
        }
    }
}
