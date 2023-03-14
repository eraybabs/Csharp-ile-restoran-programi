
namespace ksasnav
{
    partial class Form3
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
            this.İ = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.artirbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.azaltbtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.icecektxt = new System.Windows.Forms.NumericUpDown();
            this.malzemetxt = new System.Windows.Forms.NumericUpDown();
            this.yiyecektxt = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.icecektxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.malzemetxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yiyecektxt)).BeginInit();
            this.SuspendLayout();
            // 
            // İ
            // 
            this.İ.AutoSize = true;
            this.İ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.İ.Location = new System.Drawing.Point(77, 68);
            this.İ.Name = "İ";
            this.İ.Size = new System.Drawing.Size(131, 25);
            this.İ.TabIndex = 2;
            this.İ.Text = "İçecek Miktarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(77, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yiyecek Miktarı";
            // 
            // artirbtn
            // 
            this.artirbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.artirbtn.Location = new System.Drawing.Point(124, 228);
            this.artirbtn.Name = "artirbtn";
            this.artirbtn.Size = new System.Drawing.Size(100, 47);
            this.artirbtn.TabIndex = 4;
            this.artirbtn.Text = "Ekle";
            this.artirbtn.UseVisualStyleBackColor = true;
            this.artirbtn.Click += new System.EventHandler(this.artirbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(77, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Temizlik Malzemeleri";
            // 
            // azaltbtn
            // 
            this.azaltbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.azaltbtn.Location = new System.Drawing.Point(337, 228);
            this.azaltbtn.Name = "azaltbtn";
            this.azaltbtn.Size = new System.Drawing.Size(100, 47);
            this.azaltbtn.TabIndex = 9;
            this.azaltbtn.Text = "Azalt";
            this.azaltbtn.UseVisualStyleBackColor = true;
            this.azaltbtn.Click += new System.EventHandler(this.azaltbtn_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(36, 319);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(547, 129);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // icecektxt
            // 
            this.icecektxt.Location = new System.Drawing.Point(290, 71);
            this.icecektxt.Name = "icecektxt";
            this.icecektxt.Size = new System.Drawing.Size(120, 22);
            this.icecektxt.TabIndex = 14;
            // 
            // malzemetxt
            // 
            this.malzemetxt.Location = new System.Drawing.Point(290, 174);
            this.malzemetxt.Name = "malzemetxt";
            this.malzemetxt.Size = new System.Drawing.Size(120, 22);
            this.malzemetxt.TabIndex = 15;
            // 
            // yiyecektxt
            // 
            this.yiyecektxt.Location = new System.Drawing.Point(290, 121);
            this.yiyecektxt.Name = "yiyecektxt";
            this.yiyecektxt.Size = new System.Drawing.Size(120, 22);
            this.yiyecektxt.TabIndex = 16;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 481);
            this.Controls.Add(this.yiyecektxt);
            this.Controls.Add(this.malzemetxt);
            this.Controls.Add(this.icecektxt);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.azaltbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.artirbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.İ);
            this.Name = "Form3";
            this.Text = "Stok Bilgileri";
            this.Load += new System.EventHandler(this.Form3_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.icecektxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.malzemetxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yiyecektxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label İ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button artirbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button azaltbtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.NumericUpDown icecektxt;
        private System.Windows.Forms.NumericUpDown malzemetxt;
        private System.Windows.Forms.NumericUpDown yiyecektxt;
    }
}