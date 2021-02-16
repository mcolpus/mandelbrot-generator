using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;

namespace FractalApp
{
    public delegate Complex NextStepFunction(Complex z, Complex zn1, Complex c);

    public class FractalGenerator
    {
        public delegate double Method(Complex c, NextStepFunction f, int maxSteps, double maxMagnitude);

        // variables for selecting colouring function
        public delegate Color ColorFunction(double steps);
        public enum ColorMethods { proportionalHue, squish}
        public ColorMethods colorMethod = ColorMethods.proportionalHue;

        public Complex topRight;
        public Complex bottomLeft;

        // parameters which get edited by Form1.cs
        public int scale = 512;
        public int width = 1;
        public int height = 1;
        public int maxSteps = 100;
        public double[,] map;
        public double maxMagnitude;
        public NextStepFunction f;

        //coloring options
        public bool continousColoring = true;


        public Method method = LamdaExpression; // change to StandardEquation to test with default Mandelbrot equation

        public Bitmap Run(int scale)
        {
            return Run(scale, scale);
        }
        public Bitmap Run(int _width, int _height)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            // update value of width and height for later use in DrawMap

            width = _width;
            height = _height;

            map = new double[width, height]; // will contain number of steps to escape, which is used by colouring function


            for(int i = 0; i < width; i++)
            {
                for(int j = 0; j < height; j++)
                {
                    Complex number = new Complex(0, 0);
                    number.real = bottomLeft.real + (i / (double)width) * (topRight.real - bottomLeft.real);
                    number.img = bottomLeft.img + (j / (double)height) * (topRight.img - bottomLeft.img);

                    map[i, j] = method(number, f, maxSteps, maxMagnitude);
                }


                if(i % 100 == 0)
                    Console.WriteLine(((float)i / (float)width) * 100f + "%");
            }

            stopwatch.Stop();
            Console.WriteLine("fractal made in: " + stopwatch.ElapsedMilliseconds + " milliseconds");
            stopwatch.Restart();

            Bitmap bitmap = DrawMap();

            stopwatch.Stop();
            Console.WriteLine("map drawn in: " + stopwatch.ElapsedMilliseconds + " milliseconds");

            return bitmap;
        }

        public Bitmap DrawMap()
        {
            Bitmap bitmap = new Bitmap(width, height);
            ColorFunction colorFunction = GetColorProportionalHueCycle;
            switch(colorMethod)
            {
            case ColorMethods.proportionalHue:
                colorFunction = GetColorProportionalHueCycle;
                break;
            case ColorMethods.squish:
                colorFunction = GetColorSquish;
                break;
            }
            

            for(int i = 0; i < width; i++)
            {
                for(int j = 0; j < height; j++)
                {
                    Color color = Color.Black;
                    double steps = map[i, j];
                    if(!continousColoring) steps = Math.Floor(steps);
                    

                    if(steps != -1)
                    {
                        color = colorFunction(steps);
                    }

                    bitmap.SetPixel(i, j, color);
                }
            }

            return bitmap;
        }
        public Color GetColorProportionalHueCycle(double steps)
        {
            return new HSLColor((steps * 0.02) % 1.0, 1, 0.5);
        }
        public Color GetColorSquish(double steps)
        {
            return new HSLColor(steps / (float)maxSteps, 1, 0.5);
        }

        public static double LamdaExpression(Complex c, NextStepFunction f, int maxSteps, double maxMagnitude)
        {
            //Zn = (Zn-1)^2 + c 
            //steps = -1 means it never escaped
            double escapeMagnitudeSquared = maxMagnitude*maxMagnitude;
            double log2 = Math.Log(2);
            
            int steps = 0;

            Complex z = new Complex(0, 0);
            Complex zn1 = new Complex(0, 0);
            while(steps < maxSteps)
            {
                steps++;

                Complex temp = f(z, zn1, c);
                
                zn1 = new Complex(z.real,z.img);
                z = temp;

                if(z.MagnitudeSquared > escapeMagnitudeSquared)
                    return steps + (log2/(z.Magnitude-1))/log2;
            }
            return -1;
        }



        public static double StandardEquation(Complex c, NextStepFunction f = null, int maxSteps = 100, double maxMagnitude = 2)
        {
            //Zn = (Zn-1)^2 + c 
            //steps = -1 means it never escaped
            double escapeMagnitude = maxMagnitude;
            double log2 = Math.Log(2);

            int steps = 0;

            Complex z = new Complex(0, 0);
            while(steps < maxSteps)
            {
                steps++;
                z = z * z + c;
                if(z.Magnitude > escapeMagnitude)
                    return steps + (1 - (log2 / z.Magnitude) / log2);
            }
            return -1;
        }


    }

    public class Complex
    {
        public double real;
        public double img;

        public double Magnitude { get { return Math.Sqrt(real * real + img * img); } }
        public double MagnitudeSquared { get { return real * real + img * img; } }

        public Complex(double _real, double _img)
        {
            real = _real;
            img = _img;
        }
        public Complex(double both)
        {
            real = both;
            img = both;
        }

        public Complex bar
        {
            get
            {
                return new Complex(real, -img);
            }
        }
        public Complex PosDir
        {
            get
            {
                return new Complex(Math.Abs(real), Math.Abs(img));
            }
        }

        public static bool operator ==(Complex a, Complex b)
        {
            if(a.real == b.real && a.img == b.img)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Complex a, Complex b)
        {
            if(a.real != b.real || a.img != b.img)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Complex operator *(Complex a, Complex b)
        {
            return new Complex(a.real * b.real - a.img * b.img, a.real * b.img + a.img * b.real);
        }
        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.real + b.real, a.img + b.img);
        }
        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.real - b.real, a.img - b.img);
        }

        public static Complex operator *(Complex a, double b)
        {
            if(b == 0) return new Complex(0, 0);
            return new Complex(a.real * b, a.img * b);
        }
        public static Complex operator *(double b, Complex a)
        {
            if(b == 0) return new Complex(0, 0);
            return new Complex(a.real * b, a.img * b);
        }
        public static Complex operator /(Complex a, double b)
        {
            return new Complex(a.real / b, a.img / b);
        }

        public static Complex operator ^(Complex a, int b)
        {
            Complex c = new Complex(a.real, a.img);
            while(b > 1)
            {
                c = c * a;
                b--;
            }
            return c;

        }

    }


    public class HSLColor
    {
        // Private data members below are on scale 0-1
        // They are scaled for use externally based on scale
        private double hue = 1.0;
        private double saturation = 1.0;
        private double luminosity = 1.0;

        private const double scale = 1.0;

        public double Hue
        {
            get { return hue * scale; }
            set { hue = CheckRange(value / scale); }
        }
        public double Saturation
        {
            get { return saturation * scale; }
            set { saturation = CheckRange(value / scale); }
        }
        public double Luminosity
        {
            get { return luminosity * scale; }
            set { luminosity = CheckRange(value / scale); }
        }

        private double CheckRange(double value)
        {
            if(value < 0.0)
                value = 0.0;
            else if(value > 1.0)
                value = 1.0;
            return value;
        }

        public override string ToString()
        {
            return String.Format("H: {0:#0.##} S: {1:#0.##} L: {2:#0.##}", Hue, Saturation, Luminosity);
        }

        public string ToRGBString()
        {
            Color color = (Color)this;
            return String.Format("R: {0:#0.##} G: {1:#0.##} B: {2:#0.##}", color.R, color.G, color.B);
        }

        #region Casts to/from System.Drawing.Color
        public static implicit operator Color(HSLColor hslColor)
        {
            double r = 0, g = 0, b = 0;
            if(hslColor.luminosity != 0)
            {
                if(hslColor.saturation == 0)
                    r = g = b = hslColor.luminosity;
                else
                {
                    double temp2 = GetTemp2(hslColor);
                    double temp1 = 2.0 * hslColor.luminosity - temp2;

                    r = GetColorComponent(temp1, temp2, hslColor.hue + 1.0 / 3.0);
                    g = GetColorComponent(temp1, temp2, hslColor.hue);
                    b = GetColorComponent(temp1, temp2, hslColor.hue - 1.0 / 3.0);
                }
            }
            return Color.FromArgb((int)(255 * r), (int)(255 * g), (int)(255 * b));
        }

        private static double GetColorComponent(double temp1, double temp2, double temp3)
        {
            temp3 = MoveIntoRange(temp3);
            if(temp3 < 1.0 / 6.0)
                return temp1 + (temp2 - temp1) * 6.0 * temp3;
            else if(temp3 < 0.5)
                return temp2;
            else if(temp3 < 2.0 / 3.0)
                return temp1 + ((temp2 - temp1) * ((2.0 / 3.0) - temp3) * 6.0);
            else
                return temp1;
        }
        private static double MoveIntoRange(double temp3)
        {
            if(temp3 < 0.0)
                temp3 += 1.0;
            else if(temp3 > 1.0)
                temp3 -= 1.0;
            return temp3;
        }
        private static double GetTemp2(HSLColor hslColor)
        {
            double temp2;
            if(hslColor.luminosity < 0.5)  //<=??
                temp2 = hslColor.luminosity * (1.0 + hslColor.saturation);
            else
                temp2 = hslColor.luminosity + hslColor.saturation - (hslColor.luminosity * hslColor.saturation);
            return temp2;
        }

        public static implicit operator HSLColor(Color color)
        {
            HSLColor hslColor = new HSLColor();
            hslColor.hue = color.GetHue() / 360.0; // we store hue as 0-1 as opposed to 0-360 
            hslColor.luminosity = color.GetBrightness();
            hslColor.saturation = color.GetSaturation();
            return hslColor;
        }
        #endregion

        public void SetRGB(int red, int green, int blue)
        {
            HSLColor hslColor = (HSLColor)Color.FromArgb(red, green, blue);
            this.hue = hslColor.hue;
            this.saturation = hslColor.saturation;
            this.luminosity = hslColor.luminosity;
        }

        public HSLColor() { }
        public HSLColor(Color color)
        {
            SetRGB(color.R, color.G, color.B);
        }
        public HSLColor(int red, int green, int blue)
        {
            SetRGB(red, green, blue);
        }
        public HSLColor(double hue, double saturation, double luminosity)
        {
            this.Hue = hue;
            this.Saturation = saturation;
            this.Luminosity = luminosity;
        }

    }
}
