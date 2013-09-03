using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PowerOutput.Core.Model {
  /// <summary>
  /// Used for measurements of a single person
  /// </summary>
  public class Measurements {
    public int HeadNeck { get; set; }
    public int Torso { get; set; }
    public int Pelvis { get; set; }
    public int Femur { get; set; }
    public int Tibia { get; set; }
    public int AnkleToGround { get; set; }
    public int Foot { get; set; }
    public int Humerus { get; set; }
    public int Forearm { get; set; }
    public int Hand { get; set; }
    public decimal WeightPlateDiameter { get; set; }

    public int AcromionHeight {
      get {
        return Torso + Pelvis + Femur + Tibia + AnkleToGround;
      }
    }

    public int OverheadHeight {
      get {
        return AcromionHeight + Humerus + Forearm;
      }
    }

    public int OverallHeight {
      get {
        return AcromionHeight + HeadNeck;
      }
    }
  }
}
