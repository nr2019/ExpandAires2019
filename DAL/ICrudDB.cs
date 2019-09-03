using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ICrudBD
    {
        int Create(object T);
        List<object> RetrieveAll(); // Revisar
        int Update(object T);
        int Delete(object T);
    }
      
}
