using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MusicStore.Models;

public class CustomerCreateViewModel
{
    [Required]
    [DataType(DataType.EmailAddress)]
    // [EmailAddress]
    [DisplayName("Email address")]
    public string Email { get; init; }

    [Required]
    [StringLength(50)]
    [DisplayName("Prénom")]
    public string FirstName { get; init; }

    [Required]
    [StringLength(50)]
    [DisplayName("Nom de famille")]
    public string LastName { get; init; }

}
