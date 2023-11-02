using Neo4jClient;
using Neo4jClient.Cypher;
using Newtonsoft.Json;
using SocialNetwork.DTONeo4J;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.DALNeo4J
{
    public class PostNeo4JDAL
    {
        public static GraphClient client = new GraphClient(new Uri("http://localhost:7474/"), "neo4j", "neo4j");

        public static void CreatePostNeo4J(string author, string text)
        {
            var newPost = new Post
            {
                PostDate = DateTime.Now,
                UsernamePost = author,
                Content = text
            };
            client.ConnectAsync().Wait();
            client.Cypher
                .Create("(pst:Post $newPost)")
                .WithParam("newPost", newPost)
                .ExecuteWithoutResultsAsync().Wait();
            CreateAuthorConnectionNeo4J(author, text);
        }

        public static void DeletePostNeo4J(string text, string author)
        {
            client.ConnectAsync().Wait();
            client.Cypher
                .Match("(pst:Post {content: $text, author = $author})")
                .WithParam("text", text)
                .WithParam("auhor", author)
                .DetachDelete("pst")
                .ExecuteWithoutResultsAsync().Wait();
        }

        public static void CreateAuthorConnectionNeo4J(string current_user, string text)
        {
            client.ConnectAsync().Wait();
            client.Cypher
                .Match("(crUser:User {username: $crtUser})", "(nwPost:Post {content: $text, author: $author})")
                .WithParam("crtUser", current_user)
                .WithParam("text", text)
                .WithParam("author", current_user)
                .Create("(crUser)-[:IsAuthor]->(nwPost)")
                .ExecuteWithoutResultsAsync().Wait();
        }
    }
}
