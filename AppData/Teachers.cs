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
    
    public partial class Teachers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Teachers()
        {
            this.Journal = new HashSet<Journal>();
        }
    
        public int idTeach { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public string ptronymic { get; set; }
        public int gender { get; set; }
        public string eMail { get; set; }
        public int login { get; set; }
        public int available { get; set; }
        public int idSubj { get; set; }
    
        public virtual Autoriz Autoriz { get; set; }
        public virtual Gender Gender1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Journal> Journal { get; set; }
        public virtual Subjects Subjects { get; set; }
    }
}
