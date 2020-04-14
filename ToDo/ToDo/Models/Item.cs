using System;
using System.ComponentModel.DataAnnotations;

namespace ToDo.Models
{
    public class Item
    {
        public int Id { get; set; }
        [StringLength(20, ErrorMessage = "must be less than 21 characters.")]
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime Due { get; set; }  
    }
}