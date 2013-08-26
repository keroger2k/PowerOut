using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PowerOutput.Core.Model {
  public class ComponentsWeight {
    private readonly Measurements measurements;

    public ComponentsWeight(Measurements measurements) {
      this.measurements = measurements;
    }

    //TODO: Figure this calculation out.
    public float HeadNeck {
      get { return measurements.HeadNeck; }
    }

    public float Torso {
      get { return measurements.Torso * Anthropometric.Torso; }
    }

    public float Pelvis {
      get { return measurements.Pelvis * Anthropometric.Pelvis; }
    }

    public float Femur {
      get { return measurements.Femur * Anthropometric.Femur; }
    }

    public float Tibia {
      get { return measurements.Tibia * Anthropometric.Tibia; }
    }

    public float Foot {
      get { return measurements.Foot * Anthropometric.Foot; }
    }

    public float Humerus {
      get { return measurements.Humerus * Anthropometric.Humerus; }
    }

    public float Forearm {
      get { return measurements.Forearm * Anthropometric.Forearm; }
    }

    public float Hand {
      get { return measurements.Hand * Anthropometric.Hand; }
    }

    public float TotalCalculatedWeight {
      get {
        return HeadNeck + Torso + Pelvis + Femur + Tibia + Foot + Humerus + Forearm + Hand;
      }
    }

    public float TotalCalculatedWeightBelowNeck {
      get {
        return Torso + Pelvis + Femur + Tibia + Foot + Humerus + Forearm + Hand;
      }
    }

  }
}
