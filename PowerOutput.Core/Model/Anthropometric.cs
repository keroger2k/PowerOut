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
    public static decimal Torso {
      get {
        return 2.99097643598219M;
      }
    }

    public static decimal Pelvis {
      get {
        return 2.79487946664058M;
      }
    }

    public static decimal Femur {
      get {
        return 2.87053906046146M;
      }
    }

    public static decimal Tibia {
      get {
        return 1.09708295651235M;
      }
    }

    public static decimal Foot {
      get {
        return 0.280782753883921M;
      }
    }

    public static decimal Humerus {
      get {
        return 0.756498754402191M;
      }
    }

    public static decimal Forearm {
      get {
        return 0.57770702717082M;
      }
    }

    public static decimal Hand {
      get {
        return 0.273306929266584M;
      }
    }

  }
}
