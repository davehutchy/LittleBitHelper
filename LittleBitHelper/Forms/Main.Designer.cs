namespace LittleBitHelper
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnConvertFromHex = new System.Windows.Forms.Button();
            this.txtHexValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConvertFromDecimal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDecimalValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBinary = new System.Windows.Forms.TextBox();
            this.btnConvertFromBinary = new System.Windows.Forms.Button();
            this.btnSwapEndianness = new System.Windows.Forms.Button();
            this.btnFlipBits = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtShiftAmount = new System.Windows.Forms.TextBox();
            this.btnLeftShift = new System.Windows.Forms.Button();
            this.btnRightShift = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUnsignedByte = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSignedByte = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConvertFromHex
            // 
            this.btnConvertFromHex.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnConvertFromHex.FlatAppearance.BorderSize = 0;
            this.btnConvertFromHex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertFromHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertFromHex.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnConvertFromHex.Location = new System.Drawing.Point(94, 82);
            this.btnConvertFromHex.Name = "btnConvertFromHex";
            this.btnConvertFromHex.Size = new System.Drawing.Size(243, 103);
            this.btnConvertFromHex.TabIndex = 0;
            this.btnConvertFromHex.Text = "Convert From Hex";
            this.btnConvertFromHex.UseVisualStyleBackColor = false;
            this.btnConvertFromHex.Click += new System.EventHandler(this.btnConvertFromHex_Click);
            // 
            // txtHexValue
            // 
            this.txtHexValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHexValue.Location = new System.Drawing.Point(94, 26);
            this.txtHexValue.MaxLength = 18;
            this.txtHexValue.Name = "txtHexValue";
            this.txtHexValue.Size = new System.Drawing.Size(243, 31);
            this.txtHexValue.TabIndex = 1;
            this.txtHexValue.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hex:";
            // 
            // btnConvertFromDecimal
            // 
            this.btnConvertFromDecimal.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnConvertFromDecimal.FlatAppearance.BorderSize = 0;
            this.btnConvertFromDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertFromDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertFromDecimal.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnConvertFromDecimal.Location = new System.Drawing.Point(817, 82);
            this.btnConvertFromDecimal.Name = "btnConvertFromDecimal";
            this.btnConvertFromDecimal.Size = new System.Drawing.Size(243, 103);
            this.btnConvertFromDecimal.TabIndex = 3;
            this.btnConvertFromDecimal.Text = "Convert From Decimal";
            this.btnConvertFromDecimal.UseVisualStyleBackColor = false;
            this.btnConvertFromDecimal.Click += new System.EventHandler(this.btnConvertFromDecimal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(669, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Decimal:";
            // 
            // txtDecimalValue
            // 
            this.txtDecimalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecimalValue.Location = new System.Drawing.Point(770, 26);
            this.txtDecimalValue.MaxLength = 27;
            this.txtDecimalValue.Name = "txtDecimalValue";
            this.txtDecimalValue.Size = new System.Drawing.Size(290, 31);
            this.txtDecimalValue.TabIndex = 4;
            this.txtDecimalValue.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(9, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Binary:";
            // 
            // txtBinary
            // 
            this.txtBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBinary.Location = new System.Drawing.Point(94, 213);
            this.txtBinary.MaxLength = 80;
            this.txtBinary.Name = "txtBinary";
            this.txtBinary.Size = new System.Drawing.Size(966, 31);
            this.txtBinary.TabIndex = 9;
            this.txtBinary.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // btnConvertFromBinary
            // 
            this.btnConvertFromBinary.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnConvertFromBinary.FlatAppearance.BorderSize = 0;
            this.btnConvertFromBinary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertFromBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertFromBinary.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnConvertFromBinary.Location = new System.Drawing.Point(94, 269);
            this.btnConvertFromBinary.Name = "btnConvertFromBinary";
            this.btnConvertFromBinary.Size = new System.Drawing.Size(243, 103);
            this.btnConvertFromBinary.TabIndex = 12;
            this.btnConvertFromBinary.Text = "Convert From Binary";
            this.btnConvertFromBinary.UseVisualStyleBackColor = false;
            this.btnConvertFromBinary.Click += new System.EventHandler(this.btnConvertFromBinary_Click);
            // 
            // btnSwapEndianness
            // 
            this.btnSwapEndianness.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSwapEndianness.Enabled = false;
            this.btnSwapEndianness.FlatAppearance.BorderSize = 0;
            this.btnSwapEndianness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwapEndianness.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwapEndianness.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSwapEndianness.Location = new System.Drawing.Point(817, 269);
            this.btnSwapEndianness.Name = "btnSwapEndianness";
            this.btnSwapEndianness.Size = new System.Drawing.Size(243, 43);
            this.btnSwapEndianness.TabIndex = 13;
            this.btnSwapEndianness.Text = "Swap Endianness";
            this.btnSwapEndianness.UseVisualStyleBackColor = false;
            this.btnSwapEndianness.Click += new System.EventHandler(this.btnSwapEndianness_Click);
            // 
            // btnFlipBits
            // 
            this.btnFlipBits.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFlipBits.Enabled = false;
            this.btnFlipBits.FlatAppearance.BorderSize = 0;
            this.btnFlipBits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlipBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlipBits.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnFlipBits.Location = new System.Drawing.Point(817, 336);
            this.btnFlipBits.Name = "btnFlipBits";
            this.btnFlipBits.Size = new System.Drawing.Size(243, 43);
            this.btnFlipBits.TabIndex = 14;
            this.btnFlipBits.Text = "Flip Bits";
            this.btnFlipBits.UseVisualStyleBackColor = false;
            this.btnFlipBits.Click += new System.EventHandler(this.btnFlipBits_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnClear.Location = new System.Drawing.Point(94, 405);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(243, 43);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(54, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Value:";
            // 
            // txtShiftAmount
            // 
            this.txtShiftAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShiftAmount.Location = new System.Drawing.Point(133, 44);
            this.txtShiftAmount.MaxLength = 2;
            this.txtShiftAmount.Name = "txtShiftAmount";
            this.txtShiftAmount.Size = new System.Drawing.Size(71, 31);
            this.txtShiftAmount.TabIndex = 18;
            // 
            // btnLeftShift
            // 
            this.btnLeftShift.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLeftShift.Enabled = false;
            this.btnLeftShift.FlatAppearance.BorderSize = 0;
            this.btnLeftShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeftShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeftShift.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnLeftShift.Location = new System.Drawing.Point(40, 95);
            this.btnLeftShift.Name = "btnLeftShift";
            this.btnLeftShift.Size = new System.Drawing.Size(80, 43);
            this.btnLeftShift.TabIndex = 20;
            this.btnLeftShift.Text = "<<";
            this.btnLeftShift.UseVisualStyleBackColor = false;
            this.btnLeftShift.Click += new System.EventHandler(this.btnLeftShift_Click);
            // 
            // btnRightShift
            // 
            this.btnRightShift.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRightShift.Enabled = false;
            this.btnRightShift.FlatAppearance.BorderSize = 0;
            this.btnRightShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRightShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRightShift.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRightShift.Location = new System.Drawing.Point(124, 95);
            this.btnRightShift.Name = "btnRightShift";
            this.btnRightShift.Size = new System.Drawing.Size(80, 43);
            this.btnRightShift.TabIndex = 21;
            this.btnRightShift.Text = ">>";
            this.btnRightShift.UseVisualStyleBackColor = false;
            this.btnRightShift.Click += new System.EventHandler(this.btnRightShift_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(25, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Unsigned Value:";
            // 
            // txtUnsignedByte
            // 
            this.txtUnsignedByte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnsignedByte.Location = new System.Drawing.Point(201, 47);
            this.txtUnsignedByte.MaxLength = 3;
            this.txtUnsignedByte.Name = "txtUnsignedByte";
            this.txtUnsignedByte.Size = new System.Drawing.Size(104, 31);
            this.txtUnsignedByte.TabIndex = 22;
            this.txtUnsignedByte.TextChanged += new System.EventHandler(this.txtUnsignedByte_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(49, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Signed Value:";
            // 
            // txtSignedByte
            // 
            this.txtSignedByte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignedByte.Location = new System.Drawing.Point(201, 99);
            this.txtSignedByte.MaxLength = 4;
            this.txtSignedByte.Name = "txtSignedByte";
            this.txtSignedByte.Size = new System.Drawing.Size(104, 31);
            this.txtSignedByte.TabIndex = 25;
            this.txtSignedByte.TextChanged += new System.EventHandler(this.txtSignedByte_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUnsignedByte);
            this.groupBox1.Controls.Add(this.txtSignedByte);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(397, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 179);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Convert Byte Signedness";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtShiftAmount);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnLeftShift);
            this.groupBox2.Controls.Add(this.btnRightShift);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Location = new System.Drawing.Point(397, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 159);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bit Shift:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(898, 463);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 28);
            this.label7.TabIndex = 27;
            this.label7.Text = "Little Bit Helper";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(1041, 469);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "ver: 1.0.0";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1118, 500);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnFlipBits);
            this.Controls.Add(this.btnSwapEndianness);
            this.Controls.Add(this.btnConvertFromBinary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBinary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDecimalValue);
            this.Controls.Add(this.btnConvertFromDecimal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHexValue);
            this.Controls.Add(this.btnConvertFromHex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Little Bit Helper";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvertFromHex;
        private System.Windows.Forms.TextBox txtHexValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConvertFromDecimal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDecimalValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBinary;
        private System.Windows.Forms.Button btnConvertFromBinary;
        private System.Windows.Forms.Button btnSwapEndianness;
        private System.Windows.Forms.Button btnFlipBits;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtShiftAmount;
        private System.Windows.Forms.Button btnLeftShift;
        private System.Windows.Forms.Button btnRightShift;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUnsignedByte;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSignedByte;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

