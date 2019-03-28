using System.ComponentModel.DataAnnotations;

namespace MySqlApi.Models
{
    public class person
    {
        [Key]
        public int idperson {get; set;}
        public string name {get; set;}
    }
}