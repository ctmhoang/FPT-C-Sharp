using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Winform.Dao;

namespace Winform.Business
{
    class DeliveryCompany
    {
        public int Id { get; }
        public string Name { get; set; }

        public DeliveryCompany(int id, string name)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public static List<DeliveryCompany> FetchAll()
        {
            return OrderDataAccess.FetchAllShippingComp().Select().Select(dr =>
                new DeliveryCompany(Convert.ToInt32(dr["ShipperID"]), dr["CompanyName"].ToString())).ToList();
        }
    }
}