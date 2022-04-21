using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService:IGenericService<Blog>
    {       
            //IGENERİCSERVİCE VAR ARTIK BUNLARA GEREK KALMADI :
            //List<Blog> GetList();
            //void BlogAdd (Blog blog);
            //void BlogDelete(Blog blog);
            //void BlogUpdate(Blog blog);
            //Blog GetByID(int id);
        List<Blog> GetBlogListWithCategory();   // Frontendde yazılar uzerınde categoryname gösterebilmek sonradan ekledik.
        List<Blog> GetBlogListByWriter(int id );        //Ekranın sagına yazarların yazdıgı diger yazıları getiricez.

    }
    }
 