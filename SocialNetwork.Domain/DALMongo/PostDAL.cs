using Microsoft.VisualBasic.ApplicationServices;
using MongoDB.Bson;
using MongoDB.Driver;
using SocialNetwork.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SocialNetwork.DAL
{
    public class PostDAL
    {
        static MongoClient client = new MongoClient("mongodb://localhost:27017/");
        static IMongoDatabase database = client.GetDatabase("Test");
        static IMongoCollection<Post> posts = database.GetCollection<Post>("Posts");

        public static List<Post> GetSortedPosts()
        {
            return posts.Aggregate().SortByDescending(x => x.Date).ToList();
        }

        public static Post GetPostById(string postId)
        {
            return posts.Find(y => y.Id == postId).FirstOrDefault();
        }

        /*public static int CountPostsByUserId(string userId)
        {
            Posts posts = new Posts();
            var counter = 0;
            var userPost = posts.Get;
            counter = userPost.Count();

            return counter;
        }*/
        public static List<Post> GetUserPosts(string userId)
        {
            return posts.Find(y => y.UserIdPost == userId).ToList();
        }

        public static string AddPost(string userId, string text)
        {
            Post ins = new Post();
            ins.Likes = 0;
            ins.LikeUsers = new List<string>() { };
            ins.Content = text;
            ins.UserIdPost = userId;
            ins.Date = DateTime.Now;
            var task = posts.InsertOneAsync(ins);
            task.Wait();
            return Convert.ToString(ins.Id);
        }

        public static void LikePost(string postId, string likerId)
        {
            var LikeUsers = posts.Find(x => x.Id == postId).Project("{likeUsers:1}").FirstOrDefault().GetValue("likesUsersPost").AsBsonArray;
            if (LikeUsers.Contains(likerId)) { return; }
            else { LikeUsers.Add(likerId); }

            var filter = Builders<Post>.Filter.Eq(x => x.Id, postId);
            var update = Builders<Post>.Update.Set("likeUsers", LikeUsers).Inc("likes", -1);
            posts.UpdateOne(filter, update);
        }
        public static void LikeBackPost(string postId, string likerId)
        {
            var LikeUsers = posts.Find(x => x.Id == postId).Project("{likeUsers:1}").FirstOrDefault().GetValue("likesUsersPost").AsBsonArray;
            if (!LikeUsers.Contains(likerId)) { return; }
            else { LikeUsers.Remove(likerId); }

            var filter = Builders<Post>.Filter.Eq(x => x.Id, postId);
            var update = Builders<Post>.Update.Set("likeUsers", LikeUsers).Inc("likes", -1);
            posts.UpdateOne(filter, update);
        }

        public static int GetUserPostsCount(string userId)
        {
            return (int)posts.Count(post => post.UserIdPost == userId);
        }
    }
}