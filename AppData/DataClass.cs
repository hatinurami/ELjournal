using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ELjournal.AppData
{
    public static class DataClass
    {
        public static ElJournalEntities context = new ElJournalEntities();
        public static Students userStud;
        public static Teachers userTeach;


    }
}
