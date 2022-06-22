using System;
using HardwareWarehouse_MS.Entities;
using WarehouseManagementSystemAPI;

namespace HardwareWarehouse_MS
{
  internal static class ConsoleWriter
  {
    public static void WriteValuesInQueueToScreen(CustomQueue<HardwareItem> hardwareItems)
    {
      foreach (var hardwareItem in hardwareItems)
        Console.WriteLine(
          $"{hardwareItem.Id,-6}{hardwareItem.Name,-15}{hardwareItem.Type,-20}{hardwareItem.Quantity,10}{hardwareItem.UnitValue,10}");
    }

    public static string FieldHeadings()
    {
      return UnderLine($"{"Id",-6}{"Name",-15}{"Type",-20}{"Quantity",10}{"Value",10}");
    }

    public static string RealTimeUpdateHeading()
    {
      return UnderLine("Real-time Update");
    }

    public static string ItemsInQueueHeading()
    {
      return UnderLine("Items Queued for Processing");
    }

    public static string MainHeading()
    {
      return UnderLine("Warehouse Management System");
    }

    private static string UnderLine(string heading)
    {
      return $"{heading}{Environment.NewLine}{new string('-', heading.Length)}";
    }
  }
}