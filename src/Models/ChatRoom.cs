﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetSignalR.Models
{
    public class ChatRoom
    {
        public string OwnerConnectionId { get; set; }

        public string Name { get; set; }
    }
}
