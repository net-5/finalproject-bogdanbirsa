using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Conference.Data
{
    public interface ITalksRepository
    {
        IEnumerable<Talks> GetTalks();
        Talks GetById(int id);
        Talks CreateTalk(Talks talks);
        Talks Update(Talks talks);

        void Delete(Talks talks);

        bool IsUnique(string name);

    }
    public class TalksRepository : ITalksRepository
    {

        private ConferenceContext conferenceContext;

        public TalksRepository(ConferenceContext conferenceContext)
        {
            this.conferenceContext = conferenceContext;
        }


        public IEnumerable<Talks> GetTalks()
        {
            return conferenceContext.Talks.ToList();
        }

        public Talks GetById(int id)
        {
            var getById = conferenceContext.Talks.Find(id);
            return getById;
        }

        public Talks CreateTalk(Talks talks)
        {
            var create = conferenceContext.Talks.Add(talks);
            conferenceContext.SaveChanges();
            return create.Entity;
        }

        public Talks Update(Talks talks)
        {
            var update = conferenceContext.Talks.Update(talks);
            conferenceContext.SaveChanges();
            return update.Entity;
        }

        public void Delete(Talks talks)
        {
            var delete = conferenceContext.Talks.Remove(talks);
            conferenceContext.SaveChanges();

        }

        public bool IsUnique(string name)
        {
            int number = conferenceContext.Talks.Count(x => x.Name == name);

            if (number == 0)
            {
                return true;
            }
            return false;
        }
    }

}
