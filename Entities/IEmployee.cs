namespace Entities
{
    public interface IEmployee
    {
        void Add(int id, string firstname, string lastname);
        void Update(int id, string firstname, string lastname);
    }
}