using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorePersistence.Repositories;

namespace Domain.Entities
{
    public class Brand : Entity
    {
        public Brand()
        {
        }

        public Brand(int id, string name) : this()
        {
            Id = id;
            Name = name;
        }

        public string Name { get; set; }
    }
}