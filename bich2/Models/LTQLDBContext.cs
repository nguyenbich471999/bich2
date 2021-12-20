using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace bich2.Models
{
    public partial class LTQLDBContext : DbContext
    {
        public LTQLDBContext()
            : base("name=LTQLDBContext")
        {
        }
        public virtual DbSet<TinhThanh> TinhThanhs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
