using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RooftopActorsV3.Models
{
    /// <summary>
    /// Edit and Insert statements
    /// 
    ///This will be used as the business layer
    /// </summary>
    public class ActorRepo
    {
            RooftopActorDBContext dBContext = new RooftopActorDBContext();

        public List<Actors> GetActors()
        {
            return dBContext.Actors.ToList();
        }

        public void UpdateActor(Actors actors)
        {
            Actors actorsToUpdate = dBContext.Actors.FirstOrDefault(x => x.actID == actors.actID);
            actorsToUpdate.actName = actors.actName;
            actorsToUpdate.actSurname = actors.actSurname;

            dBContext.SaveChanges();

        }

        public void InsertActor(Actors actors)
        {
            dBContext.Actors.Add(actors);
            dBContext.SaveChanges();

        }

        public void DeleteActor(Actors actors)
        {
            Actors actorsToUpdate = dBContext.Actors.FirstOrDefault(x => x.actID == actors.actID);
            dBContext.Actors.Remove(actorsToUpdate);
            dBContext.SaveChanges();
        }

        
            

    }
}