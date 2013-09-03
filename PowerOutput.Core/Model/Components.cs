using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PowerOutput.Core.Model {
  public class Components {
    public Measurements Measurements { get; private set; }
    public int MeasuredBodyWeight { get; private set; }
    public int MeasuredBodyHeight { get; private set; }


    public Components(Measurements measurements, int measuredBodyWeight, int measuredBodyHeight) {
      this.Measurements = measurements;
      this.MeasuredBodyWeight = measuredBodyWeight;
      this.MeasuredBodyHeight = measuredBodyHeight;
    }

    public decimal HeadNeckWeight {
      get {
        return (decimal)Math.Sqrt(94.096586958479262784 + Math.Pow(0.65 * MeasuredBodyWeight * 0.063842135809635, 2));
      }
    }

    public decimal TorsoWeight {
      get { return Measurements.Torso * Anthropometric.Torso; }
    }

    public decimal PelvisWeight {
      get { return Measurements.Pelvis * Anthropometric.Pelvis; }
    }

    public decimal FemurWeight {
      get { return Measurements.Femur * Anthropometric.Femur; }
    }

    public decimal TibiaWeight {
      get { return Measurements.Tibia * Anthropometric.Tibia; }
    }

    public decimal FootWeight {
      get { return Measurements.Foot * Anthropometric.Foot; }
    }

    public decimal HumerusWeight {
      get { return Measurements.Humerus * Anthropometric.Humerus; }
    }

    public decimal ForearmWeight {
      get { return Measurements.Forearm * Anthropometric.Forearm; }
    }

    public decimal HandWeight {
      get { return Measurements.Hand * Anthropometric.Hand; }
    }

    public decimal TotalCalculatedWeight {
      get {
        return HeadNeckWeight + TorsoWeight + PelvisWeight + FemurWeight + TibiaWeight + FootWeight + HumerusWeight + ForearmWeight + HandWeight;
      }
    }

    public decimal TotalCalculatedWeightBelowNeck {
      get {
        return TorsoWeight + PelvisWeight + FemurWeight + TibiaWeight + FootWeight + HumerusWeight + ForearmWeight + HandWeight;
      }
    }

  }
}
