//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ELjournal.AppData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Students
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Students()
        {
            this.Journal = new HashSet<Journal>();
        }
    
        public int idStud { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public string patronymic { get; set; }
        public int gender { get; set; }
        public string eMail { get; set; }
        public int idGroup { get; set; }
        public Nullable<int> login { get; set; }
        public int available { get; set; }
    
        public virtual Gender Gender1 { get; set; }
        public virtual Group Group { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Journal> Journal { get; set; }
        public virtual Autoriz Autoriz { get; set; }
    }
}
