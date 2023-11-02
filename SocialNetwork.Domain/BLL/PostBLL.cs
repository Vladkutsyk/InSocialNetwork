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

namespace SocialNetwork.PostBLL
{
    public class PostBLL
    {
        static public void CreatePost(string currentId, string text, string author)
        {
            SocialNetwork.DAL.PostDAL.AddPost(currentId, text);
            SocialNetwork.DALNeo4J.PostNeo4JDAL.CreatePostNeo4J(author, text);
        }
    }
}