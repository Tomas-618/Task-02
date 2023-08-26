namespace Encapsulation
{
    public abstract class StorageBase : IStorage
    {
        private readonly Dictionary<Good, int> _goods;

        private protected StorageBase() =>
            _goods = new Dictionary<Good, int>();

        private protected IReadOnlyDictionary<Good, int> Goods => _goods;

        public void Add(Good good, int count)
        {
            if (good == null)
                throw new ArgumentNullException(nameof(good));

            if (count <= 0)
                throw new ArgumentOutOfRangeException();

            if (_goods.ContainsKey(good) == false)
                _goods[good] = 0;

            _goods[good] += count;
            ShowInfo();
        }

        public void Remove(Good good, int count)
        {
            if (IsEnough(good, count))
                throw new InvalidOperationException();

            if (count == Goods[good])
            {
                _goods.Remove(good);

                return;
            }

            _goods[good] -= count;
        }

        public bool IsEnough(Good good, int count)
        {
            if (good == null)
                throw new ArgumentNullException(nameof(good));

            if (count <= 0)
                throw new ArgumentOutOfRangeException();

            return count > Goods[good];
        }

        private void ShowInfo()
        {
            foreach (var good in _goods.Keys)
                Console.WriteLine($"{good.Name} has been added (count: {_goods[good]})");
        }
    }
}
