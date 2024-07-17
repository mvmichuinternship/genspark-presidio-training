using System.ComponentModel.DataAnnotations;
namespace azureProductWebApp.models;


public class Product
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Image { get; set; }
}
