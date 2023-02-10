using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class OutGoingManager : IOutGoingService
    {
        IOutGoingDal _outGoingDal;

        public OutGoingManager(IOutGoingDal outGoingDal)
        {
            _outGoingDal = outGoingDal;
        }

        public void Add(OutGoing outGoing)
        {
            _outGoingDal.Add(outGoing);
        }

        public void Delete(OutGoing outGoing)
        {
            _outGoingDal.Delete(outGoing);
        }

        public OutGoing Get(int id)
        {
            return _outGoingDal.Get(p => p.ID.Equals(id));
        }

        public List<OutGoing> GetAll()
        {
            return _outGoingDal.GetAll();
        }

        public void Update(OutGoing outGoing)
        {
            _outGoingDal.Update(outGoing);
        }
    }
}
