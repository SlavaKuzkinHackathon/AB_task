using System;
using System.ComponentModel.DataAnnotations;
using Npgsql;

namespace AB.Models {

    public class User {
        [Key]
        [Required]
        public int Id { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Date_Registration { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Date_Last_Activity { get; set; }
    }
}
