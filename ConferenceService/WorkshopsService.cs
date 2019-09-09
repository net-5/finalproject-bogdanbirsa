
using Conference.Data;
using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Service
{
    public interface IWorkshopsService
    {


        IEnumerable<Workshops> GetWorkshops();
        Workshops GetById(int id);
        Workshops CreateWorkshops(Workshops workshops);
        Workshops Update(Workshops workshops);

        void DeleteWorkshop(Workshops workshops);

        bool Isunique(string name);
    }


    public class WorkshopsService : IWorkshopsService
    {

        private IWorkshopsRepository workshopRepository;

        public WorkshopsService(IWorkshopsRepository workshopRepository)
        {
            this.workshopRepository = workshopRepository;
        }

        public IEnumerable<Workshops> GetWorkshops()
        {
            return workshopRepository.GetWorkshops();
        }

        public Workshops GetById(int id)
        {
            var getById = workshopRepository.GetById(id);
            return getById;
        }

        public Workshops CreateWorkshops(Workshops workshops)
        {

            if (Isunique(workshops.Name))
            {
                return workshopRepository.CreateWorkshop(workshops);
            }
            return null;
        }

        public Workshops Update(Workshops workshops)
        {
            var update = workshopRepository.Update(workshops);
            return update;
        }

        public void DeleteWorkshop(Workshops workshops)
        {
            workshopRepository.Delete(workshops);

        }

        public bool Isunique(string name)
        {
            return workshopRepository.IsUnique(name);
        }
    }
}