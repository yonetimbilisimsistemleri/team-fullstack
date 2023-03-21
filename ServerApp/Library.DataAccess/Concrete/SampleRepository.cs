using Library.DataAccess.Abstract;
using Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.Concrete
{
    public class SampleRepository : ILibraryRepository<Sample>
    {
        public Sample Create(Sample entity)
        {
            //TODO: Add create logic here:
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            //TODO: Add delete logic here:
            throw new NotImplementedException();
        }

        public List<Sample> Get()
        {
            //TODO: Add get method logic here:
            throw new NotImplementedException();
        }

        public Sample Get(int id)
        {
            //TODO: Add get method logic here:
            throw new NotImplementedException();
        }

        public Sample Update(Sample entity)
        {
            //TODO: Add update method logic here:
            throw new NotImplementedException();
        }
    }
}
