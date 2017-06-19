using SistemaAcademico.SchemaTypes;
using SistemaAcademico.FixedValues;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace SistemaAcademico.Classes

{
    #region UsersModule
    public class User
    {
        public int UserId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Name2 { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Password { get; set; }
        [EmailAddress]
        [StringLength(450)]
        [Index(IsUnique = true)]
        [Index]
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime BirhtdaDate { get; set; }
        public int PhoneNum { get; set; }
        [Required]
        public sex Sex { get; set; }
        [Required]
        public UserTypes UserType { get; set; }

    }
    #endregion
    #region sysmodule
    public class MenuOption
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public UserTypes allowedType { get; set; }
        public MenuOption parent { get; set; }
        public int order { get; set; }
    }
    #endregion
}
