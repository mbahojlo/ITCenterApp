using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCenterApp.Database
{
    public interface IDatabaseManager
    {
        List<Headers> GetHeaders();
        void CreateHeader(Headers header);
        void DeleteHeader(int Id);
        Headers GetHeaderById(int id);
        void UpdateHeader(Headers header);
        List<Rows> GetRowsById(int id);
    }
}
