using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.DTODynamo
{
    [DynamoDBTable("SocialNetwork")]
    public class ReactionDynamo
    {
        [DynamoDBHashKey]   //Partition key
        public string PK { get; set; }
        [DynamoDBRangeKey]
        public string SK { get; set; }
        [DynamoDBProperty]
        public string CommentID { get; set; }
        [DynamoDBProperty]
        public string UserID { get; set; }
        [DynamoDBProperty]
        public string Username { get; set; }
    }
}
