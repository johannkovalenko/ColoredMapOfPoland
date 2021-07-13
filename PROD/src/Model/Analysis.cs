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

            while (true)
            {
                int iterations = points.Count;
                for (int it = 0; it < iterations; it++)
                {
                    DB point = points[it];

                    if (point.finished == false)
                    {
                        foreach(int[] direction in directions)
                        {
                            DB neighbor = new DB(point.X + direction[0], point.Y + direction[1]);
                            Color neighborColor = bmp.GetColorOfPoint(neighbor.X, neighbor.Y);

                            //sb.Append(neighborColor + "\r\n");
                            if(points.Contains(neighbor))
                            {
                            }
                            else if (neighborColor.R == 255 && neighborColor.G == 255 && neighborColor.B == 255)
                            {
                            }
                            else if (neighborColor.R == 0 && neighborColor.G == 0 && neighborColor.B == 0)
                            {
                            }
                            else
                                points.Add(neighbor);
                        }

                        point.finished = true;
                    } 
                }
                if (points.Count == iterations)
                    break;
            }

            stopwatch.Stop();

            System.IO.File.WriteAllText("debug.txt", stopwatch.Elapsed.TotalMilliseconds.ToString());

            return points;
        }
    }
}