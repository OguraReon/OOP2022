
namespace WeatherApp {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.himawariLabel = new System.Windows.Forms.Label();
            this.picWetherMap = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picWetherMap)).BeginInit();
            this.SuspendLayout();
            // 
            // himawariLabel
            // 
            this.himawariLabel.AutoSize = true;
            this.himawariLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.himawariLabel.Location = new System.Drawing.Point(12, 19);
            this.himawariLabel.Name = "himawariLabel";
            this.himawariLabel.Size = new System.Drawing.Size(173, 37);
            this.himawariLabel.TabIndex = 0;
            this.himawariLabel.Text = "ひまわり";
            // 
            // picWetherMap
            // 
            this.picWetherMap.Location = new System.Drawing.Point(19, 59);
            this.picWetherMap.Name = "picWetherMap";
            this.picWetherMap.Size = new System.Drawing.Size(899, 605);
            this.picWetherMap.TabIndex = 1;
            this.picWetherMap.TabStop = false;
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(811, 16);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(97, 37);
            this.close.TabIndex = 2;
            this.close.Text = "閉じる";
            this.close.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 693);
            this.Controls.Add(this.close);
            this.Controls.Add(this.picWetherMap);
            this.Controls.Add(this.himawariLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.picWetherMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label himawariLabel;
        private System.Windows.Forms.PictureBox picWetherMap;
        private System.Windows.Forms.Button close;
    }
}