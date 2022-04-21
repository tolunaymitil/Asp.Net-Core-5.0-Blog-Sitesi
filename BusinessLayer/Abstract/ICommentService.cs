using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void CommentAdd(Comment comment);
        List<Comment> GetList(int id );   //Yorum lİsteleme
        //Comment GetByID(int id);
        List<Comment> GetCommentWithBlog();
        // void CommentDelete(Comment comment);
        //  void CommentUpdate(Comment comment);
    }
}
