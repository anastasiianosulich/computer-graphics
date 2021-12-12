﻿using System;
using System.Drawing;

namespace ColorModels
{
    static class ColorConverter
    {

        public static double[] RgbToHsl(byte r, byte g, byte b, string luminance = null)
        {
            double h, s, l;

            double double_r = r / 255.0;
            double double_g = g / 255.0;
            double double_b = b / 255.0;

            double max = Math.Max(double_r, Math.Max(double_g, double_b));
            double min = Math.Min(double_r, Math.Min(double_g, double_b));
            double diff = max - min;

            l = (max + min) / 2;

            if (Math.Abs(diff) < 0.00001)
            {
                s = 0;
                h = 0;
            }
            else
            {
                if (l <= 0.5) s = diff / (max + min);
                else s = diff / (2 - max - min);

                double r_dist = (max - double_r) / diff;
                double g_dist = (max - double_g) / diff;
                double b_dist = (max - double_b) / diff;

                if (Math.Abs(double_r - max) < 0.0001) h = b_dist - g_dist;
                else if (Math.Abs(double_g - max) < 0.0001) h = 2 + r_dist - b_dist;
                else h = 4 + g_dist - r_dist;

                h = h * 60;
                if (h < 0) h += 360;
                if(s < 0.03)
                {
                    l = int.Parse(luminance) / 100.0;
                }
            }

            return new[] { h, s, l };
        }

        public static byte[] HslToRgb(double h, double s, double l)
        {
            byte r, g, b;
            double p2;
            if (l <= 0.5) p2 = l * (1 + s);
            else p2 = l + s - l * s;

            double p1 = 2 * l - p2;
            double double_r, double_g, double_b;
            if (s == 0)
            {
                double_r = l;
                double_g = l;
                double_b = l;
            }
            else
            {
                double_r = QqhToRgb(p1, p2, h + 120);
                double_g = QqhToRgb(p1, p2, h);
                double_b = QqhToRgb(p1, p2, h - 120);
            }

            r = (byte)(double_r * 255.0);
            g = (byte)(double_g * 255.0);
            b = (byte)(double_b * 255.0);
            return new[] { r, g, b };
        }

        private static double QqhToRgb(double q1, double q2, double hue)
        {
            if (hue > 360) hue -= 360;
            else if (hue < 0) hue += 360;

            if (hue < 60) return q1 + (q2 - q1) * hue / 60;
            if (hue < 180) return q2;
            if (hue < 240) return q1 + (q2 - q1) * (240 - hue) / 60;
            return q1;
        }
    }
}
