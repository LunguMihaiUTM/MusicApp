using MusicApp.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicApp.Domain.Entities.Music;

namespace MusicApp.BusinessLogic.DBModel
{
    public class SongContext : DbContext
    {
        public SongContext() :
            base("name = MusicApp") // connectionstring name define in your web.config
        {

        }

        public virtual DbSet<SongTables> Songs { get; set; }
    }
}
