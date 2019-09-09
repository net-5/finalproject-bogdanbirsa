using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Conference.Data
{
    public interface ISpeakerRepository
    {
        IEnumerable<Speakers> GetSpeakers();
        Speakers GetById(int id);
        Speakers CreateSpeaker(Speakers speakers);
        Speakers Update(Speakers speakers);

        void Delete(Speakers speakers);

        bool IsUnique(string name);

    }
    public class SpeakerRepository : ISpeakerRepository
    {

        private ConferenceContext conferenceContext;

        public SpeakerRepository(ConferenceContext conferenceContext)
        {
            this.conferenceContext = conferenceContext;
        }


        public IEnumerable<Speakers> GetSpeakers()
        {
            return conferenceContext.Speakers.ToList();
        }

        public Speakers GetById(int id)
        {
            var getById = conferenceContext.Speakers.Find(id);
            return getById;
        }

        public Speakers CreateSpeaker(Speakers speakers)
        {
            var create = conferenceContext.Speakers.Add(speakers);
            conferenceContext.SaveChanges();
            return create.Entity;
        }

        public Speakers Update(Speakers speakers)
        {
            var update = conferenceContext.Speakers.Update(speakers);
            conferenceContext.SaveChanges();
            return update.Entity;
        }

        public void Delete(Speakers speakers)
        {
            var delete = conferenceContext.Speakers.Remove(speakers);
            conferenceContext.SaveChanges();

        }

        public bool IsUnique(string name)
        {
            int number = conferenceContext.Speakers.Count(x => x.CompanyName == name);

            if (number == 0)
            {
                return true;
            }
            return false;
        }
    }

}
