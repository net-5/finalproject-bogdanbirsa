using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Conference.Data
{
    public interface ISponsorTypesRepository
    {
        IEnumerable<SponsorTypes> GetSponsorTypes();
        SponsorTypes GetById(int id);
        SponsorTypes CreateSponsorType(SponsorTypes sponsorTypes);
        SponsorTypes Update(SponsorTypes sponsorTypes);

        void Delete(SponsorTypes sponsorTypes);

        bool IsUnique(string name);

    }
    public class SponsorTypesRepository : ISponsorTypesRepository
    {

        private ConferenceContext conferenceContext;

        public SponsorTypesRepository(ConferenceContext conferenceContext)
        {
            this.conferenceContext = conferenceContext;
        }


        public IEnumerable<SponsorTypes> GetSponsorTypes()
        {
            return conferenceContext.SponsorTypes.ToList();
        }

        public SponsorTypes GetById(int id)
        {
            var getById = conferenceContext.SponsorTypes.Find(id);
            return getById;
        }

        public SponsorTypes CreateSponsorType(SponsorTypes sponsorTypes)
        {
            var create = conferenceContext.SponsorTypes.Add(sponsorTypes);
            conferenceContext.SaveChanges();
            return create.Entity;
        }

        public SponsorTypes Update(SponsorTypes sponsorTypes)
        {
            var update = conferenceContext.SponsorTypes.Update(sponsorTypes);
            conferenceContext.SaveChanges();
            return update.Entity;
        }

        public void Delete(SponsorTypes sponsorTypes)
        {
            var delete = conferenceContext.SponsorTypes.Remove(sponsorTypes);
            conferenceContext.SaveChanges();

        }

        public bool IsUnique(string name)
        {
            int number = conferenceContext.SponsorTypes.Count(x => x.Name == name);

            if (number == 0)
            {
                return true;
            }
            return false;
        }
    }

}
