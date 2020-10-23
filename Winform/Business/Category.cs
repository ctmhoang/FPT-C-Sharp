using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Winform.Dao;

namespace Winform.Business
{
    class Category
    {
        public int Id { get; }

        public string Name { get; set; }

        public Category(int id, string name)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public static List<Category> FetchAll()
        {
            return ProductDataAccess.FetchAllCategory().Select().Select(dr =>
                new Category(Convert.ToInt32(dr["CategoryID"]), dr["CategoryName"].ToString())).ToList();
        }
    }
}