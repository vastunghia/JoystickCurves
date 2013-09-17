﻿namespace JoystickCurves
{
    partial class AxisEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            JoystickCurves.BezierCurvePoints bezierCurvePoints2 = new JoystickCurves.BezierCurvePoints();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AxisEditor));
            this.comboSourceAxis = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboSourceDevice = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboDestDevice = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboDestAxis = new System.Windows.Forms.ComboBox();
            this.groupBoxCurve = new System.Windows.Forms.GroupBox();
            this.curveResponse = new JoystickCurves.BezierCurve();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxCurve.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboSourceAxis
            // 
            this.comboSourceAxis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSourceAxis.FormattingEnabled = true;
            this.comboSourceAxis.Location = new System.Drawing.Point(56, 41);
            this.comboSourceAxis.Name = "comboSourceAxis";
            this.comboSourceAxis.Size = new System.Drawing.Size(221, 21);
            this.comboSourceAxis.TabIndex = 1;
            this.comboSourceAxis.SelectionChangeCommitted += new System.EventHandler(this.Change);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Axis:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboSourceDevice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboSourceAxis);
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 88);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source (Physical device)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Device:";
            // 
            // comboSourceDevice
            // 
            this.comboSourceDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSourceDevice.FormattingEnabled = true;
            this.comboSourceDevice.Location = new System.Drawing.Point(56, 15);
            this.comboSourceDevice.Name = "comboSourceDevice";
            this.comboSourceDevice.Size = new System.Drawing.Size(221, 21);
            this.comboSourceDevice.TabIndex = 3;
            this.comboSourceDevice.SelectionChangeCommitted += new System.EventHandler(this.Change);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboDestDevice);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboDestAxis);
            this.groupBox2.Location = new System.Drawing.Point(294, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 88);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destination (Virtual joystick)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Device:";
            // 
            // comboDestDevice
            // 
            this.comboDestDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDestDevice.FormattingEnabled = true;
            this.comboDestDevice.Location = new System.Drawing.Point(75, 15);
            this.comboDestDevice.Name = "comboDestDevice";
            this.comboDestDevice.Size = new System.Drawing.Size(219, 21);
            this.comboDestDevice.TabIndex = 7;
            this.comboDestDevice.SelectionChangeCommitted += new System.EventHandler(this.Change);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Axis:";
            // 
            // comboDestAxis
            // 
            this.comboDestAxis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDestAxis.FormattingEnabled = true;
            this.comboDestAxis.Location = new System.Drawing.Point(75, 41);
            this.comboDestAxis.Name = "comboDestAxis";
            this.comboDestAxis.Size = new System.Drawing.Size(219, 21);
            this.comboDestAxis.TabIndex = 5;
            this.comboDestAxis.SelectionChangeCommitted += new System.EventHandler(this.Change);
            // 
            // groupBoxCurve
            // 
            this.groupBoxCurve.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCurve.Controls.Add(this.curveResponse);
            this.groupBoxCurve.Location = new System.Drawing.Point(5, 92);
            this.groupBoxCurve.Name = "groupBoxCurve";
            this.groupBoxCurve.Size = new System.Drawing.Size(589, 307);
            this.groupBoxCurve.TabIndex = 6;
            this.groupBoxCurve.TabStop = false;
            this.groupBoxCurve.Text = "Response Curve";
            // 
            // curveResponse
            // 
            this.curveResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.curveResponse.BackColor = System.Drawing.Color.White;
            this.curveResponse.HorizontalLines = 5;
            this.curveResponse.Location = new System.Drawing.Point(6, 19);
            this.curveResponse.Name = "curveResponse";
            this.curveResponse.Padding = new System.Windows.Forms.Padding(10);
            bezierCurvePoints2.DrawHeight = 262;
            bezierCurvePoints2.DrawPoints = ((System.Collections.Generic.List<System.Drawing.Point>)(resources.GetObject("bezierCurvePoints2.DrawPoints")));
            bezierCurvePoints2.DrawWidth = 557;
            bezierCurvePoints2.PointsCount = 13;
            bezierCurvePoints2.RawPoints = ((System.Collections.Generic.List<System.Drawing.PointF>)(resources.GetObject("bezierCurvePoints2.RawPoints")));
            this.curveResponse.Points = bezierCurvePoints2;
            this.curveResponse.PointsCount = 13;
            this.curveResponse.Size = new System.Drawing.Size(577, 282);
            this.curveResponse.TabIndex = 1;
            this.curveResponse.OnCurveChange += new System.EventHandler<System.EventArgs>(this.curveResponse_OnCurveChange);
            // 
            // AxisEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxCurve);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AxisEditor";
            this.Size = new System.Drawing.Size(597, 406);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxCurve.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboSourceAxis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboSourceDevice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboDestDevice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboDestAxis;
        private System.Windows.Forms.GroupBox groupBoxCurve;
        private JoystickCurves.BezierCurve curveResponse;
    }
}
