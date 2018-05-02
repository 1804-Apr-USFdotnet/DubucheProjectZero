﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dubuche.BL
{
    public class Restaurants
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Website { get; set; }
        public string Phone { get; set; }
        public double Rating { get; set; }
        public List<Restaurants> Reviews = new List<Restaurants>();

    }

    public class Reviewers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public double Rating { get; set; }
        public int RestaurantId { get; set; }
    }
}
