using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PowerOutput.Core.Model;

namespace PowerOutput.Core.Exercises {

  public class Burpee : Exercise {

    private readonly Person _person;
    private readonly Squat _squat;
    private readonly Pushup _pushup;

    public Burpee(Person person) {
      this._person = person;
      this._squat = new Squat(_person);
      this._pushup = new Pushup(_person);
    }

    public override Movement[] Movements {
      get {
        var movements = new List<Movement>();
        movements.AddRange(_squat.Movements);
        movements.AddRange(_pushup.Movements);
        return movements.ToArray();
      }
    }

    public override decimal WeightDistanceMoved {
      get { return 0; }
    }
  }
}
