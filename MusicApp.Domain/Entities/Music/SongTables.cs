using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Domain.Entities.Music
{
    public class SongTables
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [StringLength(50)]
        public string Artist { get; set; }

        [Required]
        public byte[] Mp3File { get; set; }

        [Required]
        [StringLength(100)]
        public string Mp3FileName { get; set; }

        [Required]
        public byte[] Image { get; set; }

        [Required]
        [StringLength(100)]
        public string ImageFileName { get; set; }
    }
}
