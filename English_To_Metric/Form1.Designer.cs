﻿namespace English_To_Metric
{
    partial class frmEnglishToMetric
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
            if (disposing && (components != null))
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpEnglishToMetric = new System.Windows.Forms.GroupBox();
            this.lblInches = new System.Windows.Forms.Label();
            this.lblEFeet = new System.Windows.Forms.Label();
            this.lblYards = new System.Windows.Forms.Label();
            this.lblEMiles = new System.Windows.Forms.Label();
            this.btnEnglishClear = new System.Windows.Forms.Button();
            this.txtInches = new System.Windows.Forms.TextBox();
            this.txtYards = new System.Windows.Forms.TextBox();
            this.txtFeet = new System.Windows.Forms.TextBox();
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.grpMetricToEnglish = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKilometers = new System.Windows.Forms.Label();
            this.lblMeters = new System.Windows.Forms.Label();
            this.btnMetricClear = new System.Windows.Forms.Button();
            this.txtCentimeters = new System.Windows.Forms.TextBox();
            this.txtKilometers = new System.Windows.Forms.TextBox();
            this.txtMeters = new System.Windows.Forms.TextBox();
            this.optEnglishToMetric = new System.Windows.Forms.RadioButton();
            this.optMetricToEnglish = new System.Windows.Forms.RadioButton();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpEnglishToMetric.SuspendLayout();
            this.grpMetricToEnglish.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(207, 25);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(438, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "English To Metric Converter";
            // 
            // grpEnglishToMetric
            // 
            this.grpEnglishToMetric.Controls.Add(this.lblInches);
            this.grpEnglishToMetric.Controls.Add(this.lblEFeet);
            this.grpEnglishToMetric.Controls.Add(this.lblYards);
            this.grpEnglishToMetric.Controls.Add(this.lblEMiles);
            this.grpEnglishToMetric.Controls.Add(this.btnEnglishClear);
            this.grpEnglishToMetric.Controls.Add(this.txtInches);
            this.grpEnglishToMetric.Controls.Add(this.txtYards);
            this.grpEnglishToMetric.Controls.Add(this.txtFeet);
            this.grpEnglishToMetric.Controls.Add(this.txtMiles);
            this.grpEnglishToMetric.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEnglishToMetric.Location = new System.Drawing.Point(25, 140);
            this.grpEnglishToMetric.Margin = new System.Windows.Forms.Padding(2);
            this.grpEnglishToMetric.Name = "grpEnglishToMetric";
            this.grpEnglishToMetric.Padding = new System.Windows.Forms.Padding(2);
            this.grpEnglishToMetric.Size = new System.Drawing.Size(439, 246);
            this.grpEnglishToMetric.TabIndex = 1;
            this.grpEnglishToMetric.TabStop = false;
            this.grpEnglishToMetric.Text = "English";
            this.grpEnglishToMetric.Visible = false;
            this.grpEnglishToMetric.Enter += new System.EventHandler(this.grpEnglishToMetric_Enter);
            // 
            // lblInches
            // 
            this.lblInches.AutoSize = true;
            this.lblInches.Location = new System.Drawing.Point(295, 145);
            this.lblInches.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInches.Name = "lblInches";
            this.lblInches.Size = new System.Drawing.Size(66, 24);
            this.lblInches.TabIndex = 8;
            this.lblInches.Text = "Inches";
            // 
            // lblEFeet
            // 
            this.lblEFeet.AutoSize = true;
            this.lblEFeet.Location = new System.Drawing.Point(42, 145);
            this.lblEFeet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEFeet.Name = "lblEFeet";
            this.lblEFeet.Size = new System.Drawing.Size(48, 24);
            this.lblEFeet.TabIndex = 7;
            this.lblEFeet.Text = "Feet";
            // 
            // lblYards
            // 
            this.lblYards.AutoSize = true;
            this.lblYards.Location = new System.Drawing.Point(303, 35);
            this.lblYards.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYards.Name = "lblYards";
            this.lblYards.Size = new System.Drawing.Size(58, 24);
            this.lblYards.TabIndex = 6;
            this.lblYards.Text = "Yards";
            // 
            // lblEMiles
            // 
            this.lblEMiles.AutoSize = true;
            this.lblEMiles.Location = new System.Drawing.Point(42, 43);
            this.lblEMiles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEMiles.Name = "lblEMiles";
            this.lblEMiles.Size = new System.Drawing.Size(54, 24);
            this.lblEMiles.TabIndex = 5;
            this.lblEMiles.Text = "Miles";
            // 
            // btnEnglishClear
            // 
            this.btnEnglishClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnglishClear.Location = new System.Drawing.Point(332, 204);
            this.btnEnglishClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnglishClear.Name = "btnEnglishClear";
            this.btnEnglishClear.Size = new System.Drawing.Size(78, 38);
            this.btnEnglishClear.TabIndex = 4;
            this.btnEnglishClear.Text = "Clear";
            this.btnEnglishClear.UseVisualStyleBackColor = true;
            this.btnEnglishClear.Click += new System.EventHandler(this.btnEnglishClear_Click);
            // 
            // txtInches
            // 
            this.txtInches.Location = new System.Drawing.Point(265, 171);
            this.txtInches.Margin = new System.Windows.Forms.Padding(2);
            this.txtInches.Multiline = true;
            this.txtInches.Name = "txtInches";
            this.txtInches.Size = new System.Drawing.Size(127, 29);
            this.txtInches.TabIndex = 3;
            this.txtInches.TextChanged += new System.EventHandler(this.txtInches_TextChanged);
            // 
            // txtYards
            // 
            this.txtYards.Location = new System.Drawing.Point(265, 71);
            this.txtYards.Margin = new System.Windows.Forms.Padding(2);
            this.txtYards.Multiline = true;
            this.txtYards.Name = "txtYards";
            this.txtYards.Size = new System.Drawing.Size(127, 30);
            this.txtYards.TabIndex = 2;
            // 
            // txtFeet
            // 
            this.txtFeet.Location = new System.Drawing.Point(15, 171);
            this.txtFeet.Margin = new System.Windows.Forms.Padding(2);
            this.txtFeet.Name = "txtFeet";
            this.txtFeet.Size = new System.Drawing.Size(127, 29);
            this.txtFeet.TabIndex = 1;
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(15, 71);
            this.txtMiles.Margin = new System.Windows.Forms.Padding(2);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(127, 29);
            this.txtMiles.TabIndex = 0;
            // 
            // grpMetricToEnglish
            // 
            this.grpMetricToEnglish.Controls.Add(this.label2);
            this.grpMetricToEnglish.Controls.Add(this.lblKilometers);
            this.grpMetricToEnglish.Controls.Add(this.lblMeters);
            this.grpMetricToEnglish.Controls.Add(this.btnMetricClear);
            this.grpMetricToEnglish.Controls.Add(this.txtCentimeters);
            this.grpMetricToEnglish.Controls.Add(this.txtKilometers);
            this.grpMetricToEnglish.Controls.Add(this.txtMeters);
            this.grpMetricToEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMetricToEnglish.Location = new System.Drawing.Point(497, 140);
            this.grpMetricToEnglish.Margin = new System.Windows.Forms.Padding(2);
            this.grpMetricToEnglish.Name = "grpMetricToEnglish";
            this.grpMetricToEnglish.Padding = new System.Windows.Forms.Padding(2);
            this.grpMetricToEnglish.Size = new System.Drawing.Size(439, 246);
            this.grpMetricToEnglish.TabIndex = 2;
            this.grpMetricToEnglish.TabStop = false;
            this.grpMetricToEnglish.Text = "Metric";
            this.grpMetricToEnglish.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "centimeters";
            // 
            // lblKilometers
            // 
            this.lblKilometers.AutoSize = true;
            this.lblKilometers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKilometers.Location = new System.Drawing.Point(259, 30);
            this.lblKilometers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKilometers.Name = "lblKilometers";
            this.lblKilometers.Size = new System.Drawing.Size(113, 25);
            this.lblKilometers.TabIndex = 5;
            this.lblKilometers.Text = "Kilometers";
            // 
            // lblMeters
            // 
            this.lblMeters.AutoSize = true;
            this.lblMeters.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeters.Location = new System.Drawing.Point(48, 34);
            this.lblMeters.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMeters.Name = "lblMeters";
            this.lblMeters.Size = new System.Drawing.Size(78, 25);
            this.lblMeters.TabIndex = 4;
            this.lblMeters.Text = "Meters";
            // 
            // btnMetricClear
            // 
            this.btnMetricClear.Location = new System.Drawing.Point(346, 204);
            this.btnMetricClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnMetricClear.Name = "btnMetricClear";
            this.btnMetricClear.Size = new System.Drawing.Size(78, 38);
            this.btnMetricClear.TabIndex = 3;
            this.btnMetricClear.Text = "Clear";
            this.btnMetricClear.UseVisualStyleBackColor = true;
            this.btnMetricClear.Click += new System.EventHandler(this.btnMetricClear_Click);
            // 
            // txtCentimeters
            // 
            this.txtCentimeters.Location = new System.Drawing.Point(111, 171);
            this.txtCentimeters.Margin = new System.Windows.Forms.Padding(2);
            this.txtCentimeters.Multiline = true;
            this.txtCentimeters.Name = "txtCentimeters";
            this.txtCentimeters.Size = new System.Drawing.Size(140, 30);
            this.txtCentimeters.TabIndex = 2;
            // 
            // txtKilometers
            // 
            this.txtKilometers.Location = new System.Drawing.Point(234, 72);
            this.txtKilometers.Margin = new System.Windows.Forms.Padding(2);
            this.txtKilometers.Multiline = true;
            this.txtKilometers.Name = "txtKilometers";
            this.txtKilometers.Size = new System.Drawing.Size(138, 33);
            this.txtKilometers.TabIndex = 1;
            // 
            // txtMeters
            // 
            this.txtMeters.Location = new System.Drawing.Point(23, 79);
            this.txtMeters.Margin = new System.Windows.Forms.Padding(2);
            this.txtMeters.Multiline = true;
            this.txtMeters.Name = "txtMeters";
            this.txtMeters.Size = new System.Drawing.Size(127, 30);
            this.txtMeters.TabIndex = 0;
            // 
            // optEnglishToMetric
            // 
            this.optEnglishToMetric.AutoSize = true;
            this.optEnglishToMetric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optEnglishToMetric.Location = new System.Drawing.Point(148, 102);
            this.optEnglishToMetric.Margin = new System.Windows.Forms.Padding(2);
            this.optEnglishToMetric.Name = "optEnglishToMetric";
            this.optEnglishToMetric.Size = new System.Drawing.Size(148, 24);
            this.optEnglishToMetric.TabIndex = 3;
            this.optEnglishToMetric.Text = "English To Metric";
            this.optEnglishToMetric.UseVisualStyleBackColor = true;
            this.optEnglishToMetric.CheckedChanged += new System.EventHandler(this.optEnglishToMetric_CheckedChanged);
            // 
            // optMetricToEnglish
            // 
            this.optMetricToEnglish.AutoSize = true;
            this.optMetricToEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optMetricToEnglish.Location = new System.Drawing.Point(640, 92);
            this.optMetricToEnglish.Margin = new System.Windows.Forms.Padding(2);
            this.optMetricToEnglish.Name = "optMetricToEnglish";
            this.optMetricToEnglish.Size = new System.Drawing.Size(148, 24);
            this.optMetricToEnglish.TabIndex = 4;
            this.optMetricToEnglish.Text = "Metric To English";
            this.optMetricToEnglish.UseVisualStyleBackColor = true;
            this.optMetricToEnglish.CheckedChanged += new System.EventHandler(this.optMetricToEnglish_CheckedChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(427, 435);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(2);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(101, 36);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(71, 435);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 36);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(814, 435);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(84, 36);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmEnglishToMetric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 509);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.optMetricToEnglish);
            this.Controls.Add(this.optEnglishToMetric);
            this.Controls.Add(this.grpMetricToEnglish);
            this.Controls.Add(this.grpEnglishToMetric);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEnglishToMetric";
            this.Text = "English To Metric Converter";
            this.Load += new System.EventHandler(this.frmEnglishToMetric_Load);
            this.grpEnglishToMetric.ResumeLayout(false);
            this.grpEnglishToMetric.PerformLayout();
            this.grpMetricToEnglish.ResumeLayout(false);
            this.grpMetricToEnglish.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpEnglishToMetric;
        private System.Windows.Forms.Label lblInches;
        private System.Windows.Forms.Label lblEFeet;
        private System.Windows.Forms.Label lblYards;
        private System.Windows.Forms.Label lblEMiles;
        private System.Windows.Forms.Button btnEnglishClear;
        private System.Windows.Forms.TextBox txtInches;
        private System.Windows.Forms.TextBox txtYards;
        private System.Windows.Forms.TextBox txtFeet;
        private System.Windows.Forms.TextBox txtMiles;
        private System.Windows.Forms.GroupBox grpMetricToEnglish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKilometers;
        private System.Windows.Forms.Label lblMeters;
        private System.Windows.Forms.Button btnMetricClear;
        private System.Windows.Forms.TextBox txtCentimeters;
        private System.Windows.Forms.TextBox txtKilometers;
        private System.Windows.Forms.TextBox txtMeters;
        private System.Windows.Forms.RadioButton optEnglishToMetric;
        private System.Windows.Forms.RadioButton optMetricToEnglish;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
    }
}

