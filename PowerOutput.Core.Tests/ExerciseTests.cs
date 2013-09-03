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

    private Measurements _dummyMeasurements;
    private Components _dummyComponents;
    private Person _dummyPerson;

    [SetUp]
    public void Init() {
      _dummyMeasurements = new Measurements { WeightPlateDiameter = 17.7M, AnkleToGround = 3, Hand = 7, Foot = 10, Pelvis = 8, Torso = 20, Femur = 17, Tibia = 10, Forearm = 9, Humerus = 10, HeadNeck = 11 };
      _dummyComponents = new Components(measurements: _dummyMeasurements, measuredBodyWeight: 170, measuredBodyHeight: 70);
      _dummyPerson = new Person(_dummyComponents);
    }

    [Test]
    public void pullup_exercise_should_correctly_calculate_the_body_weight_work_being_done() {

      var pu = new Pullup(_dummyPerson);

      Assert.AreEqual(257.91, Math.Round(pu.BodyWeightWorkDone, 2));
     
    }

    [Test]
    public void squat_exercise_should_correctly_calculate_the_body_weight_work_being_done() {

      var squat = new Squat(_dummyPerson);

      Assert.AreEqual(223.34M, Math.Round(squat.BodyWeightWorkDone, 2));

    }

    [Test]
    public void pushup_exercise_should_correctly_calculate_the_body_weight_work_being_done() {

      var pushup = new Pushup(_dummyPerson);

      Assert.AreEqual(133.40M, Math.Round(pushup.BodyWeightWorkDone, 2));

    }

    [Test]
    public void burpee_exercise_should_correctly_calculate_the_body_weight_work_being_done() {

      var burpee = new Burpee(_dummyPerson);

      Assert.AreEqual(356.74M, Math.Round(burpee.BodyWeightWorkDone, 2));

    }

    [Test]
    public void deadlift_exercise_should_correctly_calculate_the_body_weight_work_being_done() {

      var dl = new Deadlift(_dummyPerson);

      Assert.AreEqual(65.69M, Math.Round(dl.BodyWeightWorkDone, 2));

    }

    [Test]
    public void deadlift_exercise_should_correctly_calculate_the_weight_distance_moved() {

      var dl = new Deadlift(_dummyPerson);

      Assert.AreEqual(1.85M, Math.Round(dl.WeightDistanceMoved, 2));

    }

    [Test]
    public void power_clean_exercise_should_correctly_calculate_the_body_weight_work_being_done() {

      var pc = new PowerClean(_dummyPerson);

      Assert.AreEqual(65.69M, Math.Round(pc.BodyWeightWorkDone, 2));

    }

    [Test]
    public void power_clean_exercise_should_correctly_calculate_the_weight_distance_moved() {

      var pc = new PowerClean(_dummyPerson);

      Assert.AreEqual(4.10M, Math.Round(pc.WeightDistanceMoved, 2));

    }
  
  
  }
}
