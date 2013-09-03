using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PowerOutput.Core.Model;

namespace PowerOutput.Core.Exercises {

  public class Squat : Exercise {

    private readonly Person _person;
    private decimal _bodyWeightDistanceMoved {
      get {
        return (decimal)(this._person.Components.Measurements.Femur) / 12;
      }
    }

    public Squat(Person person) {
      this._person = person;
    }

    public override Movement[] Movements {
      get {
        return new Movement[] { 
        new Movement { 
          BodyWeightWeightMoved = 
            (_person.Components.ForearmWeight) +
            (_person.Components.HumerusWeight) +
            (_person.Components.PelvisWeight) +
            (_person.Components.HeadNeckWeight) +
            (_person.Components.FemurWeight) +
            (_person.Components.TorsoWeight) +
            (_person.Components.HandWeight),
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
