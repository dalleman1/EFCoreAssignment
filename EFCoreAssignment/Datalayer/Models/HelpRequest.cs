﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreAssignment.Datalayer.Models
{
    public class HelpRequest
    {
        public string auId { get; set; }

        Student student { get; set; }

        public int assignmentId { get; set; }
        Assignment assignment { get; set; }
    }
}
