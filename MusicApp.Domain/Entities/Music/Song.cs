using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Domain.Entities.Music
{
    public class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public byte[] Mp3File { get; set; }
        public string Mp3FileName { get; set; }
        public byte[] Image { get; set; }
        public string ImageFileName { get; set; }
    }
}
