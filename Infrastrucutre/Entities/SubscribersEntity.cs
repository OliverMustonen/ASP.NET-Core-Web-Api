using System.ComponentModel.DataAnnotations;

namespace Infrastrucutre.Entities;

public class SubscribersEntity
{
    [Key]
    public string Email { get; set; } = null!;


}
