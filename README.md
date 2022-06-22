# Simulate Warehouse Management System using Event And Generics

* use of a generic delegate used to define an event that is raised whenever a generic queue data structure is changed
* provide the functionality of a real-time monitoring
system for items entering a warehouse and subsequently being processed
* processed i mean the item is placed
in a predefined location within the warehouse for storage so an event is raised when an item enters the warehouse and an event is subsequently raised once the relevant item has reached its predefined location within the warehouse
* let's say the item has a qr code attached to it that when scanned provides necessary information about the item when the item is scanned an event is raised so for example the supervisor could be monitoring the relevant activities relating to the warehouse and when an event is raised the relevant information is displayed on a screen in real time so the supervisor could for example be monitoring these real-time events using a handheld device

## Demo

![](demo/Demo.gif)
