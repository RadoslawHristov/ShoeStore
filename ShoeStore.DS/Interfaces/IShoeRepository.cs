using ShoeStore.Models.models;

namespace ShoeStore.DL.Interfaces
{
    public interface IShoeRepository
    {
        public void AddShoe(Shoe shoe);


        public void RemoveShoe(Shoe shoe);


        public void UpdateShoe(Shoe shoe);


        public Shoe GetShoe(int Id);


        public List<Shoe> GetAllShoes();
    }
}
