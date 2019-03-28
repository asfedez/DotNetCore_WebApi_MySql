using System.ComponentModel.DataAnnotations;

namespace MySqlApi.Models
{
    public class item
    {
        [Key]
        public int id {get; set;}
        public string description {get; set;}
        public int ischeck {get; set;}
    }
}