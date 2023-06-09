﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Zero_Hunger.EF.Models;
using ZeroHunger.Ef.Models;

namespace ZeroHunger.Ef
{
    public class ZHContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Resturant> Resturants { get; set; }
        public DbSet<CollectRequests> CollectRequests { get; set; }
        public DbSet<Distribution> Distribution { get; set; }
        public DbSet<Food> Foods { get; set; }

    }
}