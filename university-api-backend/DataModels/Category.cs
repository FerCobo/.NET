﻿using System.ComponentModel.DataAnnotations;

namespace university_api_backend.DataModels
{
    public class Category: BaseEntity
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        public ICollection<Course> Courses { get; set;} = new List<Course>();
    }
}
