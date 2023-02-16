using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    internal interface iCRUD
    {
        void Create(List<Zametka> zametki);
        List<List<Zametka>> Read();
        void Update();
        void Delete();
    }
}
