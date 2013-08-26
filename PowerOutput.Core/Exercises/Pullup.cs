using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PowerOutput.Core.Model;

namespace PowerOutput.Core.Exercises {

  public class Pullup : Exercise {

    private readonly Person person;

    public Pullup(Person person) {
      this.person = person;
    }

    public override Movement[] Movements {
      get {
        return new Movement[] { 
        new Movement { 
          BodyWeightWeightMoved = person.Weight - ((Anthropometric.Forearm * person.Measurements.Forearm) + (Anthropometric.Hand * person.Measurements.Hand)), 
          BodyWeightDistanceMoved = (float)(this.person.Measurements.Humerus + this.person.Measurements.Forearm) /12
        } 
      };
      }
    }

    public override float WeightDistanceMoved {
      get { return (float)(this.person.Measurements.Humerus + this.person.Measurements.Forearm) / 12; }
    }

  }

}
