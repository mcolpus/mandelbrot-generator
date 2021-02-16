namespace FractalApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainImage = new System.Windows.Forms.PictureBox();
            this.Reset = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Label();
            this.ZoomOut = new System.Windows.Forms.Button();
            this.MaxSteps = new System.Windows.Forms.NumericUpDown();
            this.LabelMaxSteps = new System.Windows.Forms.Label();
            this.LabelZoomMultiplier = new System.Windows.Forms.Label();
            this.InputZoomMultiplier = new System.Windows.Forms.NumericUpDown();
            this.LabelEquation = new System.Windows.Forms.Label();
            this.LabelEscapeMagnitude = new System.Windows.Forms.Label();
            this.InputEscapeMagnitude = new System.Windows.Forms.NumericUpDown();
            this.LabelPrintOptions = new System.Windows.Forms.Label();
            this.InputPrintX = new System.Windows.Forms.NumericUpDown();
            this.LabelPrintX = new System.Windows.Forms.Label();
            this.LabelPrintY = new System.Windows.Forms.Label();
            this.InputPrintY = new System.Windows.Forms.NumericUpDown();
            this.ButtonPrint = new System.Windows.Forms.Button();
            this.InputEquation = new System.Windows.Forms.TextBox();
            this.InputUpdate = new System.Windows.Forms.Button();
            this.LabelExampleEquation = new System.Windows.Forms.Label();
            this.LabelSaveLocation = new System.Windows.Forms.Label();
            this.InputSaveLocation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxSteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputZoomMultiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputEscapeMagnitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputPrintX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputPrintY)).BeginInit();
            this.SuspendLayout();
            // 
            // mainImage
            // 
            this.mainImage.Location = new System.Drawing.Point(91, 12);
            this.mainImage.Name = "mainImage";
            this.mainImage.Size = new System.Drawing.Size(512, 512);
            this.mainImage.TabIndex = 0;
            this.mainImage.TabStop = false;
            this.mainImage.Click += new System.EventHandler(this.mainImage_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(609, 12);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 1;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(12, 694);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(37, 13);
            this.Output.TabIndex = 2;
            this.Output.Text = "output";
            // 
            // ZoomOut
            // 
            this.ZoomOut.Location = new System.Drawing.Point(610, 501);
            this.ZoomOut.Name = "ZoomOut";
            this.ZoomOut.Size = new System.Drawing.Size(75, 23);
            this.ZoomOut.TabIndex = 3;
            this.ZoomOut.Text = "zoom out";
            this.ZoomOut.UseVisualStyleBackColor = true;
            this.ZoomOut.Click += new System.EventHandler(this.ZoomOut_Click);
            // 
            // MaxSteps
            // 
            this.MaxSteps.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MaxSteps.Location = new System.Drawing.Point(611, 69);
            this.MaxSteps.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.MaxSteps.Name = "MaxSteps";
            this.MaxSteps.Size = new System.Drawing.Size(110, 20);
            this.MaxSteps.TabIndex = 10;
            this.MaxSteps.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.MaxSteps.ValueChanged += new System.EventHandler(this.MaxSteps_ValueChanged);
            // 
            // LabelMaxSteps
            // 
            this.LabelMaxSteps.AutoSize = true;
            this.LabelMaxSteps.Location = new System.Drawing.Point(610, 50);
            this.LabelMaxSteps.Name = "LabelMaxSteps";
            this.LabelMaxSteps.Size = new System.Drawing.Size(54, 13);
            this.LabelMaxSteps.TabIndex = 11;
            this.LabelMaxSteps.Text = "max steps";
            // 
            // LabelZoomMultiplier
            // 
            this.LabelZoomMultiplier.AutoSize = true;
            this.LabelZoomMultiplier.Location = new System.Drawing.Point(613, 96);
            this.LabelZoomMultiplier.Name = "LabelZoomMultiplier";
            this.LabelZoomMultiplier.Size = new System.Drawing.Size(75, 13);
            this.LabelZoomMultiplier.TabIndex = 12;
            this.LabelZoomMultiplier.Text = "zoom multiplier";
            // 
            // InputZoomMultiplier
            // 
            this.InputZoomMultiplier.Location = new System.Drawing.Point(611, 113);
            this.InputZoomMultiplier.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.InputZoomMultiplier.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.InputZoomMultiplier.Name = "InputZoomMultiplier";
            this.InputZoomMultiplier.Size = new System.Drawing.Size(110, 20);
            this.InputZoomMultiplier.TabIndex = 13;
            this.InputZoomMultiplier.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.InputZoomMultiplier.ValueChanged += new System.EventHandler(this.InputZoomMultiplier_ValueChanged);
            // 
            // LabelEquation
            // 
            this.LabelEquation.AutoSize = true;
            this.LabelEquation.Location = new System.Drawing.Point(88, 537);
            this.LabelEquation.Name = "LabelEquation";
            this.LabelEquation.Size = new System.Drawing.Size(49, 13);
            this.LabelEquation.TabIndex = 14;
            this.LabelEquation.Text = "Equation";
            // 
            // LabelEscapeMagnitude
            // 
            this.LabelEscapeMagnitude.AutoSize = true;
            this.LabelEscapeMagnitude.Location = new System.Drawing.Point(611, 140);
            this.LabelEscapeMagnitude.Name = "LabelEscapeMagnitude";
            this.LabelEscapeMagnitude.Size = new System.Drawing.Size(95, 13);
            this.LabelEscapeMagnitude.TabIndex = 36;
            this.LabelEscapeMagnitude.Text = "escape Magnitude";
            // 
            // InputEscapeMagnitude
            // 
            this.InputEscapeMagnitude.DecimalPlaces = 1;
            this.InputEscapeMagnitude.Location = new System.Drawing.Point(610, 156);
            this.InputEscapeMagnitude.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.InputEscapeMagnitude.Name = "InputEscapeMagnitude";
            this.InputEscapeMagnitude.Size = new System.Drawing.Size(110, 20);
            this.InputEscapeMagnitude.TabIndex = 37;
            this.InputEscapeMagnitude.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.InputEscapeMagnitude.ValueChanged += new System.EventHandler(this.InputEscapeMagnitude_ValueChanged);
            // 
            // LabelPrintOptions
            // 
            this.LabelPrintOptions.AutoSize = true;
            this.LabelPrintOptions.Location = new System.Drawing.Point(609, 208);
            this.LabelPrintOptions.Name = "LabelPrintOptions";
            this.LabelPrintOptions.Size = new System.Drawing.Size(64, 13);
            this.LabelPrintOptions.TabIndex = 38;
            this.LabelPrintOptions.Text = "PrintOptions";
            // 
            // InputPrintX
            // 
            this.InputPrintX.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.InputPrintX.Location = new System.Drawing.Point(654, 234);
            this.InputPrintX.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.InputPrintX.Name = "InputPrintX";
            this.InputPrintX.Size = new System.Drawing.Size(95, 20);
            this.InputPrintX.TabIndex = 39;
            this.InputPrintX.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // LabelPrintX
            // 
            this.LabelPrintX.AutoSize = true;
            this.LabelPrintX.Location = new System.Drawing.Point(613, 236);
            this.LabelPrintX.Name = "LabelPrintX";
            this.LabelPrintX.Size = new System.Drawing.Size(14, 13);
            this.LabelPrintX.TabIndex = 40;
            this.LabelPrintX.Text = "X";
            // 
            // LabelPrintY
            // 
            this.LabelPrintY.AutoSize = true;
            this.LabelPrintY.Location = new System.Drawing.Point(613, 262);
            this.LabelPrintY.Name = "LabelPrintY";
            this.LabelPrintY.Size = new System.Drawing.Size(14, 13);
            this.LabelPrintY.TabIndex = 42;
            this.LabelPrintY.Text = "Y";
            // 
            // InputPrintY
            // 
            this.InputPrintY.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.InputPrintY.Location = new System.Drawing.Point(654, 260);
            this.InputPrintY.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.InputPrintY.Name = "InputPrintY";
            this.InputPrintY.Size = new System.Drawing.Size(95, 20);
            this.InputPrintY.TabIndex = 41;
            this.InputPrintY.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // ButtonPrint
            // 
            this.ButtonPrint.Location = new System.Drawing.Point(674, 388);
            this.ButtonPrint.Name = "ButtonPrint";
            this.ButtonPrint.Size = new System.Drawing.Size(75, 23);
            this.ButtonPrint.TabIndex = 43;
            this.ButtonPrint.Text = "Print";
            this.ButtonPrint.UseVisualStyleBackColor = true;
            this.ButtonPrint.Click += new System.EventHandler(this.ButtonPrint_Click);
            // 
            // InputEquation
            // 
            this.InputEquation.Location = new System.Drawing.Point(91, 569);
            this.InputEquation.Multiline = true;
            this.InputEquation.Name = "InputEquation";
            this.InputEquation.Size = new System.Drawing.Size(563, 51);
            this.InputEquation.TabIndex = 44;
            this.InputEquation.Text = "(z^2) +c";
            this.InputEquation.TextChanged += new System.EventHandler(this.InputEquation_TextChanged);
            // 
            // InputUpdate
            // 
            this.InputUpdate.Location = new System.Drawing.Point(176, 532);
            this.InputUpdate.Name = "InputUpdate";
            this.InputUpdate.Size = new System.Drawing.Size(75, 23);
            this.InputUpdate.TabIndex = 45;
            this.InputUpdate.Text = "Update";
            this.InputUpdate.UseVisualStyleBackColor = true;
            this.InputUpdate.Click += new System.EventHandler(this.InputUpdate_Click);
            // 
            // LabelExampleEquation
            // 
            this.LabelExampleEquation.AutoSize = true;
            this.LabelExampleEquation.Location = new System.Drawing.Point(88, 634);
            this.LabelExampleEquation.Name = "LabelExampleEquation";
            this.LabelExampleEquation.Size = new System.Drawing.Size(228, 13);
            this.LabelExampleEquation.TabIndex = 46;
            this.LabelExampleEquation.Text = "Valid Equation is 6*(z^2) + 2*(z.bar^3) - zn1 + c\r\n";
            // 
            // LabelSaveLocation
            // 
            this.LabelSaveLocation.AutoSize = true;
            this.LabelSaveLocation.Location = new System.Drawing.Point(609, 287);
            this.LabelSaveLocation.Name = "LabelSaveLocation";
            this.LabelSaveLocation.Size = new System.Drawing.Size(76, 13);
            this.LabelSaveLocation.TabIndex = 47;
            this.LabelSaveLocation.Text = "Save Location";
            // 
            // InputSaveLocation
            // 
            this.InputSaveLocation.Location = new System.Drawing.Point(610, 303);
            this.InputSaveLocation.Multiline = true;
            this.InputSaveLocation.Name = "InputSaveLocation";
            this.InputSaveLocation.Size = new System.Drawing.Size(139, 79);
            this.InputSaveLocation.TabIndex = 48;
            this.InputSaveLocation.Text = "C:\\Users\\...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 725);
            this.Controls.Add(this.InputSaveLocation);
            this.Controls.Add(this.LabelSaveLocation);
            this.Controls.Add(this.LabelExampleEquation);
            this.Controls.Add(this.InputUpdate);
            this.Controls.Add(this.InputEquation);
            this.Controls.Add(this.ButtonPrint);
            this.Controls.Add(this.LabelPrintY);
            this.Controls.Add(this.InputPrintY);
            this.Controls.Add(this.LabelPrintX);
            this.Controls.Add(this.InputPrintX);
            this.Controls.Add(this.LabelPrintOptions);
            this.Controls.Add(this.InputEscapeMagnitude);
            this.Controls.Add(this.LabelEscapeMagnitude);
            this.Controls.Add(this.LabelEquation);
            this.Controls.Add(this.InputZoomMultiplier);
            this.Controls.Add(this.LabelZoomMultiplier);
            this.Controls.Add(this.LabelMaxSteps);
            this.Controls.Add(this.MaxSteps);
            this.Controls.Add(this.ZoomOut);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.mainImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mainImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxSteps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputZoomMultiplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputEscapeMagnitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputPrintX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputPrintY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainImage;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Button ZoomOut;
        private System.Windows.Forms.NumericUpDown MaxSteps;
        private System.Windows.Forms.Label LabelMaxSteps;
        private System.Windows.Forms.Label LabelZoomMultiplier;
        private System.Windows.Forms.NumericUpDown InputZoomMultiplier;
        private System.Windows.Forms.Label LabelEquation;
        private System.Windows.Forms.Label LabelEscapeMagnitude;
        private System.Windows.Forms.NumericUpDown InputEscapeMagnitude;
        private System.Windows.Forms.Label LabelPrintOptions;
        private System.Windows.Forms.NumericUpDown InputPrintX;
        private System.Windows.Forms.Label LabelPrintX;
        private System.Windows.Forms.Label LabelPrintY;
        private System.Windows.Forms.NumericUpDown InputPrintY;
        private System.Windows.Forms.Button ButtonPrint;
        private System.Windows.Forms.TextBox InputEquation;
        private System.Windows.Forms.Button InputUpdate;
        private System.Windows.Forms.Label LabelExampleEquation;
        private System.Windows.Forms.Label LabelSaveLocation;
        private System.Windows.Forms.TextBox InputSaveLocation;
    }
}

