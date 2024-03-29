﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaForums.Data.Models
{
    public class Forum
    {
        public int Id { get; set; }
        public string Titlle { get; set; }
        public string Descriptiom { get; set; }
        public DateTime Created { get; set; }
        public string ImageUrl { get; set; }

        public virtual IEnumerable<Post> Posts { get; set; }
    }
}
