
using Conference.Data;
using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Service
{
    public interface ITalksService
    {


        IEnumerable<Talks> GetTalks();
        Talks GetById(int id);
        Talks CreateTalk(Talks talks);
        Talks Update(Talks talks);

        void DeleteTalk(Talks talks);

        bool Isunique(string name);
    }


    public class TalksService : ITalksService
    {

        private ITalksRepository talkRepository;

        public TalksService(ITalksRepository talkRepository)
        {
            this.talkRepository = talkRepository;
        }

        public IEnumerable<Talks> GetTalks()
        {
            return talkRepository.GetTalks();
        }

        public Talks GetById(int id)
        {
            var getById = talkRepository.GetById(id);
            return getById;
        }

        public Talks CreateTalk(Talks talks)
        {

            if (Isunique(talks.Name))
            {
                return talkRepository.CreateTalk(talks);
            }
            return null;
        }

        public Talks Update(Talks talks)
        {
            var update = talkRepository.Update(talks);
            return update;
        }

        public void DeleteTalk(Talks talks)
        {
            talkRepository.Delete(talks);

        }

        public bool Isunique(string name)
        {
            return talkRepository.IsUnique(name);
        }
    }
}