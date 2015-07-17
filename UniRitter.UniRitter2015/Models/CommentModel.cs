﻿using System;
using System.ComponentModel.DataAnnotations;
namespace UniRitter.UniRitter2015.Models
{
    public class CommentModel
    {

        public Guid? id { get; set; }

        [Required]
        [MaxLength(1000)]
        public string body { get; set; }

        [Required]
        [MaxLength(50)]
        public string title { get; set; }

        public Guid? author { get; set; }

    }
}
