
using Conference.Data;
using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Service
{
    public interface ISponsorTypesService
    {


        IEnumerable<SponsorTypes> GetSponsorTypes();
        SponsorTypes GetById(int id);
        SponsorTypes CreateSponsorType(SponsorTypes sponsorTypes);
        SponsorTypes Update(SponsorTypes sponsorTypes);

        void DeleteSponsorType(SponsorTypes sponsorTypes);

        bool Isunique(string name);
    }


    public class SponsorTypesService : ISponsorTypesService
    {

        private ISponsorTypesRepository sponsorTypeRepository;

        public SponsorTypesService(ISponsorTypesRepository sponsorTypeRepository)
        {
            this.sponsorTypeRepository = sponsorTypeRepository;
        }

        public IEnumerable<SponsorTypes> GetSponsorTypes()
        {
            return sponsorTypeRepository.GetSponsorTypes();
        }

        public SponsorTypes GetById(int id)
        {
            var getById = sponsorTypeRepository.GetById(id);
            return getById;
        }

        public SponsorTypes CreateSponsorType(SponsorTypes sponsorTypes)
        {

            if (Isunique(sponsorTypes.Name))
            {
                return sponsorTypeRepository.CreateSponsorType(sponsorTypes);
            }
            return null;
        }

        public SponsorTypes Update(SponsorTypes sponsorTypes)
        {
            var update = sponsorTypeRepository.Update(sponsorTypes);
            return update;
        }

        public void DeleteSponsorType(SponsorTypes sponsorTypes)
        {
            sponsorTypeRepository.Delete(sponsorTypes);

        }

        public bool Isunique(string name)
        {
            return sponsorTypeRepository.IsUnique(name);
        }
    }
}