using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models;

public class PersonModel
{
    [Required]
    [StringLength(maximumLength:10,MinimumLength =4,ErrorMessage = "Invalid First Name length")]
    public string FirstName { get; set; }


    [Required]
    [StringLength(maximumLength: 5, MinimumLength = 2, ErrorMessage = "Invalid Last Name length")]
    public string LastName { get; set; }

    [Range(minimum:0,maximum:125,ErrorMessage ="You Need To Enter A Valid Age")]
    public int Age { get; set; }

    [Required]
    [Range(typeof(bool),minimum:"true",maximum:"true",ErrorMessage ="You Need To Gave Concent To Continue.")]
    public bool GaveConcent { get; set; }

}
