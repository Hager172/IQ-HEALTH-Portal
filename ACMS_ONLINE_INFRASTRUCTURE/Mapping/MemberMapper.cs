using ACMS_ONLINE_INFRASTRUCTURE.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_INFRASTRUCTURE.Mapping
{
    public class MemberMapper
    {
        //public static Member MapToDomain(Member dataModel)
        //{
        //    if (dataModel == null) return null;

        //    var category = new Category(dataModel.Category.CategoryId, dataModel.Category.CategoryName);
        //    return new Product(dataModel.ProductId, dataModel.ProductName, dataModel.Price, category);
        //}

        //public static ProductDataModel MapToDataModel(Product domainModel)
        //{
        //    if (domainModel == null) return null;

        //    return new ProductDataModel
        //    {
        //        ProductId = domainModel.Id,
        //        ProductName = domainModel.Name,
        //        Price = domainModel.Price,
        //        CategoryId = domainModel.Category.Id
        //    };
        //}

        //public static ProductDto MapToDto(Product domainModel)
        //{
        //    if (domainModel == null) return null;

        //    return new ProductDto
        //    {
        //        Id = domainModel.Id,
        //        Name = domainModel.Name,
        //        Price = domainModel.Price,
        //        CategoryName = domainModel.Category.Name
        //    };
        //}

        //public static Product MapFromDto(ProductDto dto)
        //{
        //    if (dto == null) return null;

        //    var category = new Category(dto.CategoryId, dto.CategoryName);
        //    return new Product(dto.Id, dto.Name, dto.Price, category);
        //}
    }
}
