using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neo4jClient;
using Neo4jClient.Cypher;
using Newtonsoft.Json;

namespace SocialNetwork.DTONeo4J
{
    public class Comment
    {

        [JsonProperty(PropertyName = "id")]
        public string CommentID { get; set; }

        [JsonProperty(PropertyName = "author")]
        public string UsernameComment { get; set; }

        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }

    }
}
