//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class BillBuy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BillBuy()
        {
            this.BillBuyDetails = new HashSet<BillBuyDetail>();
        }
    
        public int id { get; set; }
        public Nullable<System.DateTime> createdDay { get; set; }
        public string creator { get; set; }
        public string status { get; set; }
    
        public virtual Acount Acount { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillBuyDetail> BillBuyDetails { get; set; }
    }
}
