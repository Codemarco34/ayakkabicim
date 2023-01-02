using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayakkabicim.Core.UnityOfWorks
{
    public interface IGenericUnitOfWork
    {
        Task CommitAsync();
        void Commit();
        // Trancations da commit oldugu için isim verdik.
    }
}
