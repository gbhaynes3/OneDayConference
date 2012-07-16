using System.Data;
using System.Linq;

namespace OneDayConference.Web.Models
{
    public class SpeakerRepository: IRepository<Speaker>
    {
        private ConferenceContext db = new ConferenceContext();

        public IQueryable<Speaker> All { get { return db.Speakers; }}

        public Speaker Find(int id)
        {
            return db.Speakers.FirstOrDefault(s => s.Id == id);
        }

        public void InsertOrUpdate(Speaker entity)
        {
            if (entity.Id == default(int))
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
            throw new System.NotImplementedException();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}