using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicApp.Web.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public byte[] FileData { get; set; }
    }
}