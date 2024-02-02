using ShoeStore.DL.DL;
using ShoeStore.DL.Interfaces;
using ShoeStore.Models.models;

namespace ShoeStore.DL.Repository
{
    public class BrandRepository: IBrandRepository
    {
        public void AddBrand(Brand brand)
        {
            StaticData.Brands.Add(brand);
        }

        public List<Brand> GetAllBrands()
        {
            return StaticData.Brands;
        }

        public Brand? GetBrand(int Id)
        {
            return
                StaticData.Brands
                .FirstOrDefault(b => b.Id == Id);
        }

        public void RemoveBrand(Brand brand)
        {
            if (brand == null) return;
            StaticData.Brands.Remove(brand);
        }

        public void UpdateBrand(Brand brand)
        {
            var existBrand = StaticData.Brands.FirstOrDefault(b => b.Id == brand.Id);
            if (existBrand == null) return;
            existBrand.Name = brand.Name;
        }
    }
}
