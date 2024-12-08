﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quiz_Application.Services.Entities
{
    public class Candidate : IdentityUser
    {
        [Key]
        public int Sl_No { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Candidate_ID { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string Password { get; set; }
        [MaxLength]
        public string ImgFile { get; set; }
    }
}
