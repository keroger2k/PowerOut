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
    public abstract decimal WeightDistanceMoved { get; }

    /// <summary>
    /// The body weight work done for an exercise.  
    /// 
    /// The accumalated sum of the weight moved muliplied by the 
    /// total distance the weight moved for each movement.
    /// </summary>
    public decimal BodyWeightWorkDone { get { return Movements.Sum(c => c.MovementWork); } }
 
  }
}
