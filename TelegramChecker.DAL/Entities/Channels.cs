using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramChecker.DAL.Entities
{
    class Channels
    {
        public int Id { get; set; }
        public string WorkName_Channel { get; set; }
        public string Name_Channel { get; set; }
        public string Uri_Channel { get; set; }
        public string Avatar_Channel { get; set; }
        public string Subscribers_Channel { get; set; }

    }
}
