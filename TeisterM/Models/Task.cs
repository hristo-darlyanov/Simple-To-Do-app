using System.ComponentModel.DataAnnotations;

namespace TeisterM.Models
{
    public class Task
    {
        public Task()
        {

        }

        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
    }
}
