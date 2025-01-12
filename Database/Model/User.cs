﻿sing System.ComponentModel.DataAnnotations;

namespace Database.Model
{
    public class UserInfo : BaseModel
    {
        [Key]
        public string UserId { get; set; } = Guid.NewGuid().ToString();
        [Required, MaxLength(40)]
        public string? FullName { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? PasswordHash { get; set; }
        public bool IsActive { get; set; }
    }
}