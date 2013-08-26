using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PowerOutput.Core.Model {

  public abstract class Exercise {

    /// <summary>
    /// A collection, usually 2 or less of movements required
    /// to complete an exercise.
    /// </summary>
    public abstract Movement[] Movements { get; }
    
    /// <summary>
    /// The body parts moving the weight.  For example, 
    /// with Bench press you will be moving the weight
    /// the distance of 1/2 the humerous plus the forearm length.
    /// 
    /// Not all exercise will require this because a weight may
    /// not be required.  For example, box jump.
    /// </summary>
    public abstract float WeightDistanceMoved { get; }

    /// <summary>
    /// The body weight work done for an exercise.  
    /// 
    /// The accumalated sum of the weight moved muliplied by the 
    /// total distance the weight moved for each movement.
    /// </summary>
    public float BodyWeightWorkDone { get { return Movements.Sum(c => c.MovementWork); } }
 
  }

  /// <summary>
  /// Part of all of an exercise.
  /// </summary>
  public class Movement {

    /// <summary>
    /// The weight of each body part that is moving
    /// </summary>
    public float BodyWeightWeightMoved { get; set; }

    /// <summary>
    /// The distance each body part being moved will move.
    /// </summary>
    public float BodyWeightDistanceMoved { get; set; }


    public float MovementWork { get { return this.BodyWeightDistanceMoved * this.BodyWeightWeightMoved; } }
  }
}
