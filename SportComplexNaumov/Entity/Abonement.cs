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
    
    public partial class Abonement
    {
        public int id { get; set; }
        public Nullable<int> id_section { get; set; }
        public Nullable<int> id_client { get; set; }
        public Nullable<int> id_instryrtor { get; set; }
        public Nullable<System.DateTime> date { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Instryctor Instryctor { get; set; }
        public virtual Section Section { get; set; }
    }
}
