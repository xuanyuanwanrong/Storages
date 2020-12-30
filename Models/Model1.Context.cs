﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class JooWMSEntities : DbContext
    {
        public JooWMSEntities()
            : base("name=JooWMSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<BadReport> BadReport { get; set; }
        public virtual DbSet<BadReportDetail> BadReportDetail { get; set; }
        public virtual DbSet<CheckData> CheckData { get; set; }
        public virtual DbSet<CheckStock> CheckStock { get; set; }
        public virtual DbSet<CheckStockInfo> CheckStockInfo { get; set; }
        public virtual DbSet<CloneHistory> CloneHistory { get; set; }
        public virtual DbSet<CloneTemp> CloneTemp { get; set; }
        public virtual DbSet<CusAddress> CusAddress { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<InStorage> InStorage { get; set; }
        public virtual DbSet<InStorDetail> InStorDetail { get; set; }
        public virtual DbSet<InventoryBook> InventoryBook { get; set; }
        public virtual DbSet<LocalProduct> LocalProduct { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Measure> Measure { get; set; }
        public virtual DbSet<MeasureRel> MeasureRel { get; set; }
        public virtual DbSet<MoveOrder> MoveOrder { get; set; }
        public virtual DbSet<MoveOrderDetail> MoveOrderDetail { get; set; }
        public virtual DbSet<OutStoDetail> OutStoDetail { get; set; }
        public virtual DbSet<OutStorage> OutStorage { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductCategory> ProductCategory { get; set; }
        public virtual DbSet<ReportParams> ReportParams { get; set; }
        public virtual DbSet<Reports> Reports { get; set; }
        public virtual DbSet<ReturnDetail> ReturnDetail { get; set; }
        public virtual DbSet<ReturnOrder> ReturnOrder { get; set; }
        public virtual DbSet<Sequence> Sequence { get; set; }
        public virtual DbSet<Storage> Storage { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<SysDepart> SysDepart { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<SysRelation> SysRelation { get; set; }
        public virtual DbSet<SysResource> SysResource { get; set; }
        public virtual DbSet<SysRole> SysRole { get; set; }
        public virtual DbSet<TNum> TNum { get; set; }
    }
}
