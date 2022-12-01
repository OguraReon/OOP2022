
namespace Sample0610 {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.NumericUpDown();
            this.buttom_judge = new System.Windows.Forms.Button();
            this.text_reslut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Number2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Number2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ＭＳ ゴシック", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(240, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "の中で好きな数字を入力";
            // 
            // Number
            // 
            this.Number.Font = new System.Drawing.Font("ＭＳ ゴシック", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Number.Location = new System.Drawing.Point(53, 142);
            this.Number.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(120, 55);
            this.Number.TabIndex = 1;
            // 
            // buttom_judge
            // 
            this.buttom_judge.Font = new System.Drawing.Font("ＭＳ ゴシック", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttom_judge.Location = new System.Drawing.Point(267, 131);
            this.buttom_judge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttom_judge.Name = "buttom_judge";
            this.buttom_judge.Size = new System.Drawing.Size(144, 66);
            this.buttom_judge.TabIndex = 2;
            this.buttom_judge.Text = "判定";
            this.buttom_judge.UseVisualStyleBackColor = true;
            this.buttom_judge.Click += new System.EventHandler(this.buttom_judge_Click);
            // 
            // text_reslut
            // 
            this.text_reslut.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.text_reslut.Location = new System.Drawing.Point(39, 229);
            this.text_reslut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_reslut.Name = "text_reslut";
            this.text_reslut.Size = new System.Drawing.Size(372, 55);
            this.text_reslut.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ＭＳ ゴシック", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(2, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 48);
            this.label2.TabIndex = 0;
            this.label2.Text = "1から";
            // 
            // Number2
            // 
            this.Number2.Font = new System.Drawing.Font("ＭＳ ゴシック", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Number2.Location = new System.Drawing.Point(131, 47);
            this.Number2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(120, 44);
            this.Number2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 362);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.text_reslut);
            this.Controls.Add(this.buttom_judge);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Number2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Number;
        private System.Windows.Forms.Button buttom_judge;
        private System.Windows.Forms.TextBox text_reslut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Number2;
    }
}

