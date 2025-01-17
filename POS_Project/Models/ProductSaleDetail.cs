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
    
    public partial class ProductSaleDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductSaleDetail()
        {
            this.SaleProductReturns = new HashSet<SaleProductReturn>();
        }
    
        public long ProductSaleDetailId { get; set; }
        public Nullable<long> ProsuctSaleid { get; set; }
        public Nullable<long> ProductId { get; set; }
        public Nullable<decimal> SalePrice { get; set; }
        public Nullable<decimal> VatAmount { get; set; }
        public Nullable<decimal> TaxAmount { get; set; }
        public Nullable<double> SaleQty { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual ProductSale ProductSale { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleProductReturn> SaleProductReturns { get; set; }
    }
}
