//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SportComplexNaumov.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Section
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Section()
        {
            this.Abonement = new HashSet<Abonement>();
        }
    
        public int id_section { get; set; }
        public int id_cekcia { get; set; }
        public int id_trenirovki { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Abonement> Abonement { get; set; }
        public virtual Cekcia Cekcia { get; set; }
        public virtual Trenirovki Trenirovki { get; set; }
    }
}
