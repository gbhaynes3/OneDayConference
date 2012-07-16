using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace OneDayConference.Web.Models
{
    public class SessionRepository: IRepository<Session>
    {
        ConferenceContext db = new ConferenceContext();

        public IQueryable<Session> All { get { return db.Sessions; }  }
        public Session Find(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertOrUpdate(Session entity)
        {
            if (entity.Id == default(int))
            {
                db.Sessions.Add(entity);
            }
            else
            {
                db.Entry(entity).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public IEnumerable<Session> FindBySpeakerId(int speakerId)
        {
            return db.Sessions.Where(s => s.Speaker.Id.Equals(speakerId));
        }

        public Speaker FindSpeakerBySpeakerId(int speakerId)
        {
            return db.Speakers.FirstOrDefault(s => s.Id.Equals(speakerId));
        }
    }
}