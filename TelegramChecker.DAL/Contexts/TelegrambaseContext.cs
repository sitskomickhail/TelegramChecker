using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramChecker.DAL.Entities;

namespace TelegramChecker.DAL.Contexts
{
    class TelegrambaseContext:DbContext
    {
        public TelegrambaseContext():base("telegramsoftDB")
        {}

        public DbSet<Channels> Channels { get; set; }
        public DbSet<CheckStatus> CheckStatuses { get; set; }
    }
}
