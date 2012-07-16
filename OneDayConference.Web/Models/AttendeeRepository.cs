using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace OneDayConference.Web.Models
{
    public class AttendeeRepository: IRepository<Attendee>
    {
        ConferenceContext db = new ConferenceContext();

        public IQueryable<Attendee> All
        {
            get { return db.Attendees; }
        }

        public Attendee Find(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertOrUpdate(Attendee entity)
        {
            if(entity.Id == default(int))
            {
                db.Attendees.Add(entity);
            }
            else
            {
                db.Entry(entity).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var attendee = db.Attendees.FirstOrDefault(x => x.Id.Equals(id));
            db.Attendees.Remove(attendee);
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}