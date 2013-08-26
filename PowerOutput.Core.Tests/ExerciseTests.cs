using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using PowerOutput.Core.Exercises;
using PowerOutput.Core.Model;

namespace PowerOutput.Core.Tests {
  [TestFixture]
  public class ExerciseTests {

    [Test]
    public void pullup_exercise_should_be_this() {
      var m = new Measurements { AnkleToGround = 3, Hand = 7, Foot = 10, Pelvis = 8, Torso = 20, Femur = 17, Tibia = 10, Forearm = 9, Humerus = 10, HeadNeck = 11 };

      var p = new Person(70, 170, m);

      var pu = new Pullup(p);

      Assert.AreEqual(257.91, Math.Round(pu.BodyWeightWorkDone, 2));
     
    }
  }
}
