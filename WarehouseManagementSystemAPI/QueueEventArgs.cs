using System;

namespace WarehouseManagementSystemAPI
{
  public class QueueEventArgs: EventArgs
  {
    public string Message { get; set; }
    
  }
}