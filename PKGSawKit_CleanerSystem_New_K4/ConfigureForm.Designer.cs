﻿
namespace PKGSawKit_CleanerSystem_New_K4
{
    partial class ConfigureForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigureForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtBoxBrushRotateTimeout = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxNozzleFwdBwdTimeout = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnParameterSave = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.label24 = new System.Windows.Forms.Label();
            this.txtBoxBrushFwdBwdTimeout = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMotionParameterSave = new System.Windows.Forms.Button();
            this.txtBoxBrushRotationSpeed = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.txtBoxBrushRotateTimeout);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBoxNozzleFwdBwdTimeout);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnParameterSave);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.txtBoxBrushFwdBwdTimeout);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(14, 155);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Size = new System.Drawing.Size(538, 320);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "< Timeout >";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Navy;
            this.label21.Location = new System.Drawing.Point(495, 75);
            this.label21.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(36, 21);
            this.label21.TabIndex = 50;
            this.label21.Text = "Sec";
            // 
            // txtBoxBrushRotateTimeout
            // 
            this.txtBoxBrushRotateTimeout.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxBrushRotateTimeout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBoxBrushRotateTimeout.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBrushRotateTimeout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBoxBrushRotateTimeout.Location = new System.Drawing.Point(333, 66);
            this.txtBoxBrushRotateTimeout.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBoxBrushRotateTimeout.Name = "txtBoxBrushRotateTimeout";
            this.txtBoxBrushRotateTimeout.ReadOnly = true;
            this.txtBoxBrushRotateTimeout.Size = new System.Drawing.Size(152, 30);
            this.txtBoxBrushRotateTimeout.TabIndex = 49;
            this.txtBoxBrushRotateTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxBrushRotateTimeout.Click += new System.EventHandler(this.txtBoxDoorOpenCloseTimeout_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Navy;
            this.label22.Location = new System.Drawing.Point(16, 66);
            this.label22.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(278, 25);
            this.label22.TabIndex = 48;
            this.label22.Text = "[CH1] Brush rotation time out";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(495, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 21);
            this.label1.TabIndex = 44;
            this.label1.Text = "Sec";
            // 
            // txtBoxNozzleFwdBwdTimeout
            // 
            this.txtBoxNozzleFwdBwdTimeout.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxNozzleFwdBwdTimeout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBoxNozzleFwdBwdTimeout.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNozzleFwdBwdTimeout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBoxNozzleFwdBwdTimeout.Location = new System.Drawing.Point(333, 150);
            this.txtBoxNozzleFwdBwdTimeout.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBoxNozzleFwdBwdTimeout.Name = "txtBoxNozzleFwdBwdTimeout";
            this.txtBoxNozzleFwdBwdTimeout.ReadOnly = true;
            this.txtBoxNozzleFwdBwdTimeout.Size = new System.Drawing.Size(152, 30);
            this.txtBoxNozzleFwdBwdTimeout.TabIndex = 43;
            this.txtBoxNozzleFwdBwdTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxNozzleFwdBwdTimeout.Click += new System.EventHandler(this.txtBoxDoorOpenCloseTimeout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(16, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "[CH1/2] Nozzle fwd/bwd time out";
            // 
            // btnParameterSave
            // 
            this.btnParameterSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnParameterSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParameterSave.FlatAppearance.BorderSize = 0;
            this.btnParameterSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnParameterSave.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParameterSave.ForeColor = System.Drawing.Color.Navy;
            this.btnParameterSave.ImageIndex = 0;
            this.btnParameterSave.ImageList = this.imageList;
            this.btnParameterSave.Location = new System.Drawing.Point(402, 257);
            this.btnParameterSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnParameterSave.Name = "btnParameterSave";
            this.btnParameterSave.Size = new System.Drawing.Size(126, 51);
            this.btnParameterSave.TabIndex = 41;
            this.btnParameterSave.Text = "Save";
            this.btnParameterSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnParameterSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnParameterSave.UseVisualStyleBackColor = true;
            this.btnParameterSave.Click += new System.EventHandler(this.btnParameterSave_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Save.png");
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Navy;
            this.label24.Location = new System.Drawing.Point(495, 117);
            this.label24.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(36, 21);
            this.label24.TabIndex = 33;
            this.label24.Text = "Sec";
            // 
            // txtBoxBrushFwdBwdTimeout
            // 
            this.txtBoxBrushFwdBwdTimeout.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxBrushFwdBwdTimeout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBoxBrushFwdBwdTimeout.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBrushFwdBwdTimeout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBoxBrushFwdBwdTimeout.Location = new System.Drawing.Point(333, 108);
            this.txtBoxBrushFwdBwdTimeout.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBoxBrushFwdBwdTimeout.Name = "txtBoxBrushFwdBwdTimeout";
            this.txtBoxBrushFwdBwdTimeout.ReadOnly = true;
            this.txtBoxBrushFwdBwdTimeout.Size = new System.Drawing.Size(152, 30);
            this.txtBoxBrushFwdBwdTimeout.TabIndex = 31;
            this.txtBoxBrushFwdBwdTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxBrushFwdBwdTimeout.Click += new System.EventHandler(this.txtBoxDoorOpenCloseTimeout_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.Navy;
            this.label25.Location = new System.Drawing.Point(16, 108);
            this.label25.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(286, 25);
            this.label25.TabIndex = 25;
            this.label25.Text = "[CH1] Brush fwd/bwd time out";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnMotionParameterSave);
            this.groupBox2.Controls.Add(this.txtBoxBrushRotationSpeed);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(562, 155);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox2.Size = new System.Drawing.Size(578, 320);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "< Motion parameter (Process)>";
            // 
            // btnMotionParameterSave
            // 
            this.btnMotionParameterSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMotionParameterSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMotionParameterSave.FlatAppearance.BorderSize = 0;
            this.btnMotionParameterSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMotionParameterSave.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMotionParameterSave.ForeColor = System.Drawing.Color.Navy;
            this.btnMotionParameterSave.ImageIndex = 0;
            this.btnMotionParameterSave.ImageList = this.imageList;
            this.btnMotionParameterSave.Location = new System.Drawing.Point(442, 257);
            this.btnMotionParameterSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnMotionParameterSave.Name = "btnMotionParameterSave";
            this.btnMotionParameterSave.Size = new System.Drawing.Size(126, 51);
            this.btnMotionParameterSave.TabIndex = 41;
            this.btnMotionParameterSave.Text = "Save";
            this.btnMotionParameterSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMotionParameterSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMotionParameterSave.UseVisualStyleBackColor = true;
            this.btnMotionParameterSave.Click += new System.EventHandler(this.btnMotionParameterSave_Click);
            // 
            // txtBoxBrushRotationSpeed
            // 
            this.txtBoxBrushRotationSpeed.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxBrushRotationSpeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBoxBrushRotationSpeed.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBrushRotationSpeed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBoxBrushRotationSpeed.Location = new System.Drawing.Point(333, 66);
            this.txtBoxBrushRotationSpeed.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBoxBrushRotationSpeed.Name = "txtBoxBrushRotationSpeed";
            this.txtBoxBrushRotationSpeed.ReadOnly = true;
            this.txtBoxBrushRotationSpeed.Size = new System.Drawing.Size(152, 30);
            this.txtBoxBrushRotationSpeed.TabIndex = 30;
            this.txtBoxBrushRotationSpeed.Tag = "";
            this.txtBoxBrushRotationSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxBrushRotationSpeed.Click += new System.EventHandler(this.txtBoxBrushRotationSpeed_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(26, 66);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(255, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "[CH1] Brush rotation speed";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(495, 75);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 21);
            this.label11.TabIndex = 24;
            this.label11.Text = "Unit/Sec";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(386, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 21);
            this.label3.TabIndex = 42;
            this.label3.Text = "(Max: 3000)";
            // 
            // ConfigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1172, 824);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ConfigureForm";
            this.Text = "Configure";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigureForm_FormClosing);
            this.Load += new System.EventHandler(this.ConfigureForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnParameterSave;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtBoxBrushFwdBwdTimeout;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxNozzleFwdBwdTimeout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMotionParameterSave;
        private System.Windows.Forms.TextBox txtBoxBrushRotationSpeed;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtBoxBrushRotateTimeout;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label3;
    }
}