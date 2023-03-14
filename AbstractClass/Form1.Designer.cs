namespace AbstractClass
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
            this.btnCar = new System.Windows.Forms.Button();
            this.btnBycicle = new System.Windows.Forms.Button();
            this.btnBoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCar
            // 
            this.btnCar.Location = new System.Drawing.Point(194, 57);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(95, 44);
            this.btnCar.TabIndex = 0;
            this.btnCar.Text = "Car";
            this.btnCar.UseVisualStyleBackColor = true;
            this.btnCar.Click += new System.EventHandler(this.btnCar_Click);
            // 
            // btnBycicle
            // 
            this.btnBycicle.Location = new System.Drawing.Point(194, 163);
            this.btnBycicle.Name = "btnBycicle";
            this.btnBycicle.Size = new System.Drawing.Size(95, 44);
            this.btnBycicle.TabIndex = 1;
            this.btnBycicle.Text = "Bycicle";
            this.btnBycicle.UseVisualStyleBackColor = true;
            this.btnBycicle.Click += new System.EventHandler(this.btnBycicle_Click);
            // 
            // btnBoat
            // 
            this.btnBoat.Location = new System.Drawing.Point(194, 266);
            this.btnBoat.Name = "btnBoat";
            this.btnBoat.Size = new System.Drawing.Size(95, 44);
            this.btnBoat.TabIndex = 2;
            this.btnBoat.Text = "Boat";
            this.btnBoat.UseVisualStyleBackColor = true;
            this.btnBoat.Click += new System.EventHandler(this.btnBoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 393);
            this.Controls.Add(this.btnBoat);
            this.Controls.Add(this.btnBycicle);
            this.Controls.Add(this.btnCar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCar;
        private System.Windows.Forms.Button btnBycicle;
        private System.Windows.Forms.Button btnBoat;
    }
}

