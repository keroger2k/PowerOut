using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PowerOutput.Core.Model {
  public class Person {

    public int Height { get { return this.Components.MeasuredBodyHeight; } }
    public int Weight { get { return this.Components.MeasuredBodyWeight; } }

    public Components Components { get; private set; }

    public Person(Components components) {
      this.Components = components;
    }

  }
}
