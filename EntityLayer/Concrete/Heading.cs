using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        [Key]
        public int HeadingID { get; set; }
        [StringLength(50)]
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }

        public int CategoryID { get; set; }
        //heading tablosunun içinde categoryıd olacak
        public virtual Category Category { get; set; } //sınıftan değer alır, kategori sınıfından değer alır

        public int WriterID { get; set; }

        public virtual Writer Writer { get; set; } //başlığın kimin aççtığını görmüş olacağız
        public ICollection<Content> Contents { get; set; }

    }
}
