using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Categories
    {
        public int CateId { get; set; }
        public string CateName { get; set; }
        public string Alias { get; set; }
        public int ParrentId { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateByUser { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
        public string Keyword { get; set; }
    }
}
