﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hrssu.Models.Dtos
{
    public class EnrollStudentsDto
    {
        public int ProfileId { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string OtherName { get; set; }
        public string StudentRegNumberPin { get; set; }
    }
}