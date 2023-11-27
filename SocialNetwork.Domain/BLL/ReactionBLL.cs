using SocialNetwork.DAL;
using SocialNetwork.Domain.DALDynamo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.BLL
{
    public class ReactionBLL
    {
        static public void CreateReactionComment(string currentId, string commentId, string author)
        {
            CommentDAL.LikeComment(commentId, currentId);
            var reactionDynamoDAL = new ReactionDynamoDAL();
            reactionDynamoDAL.CreateReactionItem(CommentDAL.GetCommentById(commentId).PostIdComment, commentId, currentId, author);    
        }

        static public void DeleteReactionComment(string currentId, string commentId, string author)
        {
            CommentDAL.LikeBackComment(commentId, currentId);
            var reactionDynamoDAL = new ReactionDynamoDAL();
            reactionDynamoDAL.DeleteReactionItem(CommentDAL.GetCommentById(commentId).PostIdComment, commentId, currentId);
        }
    }
}
