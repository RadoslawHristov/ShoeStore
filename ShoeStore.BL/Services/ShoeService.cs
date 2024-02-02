using ShoeStore.BL.Interfaces;
using ShoeStore.Models.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStore.BL.Services
{
    public class ShoeService : IShoeService
    {
    private readonly IShoeRepository _shoeRepository;

    public ShoeService(IShoeRepository shoeRepository)
        {
            _shoeRepository = shoeRepository;
        }

     public List<Shoe> GetAllShoes()
     {
            return _shoeRepository.GetAll();
      }

    public Shoe GetShoe(int Id)
        {
            if (Id <= 0) return new Shoe();
            return _shoeRepository.GetById(Id);
        }
    public void AddShoe(Shoe shoe)
        {
            _shoeRepository.Add(shoe);
        }
        public void RemoveShoe(int Id)
        {
            _shoeRepository.Remove(Id);
        }

    public List<Shoe> GetAllByBrandAfterReleaseDate
            (int brandId, DateTime afterDate)
        {
            var result = _shoeRepository.GetAllByBrand(brandId);

            return result
                .Where(b => b.ReleaseDate >= afterDate)
                .ToList();
        }
    }

}
