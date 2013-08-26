using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PowerOutput.Core.Model {
  public class Person {

    public int Height { get; set; }
    public int Weight { get; set; }
    public Measurements Measurements { get; set; }


    public Person(int height, int weight, Measurements measurements) {
      this.Height = height;
      this.Weight = weight;
      this.Measurements = measurements;
    }

  }
}
