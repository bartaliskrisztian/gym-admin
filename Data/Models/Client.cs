﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessProject.Data
{
    public class Client
    {
        [Key]
        public int Client_id { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        public String Phone_number { get; set; }

        [Required]
        public String Email { get; set; }

        [Required]
        public String Password { get; set; }

        public bool Is_deleted { get; set; } = false;

        public byte[] Photo { get; set; } = new byte[0];

        public DateTime Inserted_date { get; set; }
        
        [Required]
        public String PIN { get; set; }

        [Required]
        public String Address { get; set; }

        public String Bar_code { get; set; } = "";

        public String Comments { get; set; } = "";

        public int User_type { get; set; } = 1;

    }
}
