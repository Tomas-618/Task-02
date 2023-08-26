namespace Encapsulation
{
    public class Order
    {
        public Order(string paylink) =>
            Paylink = paylink;

        public string Paylink { get; }
    }
}
