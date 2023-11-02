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
    public class CommentNeo4JDAL
    {
        public static GraphClient client = new GraphClient(new Uri("http://localhost:7474/"), "neo4j", "neo4j");

        public static void CreateCommentNeo4J(string author, string text)
        {
            var newComment = new Comment
            {
                CommentDate = DateTime.Now,
                UsernameComment = author,
                Content = text
            };
            client.ConnectAsync().Wait();
            client.Cypher
                .Create("(cmt:Comment $newComment)")
                .WithParam("newComment", newComment)
                .ExecuteWithoutResultsAsync().Wait();
            CreateAuthorConnectionNeo4J(author, text);
        }

        public static void DeleteCommentNeo4J(string text, string author)
        {
            client.ConnectAsync().Wait();
            client.Cypher
                .Match("(cmt:Comment {content: $text, author: $author})")
                .WithParam("text", text)
                .WithParam("author", author)
                .DetachDelete("cmt")
                .ExecuteWithoutResultsAsync().Wait();
        }

        public static void CreateAuthorConnectionNeo4J(string current_user, string text)
        {
            client.ConnectAsync().Wait();
            client.Cypher
                .Match("(crUser:User {username: $crtUser})", "(nwComment:Comment {content: $text, author: $author})")
                .WithParam("crtUser", current_user)
                .WithParam("text", text)
                .WithParam("author", current_user)
                .Create("(crUser)-[:IsAuthor]->(nwComment)")
                .ExecuteWithoutResultsAsync().Wait();
        }
    }
}
