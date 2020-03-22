﻿using eShopSolution.ViewModels.Catalog.Products;
using eShopSolution.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<int> Delete(int productId);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task AddViewCount(int productId);

        Task<bool> UpdateStock(int productId, int addQuantity);

        Task<PageResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);


        Task<int> AddImage(int productId, List<IFormFile> files);

        Task<int> RemoveImages(int iamgeId);

        Task<int> UpdateImage(int iamgeId, string caption, bool isDefault);

        Task<List<ProductImageViewModel>> GetListImage(int productId);

        Task<ProductViewModel> GetById(int productId);
    }
}
