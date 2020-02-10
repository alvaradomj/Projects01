using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Notes.Models
{
    public class Note
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]


        public long ID { get; set; }
        [Required]

        public string Title { get; set; }
        [Required]

        public string  Body { get; set; }

        public User  Owner { get; set; }

    }
}
