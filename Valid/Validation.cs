using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELjournal.Valid
{
    class Validation
    {
        public static bool ValidateName(string name)
        {
            int s = 0;
            while (s < name.Length)
            {
                if ((name[s] >= 'А' && name[s] <= 'Я' ||
                    name[s] >= 'а' && name[s] <= 'я') ||
                    ((name[s] == '-' || name[s] == ' ') &&
                    (name[s] >= 'А' && name[s] <= 'Я' ||
                    name[s] >= 'а' && name[s] <= 'я')))
                {
                    s++;
                }
                else return false;

            }
            return true;
        }
        
    }
}
