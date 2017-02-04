using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineLaserMapping {
	class ImageComparer {

		public unsafe Bitmap CompareImages(Bitmap img1, Bitmap img2) {
			double threshold = 30d;
			List<string> results = new List<string>();

			BitmapData img1BmpData = img1.LockBits(new Rectangle(0, 0, img1.Width, img1.Height), ImageLockMode.ReadWrite, img1.PixelFormat);
			BitmapData img2BmpData = img2.LockBits(new Rectangle(0, 0, img2.Width, img2.Height), ImageLockMode.ReadWrite, img2.PixelFormat);

			byte img1BitsPerPixel = GetBitsPerPixel(img1BmpData.PixelFormat);
			byte img2BitsPerPixel = GetBitsPerPixel(img2BmpData.PixelFormat);

			byte* img1Scan0 = (byte*)img1BmpData.Scan0.ToPointer();
			byte* img2Scan0 = (byte*)img2BmpData.Scan0.ToPointer();

			for (int height = 0; height < img1BmpData.Height; ++height) {
				for (int width = 0; width < img1BmpData.Width; ++width) {

					byte* img1Data = img1Scan0 + height * img1BmpData.Stride + width * img1BitsPerPixel / 8;
					byte* img2Data = img2Scan0 + height * img2BmpData.Stride + width * img2BitsPerPixel / 8;

					// red diff
					double diff = Math.Abs(img1Data[2] - img2Data[2]);

					// all diff
					//double img1Magnitude = 1 / 3d * (img1Data[0] + img1Data[1] + img1Data[2]);
					//double img2Magnitude = 1 / 3d * (img2Data[0] + img2Data[1] + img2Data[2]);
					//double diff = Math.Abs(img1Magnitude - img2Magnitude);

					if (diff > threshold) {
						results.Add(String.Format("Width: {0}, Height: {1}, Diff: {2}", width, height, diff));
						img1Data[0] = 0;
						img1Data[1] = 0;
						img1Data[2] = 0;
					} else {
						img1Data[0] = 255;
						img1Data[1] = 255;
						img1Data[2] = 255;
					}

				}
			}

			img1.UnlockBits(img1BmpData);
			img2.UnlockBits(img1BmpData);

			return img1;
		}

		private byte GetBitsPerPixel(PixelFormat pixelFormat) {
			byte result;
			switch (pixelFormat) {
				case PixelFormat.Format8bppIndexed: result = 8; break;
				case PixelFormat.Format24bppRgb: result = 24; break;
				case PixelFormat.Format32bppArgb:
				case PixelFormat.Format32bppPArgb: result = 32; break;
				default: result = 0; break;
			}
			return result;
		}


	}
}
