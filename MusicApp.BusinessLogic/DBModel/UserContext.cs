﻿using MusicApp.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.BusinessLogic.DBModel
{
    class UserContext : DbContext
    {
        public UserContext() :
            base("name=MusicApp") // connectionstring name define in your web.config
        {

        }

        public virtual DbSet<UDBTable> Users { get; set; }
    }
}
