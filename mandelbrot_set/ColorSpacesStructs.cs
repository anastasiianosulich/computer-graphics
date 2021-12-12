using System;

namespace ColorModels.Code
{
    public struct CMYK
    {
        public readonly static CMYK Empty = new CMYK();

        private double c;
        private double m;
        private double y;
        private double k;

        public static bool operator ==(CMYK item1, CMYK item2)
        {
            return (
                item1.Cyan == item2.Cyan
                && item1.Magenta == item2.Magenta
                && item1.Yellow == item2.Yellow
                && item1.Black == item2.Black
                );
        }

        public static bool operator !=(CMYK item1, CMYK item2)
        {
            return (
                item1.Cyan != item2.Cyan
                || item1.Magenta != item2.Magenta
                || item1.Yellow != item2.Yellow
                || item1.Black != item2.Black
                );
        }

        public double Cyan
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
                c = (c > 1) ? 1 : ((c < 0) ? 0 : c);
            }
        }

        public double Magenta
        {
            get
            {
                return m;
            }
            set
            {
                m = value;
                m = (m > 1) ? 1 : ((m < 0) ? 0 : m);
            }
        }

        public double Yellow
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
                y = (y > 1) ? 1 : ((y < 0) ? 0 : y);
            }
        }

        public double Black
        {
            get
            {
                return k;
            }
            set
            {
                k = value;
                k = (k > 1) ? 1 : ((k < 0) ? 0 : k);
            }
        }

        /// <summary>
        /// Creates an instance of a CMYK structure.
        /// </summary>
        public CMYK(double c, double m, double y, double k)
        {
            this.c = c;
            this.m = m;
            this.y = y;
            this.k = k;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;

            return (this == (CMYK)obj);
        }

        public override int GetHashCode()
        {
            return Cyan.GetHashCode() ^
              Magenta.GetHashCode() ^ Yellow.GetHashCode() ^ Black.GetHashCode();
        }

    }
    public struct HSL
    {
        /// <summary>
        /// Gets an empty HSL structure;
        /// </summary>
        public static readonly HSL Empty = new HSL();

        private double hue;
        private double saturation;
        private double luminance;

        public static bool operator ==(HSL item1, HSL item2)
        {
            return (
                item1.Hue == item2.Hue
                && item1.Saturation == item2.Saturation
                && item1.Luminance == item2.Luminance
                );
        }

        public static bool operator !=(HSL item1, HSL item2)
        {
            return (
                item1.Hue != item2.Hue
                || item1.Saturation != item2.Saturation
                || item1.Luminance != item2.Luminance
                );
        }

        /// <summary>
        /// Gets or sets the hue component.
        /// </summary>
        public double Hue
        {
            get
            {
                return hue;
            }
            set
            {
                hue = (value > 360) ? 360 : ((value < 0) ? 0 : value);
            }
        }

        /// <summary>
        /// Gets or sets saturation component.
        /// </summary>
        public double Saturation
        {
            get
            {
                return saturation;
            }
            set
            {
                saturation = (value > 1) ? 1 : ((value < 0) ? 0 : value);
            }
        }

        /// <summary>
        /// Gets or sets the luminance component.
        /// </summary>
        public double Luminance
        {
            get
            {
                return luminance;
            }
            set
            {
                luminance = (value > 1) ? 1 : ((value < 0) ? 0 : value);
            }
        }

        /// <summary>
        /// Creates an instance of a HSL structure.
        /// </summary>
        /// <param name="h">Hue value.</param>
        /// <param name="s">Saturation value.</param>
        /// <param name="l">Lightness value.</param>
        public HSL(double h, double s, double l)
        {
            this.hue = (h > 360) ? 360 : ((h < 0) ? 0 : h);
            this.saturation = (s > 1) ? 1 : ((s < 0) ? 0 : s);
            this.luminance = (l > 1) ? 1 : ((l < 0) ? 0 : l);
        }

        public override bool Equals(Object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;

            return (this == (HSL)obj);
        }

        public override int GetHashCode()
        {
            return Hue.GetHashCode() ^ Saturation.GetHashCode() ^
                Luminance.GetHashCode();
        }
    }
}
