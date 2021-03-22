using System;
using System.ComponentModel.DataAnnotations;

namespace AB.Dtos {
    public class UserUpdateDto {

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Date_Registration { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Date_Last_Activity { get; set; }
    }
}