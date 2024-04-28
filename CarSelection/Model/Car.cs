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
    
    public partial class Car
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Car()
        {
            this.Advertisement = new HashSet<Advertisement>();
            this.Photo = new HashSet<Photo>();
        }
    
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string Model { get; set; }
        public System.DateTime DateOfRelease { get; set; }
        public int BodyId { get; set; }
        public decimal Tax { get; set; }
        public Nullable<int> EngineId { get; set; }
        public int TransmissionId { get; set; }
        public int DriveId { get; set; }
        public int ColourId { get; set; }
        public long Mileage { get; set; }
        public Nullable<int> DealershipId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Advertisement> Advertisement { get; set; }
        public virtual Body Body { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Colour Colour { get; set; }
        public virtual DealerShip DealerShip { get; set; }
        public virtual Drive Drive { get; set; }
        public virtual Engine Engine { get; set; }
        public virtual Transmission Transmission { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Photo> Photo { get; set; }
    }
}
