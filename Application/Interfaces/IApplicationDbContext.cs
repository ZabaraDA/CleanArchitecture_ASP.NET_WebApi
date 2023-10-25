﻿
namespace Application.Interfaces
{
    public interface IApplicationDbContext
    {
        ICategoryRepository Categories { get; set; }
        IProductRepository Products { get; set; }
    }
}
