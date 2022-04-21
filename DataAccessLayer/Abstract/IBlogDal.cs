using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
   public interface IBlogDal:IGenericDal<Blog>
    {
        List<Blog> GetListWithCategory();      // Frontendde yazılar uzerınde categoryname gösterebilmek için bunu yaptık.
        List<Blog> GetListWithCategoryByWriter(int id);       // Bloglarda Kategori Adının Listelenmesi için 57. derste yazdık.
    }
}
