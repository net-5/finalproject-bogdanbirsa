using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Conference.Data
{
    public interface ISponsorsRepository
    {
        IEnumerable<Sponsors> GetSponsors();
        Sponsors GetById(int id);
        Sponsors CreateSponsor(Sponsors sponsors);
        Sponsors Update(Sponsors sponsors);

        void Delete(Sponsors sponsors);

        bool IsUnique(string name);

    }
    public class SponsorsRepository : ISponsorsRepository
    {

        private ConferenceContext conferenceContext;

        public SponsorsRepository(ConferenceContext conferenceContext)
        {
            this.conferenceContext = conferenceContext;
        }


        public IEnumerable<Sponsors> GetSponsors()
        {
            return conferenceContext.Sponsors.ToList();
        }

        public Sponsors GetById(int id)
        {
            var getById = conferenceContext.Sponsors.Find(id);
            return getById;
        }

        public Sponsors CreateSponsor(Sponsors sponsors)
        {
            var create = conferenceContext.Sponsors.Add(sponsors);
            conferenceContext.SaveChanges();
            return create.Entity;
        }

        public Sponsors Update(Sponsors sponsors)
        {
            var update = conferenceContext.Sponsors.Update(sponsors);
            conferenceContext.SaveChanges();
            return update.Entity;
        }

        public void Delete(Sponsors sponsors)
        {
            var delete = conferenceContext.Sponsors.Remove(sponsors);
            conferenceContext.SaveChanges();

        }

        public bool IsUnique(string name)
        {
            int number = conferenceContext.Sponsors.Count(x => x.Name == name);

            if (number == 0)
            {
                return true;
            }
            return false;
        }
    }

}
