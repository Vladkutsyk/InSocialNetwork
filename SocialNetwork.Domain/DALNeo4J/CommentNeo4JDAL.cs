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

        public static void CreateCommentNeo4J(string commentId, string author, string text)
        {
            var newComment = new Comment
            {
                CommentID = commentId,
                UsernameComment = author,
                Content = text
            };
            client.ConnectAsync().Wait();
            client.Cypher
                .Create("(cmt:Comment $newComment)")
                .WithParam("newComment", newComment)
                .ExecuteWithoutResultsAsync().Wait();
            CreateAuthorConnectionNeo4J(author, commentId);
        }

        public static void DeleteCommentNeo4J(string comment)
        {
            client.ConnectAsync().Wait();
            client.Cypher
                .Match("(cmt:Comment {id: $comment})")
                .WithParam("comment", comment)
                .DetachDelete("cmt")
                .ExecuteWithoutResultsAsync().Wait();
        }

        public static void CreateAuthorConnectionNeo4J(string current_user, string commentId)
        {
            client.ConnectAsync().Wait();
            client.Cypher
                .Match("(crUser:User {username: $crtUser})", "(nwComment:Comment {id: $cmtId})")
                .WithParam("crtUser", current_user)
                .WithParam("cmtId", commentId)
                .Create("(crUser)-[:IsAuthor]->(nwComment)")
                .ExecuteWithoutResultsAsync().Wait();
        }
    }
}
