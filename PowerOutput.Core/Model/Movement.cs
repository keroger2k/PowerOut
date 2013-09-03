using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PowerOutput.Core.Model {
  /// <summary>
  /// Part of all of an exercise.
  /// </summary>
  public class Movement {

    /// <summary>
    /// The weight of each body part that is moving
    /// </summary>
    public decimal BodyWeightWeightMoved { get; set; }

    /// <summary>
    /// The distance each body part being moved will move.
    /// </summary>
    public decimal BodyWeightDistanceMoved { get; set; }


    public decimal MovementWork { get { return this.BodyWeightDistanceMoved * this.BodyWeightWeightMoved; } }
  }
}
