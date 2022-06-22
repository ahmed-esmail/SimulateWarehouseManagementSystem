using System;
using System.Collections.Generic;

namespace WarehouseManagementSystemAPI
{
  public delegate void QueueEventHandler<in T, in U>(T sender, U eventArgs);

  public class CustomQueue<T> where T : IEntityPrimaryProperties, IEntityAdditionalProperties
  {
    private readonly Queue<T> _queue;

    public CustomQueue()
    {
      _queue = new Queue<T>();
    }

    public int QueueLength => _queue.Count;
    public event QueueEventHandler<CustomQueue<T>, QueueEventArgs> CustomQueueEvent;

    public void AddItem(T item)
    {
      _queue.Enqueue(item);

      var queueEventArgs = new QueueEventArgs
      {
        Message =
          $"DateTime: {DateTime.Now.ToString(Constants.DateFormat)}, Id {item.Id}, Name ({item.Name}), Type ({item.Type}), Quantity ({item.Quantity}, has been added to queue."
      };
      OnQueueChanged(queueEventArgs);
    }

    public T GetItem()
    {
      var item = _queue.Dequeue();
      var queueEventArgs = new QueueEventArgs
      {
        Message =
          $"DateTime: {DateTime.Now.ToString(Constants.DateFormat)}, Id {item.Id}, Name ({item.Name}), Type ({item.Type}), Quantity ({item.Quantity}, has been processed to queue."
      };
      OnQueueChanged(queueEventArgs);

      return item;
    }

    protected virtual void OnQueueChanged(QueueEventArgs eventArgs)
    {
      CustomQueueEvent?.Invoke(this, eventArgs);
    }

    public IEnumerator<T> GetEnumerator()
    {
      return _queue.GetEnumerator();
    }
  }
}