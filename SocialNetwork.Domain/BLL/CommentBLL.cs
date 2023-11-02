using Neo4jClient;
using Neo4jClient.Cypher;
using Newtonsoft.Json;
using SocialNetwork.DAL;
using SocialNetwork.DALNeo4J;
using SocialNetwork.DTO;
using SocialNetwork.DTONeo4J;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.UserBLL
{
    public class CommentBLL
    {
        static public void CreateComment(string currentId, string postId, string text, string author)
        {
            SocialNetwork.DAL.CommentDAL.AddComment(postId, currentId, text);
            SocialNetwork.DALNeo4J.CommentNeo4JDAL.CreateCommentNeo4J(author, text);
        }
    }
}