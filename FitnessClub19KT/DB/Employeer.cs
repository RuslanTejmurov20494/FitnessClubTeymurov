//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FitnessClub19KT.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employeer
    {
        public int IdEmployeer { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int idSpecialistCategory { get; set; }
    
        public virtual SpecialistCategory SpecialistCategory { get; set; }
    }
}
