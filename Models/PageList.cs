using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class PageList
    {
        //数据集合
        public IQueryable DataList { get; set; }

        //总行数
        public int PageCount { get; set; }
    }
}
