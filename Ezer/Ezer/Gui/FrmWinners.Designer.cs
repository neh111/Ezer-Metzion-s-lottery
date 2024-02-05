namespace Ezer.Gui
{
    partial class FrmWinners
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
            this.lblProduct_code = new System.Windows.Forms.Label();
            this.lblId_donor = new System.Windows.Forms.Label();
            this.lblSerial = new System.Windows.Forms.Label();
            this.txtProduct_code = new System.Windows.Forms.TextBox();
            this.txtId_donor = new System.Windows.Forms.TextBox();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.dgSearchAllWinners = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBefore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearchAllWinners)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(696, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "זוכים";
            // 
            // lblProduct_code
            // 
            this.lblProduct_code.AutoSize = true;
            this.lblProduct_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblProduct_code.Location = new System.Drawing.Point(1281, 143);
            this.lblProduct_code.Name = "lblProduct_code";
            this.lblProduct_code.Size = new System.Drawing.Size(77, 20);
            this.lblProduct_code.TabIndex = 1;
            this.lblProduct_code.Text = "קוד מוצר";
            // 
            // lblId_donor
            // 
            this.lblId_donor.AutoSize = true;
            this.lblId_donor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblId_donor.Location = new System.Drawing.Point(1224, 214);
            this.lblId_donor.Name = "lblId_donor";
            this.lblId_donor.Size = new System.Drawing.Size(134, 20);
            this.lblId_donor.TabIndex = 2;
            this.lblId_donor.Text = "תעודת זהות זוכה";
            this.lblId_donor.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblSerial
            // 
            this.lblSerial.AutoSize = true;
            this.lblSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSerial.Location = new System.Drawing.Point(1256, 283);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(102, 20);
            this.lblSerial.TabIndex = 3;
            this.lblSerial.Text = "מספר סידורי";
            // 
            // txtProduct_code
            // 
            this.txtProduct_code.Location = new System.Drawing.Point(1162, 143);
            this.txtProduct_code.Name = "txtProduct_code";
            this.txtProduct_code.Size = new System.Drawing.Size(100, 20);
            this.txtProduct_code.TabIndex = 4;
            // 
            // txtId_donor
            // 
            this.txtId_donor.Location = new System.Drawing.Point(1106, 214);
            this.txtId_donor.Name = "txtId_donor";
            this.txtId_donor.Size = new System.Drawing.Size(100, 20);
            this.txtId_donor.TabIndex = 5;
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(1133, 283);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(100, 20);
            this.txtSerial.TabIndex = 6;
            // 
            // dgSearchAllWinners
            // 
            this.dgSearchAllWinners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSearchAllWinners.Location = new System.Drawing.Point(744, 328);
            this.dgSearchAllWinners.Name = "dgSearchAllWinners";
            this.dgSearchAllWinners.Size = new System.Drawing.Size(451, 239);
            this.dgSearchAllWinners.TabIndex = 11;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1228, 337);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 46);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "הצג את כל הזוכים";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(1228, 402);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 47);
            this.btnShow.TabIndex = 13;
            this.btnShow.Text = "הצג זוכה זה";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1228, 476);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 50);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "הזוכה הבא";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBefore
            // 
            this.btnBefore.Location = new System.Drawing.Point(1218, 47);
            this.btnBefore.Name = "btnBefore";
            this.btnBefore.Size = new System.Drawing.Size(75, 56);
            this.btnBefore.TabIndex = 15;
            this.btnBefore.Text = "חזרה לטופס קודם";
            this.btnBefore.UseVisualStyleBackColor = true;
            this.btnBefore.Click += new System.EventHandler(this.btnBefore_Click);
            // 
            // FrmWinners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 634);
            this.Controls.Add(this.btnBefore);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgSearchAllWinners);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.txtId_donor);
            this.Controls.Add(this.txtProduct_code);
            this.Controls.Add(this.lblSerial);
            this.Controls.Add(this.lblId_donor);
            this.Controls.Add(this.lblProduct_code);
            this.Controls.Add(this.label1);
            this.Name = "FrmWinners";
            this.Text = "FrmWinners";
            ((System.ComponentModel.ISupportInitialize)(this.dgSearchAllWinners)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProduct_code;
        private System.Windows.Forms.Label lblId_donor;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.TextBox txtProduct_code;
        private System.Windows.Forms.TextBox txtId_donor;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.DataGridView dgSearchAllWinners;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBefore;
    }
}