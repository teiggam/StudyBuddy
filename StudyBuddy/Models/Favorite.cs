﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudyBuddy.Models
{
    // Here we created our favorite model with properties being pulled from our database, we started this project code first
    public class Favorite
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FavoriteID { get; set; }

        [Required]
        public string UserID { get; set; }

        public int? QuestionID { get; set; }
    }
}
