namespace Encapsulation
{
    public class Cart : StorageBase
    {
        private readonly IStorage _storage;

        public Cart(IStorage storage) =>
            _storage = storage;

        public Order Order()
        {
            foreach (var good in Goods.Keys)
                _storage.Remove(good, Goods[good]);

            return new Order("Hello, mentor!");
        }
    }
}
