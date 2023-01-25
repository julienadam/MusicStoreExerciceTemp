using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MusicStore.Models;

public class CustomerCreateViewModel
{
    [DataType(DataType.EmailAddress)]
    [DisplayName("Email address")]
    public string Email { get; init; }
    
    [DisplayName("Prénom")]
    public string FirstName { get; init; }
    [DisplayName("Nom de famille")]
    public string LastName { get; init; }
}
