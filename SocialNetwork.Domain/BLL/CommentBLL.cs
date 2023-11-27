using Neo4jClient;
using Neo4jClient.Cypher;
using Newtonsoft.Json;
using SocialNetwork.DAL;
using SocialNetwork.DALNeo4J;
using SocialNetwork.Domain.DALDynamo;
using SocialNetwork.DTO;
using SocialNetwork.DTONeo4J;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Amazon.DynamoDBv2;

namespace SocialNetwork.UserBLL
{
    public class CommentBLL
    {
        static public void CreateComment(string currentId, string postId, string text, string author)
        {
            string _id = CommentDAL.AddComment(postId, currentId, text);
            CommentNeo4JDAL.CreateCommentNeo4J(author, text);
            var commentDynamoDAL = new CommentDynamoDAL();
            commentDynamoDAL.CreateCommentItem(postId, _id, currentId, author, text);
        }

        static public void UpdateComment(string currentId, string postId, string commentId, string text, string author)
        {
            var commentDynamoDAL = new CommentDynamoDAL();
            commentDynamoDAL.UpdateCommentItem(postId, commentId, text);
        }

        static public void DeleteComment(string currentId, string postId, string commentId, string text, string author)
        {
            CommentDAL.DeleteComment(commentId);
            CommentNeo4JDAL.DeleteCommentNeo4J(text, author);
            var commentDynamoDAL = new CommentDynamoDAL();
            commentDynamoDAL.DeleteCommentItem(postId, commentId);
        }

        static public List<Document> GetPostComments(string currentId, string postId, string author)
        {
            var commentDynamoDAL = new CommentDynamoDAL();
            return commentDynamoDAL.QueryIndex(postId);
        }
    }
}