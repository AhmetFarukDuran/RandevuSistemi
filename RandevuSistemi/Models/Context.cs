using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RandevuSistemi.Models
{
    public class Context:DbContext
    {
        public DbSet<Kisiler> Kisilers { get; set; }
        public DbSet<Randevu> Randevus { get; set; }
        public DbSet<Personel> Personels { get; set; }
    }
}