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
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Bad = new HashSet<Bad>();
            this.Delivery = new HashSet<Delivery>();
            this.MoveBank = new HashSet<MoveBank>();
            this.ReturnPrduct = new HashSet<ReturnPrduct>();
            this.Warehousing = new HashSet<Warehousing>();
        }
    
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public Nullable<int> did { get; set; }
        public Nullable<int> UserJdId { get; set; }
        public Nullable<int> UserState { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bad> Bad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Delivery> Delivery { get; set; }
        public virtual Department Department { get; set; }
        public virtual Jurisdiction Jurisdiction { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MoveBank> MoveBank { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReturnPrduct> ReturnPrduct { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Warehousing> Warehousing { get; set; }
    }
}
