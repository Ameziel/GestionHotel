﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionHotel.Apis.administration
{
    [Table("users")]
    public class UserAPP
    {
        [Key]
        public Guid Id { get; set; }

        [EnumDataType(typeof(UserRole))]
        public UserRole Role { get; set; }
    }
}
