using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Asp.netCoreMvc.Models
{
    public class Warehouse
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(25)")]
        [Required(ErrorMessage ="Bu alan gereklidir.") ]
        [DisplayName("Antrepo Adı")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(5)")]
        [DisplayName("Antrepo Kodu")]
        public string Code { get; set; }
        [Column(TypeName = "nvarchar(8)")]
        [DisplayName("Yürürlük G Tarihi")]
        public string TarihG { get; set; }
        [Column(TypeName = "nvarchar(8)")]
        [DisplayName("Yürürlük K Tarihi")]
        public string TarihK { get; set; }
        [Column(TypeName = "nvarchar(6)")]
        [DisplayName("Gümrük")]
        public string Gumruk { get; set; }
    }
}
