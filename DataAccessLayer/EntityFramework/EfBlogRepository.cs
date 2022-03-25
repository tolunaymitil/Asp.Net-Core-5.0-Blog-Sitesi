using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetListWithCategory()   // Frontendde yazılar uzerınde categoryname gösterebilmek için bunu yaptık.
      {
            using (var c=new Context())
            {
                return c.Blogs.Include(x => x.Category).ToList(); 
            }
                
        }
    }
}
