﻿using DataAccess.Entities.Enums;
using DataAccess.Entities.Interfaces;
using DataAccess.Entities.Models.Countries;
using DataAccess.Entities.Models.Orders;
using Microsoft.AspNetCore.Identity;

namespace DataAccess.Entities.Models.WebUsers
{
    public class WebUserAccount : IdentityUser<int>, IEntity
    {
        public string Guid { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedID { get; set; }
        public string CreatedIPAddress { get; set; }
        public bool IsUpdated { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedID { get; set; }
        public string? UpdatedIPAddress { get; set; }
        public DataStatus Status { get; set; }
        //Mapping
        //WebUserAccount
        public virtual WebUserProfile? WebUserProfile { get; set; }
        //Country
        public int? CountryId { get; set; }
        public virtual Country? Country { get; set; }
        //TourTicketOrder
        public virtual ICollection<TourTicketOrder>? TourTicketOrders { get; set; }
        //EventTicketOrder
        public virtual ICollection<EventTicketOrder>? EventTicketOrders { get; set; }
        //ProductOrder
        public virtual ICollection<ProductOrder>? ProductOrders { get; set; }

    }
}
