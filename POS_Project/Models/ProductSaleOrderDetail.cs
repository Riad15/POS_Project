//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POS_Project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductSaleOrderDetail
    {
        public long ProductSaleOrderDetailId { get; set; }
        public Nullable<long> ProductSaleOrderId { get; set; }
        public Nullable<long> ProductReceiveDetailId { get; set; }
        public Nullable<double> OrderQty { get; set; }
        public Nullable<decimal> salePrice { get; set; }
    
        public virtual ProductReceiveDetail ProductReceiveDetail { get; set; }
        public virtual ProductSaleOrder ProductSaleOrder { get; set; }
    }
}
