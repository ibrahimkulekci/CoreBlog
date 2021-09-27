using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Page
    {
        [Key]
        public int PageID { get; set; }
        public string PageTitle { get; set; }
        public string PageContent { get; set; }
        public string PageSeoUrl { get; set; }
        public DateTime PageCreateDate { get; set; }
        public DateTime PageUpdateDate { get; set; }
        public bool PageStatus { get; set; }
    }
}
