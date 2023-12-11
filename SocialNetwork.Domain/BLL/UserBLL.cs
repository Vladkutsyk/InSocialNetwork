using Neo4jClient;
using Neo4jClient.Cypher;
using Newtonsoft.Json;
using SocialNetwork.DAL;
using SocialNetwork.DALNeo4J;
using SocialNetwork.Domain.DALRedis;
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

        static public Tuple<bool, int, List<DTO.Post>> OnSelectionChanged(string currentUsername, string getId, string getUsername)
        {
            return Tuple.Create(UserNeo4JDAL.CheckFriendConnectionNeo4J(currentUsername, getUsername), 
                UserNeo4JDAL.PathLengthNeo4J(currentUsername, getUsername), PostDAL.GetUserPosts(getId));   
        }

        static public void AddUser(string firstname, string lastname, string username, string password, string email)
        {
            _ = SocialNetwork.DAL.UserDAL.AddUser(firstname, lastname, username, password, email);
            SocialNetwork.DALNeo4J.UserNeo4JDAL.CreateUserNeo4J(firstname, lastname, username);
        }

        static public void DeleteUser(string currentId, string password, string currentUsername)
        {
            SocialNetwork.DAL.UserDAL.DeleteUser(currentId, password);
            SocialNetwork.DALNeo4J.UserNeo4JDAL.DeleteUserNeo4J(currentUsername);
        }

        static public List<DTO.User> DataAccess()
        {
            if (UserRedisDAL.dbIsNotEmpty())
            {
                return UserRedisDAL.ReadUsersFromRedis();
            }
            else
            {
                UserRedisDAL.WriteUsersToRedis(UserDAL.GetUsers());
                return UserDAL.GetUsers();
            }
        }
    }
}