using MongoDB.Bson;
using MongoDB.Driver;
using SocialNetwork.DTO;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.DAL
{
    public class CommentDAL
    {
        static MongoClient client = new MongoClient("mongodb://localhost:27017/");
        static IMongoDatabase database = client.GetDatabase("Test");
        static IMongoCollection<Comment> comments = database.GetCollection<Comment>("Comments");

        public static Comment GetCommentById(string commentId)
        {
            return comments.Find(x => x.Id == commentId).FirstOrDefault();
        }

        /*public static int CountPostsByUserId(string userId)
        {
            Posts posts = new Posts();
            var counter = 0;
            var userPost = posts.Get;
            counter = userPost.Count();

            return counter;
        }*/

        public static List<Comment>  GetPostComments(string postId)
        {
            List<Comment> a = comments.Find(x => x.PostIdComment == postId).ToList();
            return a;
        }


        public static string AddComment(string postId, string userId, string comment)
        {
            Comment ins = new Comment();
            ins.Likes = 0;
            ins.LikeUsers = new List<string>() { };
            ins.Content = comment;
            ins.UserIdComment = userId;
            ins.PostIdComment = postId;
            var task = comments.InsertOneAsync(ins);
            task.Wait();
            return Convert.ToString(ins.Id);
        }


        public static void LikeComment(string postId, string likerId)
        {
            var LikeUsers = comments.Find(x => x.Id == postId).Project("{likeUsers:1}").FirstOrDefault().GetValue("likesUsersPost").AsBsonArray;
            if (LikeUsers.Contains(likerId)) {return;}
            else {LikeUsers.Add(likerId);}

            var filter = Builders<Comment>.Filter.Eq(x => x.Id, postId);
            var update = Builders<Comment>.Update.Set("likeUsers", LikeUsers).Inc("likes", 1);
            comments.UpdateOne(filter, update);
        }

        public static void LikeBackComment(string postId, string likerId)
        {
            var LikeUsers = comments.Find(x => x.Id == postId).Project("{likeUsers:1}").FirstOrDefault().GetValue("likesUsersPost").AsBsonArray;
            if (!LikeUsers.Contains(likerId)) { return; }
            else { LikeUsers.Remove(likerId); }

            var filter = Builders<Comment>.Filter.Eq(x => x.Id, postId);
            var update = Builders<Comment>.Update.Set("likeUsers", LikeUsers).Inc("likes", -1);
            comments.UpdateOne(filter, update);
        }

        public static void DeleteComment(string commentId)
        {
            var documentIdToDelete = ObjectId.Parse(commentId).ToString();
            var deleteResult = comments.DeleteOne(Builders<Comment>.Filter.Eq(u => u.Id, documentIdToDelete));
        }
    }
}
