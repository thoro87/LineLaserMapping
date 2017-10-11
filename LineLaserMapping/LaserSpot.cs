using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineLaserMapping {
    public class LaserSpot {

        public int ImageWidth { get; set; }
        public int ImageHeight { get; set; }
        public byte Threshold { get; set; }

        public int PosX { get; set; }
        public int PosY { get; set; }
        public double Difference { get; set; }

        public bool IsOverThreashold { get { return Difference > Threshold; } }
        public int PixelToCenter { get { return (ImageHeight / 2) - PosY; } }
        public decimal Distance {
            get {
                // Seperation 6.8cm
                // m 0.000919913
                // y 0.026493506
                // See Calibration.ods for more info
                return 6.8m / (PixelToCenter * 0.000919913m - 0.026493506m);
            }
        }

        public LaserSpot(Bitmap img, int posX, byte threshold) {
            ImageWidth = img.Width;
            ImageHeight = img.Height;
            PosX = posX;
            Threshold = threshold;
        }

    }
}
