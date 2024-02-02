using ShoeStore.Models.models;

namespace ShoeStore.BL.Interfaces
{
    public interface IShoeService
    {
        List<Shoe> GetAllShoes();

        Shoe GetShoe(int Id);

        void AddShoe(Shoe shoe);

        void RemoveShoe(int Id);

        GetAllByBrandsAfterReleaseDate(
            int brandId,
            DateTime afterDate);
    }
}
