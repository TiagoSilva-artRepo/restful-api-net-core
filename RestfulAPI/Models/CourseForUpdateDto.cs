using System.ComponentModel.DataAnnotations;

namespace RestfulAPI.Models
{
    public class CourseForUpdateDto : CourseForManipulationDto
    {
        [Required]
        public override string Description { get => base.Description; set=>base.Description = value; }        
    }
}