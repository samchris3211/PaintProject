namespace PaintProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CalculatePaintTotal = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            FloorLength = new TextBox();
            FloorWidth = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbFloorArea = new TextBox();
            label6 = new Label();
            label8 = new Label();
            Wall1Length = new TextBox();
            label10 = new Label();
            WallWidth1 = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            WallLength2 = new TextBox();
            label14 = new Label();
            WallWidth2 = new TextBox();
            label15 = new Label();
            label16 = new Label();
            WallLength3 = new TextBox();
            label17 = new Label();
            WallWidth3 = new TextBox();
            label18 = new Label();
            label19 = new Label();
            WallLength4 = new TextBox();
            label20 = new Label();
            WallWidth4 = new TextBox();
            tbCalculatedPaint = new TextBox();
            button1 = new Button();
            tbCalculateVolume = new TextBox();
            label21 = new Label();
            button2 = new Button();
            label22 = new Label();
            label23 = new Label();
            SuspendLayout();
            // 
            // CalculatePaintTotal
            // 
            CalculatePaintTotal.Location = new Point(8, 507);
            CalculatePaintTotal.Name = "CalculatePaintTotal";
            CalculatePaintTotal.Size = new Size(200, 39);
            CalculatePaintTotal.TabIndex = 2;
            CalculatePaintTotal.Text = "Calculate Paint total";
            CalculatePaintTotal.UseVisualStyleBackColor = true;
            CalculatePaintTotal.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 9);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 3;
            label1.Text = "Floor";
            label1.Click += label1_Click;
            // 
            // FloorLength
            // 
            FloorLength.Location = new Point(94, 36);
            FloorLength.Name = "FloorLength";
            FloorLength.Size = new Size(125, 27);
            FloorLength.TabIndex = 4;
            FloorLength.TextChanged += textBox1_TextChanged;
            // 
            // FloorWidth
            // 
            FloorWidth.Location = new Point(298, 36);
            FloorWidth.Name = "FloorWidth";
            FloorWidth.Size = new Size(125, 27);
            FloorWidth.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 36);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 6;
            label2.Text = "Length(m)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 39);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 7;
            label3.Text = "Width(m)";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 75);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 9;
            label4.Text = "Floor Area";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(261, 75);
            label5.Name = "label5";
            label5.Size = new Size(30, 20);
            label5.TabIndex = 10;
            label5.Text = "m2";
            label5.Click += label5_Click;
            // 
            // tbFloorArea
            // 
            tbFloorArea.Location = new Point(130, 72);
            tbFloorArea.Name = "tbFloorArea";
            tbFloorArea.Size = new Size(125, 27);
            tbFloorArea.TabIndex = 11;
            tbFloorArea.TextChanged += FloorArea_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 158);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 12;
            label6.Text = "Room";
            label6.Click += label6_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 221);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 18;
            label8.Text = "Length(m)";
            // 
            // Wall1Length
            // 
            Wall1Length.Location = new Point(91, 218);
            Wall1Length.Name = "Wall1Length";
            Wall1Length.Size = new Size(125, 27);
            Wall1Length.TabIndex = 19;
            Wall1Length.TextChanged += Wall1Length_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(225, 221);
            label10.Name = "label10";
            label10.Size = new Size(72, 20);
            label10.TabIndex = 20;
            label10.Text = "Width(m)";
            // 
            // WallWidth1
            // 
            WallWidth1.Location = new Point(298, 218);
            WallWidth1.Name = "WallWidth1";
            WallWidth1.Size = new Size(125, 27);
            WallWidth1.TabIndex = 21;
            WallWidth1.TextChanged += WallWidth1_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(11, 201);
            label11.Name = "label11";
            label11.Size = new Size(46, 20);
            label11.TabIndex = 22;
            label11.Text = "Wall1";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(11, 260);
            label12.Name = "label12";
            label12.Size = new Size(46, 20);
            label12.TabIndex = 23;
            label12.Text = "Wall2";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(8, 280);
            label13.Name = "label13";
            label13.Size = new Size(77, 20);
            label13.TabIndex = 24;
            label13.Text = "Length(m)";
            // 
            // WallLength2
            // 
            WallLength2.Location = new Point(83, 277);
            WallLength2.Name = "WallLength2";
            WallLength2.Size = new Size(125, 27);
            WallLength2.TabIndex = 25;
            WallLength2.TextChanged += textBox4_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(225, 280);
            label14.Name = "label14";
            label14.Size = new Size(72, 20);
            label14.TabIndex = 26;
            label14.Text = "Width(m)";
            // 
            // WallWidth2
            // 
            WallWidth2.Location = new Point(298, 277);
            WallWidth2.Name = "WallWidth2";
            WallWidth2.Size = new Size(125, 27);
            WallWidth2.TabIndex = 27;
            WallWidth2.TextChanged += textBox5_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(15, 323);
            label15.Name = "label15";
            label15.Size = new Size(46, 20);
            label15.TabIndex = 28;
            label15.Text = "Wall3";
            label15.Click += label15_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(11, 343);
            label16.Name = "label16";
            label16.Size = new Size(77, 20);
            label16.TabIndex = 29;
            label16.Text = "Length(m)";
            // 
            // WallLength3
            // 
            WallLength3.Location = new Point(83, 340);
            WallLength3.Name = "WallLength3";
            WallLength3.Size = new Size(125, 27);
            WallLength3.TabIndex = 30;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(225, 347);
            label17.Name = "label17";
            label17.Size = new Size(72, 20);
            label17.TabIndex = 31;
            label17.Text = "Width(m)";
            // 
            // WallWidth3
            // 
            WallWidth3.Location = new Point(298, 343);
            WallWidth3.Name = "WallWidth3";
            WallWidth3.Size = new Size(125, 27);
            WallWidth3.TabIndex = 32;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(14, 380);
            label18.Name = "label18";
            label18.Size = new Size(46, 20);
            label18.TabIndex = 33;
            label18.Text = "Wall4";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(8, 400);
            label19.Name = "label19";
            label19.Size = new Size(77, 20);
            label19.TabIndex = 34;
            label19.Text = "Length(m)";
            // 
            // WallLength4
            // 
            WallLength4.Location = new Point(83, 393);
            WallLength4.Name = "WallLength4";
            WallLength4.Size = new Size(125, 27);
            WallLength4.TabIndex = 35;
            WallLength4.TextChanged += textBox8_TextChanged;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(225, 396);
            label20.Name = "label20";
            label20.Size = new Size(72, 20);
            label20.TabIndex = 36;
            label20.Text = "Width(m)";
            // 
            // WallWidth4
            // 
            WallWidth4.Location = new Point(298, 396);
            WallWidth4.Name = "WallWidth4";
            WallWidth4.Size = new Size(125, 27);
            WallWidth4.TabIndex = 37;
            // 
            // tbCalculatedPaint
            // 
            tbCalculatedPaint.Location = new Point(225, 513);
            tbCalculatedPaint.Name = "tbCalculatedPaint";
            tbCalculatedPaint.Size = new Size(162, 27);
            tbCalculatedPaint.TabIndex = 38;
            tbCalculatedPaint.TextChanged += tbCalculatedPaint_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(8, 567);
            button1.Name = "button1";
            button1.Size = new Size(200, 35);
            button1.TabIndex = 40;
            button1.Text = "Calculate Volume";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // tbCalculateVolume
            // 
            tbCalculateVolume.Location = new Point(225, 571);
            tbCalculateVolume.Name = "tbCalculateVolume";
            tbCalculateVolume.Size = new Size(162, 27);
            tbCalculateVolume.TabIndex = 41;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(393, 578);
            label21.Name = "label21";
            label21.Size = new Size(30, 20);
            label21.TabIndex = 42;
            label21.Text = "m3";
            // 
            // button2
            // 
            button2.Location = new Point(476, 32);
            button2.Name = "button2";
            button2.Size = new Size(193, 34);
            button2.TabIndex = 43;
            button2.Text = "Calculate Floor Area";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(18, 463);
            label22.Name = "label22";
            label22.Size = new Size(106, 20);
            label22.TabIndex = 44;
            label22.Text = "Layers of paint";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(395, 519);
            label23.Name = "label23";
            label23.Size = new Size(30, 20);
            label23.TabIndex = 45;
            label23.Text = "m2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 636);
            Controls.Add(label23);
            Controls.Add(label22);
            Controls.Add(button2);
            Controls.Add(label21);
            Controls.Add(tbCalculateVolume);
            Controls.Add(button1);
            Controls.Add(tbCalculatedPaint);
            Controls.Add(WallWidth4);
            Controls.Add(label20);
            Controls.Add(WallLength4);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(WallWidth3);
            Controls.Add(label17);
            Controls.Add(WallLength3);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(WallWidth2);
            Controls.Add(label14);
            Controls.Add(WallLength2);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(WallWidth1);
            Controls.Add(label10);
            Controls.Add(Wall1Length);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(tbFloorArea);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(FloorWidth);
            Controls.Add(FloorLength);
            Controls.Add(label1);
            Controls.Add(CalculatePaintTotal);
            Name = "Form1";
            Text = "PaintCalculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button CalculatePaintTotal;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private TextBox FloorLength;
        private TextBox FloorWidth;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbFloorArea;
        private Label label6;
        private Label label8;
        private TextBox Wall1Length;
        private Label label10;
        private TextBox WallWidth1;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox WallLength2;
        private Label label14;
        private TextBox WallWidth2;
        private Label label15;
        private Label label16;
        private TextBox WallLength3;
        private Label label17;
        private TextBox WallWidth3;
        private Label label18;
        private Label label19;
        private TextBox WallLength4;
        private Label label20;
        private TextBox WallWidth4;
        private TextBox tbCalculatedPaint;
        private Button button1;
        private TextBox tbCalculateVolume;
        private Label label21;
        private Button button2;
        private Label label22;
        private Label label23;
    }
}
