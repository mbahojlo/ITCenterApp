using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCenterApp.Database
{
    public class DatabaseManager: IDatabaseManager
    {
        public void CreateHeader(Headers header)
        {
            using (ITCenterDBEntitiesContext _dbContext = new ITCenterDBEntitiesContext())
            {
                _dbContext.Headers.Attach(header);
                _dbContext.Headers.Add(header);
                _dbContext.SaveChanges();
            }
        }

        public void UpdateHeader(Headers header)
        {
            using (ITCenterDBEntitiesContext _dbContext = new ITCenterDBEntitiesContext())
            {
                _dbContext.Headers.Attach(header);
                _dbContext.Headers.Add(header);
                _dbContext.Entry(header).State = System.Data.Entity.EntityState.Modified;
                //_dbContext.Headers.(header);
                _dbContext.SaveChanges();
            }
        }

        public void DeleteHeader(int Id)
        {
            using (ITCenterDBEntitiesContext _dbContext = new ITCenterDBEntitiesContext())
            {
                Headers header = new Headers();
                header.Id = Id;
                _dbContext.Headers.Attach(header);
                _dbContext.Headers.Remove(header);
                _dbContext.SaveChanges();
            }
        }

        public Headers GetHeaderById(int id)
        {
            using (ITCenterDBEntitiesContext _dbContext = new ITCenterDBEntitiesContext())
            {
                 return _dbContext.Headers.Where(h => h.Id == id).FirstOrDefault();
            }
        }

        public List<Headers> GetHeaders()
        {
            using (ITCenterDBEntitiesContext _dbContext = new ITCenterDBEntitiesContext())
            {
                return _dbContext.Headers.ToList();
            }
        }

        public List<Rows> GetRowsById(int id)
        {
            using (ITCenterDBEntitiesContext _dbContext = new ITCenterDBEntitiesContext())
            {
                return _dbContext.Rows.Where(r => r.HeaderId == id).ToList();
            }
        }
    }
}
