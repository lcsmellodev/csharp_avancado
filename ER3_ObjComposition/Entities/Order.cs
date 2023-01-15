using ER3_ObjComposition.Entities.Enums;
using System.Text;

namespace ER3_ObjComposition.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }
        

        public void AddItem(OrderItem item)
        {
            OrderItems.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            OrderItems.Remove(item);
        }

        public double Total()
        {
            double sum = 0;

            foreach (OrderItem item in OrderItems)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("");
            sb.AppendLine("ORDER SUMMARY");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString());
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append(Client.BirthDate);
            sb.Append(" - ");
            sb.AppendLine(Client.Email);
            sb.AppendLine("Order items:");

            foreach(OrderItem item in OrderItems)
            {
                sb.Append(item.Product.Name);
                sb.Append(", ");
                sb.Append(item.Product.Price.ToString());
                sb.Append(", ");
                sb.Append("Quantity: ");
                sb.Append(item.Quantity);
                sb.Append(", ");
                sb.Append("Subtotal: ");
                sb.AppendLine(item.SubTotal().ToString());

            }
            sb.Append("Total Price: ");
            sb.AppendLine(Total().ToString());

            return sb.ToString();
        }

    }
}

