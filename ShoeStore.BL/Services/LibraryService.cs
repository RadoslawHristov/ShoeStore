﻿using ShoeStore.BL.Interfaces;
using ShoeStore.Models.Requests;
using ShoeStore.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStore.BL.Services
{
    public class LibraryService : ILibraryService
    {
        private readonly IBrandService _brandService;
        private readonly IShoeService _shoeService;

        public LibraryService(
           IBrandService brandService,
           IShoeService shoeService)
        {
            _brandService = brandService;
            _shoeService = shoeService;
        }

        public int CheckShoeCount(int input)
        {
            if (input < 0) return 0;
            var shoeCount.Count + input;
        }

        public GetAllShoesByBrandResponse?
        GetAllByBrandsAfterReleaseDate(
            GetAllShoesByBrandRequest request)
        {
            var response = new GetAllShoesByBrandResponse
            {
                Brand= _brandService
                .GetBrand(request.BrandId),
                Shoe= _shoeService
                .GetAllByBrandsAfterReleaseDate(
                    request.BrandId,
                    request.DateAfter)
            };
            return response;
        }
    }
}
