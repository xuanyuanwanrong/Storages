//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.Relation = new HashSet<Relation>();
        }
    
        public int PId { get; set; }
        public int MId { get; set; }
        public string PName { get; set; }
        public Nullable<double> PPrice { get; set; }
        public string Pspecifications { get; set; }
        public string PRemarks { get; set; }
        public Nullable<int> PcId { get; set; }
        public Nullable<int> PCount { get; set; }
        public Nullable<int> WhId { get; set; }
        public Nullable<int> CtId { get; set; }
        public Nullable<int> PState { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Metering Metering { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
        public virtual WareHouse WareHouse { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Relation> Relation { get; set; }
    }
}
