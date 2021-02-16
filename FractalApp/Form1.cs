using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalApp
{
    public partial class Form1 : Form
    {
        public FractalGenerator gen = new FractalGenerator();
        double zoomFactor = 2.1;
        double zoomMultiplier = 2;
        Complex centre = new Complex(0, 0);
        NextStepFunction f = (z,zn1, c) => (z ^ 2) + c;
        int maxSteps = 50;
        double escapeMagnitude = 2;
        string equation = "(z^2) + c";
        


        public Form1()
        {
            
            InitializeComponent();
            Draw();
        }

        private void mainImage_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;//this, helpfully, gives the position of mouse to match pixel value (512,512)
            centre.real = centre.real + zoomFactor * (((float)coordinates.X - 256f) / 256f);
            centre.img = centre.img + zoomFactor * (((float)coordinates.Y - 256f) / 256f);

            if(me.Button == MouseButtons.Left)
                zoomFactor /= zoomMultiplier;
            else if(me.Button == MouseButtons.Right)
                zoomFactor *= zoomMultiplier;
            Draw();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            zoomFactor = 2.1;
            centre = new Complex(0, 0);
            Draw();
        }

        private void Draw()
        {
            gen.topRight = centre + new Complex(zoomFactor);
            gen.bottomLeft = centre - new Complex(zoomFactor);
            gen.maxSteps = maxSteps;
            gen.maxMagnitude = escapeMagnitude;
            
            
            object test = DynamicLambda.ExecuteLambdaExpression(equation);

            MethodInfo info = test?.GetType()?.GetMethod("LambdaMethod");

            if(info != null)
            {
                Console.WriteLine("drawing");
                Output.Text = "valid equation";

                gen.f = (NextStepFunction)Delegate.CreateDelegate(typeof(NextStepFunction), info);
                mainImage.Image = gen.Run(512);
                Console.WriteLine(mainImage.Image);

                Output.Text = "Drawn";
            }
            else
            {
                Output.Text = equation + " is invalid equation";
            }
            
        }

        private void ZoomOut_Click(object sender, EventArgs e)
        {
            zoomFactor *= zoomMultiplier;
            Draw();
        }
        

        private void MaxSteps_ValueChanged(object sender, EventArgs e)
        {
            maxSteps = (int)MaxSteps.Value;
            Draw();
        }

        private void InputZoomMultiplier_ValueChanged(object sender, EventArgs e)
        {
            zoomMultiplier = (double)InputZoomMultiplier.Value;
        }

        private void InputEscapeMagnitude_ValueChanged(object sender, EventArgs e)
        {
            escapeMagnitude = (double)InputEscapeMagnitude.Value;
            Draw();
        }
        

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            Bitmap image = gen.Run((int)InputPrintX.Value, (int)InputPrintY.Value);
            image.Save(InputSaveLocation.Text + @"\" + "image" + ".png");
            Output.Text = "printed";
        }

        private void InputEquation_TextChanged(object sender, EventArgs e)
        {
            equation = InputEquation.Text;
        }

        private void InputUpdate_Click(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
