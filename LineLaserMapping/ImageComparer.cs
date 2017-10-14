using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineLaserMapping {
	class ImageComparer {

		public unsafe ResultDO CompareImages(Bitmap img1, Bitmap img2, Image resultBackground) {
			byte threshold = 60;

			BitmapData img1BmpData = img1.LockBits(new Rectangle(0, 0, img1.Width, img1.Height), ImageLockMode.ReadWrite, img1.PixelFormat);
			byte img1BitsPerPixel = GetBitsPerPixel(img1BmpData.PixelFormat);
			byte* img1Scan0 = (byte*)img1BmpData.Scan0.ToPointer();

			BitmapData img2BmpData = img2.LockBits(new Rectangle(0, 0, img2.Width, img2.Height), ImageLockMode.ReadWrite, img2.PixelFormat);
			byte img2BitsPerPixel = GetBitsPerPixel(img2BmpData.PixelFormat);
			byte* img2Scan0 = (byte*)img2BmpData.Scan0.ToPointer();

            Bitmap diffImg = GetFilledBitmap(img1.Width, img1.Height, Brushes.White);
            BitmapData diffImgBmpData = diffImg.LockBits(new Rectangle(0, 0, diffImg.Width, diffImg.Height), ImageLockMode.ReadWrite, diffImg.PixelFormat);
            byte diffImgBitsPerPixel = GetBitsPerPixel(diffImgBmpData.PixelFormat);
            byte* diffImgScan0 = (byte*)diffImgBmpData.Scan0.ToPointer();

            Dictionary<int, LaserSpot> laserSpots = new Dictionary<int, LaserSpot>();

			for (int width = 0; width < img1BmpData.Width; width++) {

				// create LaserSpot
				laserSpots[width] = new LaserSpot(img1, width, threshold);

				for (int height = 0; height < img1BmpData.Height; height++) {

					byte* img1Data = img1Scan0 + height * img1BmpData.Stride + width * img1BitsPerPixel / 8;
					byte* img2Data = img2Scan0 + height * img2BmpData.Stride + width * img2BitsPerPixel / 8;
					byte* diffImgData = diffImgScan0 + height * diffImgBmpData.Stride + width * diffImgBitsPerPixel / 8;

                    // red diff
                    byte diff = (byte)Math.Abs(img1Data[2] - img2Data[2]);

					// all diff
					//double img1Magnitude = 1 / 3d * (img1Data[0] + img1Data[1] + img1Data[2]);
					//double img2Magnitude = 1 / 3d * (img2Data[0] + img2Data[1] + img2Data[2]);
					//double diff = Math.Abs(img1Magnitude - img2Magnitude);

					if (height < img1.Height / 2) {
						LaserSpot currentSpot = laserSpots[width];
						if (currentSpot.Difference < diff) {
							currentSpot.PosY = height;
							currentSpot.Difference = diff;
						}
					}

                    // grayScale Image
                    diffImgData[0] = diffImgData[1] = diffImgData[2] = (byte)(255 - diff);

					// horizon
					if (height == (diffImg.Height / 2)) {
                        diffImgData[0] = 255;
                        diffImgData[1] = diffImgData[2] = 0;
                    }

                    // vertical
                    if (width == (diffImg.Width / 2)) {
                        diffImgData[0] = 255;
                        diffImgData[1] = diffImgData[2] = 0;
                    }

				}
			}

			img1.UnlockBits(img1BmpData);
			img2.UnlockBits(img2BmpData);
			diffImg.UnlockBits(diffImgBmpData);

            // create resultImage
            Bitmap resultImg = new Bitmap(resultBackground);
            BitmapData resultImgBmpData = resultImg.LockBits(new Rectangle(0, 0, resultImg.Width, resultImg.Height), ImageLockMode.ReadWrite, resultImg.PixelFormat);
            byte resultImgBitsPerPixel = GetBitsPerPixel(resultImgBmpData.PixelFormat);
            byte* resultImgScan0 = (byte*)resultImgBmpData.Scan0.ToPointer();
            decimal cmToPixelFactor = 2m;
            int camX = resultImg.Width / 2;
            int camY = resultImg.Height;
            for (int i = 0; i < laserSpots.Keys.Count; i++) {
                LaserSpot spot = laserSpots[i];
                if (spot.IsOverThreashold) {
                    int pixelFromVerticalCenter = i - img1.Width / 2;
                    decimal cmFromVerticalCenter = spot.Distance * 0.6m * pixelFromVerticalCenter / (img1.Width / 2); // opening angle = 1.2
                    int x = camX + (int)(cmFromVerticalCenter * cmToPixelFactor);
                    int y = camY - (int)(spot.Distance * cmToPixelFactor);
                    if (x > 0 && x < resultImg.Width && y > 0 && y < resultImg.Height) {
                        byte* resultImgData = resultImgScan0 + y * resultImgBmpData.Stride + x * resultImgBitsPerPixel / 8;
                        resultImgData[0] = 0; // blue
                        resultImgData[1] = 0; // green
                        resultImgData[2] = 0; // red
                        resultImgData[3] = 255; // alpha
                    }
                }
            }
            resultImg.UnlockBits(resultImgBmpData);

            return new ResultDO {
				DiffImage = diffImg,
                ResultImage = resultImg,
				LaserSpots = laserSpots
			};
		}

        private Bitmap GetFilledBitmap(int x, int y, Brush brush) {
            Bitmap bmp = new Bitmap(x, y);
            using (Graphics graph = Graphics.FromImage(bmp)) {
                Rectangle ImageSize = new Rectangle(0, 0, x, y);
                graph.FillRectangle(brush, ImageSize);
            }
            return bmp;
        }

        //using (Graphics graphics = Graphics.FromImage(resultImg)) {
        //    Rectangle rectangle = new Rectangle(200, 200, 10, 10);
        //    graphics.FillRectangle(Brushes.Green, rectangle);
        //}

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
