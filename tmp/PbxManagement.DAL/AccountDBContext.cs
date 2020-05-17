using PbxManagement.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PbxManagement.DAL
{
    public class AccountDBContext : DbContext
    {
        public virtual DbSet<app_Users> Users { get; set; }
        public virtual DbSet<app_Roles> Roles { get; set; }
        
    }
}
