﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramChecker.DAL.Entities
{
    public class CheckStatus
    {
        public int Id { get; set; }
        public DateTime CheckDate { get; set; }
        public int ChannelsCount { get; set; }
        public int NoUri { get; set; }
        public int ChangeName { get; set; }
        public int ChangeAvatar { get; set; }
    }
}
