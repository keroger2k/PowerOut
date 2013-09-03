using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PowerOutput.Core.Model;

namespace PowerOutput.Core.Exercises {

  public class Pullup : Exercise {

    private readonly Person _person;
    private decimal _bodyWeightDistanceMoved {
      get {
        return (decimal)(this._person.Components.Measurements.Humerus + this._person.Components.Measurements.Forearm) / 12;
      }
    }

    public Pullup(Person person) {
      this._person = person;
    }

    public override Movement[] Movements {
      get {
        return new Movement[] { 
        new Movement { 
          BodyWeightWeightMoved = (decimal)_person.Weight - (_person.Components.ForearmWeight + _person.Components.HandWeight), 
          BodyWeightDistanceMoved = _bodyWeightDistanceMoved
        } 
      };
      }
    }

    public override decimal WeightDistanceMoved {
      get { return _bodyWeightDistanceMoved; }
    }

  }
}
