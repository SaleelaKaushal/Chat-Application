using System.ComponentModel.DataAnnotations;

namespace AppChat.Models
{
    public class Message
    {

        [Key]
        [Required]
        public int UserId { get; set; }

        [Required]
        public string Messagetext { get; set; }

        [Required]
        public DateTime DateTime { get; set; }  




    }
}
