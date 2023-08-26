namespace Encapsulation
{
    public interface IStorage
    {
        void Remove(Good good, int count);

        bool IsEnough(Good good, int count);
    }
}