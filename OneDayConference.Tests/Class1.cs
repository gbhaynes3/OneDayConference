using System;
using System.Collections.Generic;
using NUnit.Framework;
using OneDayConference.Web.Models;

namespace OneDayConference.Tests
{
    [TestFixture]
    public class Class1
    {
        /*
         * Conference goes from 8 am to 6pm
         * Lunch 12 - 1
         * Two roles speakers and attendee
         * Attendees only can say they plan to attend
         * Speakers Must input details about a session
         *  Topic, Time, and Speaker Name are required
         * Attendess can be speaker
         * Speakers can be attendees
         */

        [Test]
        public void Attendee_Can_Say_They_Plan_On_Attending()
        {
            //Arrange
            var attendee = new Attendee();

            //Act
            attendee.IsAttending = true;

            //Assert
            Assert.IsTrue(attendee.IsAttending);
        }

        [Test]
        public void Session_must_have_a_Topic()
        {
            var session = new Session();
            session.Topic = "New Topic";

            Assert.IsNotNull(session.Topic);
        }

        [Test]
        public void Session_Throws_Error_Without_a_Topic_Or_StartTime()
        {
            var session = new Session();

            Assert.Throws<NullReferenceException>(null, "Topic is required");
            Assert.Throws<NullReferenceException>(null, "Start Time is required");
        }

        [Test]
        public void Speaker_Must_Have_Atleast_One_Session()
        {
            var speaker = new Speaker();

            speaker.Sessions = new List<Session> {new Session {Topic = "Topic", StartTime = "1:00 PM"}};

            Assert.AreEqual(1, speaker.Sessions.Count);
        }

        [Test]
        public void Attendee_SignsUp()
        {
            
        }
    }

    public interface IPerson
    {
        string Name { get; set; }
    }

    public class Attendee: IPerson
    {
        public bool IsAttending { get; set; }
        public string Name { get; set; }
    }


}
