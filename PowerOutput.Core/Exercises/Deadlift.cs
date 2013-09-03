using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PowerOutput.Core.Model;

namespace PowerOutput.Core.Exercises {

  public class Deadlift : Exercise {

    private readonly Person _person;
    private decimal _bodyWeightDistanceMoved {
      get {
        return (decimal)(this._person.Components.Measurements.Tibia * 0.5) / 12;
      }
    }

    public Deadlift(Person person) {
      this._person = person;
    }

    public override Movement[] Movements {
      get {
        return new Movement[] { 
        new Movement { 
          BodyWeightWeightMoved = 
              _person.Components.HeadNeckWeight
            + _person.Components.TorsoWeight
            + _person.Components.PelvisWeight
            + _person.Components.FemurWeight
            + _person.Components.HumerusWeight
            + _person.Components.ForearmWeight
            + _person.Components.HandWeight,
          BodyWeightDistanceMoved = _bodyWeightDistanceMoved
        } 
      };
      }
    }

    public override decimal WeightDistanceMoved {
      get {
        return
          (this._person.Components.Measurements.AcromionHeight 
          - this._person.Components.Measurements.Humerus
          - this._person.Components.Measurements.Forearm
          - this._person.Components.Measurements.AnkleToGround
          - (this._person.Components.Measurements.Tibia * .5M)
          - (this._person.Components.Measurements.WeightPlateDiameter * .5M)) / 12;                }
    }
  }
}
