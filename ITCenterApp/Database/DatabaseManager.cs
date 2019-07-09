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
                _dbContext.SaveChanges();
            }
        }

        public void DeleteHeader(int id)
        {
            using (ITCenterDBEntitiesContext _dbContext = new ITCenterDBEntitiesContext())
            {
                Headers header = new Headers();
                header.Id = id;
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

        public void UpdateRow(Rows row)
        {
            using (ITCenterDBEntitiesContext _dbContext = new ITCenterDBEntitiesContext())
            {
                _dbContext.Rows.Attach(row);
                _dbContext.Rows.Add(row);
                _dbContext.Entry(row).State = System.Data.Entity.EntityState.Modified;
                _dbContext.SaveChanges();
            }
        }

        public void CreateRow(Rows row)
        {
            using (ITCenterDBEntitiesContext _dbContext = new ITCenterDBEntitiesContext())
            {
                _dbContext.Rows.Add(row);
                _dbContext.SaveChanges();
            }
        }

        public void DeleteRow(int id)
        {
            using (ITCenterDBEntitiesContext _dbContext = new ITCenterDBEntitiesContext())
            {
                Rows row = new Rows();
                row.Id = id;
                _dbContext.Rows.Attach(row);
                _dbContext.Rows.Remove(row);
                _dbContext.SaveChanges();
            }
        }

        public Rows GetRowById(int selectedIdRow)
        {
            using (ITCenterDBEntitiesContext _dbContext = new ITCenterDBEntitiesContext())
            {
                return _dbContext.Rows.Where(r => r.Id == selectedIdRow).FirstOrDefault();
            }
        }
    }
}
