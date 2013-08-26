using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PowerOutput.Core.Model {
  /// <summary>
  /// Data created from averages I found online.  Perhaps, this should
  /// be a bit more exact.  But right now, this is what I have.
  /// </summary>
  public static class Anthropometric {
    public static float Torso {
      get {
        return 2.99097643598219F;
      }
    }

    public static float Pelvis {
      get {
        return 2.79487946664058F;
      }
    }

    public static float Femur {
      get {
        return 2.87053906046146F;
      }
    }

    public static float Tibia {
      get {
        return 1.09708295651235F;
      }
    }

    public static float Foot {
      get {
        return 0.280782753883921F;
      }
    }

    public static float Humerus {
      get {
        return 0.756498754402191F;
      }
    }

    public static float Forearm {
      get {
        return 0.57770702717082F;
      }
    }

    public static float Hand {
      get {
        return 0.273306929266584F;
      }
    }

  }
}
