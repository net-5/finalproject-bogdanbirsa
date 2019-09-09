
using Conference.Data;
using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Service
{
    public interface ISpeakerService
    {
        IEnumerable<Speakers> GetSpeakers();
        Speakers GetById(int id);
        Speakers CreateSpeaker(Speakers speakers);
        Speakers Update(Speakers speakers);
        void DeleteSpeakers(Speakers speakers);
        bool Isunique(string name);
    }

    public class SpeakerService : ISpeakerService
    {

        private ISpeakerRepository speakerRepository;
        public SpeakerService(ISpeakerRepository speakerRepository)
        {
            this.speakerRepository = speakerRepository;
        }

        public IEnumerable<Speakers> GetSpeakers()
        {
            return speakerRepository.GetSpeakers();
        }

        public Speakers GetById(int id)
        {
            var getById = speakerRepository.GetById(id);
            return getById;
        }

        public Speakers CreateSpeaker(Speakers speakers)
        {

            if (Isunique(speakers.CompanyName))
            {
                return speakerRepository.CreateSpeaker(speakers);
            }
            return null;
        }

        public Speakers Update(Speakers speakers)
        {
            var update = speakerRepository.Update(speakers);
            return update;
        }

       
          public void DeleteSpeakers(Speakers speakers)
        {
            speakerRepository.Delete(speakers);

        }

        public bool Isunique(string name)
        {
            return speakerRepository.IsUnique(name);
        }
    }
}