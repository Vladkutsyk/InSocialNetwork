using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.DTODynamo
{
    [DynamoDBTable("SocialNetwork")]
    public class PostDynamo
    {
        [DynamoDBHashKey]   //Partition key
        public string PK { get; set; }
        [DynamoDBRangeKey]
        public string SK { get; set; }
        [DynamoDBProperty]
        public string PostID { get; set; }
    }
}
