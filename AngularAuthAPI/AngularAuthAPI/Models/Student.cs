using System.ComponentModel.DataAnnotations;

namespace AngularAuthAPI.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name {  get; set; } = string.Empty;
        public int Marks { get; set; }
    }
}
