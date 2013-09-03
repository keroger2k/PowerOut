using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PowerOutput.Core.Model;

namespace PowerOutput.Core.Exercises {

  public class Pushup : Exercise {

    private readonly Person _person;
    private decimal _bodyWeightDistanceMoved {
      get {
        return (decimal)(this._person.Components.Measurements.Humerus) / 12;
      }
    }

    public Pushup(Person person) {
      this._person = person;
    }

    public override Movement[] Movements {
      get {
        return new Movement[] { 
        new Movement { 
          BodyWeightWeightMoved = _person.Weight - _person.Components.FootWeight - _person.Components.ForearmWeight - _person.Components.HandWeight,
          BodyWeightDistanceMoved = _bodyWeightDistanceMoved
        } 
      };
      }
    }

    public override decimal WeightDistanceMoved {
      get { return 0; }
    }

  }
}
