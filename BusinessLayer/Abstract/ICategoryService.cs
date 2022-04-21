﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService:IGenericService<Category>
    {

         

        //Bunları sonradan genericleştirdik artık gerek kalmadı. IGenericServicede var .
        //List<Category> GetList();
        //Category GetByID(int id);
        //void CategoryAdd(Category category);
        //void CategoryDelete(Category category);
        //void CategoryUpdate(Category category);
    }
}
