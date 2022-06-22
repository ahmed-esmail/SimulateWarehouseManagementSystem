using WarehouseManagementSystemAPI;

namespace HardwareWarehouse_MS.Entities
{
  public abstract class HardwareItem : IEntityPrimaryProperties, IEntityAdditionalProperties
  {
    public int Quantity { get; set; }
    public decimal UnitValue { get; set; }
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
  }
}