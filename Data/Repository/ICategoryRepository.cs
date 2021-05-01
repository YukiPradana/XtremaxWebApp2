using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XtremaxWebApp2.Data.DataModel;

namespace XtremaxWebApp2.Data.Repository
{
    interface ICategoryRepository
    {
        IEnumerable<Category> GetALlCategory();
        Category GetCategoryById(int id);
        void CreateCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(Category category);
    }
}
