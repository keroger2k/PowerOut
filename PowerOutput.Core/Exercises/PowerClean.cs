using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PowerOutput.Core.Model;

namespace PowerOutput.Core.Exercises {

  public class PowerClean : Exercise {

    private readonly Person _person;
    private readonly Deadlift _deadlift;

    public PowerClean(Person person) {
      this._person = person;
      this._deadlift = new Deadlift(_person);
    }

    public override Movement[] Movements {
      get {
        return _deadlift.Movements;
      }
    }

    public override decimal WeightDistanceMoved {
      get { return (this._person.Components.Measurements.AcromionHeight - (this._person.Components.Measurements.WeightPlateDiameter / 2)) / 12; }
    }
  }
}
