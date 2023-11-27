using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using Amazon.DynamoDBv2.DocumentModel;

namespace SocialNetwork.Domain.DALDynamo
{
    public class PostDynamoDAL
    {
        static AmazonDynamoDBConfig clientConfig = new AmazonDynamoDBConfig();
        // Set the endpoint URL
        static AmazonDynamoDBClient client;
        private static string tableName = "SocialNetwork";
        static Table socialNetwork;

        public PostDynamoDAL()
        {
            clientConfig.ServiceURL = "http://localhost:8000";
            client = new AmazonDynamoDBClient(clientConfig);
            socialNetwork = Table.LoadTable(client, tableName);
        }

        public void CreatePostItem(string _id)
        {
            var post = new Document();
            post["PK"] = "POST#<"+_id+">";
            post["SK"] = "POSTt#<" + _id + ">";
            post["PostID"] = "POST#<" + _id + ">";

            socialNetwork.PutItem(post);
        }
    }
}
