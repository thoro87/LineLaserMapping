using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineLaserMapping {
	public class ResultDO {
		public Bitmap DiffImage { get; set; }
		public Bitmap ResultImage { get; set; }
		public Dictionary<int, LaserSpot> LaserSpots { get; set; }
	}
}
