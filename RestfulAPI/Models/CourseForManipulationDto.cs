using System.ComponentModel.DataAnnotations;
using RestfulAPI.ValidationAttributes;

namespace RestfulAPI.Models
{
    public abstract class CourseForManipulationDto
    {
        [Required(ErrorMessage = "You should fill out a title")]
        [MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(1500)]
        [CourseTitleMustBeDifferentFromDescriptionAttribute]
        public virtual string Description { get; set; }        
    }
}