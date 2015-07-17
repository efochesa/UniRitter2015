﻿using System;
using System.ComponentModel.DataAnnotations;
namespace UniRitter.UniRitter2015.Models
{
    public class PostModel
    {

        public Guid? id { get; set; }

        [Required]
        [MaxLength(4000)]
        public string body { get; set; }

        [Required]
        [MaxLength(100)]
        public string title { get; set; }

        public Guid? author { get; set; }

        public string[] tags {get; set;}

    }
}