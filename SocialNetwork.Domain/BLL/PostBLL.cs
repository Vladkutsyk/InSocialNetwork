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

namespace SocialNetwork.PostBLL
{
    public class PostBLL
    {
        static public void CreatePost(string currentId, string text, string author)
        {
            var _id = PostDAL.AddPost(currentId, text);
            PostNeo4JDAL.CreatePostNeo4J(author, text);
            var postDynamoDAL = new PostDynamoDAL();
            postDynamoDAL.CreatePostItem(_id);
        }
    }
}