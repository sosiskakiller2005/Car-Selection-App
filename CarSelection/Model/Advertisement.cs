//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarSelection.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Advertisement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Advertisement()
        {
            this.Sale = new HashSet<Sale>();
            this.Favourites = new HashSet<Favourites>();
        }
    
        public int Id { get; set; }
        public int CarId { get; set; }
        public int DealerShipId { get; set; }
        public decimal Cost { get; set; }
        public string PhoneNumber { get; set; }
        public System.DateTime DateOfPublish { get; set; }
    
        public virtual Car Car { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sale> Sale { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Favourites> Favourites { get; set; }
    }
}
