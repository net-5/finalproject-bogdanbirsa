using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Conference.Data
{
    public interface IEditionsRepository
    {
        IEnumerable<Editions> GetEditions();
        Editions GetById(int id);
        Editions CreateEdition(Editions editions);
        Editions Update(Editions editions);

        void Delete(Editions editions);

        bool IsUnique(string name);

    }
    public class EditionsRepository : IEditionsRepository
    {

        private ConferenceContext conferenceContext;

        public EditionsRepository(ConferenceContext conferenceContext)
        {
            this.conferenceContext = conferenceContext;
        }


        public IEnumerable<Editions> GetEditions()
        {
            return conferenceContext.Editions.ToList();
        }

        public Editions GetById(int id)
        {
            var getById = conferenceContext.Editions.Find(id);
            return getById;
        }

        public Editions CreateEdition(Editions editions)
        {
            var create = conferenceContext.Editions.Add(editions);
            conferenceContext.SaveChanges();
            return create.Entity;
        }

        public Editions Update(Editions editions)
        {
            var update = conferenceContext.Editions.Update(editions);
            conferenceContext.SaveChanges();
            return update.Entity;
        }

        public void Delete(Editions editions)
        {
            var delete = conferenceContext.Editions.Remove(editions);
            conferenceContext.SaveChanges();

        }

        public bool IsUnique(string name)
        {
            int number = conferenceContext.Editions.Count(x => x.Name == name);

            if (number == 0)
            {
                return true;
            }
            return false;
        }
    }

}
