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
    public class UserBLL
    {
        static public void AddFriend(string currentId, string newId)
        {
            SocialNetwork.DAL.UserDAL.NewFriend(currentId, newId);
            SocialNetwork.DALNeo4J.UserNeo4JDAL.CreateFriendConnectionNeo4J(currentId, newId);
        }

        static public void DeleteFriend(string currentId, string oldId)
        {
            SocialNetwork.DAL.UserDAL.DeleteFriend(currentId, oldId);
            SocialNetwork.DALNeo4J.UserNeo4JDAL.DeleteFriendConnectionNeo4J(currentId, oldId);
        }

        static public Tuple<bool, int, List<DTO.Post>> OnSelectionChanged(string currentId, string getId)
        {
            return Tuple.Create(UserNeo4JDAL.CheckFriendConnectionNeo4J(currentId, getId), 
                UserNeo4JDAL.PathLengthNeo4J(currentId, getId), PostDAL.GetUserPosts(getId));   
        }
    }
}