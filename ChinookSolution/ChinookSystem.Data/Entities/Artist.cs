using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional namespaces
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#endregion

namespace ChinookSystem.Data.Entities
{
    [Table("Artists")]
    public  class Artist
    {
        [Key]
        public int AritistId { get; set; }
        public String Name { get; set; }
        public virtual ICollection<Album> Albums { get; set; }
    }
}
