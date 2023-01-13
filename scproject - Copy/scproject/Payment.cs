//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace scproject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Payment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Payment()
        {
            this.Customers = new HashSet<Customer>();
            this.CustomerSuppliers = new HashSet<CustomerSupplier>();
        }
    
        public int PaymentID { get; set; }
        [DisplayName("Payment Amount")]
        [Required(ErrorMessage = "Payment Amount is required")]
        public string PaymentAmount { get; set; }
        [DisplayName("Payment Date")]
        [Required(ErrorMessage = "Payment Date is required")]
        public string PaymentDate { get; set; }
        [DisplayName("Product ID")]
        [Required(ErrorMessage = "Product ID is required")]
        public Nullable<int> ProductID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerSupplier> CustomerSuppliers { get; set; }
        public virtual Product Product { get; set; }
    }
}