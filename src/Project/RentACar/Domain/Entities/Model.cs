using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorePersistence.Repositories;

namespace Domain.Entities
{
    public class Model : Entity
    {
        public Model()
        {
        }

        public Model(int id, int brandId, string name, decimal dailyPrice, string imageUrl) : this()
        {
            Id = id;
            BrandId = brandId;
            Name = name;
            DailyPrice = dailyPrice;
            ImageUrl = imageUrl;
        }

        public int BrandId { get; set; }
        public string Name { get; set; }
        public decimal DailyPrice { get; set; }
        public string ImageUrl { get; set; }
        public virtual Brand? Brand { get; set; }
    }
}