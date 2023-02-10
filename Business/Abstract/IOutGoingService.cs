using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IOutGoingService
    {
        List<OutGoing> GetAll();
        void Add(OutGoing outGoing);
        void Update(OutGoing outGoing);
        void Delete(OutGoing outGoing);
        OutGoing Get(int id);
    }
}
