using System;
using System.Drawing;
using System.Collections.Generic;
using System.Diagnostics;

namespace Model
{
    public class Analysis
    {
        private BMP bmp;
        private Color grey = Color.FromArgb(224, 224, 224);
        private Color white = Color.White;
        private Color black = Color.Black;
        private int[][] directions = {
            new int[] {0, 1}, 
            new int[] {0, -1},
            new int[] {1, 0}, 
            new int[] {-1, 0}
        };


        public Analysis(BMP bmp)
        {
            this.bmp = bmp;
        }

        public List<DB> Run(int startX, int startY)
        {
            var stopwatch = new Stopwatch();

            stopwatch.Start();

            var points = new List<DB>();

            points.Add(new DB(startX, startY));

            int startIndex = 0;

            while (true)
            {
                int iterations = points.Count;
                for (int it = startIndex; it < iterations; it++)
                {
                    DB point = points[it];

                    //if (point.finished == false)
                    //{
                        foreach(int[] direction in directions)
                        {
                            DB neighbor = new DB(point.X + direction[0], point.Y + direction[1]);
                            Color neighborColor = bmp.GetColorOfPoint(neighbor.X, neighbor.Y);

                            if (neighborColor.R == 224 && neighborColor.G == 224 && neighborColor.B == 224)
                            {
                                bmp.SetPixel(neighbor.X, neighbor.Y);
                                points.Add(neighbor);
                            }
                        }

                        //point.finished = true;
                    //} 
                }
                if (points.Count == iterations)
                    break;

                startIndex = iterations - 1;
            }

            stopwatch.Stop();

            System.IO.File.AppendAllText("debug.txt", stopwatch.Elapsed.TotalMilliseconds.ToString() + "\r\n");

            return points;
        }
    }
}