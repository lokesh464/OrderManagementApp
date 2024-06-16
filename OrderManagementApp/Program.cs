// See https://aka.ms/new-console-template for more information
using OrderManagementApp;

var context = new OrderManagementContext();
var orderManager = new OrderManager(context);
orderManager.PlaceOrder(1, 1, 1);
context.Dispose();