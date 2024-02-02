using ShoeStore.DL.DL;
using ShoeStore.DL.Interfaces;
using ShoeStore.Models.models;

namespace ShoeStore.DL.Repository
{
    public class ShoeRepository: IShoeRepository
    {
        public void AddShoe(Shoe shoe)
        {
            StaticData.Shoes.Add(shoe);
        }

        public List<Shoe> GetAllShoes()
        {
            return StaticData.Shoes;
        }

        public void UpdateShoe(Shoe shoe)
        {
            var existShoe = StaticData.Shoes.FirstOrDefault(b => b.Id == shoe.Id);
            if (existShoe == null) return;
            existShoe.Size = shoe.Size;
        }

        public Shoe? GetShoe(int Id)
        {
            return
                StaticData.Shoes
                .FirstOrDefault(b => b.Id == Id);
        }

        public void RemoveShoe(Shoe shoe)
        {
            if (shoe == null) return;
            StaticData.Shoes.Remove(shoe);
        }
    }
}
