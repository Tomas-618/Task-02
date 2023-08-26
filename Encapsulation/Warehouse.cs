namespace Encapsulation
{
    public class Warehouse : StorageBase
    {
        public void Delive(Good good, int count) =>
            Add(good, count);
    }
}
