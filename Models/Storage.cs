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
    
    public partial class Storage
    {
        public int ID { get; set; }
        public string StorageNum { get; set; }
        public string StorageName { get; set; }
        public int StorageType { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public string Action { get; set; }
        public int IsDelete { get; set; }
        public int Status { get; set; }
        public int IsForbid { get; set; }
        public int IsDefault { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string Remark { get; set; }
    }
}
