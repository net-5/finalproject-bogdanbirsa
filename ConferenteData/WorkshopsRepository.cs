using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Conference.Data
{
    public interface IWorkshopsRepository
    {
        IEnumerable<Workshops> GetWorkshops();
        Workshops GetById(int id);
        Workshops CreateWorkshop(Workshops workshops);
        Workshops Update(Workshops workshops);

        void Delete(Workshops workshops);

        bool IsUnique(string name);

    }
    public class WorkshopsRepository : IWorkshopsRepository
    {

        private ConferenceContext conferenceContext;

        public WorkshopsRepository(ConferenceContext conferenceContext)
        {
            this.conferenceContext = conferenceContext;
        }


        public IEnumerable<Workshops> GetWorkshops()
        {
            return conferenceContext.Workshops.ToList();
        }

        public Workshops GetById(int id)
        {
            var getById = conferenceContext.Workshops.Find(id);
            return getById;
        }

        public Workshops CreateWorkshop(Workshops workshops)
        {
            var create = conferenceContext.Workshops.Add(workshops);
            conferenceContext.SaveChanges();
            return create.Entity;
        }

        public Workshops Update(Workshops workshops)
        {
            var update = conferenceContext.Workshops.Update(workshops);
            conferenceContext.SaveChanges();
            return update.Entity;
        }

        public void Delete(Workshops workshops)
        {
            var delete = conferenceContext.Workshops.Remove(workshops);
            conferenceContext.SaveChanges();

        }

        public bool IsUnique(string name)
        {
            int number = conferenceContext.Workshops.Count(x => x.Name == name);

            if (number == 0)
            {
                return true;
            }
            return false;
        }
    }

}
