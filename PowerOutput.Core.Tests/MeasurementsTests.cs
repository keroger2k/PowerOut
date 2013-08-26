using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using PowerOutput.Core.Model;

namespace PowerOutput.Core.Tests {
  [TestFixture]
  public class MeasurementsTests {

    [Test]
    public void measurements_should_calculate_your_acromion_height_by_adding_torso_femur_pelvis_tibia_ankle_to_ground() {

      var m = new Measurements { AnkleToGround = 3, Pelvis = 8, Torso = 20, Femur = 17, Tibia = 10 };

      Assert.AreEqual(58, m.AcromionHeight);

    }

    [Test]
    public void measurements_should_calculate_your_overhead_height_by_acromion_height_plus_forearm_humerous() {

      var m = new Measurements { AnkleToGround = 3, Pelvis = 8, Torso = 20, Femur = 17, Tibia = 10, Forearm = 9, Humerus = 10 };

      Assert.AreEqual(77, m.OverheadHeight);

    }

    [Test]
    public void measurements_should_calculate_your_overall_height_by_acromion_height_plus_your_head_and_neck() {

      var m = new Measurements { AnkleToGround = 3, Pelvis = 8, Torso = 20, Femur = 17, Tibia = 10, Forearm = 9, Humerus = 10, HeadNeck = 11 };

      Assert.AreEqual(69, m.OverallHeight);

    }
  }
}
