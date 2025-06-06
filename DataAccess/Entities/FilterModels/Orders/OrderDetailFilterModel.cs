﻿using DataAccess.Entities.FilterModels.BaseModel;

namespace DataAccess.Entities.FilterModels.Orders
{
    public class OrderDetailFilterModel : BaseFilterModel
    {
        public decimal? MinPrice { get; set; } = null;
        public decimal? MaxPrice { get; set; } = null;
        public bool? DescendingByPrice { get; set; } = null;
    }
}
