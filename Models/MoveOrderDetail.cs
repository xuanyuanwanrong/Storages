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
    
    public partial class MoveOrderDetail
    {
        public int ID { get; set; }
        public string SnNum { get; set; }
        public string OrderNum { get; set; }
        public string ProductName { get; set; }
        public string BarCode { get; set; }
        public string ProductNum { get; set; }
        public string BatchNum { get; set; }
        public double Num { get; set; }
        public Nullable<double> InPrice { get; set; }
        public Nullable<double> Amout { get; set; }
        public int IsPick { get; set; }
        public double RealNum { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string StorageNum { get; set; }
        public string FromLocalNum { get; set; }
        public string ToLocalNum { get; set; }
    }
}
