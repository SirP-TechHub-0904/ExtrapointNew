﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hrssu.Models.Entities
{
    public class Income
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string UserId { get; set; }
    }
}