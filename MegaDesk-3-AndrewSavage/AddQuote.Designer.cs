namespace MegaDesk_3_AndrewSavage
{
    partial class AddQuote
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.UpDownDeskWidth = new System.Windows.Forms.NumericUpDown();
            this.UpDownDeskDepth = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.UpDownDrawers = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.radioLaminate = new System.Windows.Forms.RadioButton();
            this.radioOak = new System.Windows.Forms.RadioButton();
            this.radioRosewood = new System.Windows.Forms.RadioButton();
            this.radioVeneer = new System.Windows.Forms.RadioButton();
            this.radioPine = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupShip = new System.Windows.Forms.GroupBox();
            this.groupMaterial = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownDeskWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownDeskDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownDrawers)).BeginInit();
            this.groupShip.SuspendLayout();
            this.groupMaterial.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of Customer:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Size of Desk Width:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Size of Desk Depth:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of Drawers:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Surface Material:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Shipping Speed:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(66, 445);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(243, 47);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(387, 445);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(243, 47);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // textUserName
            // 
            this.textUserName.Location = new System.Drawing.Point(242, 29);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(280, 31);
            this.textUserName.TabIndex = 1;
            // 
            // UpDownDeskWidth
            // 
            this.UpDownDeskWidth.Location = new System.Drawing.Point(242, 85);
            this.UpDownDeskWidth.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.UpDownDeskWidth.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.UpDownDeskWidth.Name = "UpDownDeskWidth";
            this.UpDownDeskWidth.Size = new System.Drawing.Size(120, 31);
            this.UpDownDeskWidth.TabIndex = 2;
            this.UpDownDeskWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // UpDownDeskDepth
            // 
            this.UpDownDeskDepth.Location = new System.Drawing.Point(668, 89);
            this.UpDownDeskDepth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.UpDownDeskDepth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.UpDownDeskDepth.Name = "UpDownDeskDepth";
            this.UpDownDeskDepth.Size = new System.Drawing.Size(120, 31);
            this.UpDownDeskDepth.TabIndex = 3;
            this.UpDownDeskDepth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(368, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "inches";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(794, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "inches";
            // 
            // UpDownDrawers
            // 
            this.UpDownDrawers.Location = new System.Drawing.Point(242, 145);
            this.UpDownDrawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.UpDownDrawers.Name = "UpDownDrawers";
            this.UpDownDrawers.Size = new System.Drawing.Size(120, 31);
            this.UpDownDrawers.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(237, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 25);
            this.label9.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(286, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 25);
            this.label10.TabIndex = 15;
            // 
            // radioLaminate
            // 
            this.radioLaminate.AutoSize = true;
            this.radioLaminate.Location = new System.Drawing.Point(10, 20);
            this.radioLaminate.Name = "radioLaminate";
            this.radioLaminate.Size = new System.Drawing.Size(131, 29);
            this.radioLaminate.TabIndex = 5;
            this.radioLaminate.TabStop = true;
            this.radioLaminate.Text = "Laminate";
            this.radioLaminate.UseVisualStyleBackColor = true;
            // 
            // radioOak
            // 
            this.radioOak.AutoSize = true;
            this.radioOak.Location = new System.Drawing.Point(10, 64);
            this.radioOak.Name = "radioOak";
            this.radioOak.Size = new System.Drawing.Size(82, 29);
            this.radioOak.TabIndex = 6;
            this.radioOak.TabStop = true;
            this.radioOak.Text = "Oak";
            this.radioOak.UseVisualStyleBackColor = true;
            this.radioOak.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioRosewood
            // 
            this.radioRosewood.AutoSize = true;
            this.radioRosewood.Location = new System.Drawing.Point(184, 20);
            this.radioRosewood.Name = "radioRosewood";
            this.radioRosewood.Size = new System.Drawing.Size(144, 29);
            this.radioRosewood.TabIndex = 7;
            this.radioRosewood.TabStop = true;
            this.radioRosewood.Text = "Rosewood";
            this.radioRosewood.UseVisualStyleBackColor = true;
            // 
            // radioVeneer
            // 
            this.radioVeneer.AutoSize = true;
            this.radioVeneer.Location = new System.Drawing.Point(184, 64);
            this.radioVeneer.Name = "radioVeneer";
            this.radioVeneer.Size = new System.Drawing.Size(112, 29);
            this.radioVeneer.TabIndex = 8;
            this.radioVeneer.TabStop = true;
            this.radioVeneer.Text = "Veneer";
            this.radioVeneer.UseVisualStyleBackColor = true;
            // 
            // radioPine
            // 
            this.radioPine.AutoSize = true;
            this.radioPine.Location = new System.Drawing.Point(359, 20);
            this.radioPine.Name = "radioPine";
            this.radioPine.Size = new System.Drawing.Size(86, 29);
            this.radioPine.TabIndex = 9;
            this.radioPine.TabStop = true;
            this.radioPine.Text = "Pine";
            this.radioPine.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(10, 23);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 29);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "3 Days";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(184, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 29);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "5 Days";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(359, 23);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(110, 29);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "7 Days";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupShip
            // 
            this.groupShip.Controls.Add(this.radioButton2);
            this.groupShip.Controls.Add(this.radioButton3);
            this.groupShip.Controls.Add(this.radioButton1);
            this.groupShip.Location = new System.Drawing.Point(149, 366);
            this.groupShip.Name = "groupShip";
            this.groupShip.Size = new System.Drawing.Size(492, 58);
            this.groupShip.TabIndex = 16;
            this.groupShip.TabStop = false;
            // 
            // groupMaterial
            // 
            this.groupMaterial.Controls.Add(this.radioLaminate);
            this.groupMaterial.Controls.Add(this.radioOak);
            this.groupMaterial.Controls.Add(this.radioPine);
            this.groupMaterial.Controls.Add(this.radioRosewood);
            this.groupMaterial.Controls.Add(this.radioVeneer);
            this.groupMaterial.Location = new System.Drawing.Point(149, 233);
            this.groupMaterial.Name = "groupMaterial";
            this.groupMaterial.Size = new System.Drawing.Size(492, 93);
            this.groupMaterial.TabIndex = 17;
            this.groupMaterial.TabStop = false;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 546);
            this.Controls.Add(this.groupMaterial);
            this.Controls.Add(this.groupShip);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.UpDownDrawers);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UpDownDeskDepth);
            this.Controls.Add(this.UpDownDeskWidth);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UpDownDeskWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownDeskDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownDrawers)).EndInit();
            this.groupShip.ResumeLayout(false);
            this.groupShip.PerformLayout();
            this.groupMaterial.ResumeLayout(false);
            this.groupMaterial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.NumericUpDown UpDownDeskWidth;
        private System.Windows.Forms.NumericUpDown UpDownDeskDepth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown UpDownDrawers;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioLaminate;
        private System.Windows.Forms.RadioButton radioOak;
        private System.Windows.Forms.RadioButton radioRosewood;
        private System.Windows.Forms.RadioButton radioVeneer;
        private System.Windows.Forms.RadioButton radioPine;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupShip;
        private System.Windows.Forms.GroupBox groupMaterial;
    }
}