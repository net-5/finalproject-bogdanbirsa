
using Conference.Data;
using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Service
{
    public interface ISponsorsService
    {


        IEnumerable<Sponsors> GetSponsors();
        Sponsors GetById(int id);
        Sponsors CreateSponsor(Sponsors sponsors);
        Sponsors Update(Sponsors sponsors);

        void DeleteSponsor(Sponsors sponsors);

        bool Isunique(string name);
    }


    public class SponsorsService : ISponsorsService
    {

        private ISponsorsRepository sponsorRepository;

        public SponsorsService(ISponsorsRepository sponsorRepository)
        {
            this.sponsorRepository = sponsorRepository;
        }

        public IEnumerable<Sponsors> GetSponsors()
        {
            return sponsorRepository.GetSponsors();
        }

        public Sponsors GetById(int id)
        {
            var getById = sponsorRepository.GetById(id);
            return getById;
        }

        public Sponsors CreateSponsor(Sponsors sponsors)
        {

            if (Isunique(sponsors.Name))
            {
                return sponsorRepository.CreateSponsor(sponsors);
            }
            return null;
        }

        public Sponsors Update(Sponsors sponsors)
        {
            var update = sponsorRepository.Update(sponsors);
            return update;
        }

        public void DeleteSponsor(Sponsors sponsors)
        {
            sponsorRepository.Delete(sponsors);

        }

        public bool Isunique(string name)
        {
            return sponsorRepository.IsUnique(name);
        }
    }
}