namespace Bakery.Models
{
  public class FlavorTreat
  {       
    public int CategoryRecipeId { get; set; }
    public int TreatId { get; set; }
    public int FlavorId { get; set; }
    public virtual Treat Treat { get; set; }
    public virtual Flavor Flavor { get; set; }
  }
}