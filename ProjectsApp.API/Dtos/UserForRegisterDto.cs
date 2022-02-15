using System.ComponentModel.DataAnnotations;

public class UserForRegisterDto
{
    [Required]
    public string Username { get; set; }

    [Required]
    public string Name { get; set; }    

    [Required]
    [StringLength(8, MinimumLength=4,ErrorMessage="You may specify password between 4 to 8 characters")]
    public string Password { get; set; }

    [Required]
    public string Position { get; set; }           
}