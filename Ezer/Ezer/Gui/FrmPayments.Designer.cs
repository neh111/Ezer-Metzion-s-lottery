namespace Ezer.Gui
{
    partial class FrmPayments
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
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblNum_of_payments = new System.Windows.Forms.Label();
            this.lblCvv = new System.Windows.Forms.Label();
            this.lblExpiration = new System.Windows.Forms.Label();
            this.lblMastercard_mis = new System.Windows.Forms.Label();
            this.lblPayment_date = new System.Windows.Forms.Label();
            this.lblPayment_amount = new System.Windows.Forms.Label();
            this.lblOrder_code = new System.Windows.Forms.Label();
            this.lblPayment_code = new System.Windows.Forms.Label();
            this.dgSearch = new System.Windows.Forms.DataGridView();
            this.txtNum_of_payments = new System.Windows.Forms.TextBox();
            this.txtCvv = new System.Windows.Forms.TextBox();
            this.txtMastercard_mis = new System.Windows.Forms.TextBox();
            this.txtPayment_amount = new System.Windows.Forms.TextBox();
            this.txtPayment_code = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtpPayment = new System.Windows.Forms.DateTimePicker();
            this.txtOrder_code = new System.Windows.Forms.TextBox();
            this.btnBefore = new System.Windows.Forms.Button();
            this.dtpTokef = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTitel.Location = new System.Drawing.Point(685, 36);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(94, 37);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "תשלום";
            // 
            // lblNum_of_payments
            // 
            this.lblNum_of_payments.AutoSize = true;
            this.lblNum_of_payments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblNum_of_payments.Location = new System.Drawing.Point(1241, 489);
            this.lblNum_of_payments.Name = "lblNum_of_payments";
            this.lblNum_of_payments.Size = new System.Drawing.Size(108, 20);
            this.lblNum_of_payments.TabIndex = 1;
            this.lblNum_of_payments.Text = "מספר תשלומים";
            // 
            // lblCvv
            // 
            this.lblCvv.AutoSize = true;
            this.lblCvv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCvv.Location = new System.Drawing.Point(1318, 439);
            this.lblCvv.Name = "lblCvv";
            this.lblCvv.Size = new System.Drawing.Size(31, 20);
            this.lblCvv.TabIndex = 2;
            this.lblCvv.Text = "cvv";
            // 
            // lblExpiration
            // 
            this.lblExpiration.AutoSize = true;
            this.lblExpiration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblExpiration.Location = new System.Drawing.Point(1307, 380);
            this.lblExpiration.Name = "lblExpiration";
            this.lblExpiration.Size = new System.Drawing.Size(42, 20);
            this.lblExpiration.TabIndex = 3;
            this.lblExpiration.Text = "תוקף";
            // 
            // lblMastercard_mis
            // 
            this.lblMastercard_mis.AutoSize = true;
            this.lblMastercard_mis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMastercard_mis.Location = new System.Drawing.Point(1251, 326);
            this.lblMastercard_mis.Name = "lblMastercard_mis";
            this.lblMastercard_mis.Size = new System.Drawing.Size(98, 20);
            this.lblMastercard_mis.TabIndex = 4;
            this.lblMastercard_mis.Text = "מספר  אשראי";
            // 
            // lblPayment_date
            // 
            this.lblPayment_date.AutoSize = true;
            this.lblPayment_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPayment_date.Location = new System.Drawing.Point(1240, 270);
            this.lblPayment_date.Name = "lblPayment_date";
            this.lblPayment_date.Size = new System.Drawing.Size(109, 20);
            this.lblPayment_date.TabIndex = 6;
            this.lblPayment_date.Text = "תאריך התשלום";
            // 
            // lblPayment_amount
            // 
            this.lblPayment_amount.AutoSize = true;
            this.lblPayment_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPayment_amount.Location = new System.Drawing.Point(1252, 214);
            this.lblPayment_amount.Name = "lblPayment_amount";
            this.lblPayment_amount.Size = new System.Drawing.Size(97, 20);
            this.lblPayment_amount.TabIndex = 7;
            this.lblPayment_amount.Text = "סכום לתשלום";
            // 
            // lblOrder_code
            // 
            this.lblOrder_code.AutoSize = true;
            this.lblOrder_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblOrder_code.Location = new System.Drawing.Point(1273, 161);
            this.lblOrder_code.Name = "lblOrder_code";
            this.lblOrder_code.Size = new System.Drawing.Size(76, 20);
            this.lblOrder_code.TabIndex = 8;
            this.lblOrder_code.Text = "קוד הזמנה";
            // 
            // lblPayment_code
            // 
            this.lblPayment_code.AutoSize = true;
            this.lblPayment_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPayment_code.Location = new System.Drawing.Point(1269, 97);
            this.lblPayment_code.Name = "lblPayment_code";
            this.lblPayment_code.Size = new System.Drawing.Size(80, 20);
            this.lblPayment_code.TabIndex = 9;
            this.lblPayment_code.Text = "קוד תשלום";
            // 
            // dgSearch
            // 
            this.dgSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSearch.Location = new System.Drawing.Point(503, 120);
            this.dgSearch.Name = "dgSearch";
            this.dgSearch.Size = new System.Drawing.Size(431, 238);
            this.dgSearch.TabIndex = 11;
            // 
            // txtNum_of_payments
            // 
            this.txtNum_of_payments.Location = new System.Drawing.Point(1107, 491);
            this.txtNum_of_payments.Name = "txtNum_of_payments";
            this.txtNum_of_payments.Size = new System.Drawing.Size(100, 20);
            this.txtNum_of_payments.TabIndex = 12;
            // 
            // txtCvv
            // 
            this.txtCvv.Location = new System.Drawing.Point(1107, 439);
            this.txtCvv.Name = "txtCvv";
            this.txtCvv.Size = new System.Drawing.Size(100, 20);
            this.txtCvv.TabIndex = 13;
            // 
            // txtMastercard_mis
            // 
            this.txtMastercard_mis.Location = new System.Drawing.Point(1107, 326);
            this.txtMastercard_mis.Name = "txtMastercard_mis";
            this.txtMastercard_mis.Size = new System.Drawing.Size(100, 20);
            this.txtMastercard_mis.TabIndex = 15;
            // 
            // txtPayment_amount
            // 
            this.txtPayment_amount.Location = new System.Drawing.Point(1103, 216);
            this.txtPayment_amount.Name = "txtPayment_amount";
            this.txtPayment_amount.Size = new System.Drawing.Size(100, 20);
            this.txtPayment_amount.TabIndex = 18;
            // 
            // txtPayment_code
            // 
            this.txtPayment_code.Location = new System.Drawing.Point(1103, 97);
            this.txtPayment_code.Name = "txtPayment_code";
            this.txtPayment_code.Size = new System.Drawing.Size(100, 20);
            this.txtPayment_code.TabIndex = 19;
            this.txtPayment_code.TextChanged += new System.EventHandler(this.txtPayment_code_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(161, 175);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 43);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "שמור";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dtpPayment
            // 
            this.dtpPayment.Location = new System.Drawing.Point(1103, 269);
            this.dtpPayment.Name = "dtpPayment";
            this.dtpPayment.Size = new System.Drawing.Size(104, 20);
            this.dtpPayment.TabIndex = 28;
            // 
            // txtOrder_code
            // 
            this.txtOrder_code.Location = new System.Drawing.Point(1107, 161);
            this.txtOrder_code.Name = "txtOrder_code";
            this.txtOrder_code.Size = new System.Drawing.Size(100, 20);
            this.txtOrder_code.TabIndex = 29;
            // 
            // btnBefore
            // 
            this.btnBefore.Location = new System.Drawing.Point(1290, 25);
            this.btnBefore.Name = "btnBefore";
            this.btnBefore.Size = new System.Drawing.Size(75, 48);
            this.btnBefore.TabIndex = 30;
            this.btnBefore.Text = "חזרה לטופס קודם";
            this.btnBefore.UseVisualStyleBackColor = true;
            this.btnBefore.Click += new System.EventHandler(this.btnBefore_Click);
            // 
            // dtpTokef
            // 
            this.dtpTokef.Location = new System.Drawing.Point(1060, 379);
            this.dtpTokef.Name = "dtpTokef";
            this.dtpTokef.Size = new System.Drawing.Size(200, 20);
            this.dtpTokef.TabIndex = 31;
            // 
            // FrmPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 650);
            this.Controls.Add(this.dtpTokef);
            this.Controls.Add(this.btnBefore);
            this.Controls.Add(this.txtOrder_code);
            this.Controls.Add(this.dtpPayment);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPayment_code);
            this.Controls.Add(this.txtPayment_amount);
            this.Controls.Add(this.txtMastercard_mis);
            this.Controls.Add(this.txtCvv);
            this.Controls.Add(this.txtNum_of_payments);
            this.Controls.Add(this.dgSearch);
            this.Controls.Add(this.lblPayment_code);
            this.Controls.Add(this.lblOrder_code);
            this.Controls.Add(this.lblPayment_amount);
            this.Controls.Add(this.lblPayment_date);
            this.Controls.Add(this.lblMastercard_mis);
            this.Controls.Add(this.lblExpiration);
            this.Controls.Add(this.lblCvv);
            this.Controls.Add(this.lblNum_of_payments);
            this.Controls.Add(this.lblTitel);
            this.Name = "FrmPayments";
            this.Text = "FrmPayments";
            this.Load += new System.EventHandler(this.FrmPayments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblNum_of_payments;
        private System.Windows.Forms.Label lblCvv;
        private System.Windows.Forms.Label lblExpiration;
        private System.Windows.Forms.Label lblMastercard_mis;
        private System.Windows.Forms.Label lblPayment_date;
        private System.Windows.Forms.Label lblPayment_amount;
        private System.Windows.Forms.Label lblOrder_code;
        private System.Windows.Forms.Label lblPayment_code;
        private System.Windows.Forms.DataGridView dgSearch;
        private System.Windows.Forms.TextBox txtNum_of_payments;
        private System.Windows.Forms.TextBox txtCvv;
        private System.Windows.Forms.TextBox txtMastercard_mis;
        private System.Windows.Forms.TextBox txtPayment_amount;
        private System.Windows.Forms.TextBox txtPayment_code;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker dtpPayment;
        private System.Windows.Forms.TextBox txtOrder_code;
        private System.Windows.Forms.Button btnBefore;
        private System.Windows.Forms.DateTimePicker dtpTokef;
    }
}