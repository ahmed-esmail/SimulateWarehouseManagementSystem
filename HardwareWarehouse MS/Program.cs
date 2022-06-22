using System;
using WarehouseManagementSystemAPI;

namespace HardwareWarehouse_MS
{
  internal class Program
  {
    private const int BatchSize = 5;
    public static void Main(string[] args)
    {
      var hardwareItemQueue = new CustomQueue<HardwareItem>();
      hardwareItemQueue.CustomQueueEvent += HardwareItemQueueOnCustomQueueEvent;
      
      //comes into stock - device scans a bar code or QR code
      hardwareItemQueue.AddItem(new Drill { Id = 1, Name = "Drill 1", Type = "Drill", UnitValue = 20.00m, Quantity = 10 });

      System.Threading.Thread.Sleep(1000);

      hardwareItemQueue.AddItem(new Drill { Id = 2, Name = "Drill 2", Type = "Drill", UnitValue = 30.00m, Quantity = 20 });

      System.Threading.Thread.Sleep(2000);

      hardwareItemQueue.AddItem(new Ladder { Id = 3, Name = "Ladder 1", Type = "Ladder", UnitValue = 100.00m, Quantity = 5 });

      System.Threading.Thread.Sleep(1000);

      hardwareItemQueue.AddItem(new Hammer { Id = 4, Name = "Hammer 1", Type = "Hammer", UnitValue = 10.00m, Quantity = 80 });
      System.Threading.Thread.Sleep(3000);

      hardwareItemQueue.AddItem(new PaintBrush { Id = 5, Name = "Paint Brush 1", Type = "PaintBrush", UnitValue = 5.00m, Quantity = 100 });
      System.Threading.Thread.Sleep(3000);

      hardwareItemQueue.AddItem(new PaintBrush { Id = 6, Name = "Paint Brush 2", Type = "PaintBrush", UnitValue = 5.00m, Quantity = 100 });
      System.Threading.Thread.Sleep(3000);

      hardwareItemQueue.AddItem(new PaintBrush { Id = 7, Name = "Paint Brush 3", Type = "PaintBrush", UnitValue = 5.00m, Quantity = 100 });
      System.Threading.Thread.Sleep(3000);

      hardwareItemQueue.AddItem(new Hammer { Id = 8, Name = "Hammer 2", Type = "Hammer", UnitValue = 11.00m, Quantity = 80 });
      System.Threading.Thread.Sleep(3000);

      hardwareItemQueue.AddItem(new Hammer { Id = 9, Name = "Hammer 3", Type = "Hammer", UnitValue = 13.00m, Quantity = 80 });
      System.Threading.Thread.Sleep(3000);

      hardwareItemQueue.AddItem(new Hammer { Id = 10, Name = "Hammer 4", Type = "Hammer", UnitValue = 14.00m, Quantity = 80 });
      System.Threading.Thread.Sleep(3000);

      Console.ReadKey();
    }

    private static void HardwareItemQueueOnCustomQueueEvent(CustomQueue<HardwareItem> sender, QueueEventArgs eventArgs)
    {
      Console.Clear();

      Console.WriteLine(ConsoleWriter.MainHeading());
      Console.WriteLine();
      Console.WriteLine(ConsoleWriter.RealTimeUpdateHeading());

      if (sender.QueueLength > 0)
      {
        Console.WriteLine(eventArgs.Message);
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine(ConsoleWriter.ItemsInQueueHeading());
        Console.WriteLine(ConsoleWriter.FieldHeadings());

        ConsoleWriter.WriteValuesInQueueToScreen(sender);

        if (sender.QueueLength == BatchSize)
        {
          ProcessItems(sender);
        }

      }
      else
      {
        Console.WriteLine("Status: All items have been processed.");
      }
    }
    private static void ProcessItems(CustomQueue<HardwareItem> customQueue)
    {
      while (customQueue.QueueLength > 0)
      {
        System.Threading.Thread.Sleep(3000); 
        HardwareItem hardWareItem = customQueue.GetItem(); 

      }

    }
  }
}