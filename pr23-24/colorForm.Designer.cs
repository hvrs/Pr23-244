namespace pr23_24
{
    partial class colorForm
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
            this.picResultColor = new System.Windows.Forms.PictureBox();
            this.scrol_red = new System.Windows.Forms.HScrollBar();
            this.scroll_green = new System.Windows.Forms.HScrollBar();
            this.scroll_blue = new System.Windows.Forms.HScrollBar();
            this.btn_OtherColors = new System.Windows.Forms.Button();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lb_red = new System.Windows.Forms.Label();
            this.lb_green = new System.Windows.Forms.Label();
            this.lb_blue = new System.Windows.Forms.Label();
            this.numeric_red = new System.Windows.Forms.NumericUpDown();
            this.numeric_green = new System.Windows.Forms.NumericUpDown();
            this.numeric_blue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.picResultColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_blue)).BeginInit();
            this.SuspendLayout();
            // 
            // picResultColor
            // 
            this.picResultColor.Location = new System.Drawing.Point(460, 12);
            this.picResultColor.Name = "picResultColor";
            this.picResultColor.Size = new System.Drawing.Size(173, 112);
            this.picResultColor.TabIndex = 0;
            this.picResultColor.TabStop = false;
            // 
            // scrol_red
            // 
            this.scrol_red.LargeChange = 1;
            this.scrol_red.Location = new System.Drawing.Point(88, 24);
            this.scrol_red.Maximum = 255;
            this.scrol_red.Name = "scrol_red";
            this.scrol_red.Size = new System.Drawing.Size(273, 23);
            this.scrol_red.TabIndex = 1;
            this.scrol_red.ValueChanged += new System.EventHandler(this.scrol_red_ValueChanged);
            // 
            // scroll_green
            // 
            this.scroll_green.LargeChange = 1;
            this.scroll_green.Location = new System.Drawing.Point(88, 62);
            this.scroll_green.Maximum = 255;
            this.scroll_green.Name = "scroll_green";
            this.scroll_green.Size = new System.Drawing.Size(273, 23);
            this.scroll_green.TabIndex = 2;
            this.scroll_green.ValueChanged += new System.EventHandler(this.scroll_green_ValueChanged);
            // 
            // scroll_blue
            // 
            this.scroll_blue.LargeChange = 1;
            this.scroll_blue.Location = new System.Drawing.Point(88, 100);
            this.scroll_blue.Maximum = 255;
            this.scroll_blue.Name = "scroll_blue";
            this.scroll_blue.Size = new System.Drawing.Size(273, 23);
            this.scroll_blue.TabIndex = 3;
            this.scroll_blue.ValueChanged += new System.EventHandler(this.scroll_blue_ValueChanged);
            // 
            // btn_OtherColors
            // 
            this.btn_OtherColors.Location = new System.Drawing.Point(481, 166);
            this.btn_OtherColors.Name = "btn_OtherColors";
            this.btn_OtherColors.Size = new System.Drawing.Size(89, 23);
            this.btn_OtherColors.TabIndex = 4;
            this.btn_OtherColors.Text = "Other Colors";
            this.btn_OtherColors.UseVisualStyleBackColor = true;
            this.btn_OtherColors.Click += new System.EventHandler(this.btn_OtherColors_Click);
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(38, 166);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(89, 23);
            this.btn_Ok.TabIndex = 5;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(145, 166);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(89, 23);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lb_red
            // 
            this.lb_red.AutoSize = true;
            this.lb_red.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_red.Location = new System.Drawing.Point(12, 31);
            this.lb_red.Name = "lb_red";
            this.lb_red.Size = new System.Drawing.Size(33, 16);
            this.lb_red.TabIndex = 7;
            this.lb_red.Text = "Red";
            // 
            // lb_green
            // 
            this.lb_green.AutoSize = true;
            this.lb_green.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_green.Location = new System.Drawing.Point(12, 70);
            this.lb_green.Name = "lb_green";
            this.lb_green.Size = new System.Drawing.Size(44, 16);
            this.lb_green.TabIndex = 8;
            this.lb_green.Text = "Green";
            // 
            // lb_blue
            // 
            this.lb_blue.AutoSize = true;
            this.lb_blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_blue.Location = new System.Drawing.Point(12, 108);
            this.lb_blue.Name = "lb_blue";
            this.lb_blue.Size = new System.Drawing.Size(34, 16);
            this.lb_blue.TabIndex = 9;
            this.lb_blue.Text = "Blue";
            // 
            // numeric_red
            // 
            this.numeric_red.Location = new System.Drawing.Point(384, 27);
            this.numeric_red.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numeric_red.Name = "numeric_red";
            this.numeric_red.Size = new System.Drawing.Size(57, 20);
            this.numeric_red.TabIndex = 10;
            this.numeric_red.ValueChanged += new System.EventHandler(this.numeric_red_ValueChanged);
            // 
            // numeric_green
            // 
            this.numeric_green.Location = new System.Drawing.Point(384, 66);
            this.numeric_green.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numeric_green.Name = "numeric_green";
            this.numeric_green.Size = new System.Drawing.Size(57, 20);
            this.numeric_green.TabIndex = 11;
            this.numeric_green.ValueChanged += new System.EventHandler(this.numeric_green_ValueChanged);
            // 
            // numeric_blue
            // 
            this.numeric_blue.Location = new System.Drawing.Point(384, 104);
            this.numeric_blue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numeric_blue.Name = "numeric_blue";
            this.numeric_blue.Size = new System.Drawing.Size(57, 20);
            this.numeric_blue.TabIndex = 12;
            this.numeric_blue.ValueChanged += new System.EventHandler(this.numeric_blue_ValueChanged);
            // 
            // colorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 201);
            this.Controls.Add(this.numeric_blue);
            this.Controls.Add(this.numeric_green);
            this.Controls.Add(this.numeric_red);
            this.Controls.Add(this.lb_blue);
            this.Controls.Add(this.lb_green);
            this.Controls.Add(this.lb_red);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.btn_OtherColors);
            this.Controls.Add(this.scroll_blue);
            this.Controls.Add(this.scroll_green);
            this.Controls.Add(this.scrol_red);
            this.Controls.Add(this.picResultColor);
            this.Name = "colorForm";
            this.Text = "colorForm";
            this.Load += new System.EventHandler(this.colorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picResultColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_blue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picResultColor;
        private System.Windows.Forms.HScrollBar scrol_red;
        private System.Windows.Forms.HScrollBar scroll_green;
        private System.Windows.Forms.HScrollBar scroll_blue;
        private System.Windows.Forms.Button btn_OtherColors;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lb_red;
        private System.Windows.Forms.Label lb_green;
        private System.Windows.Forms.Label lb_blue;
        private System.Windows.Forms.NumericUpDown numeric_red;
        private System.Windows.Forms.NumericUpDown numeric_green;
        private System.Windows.Forms.NumericUpDown numeric_blue;
    }
}