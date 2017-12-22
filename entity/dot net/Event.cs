﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Xmu.Crms.Shared.Models
{
    public class Event
    {
        public long id { get; set; }

        public string Bean { get; set; }

        public string Parameter { get; set; }

        public DateTime Time { get; set; }
    }
}