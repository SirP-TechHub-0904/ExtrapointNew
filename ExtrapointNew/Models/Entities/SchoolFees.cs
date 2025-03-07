﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hrssu.Models.Entities
{
    public class SchoolFees
    {
        public int Id { get; set; }

        [Display(Name = "SCHOOL FEES CATEGORY")]
        public string Category { get; set; }

        [Display(Name = "TOTAL AMOUNT")]
        public string Amount { get; set; }

        [Display(Name = "DISCOUNT")]
        public string Discount { get; set; }

        [Display(Name = "AMOUNT DUE")]
        public string AmountDue { get; set; }

        public int EnrolmentId { get; set; }

        public int? SessionId { get; set; }
        public Session Session { get; set; }
    }
}