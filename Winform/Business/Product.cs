using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Winform.Dao;

namespace Winform.Business
{
    public class Product : IEquatable<Product>
    {
        public int Cid { get; }
        public int Pid { get; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(int cid, int pid = default, string name = null, decimal price = default)
        {
            Cid = cid;
            Pid = pid;
            Name = name;
            Price = price;
        }

        public static List<Product> FetchAllByCategoryId(int id)
        {
            return ProductDataAccess.GetProductsByCategoryId(id).Select().Select(dr =>
                new Product(id, Convert.ToInt32(dr["ProductID"]), dr["ProductName"].ToString(),
                    Convert.ToDecimal(dr["UnitPrice"]))).ToList();
        }

        public static List<Product> FetchAll()
        {
            return ProductDataAccess.FetchAllProducts().Select().Select(dr =>
                new Product(Convert.ToInt32(dr["CategoryID"]), Convert.ToInt32(dr["ProductID"]), dr["ProductName"].ToString(),
                    Convert.ToDecimal(dr["UnitPrice"]))).ToList();
        }

        public static int Edit(int id, string name, decimal price)
        {
            return ProductDataAccess.EditProduct(id, name, price);
        }

        public static int Insert(int cid, string name, decimal price)
        {
            return ProductDataAccess.InsertProduct(cid, name, price);
        }

        public static int DeleteRange(List<int> ids)
        {
            return ids.Select(ProductDataAccess.DeleteProduct).Sum();
        }

        public bool Equals(Product other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Cid == other.Cid && Pid == other.Pid;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Product) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Cid * 397) ^ Pid;
            }
        }
    }
}