namespace Ezer.Gui
{
    partial class FrmMembers
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblF_name = new System.Windows.Forms.Label();
            this.lblL_name = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblPel = new System.Windows.Forms.Label();
            this.lblGmail = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtF_name = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtL_name = new System.Windows.Forms.TextBox();
            this.txtGmail = new System.Windows.Forms.TextBox();
            this.txtPel = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnCode = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgSearch = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnBefore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTitel.Location = new System.Drawing.Point(674, 48);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(128, 42);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "נאמנות";
            this.lblTitel.Click += new System.EventHandler(this.lblTitel_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblId.Location = new System.Drawing.Point(1241, 141);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(87, 20);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "תעודת זהות";
            // 
            // lblF_name
            // 
            this.lblF_name.AutoSize = true;
            this.lblF_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblF_name.Location = new System.Drawing.Point(1263, 187);
            this.lblF_name.Name = "lblF_name";
            this.lblF_name.Size = new System.Drawing.Size(65, 20);
            this.lblF_name.TabIndex = 3;
            this.lblF_name.Text = "שם פרטי";
            // 
            // lblL_name
            // 
            this.lblL_name.AutoSize = true;
            this.lblL_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblL_name.Location = new System.Drawing.Point(1247, 230);
            this.lblL_name.Name = "lblL_name";
            this.lblL_name.Size = new System.Drawing.Size(81, 20);
            this.lblL_name.TabIndex = 4;
            this.lblL_name.Text = "שם משפחה";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTel.Location = new System.Drawing.Point(1280, 277);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(48, 20);
            this.lblTel.TabIndex = 5;
            this.lblTel.Text = "טלפון";
            this.lblTel.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblPel
            // 
            this.lblPel.AutoSize = true;
            this.lblPel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPel.Location = new System.Drawing.Point(1272, 318);
            this.lblPel.Name = "lblPel";
            this.lblPel.Size = new System.Drawing.Size(56, 20);
            this.lblPel.TabIndex = 6;
            this.lblPel.Text = "פלאפון";
            this.lblPel.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblGmail
            // 
            this.lblGmail.AutoSize = true;
            this.lblGmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblGmail.Location = new System.Drawing.Point(1290, 366);
            this.lblGmail.Name = "lblGmail";
            this.lblGmail.Size = new System.Drawing.Size(38, 20);
            this.lblGmail.TabIndex = 7;
            this.lblGmail.Text = "מייל";
            this.lblGmail.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTotal.Location = new System.Drawing.Point(707, 491);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(154, 20);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "הסכום שהצטבר עד כה";
            // 
            // txtF_name
            // 
            this.txtF_name.Location = new System.Drawing.Point(1092, 189);
            this.txtF_name.Name = "txtF_name";
            this.txtF_name.Size = new System.Drawing.Size(100, 20);
            this.txtF_name.TabIndex = 9;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(1092, 141);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 10;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(571, 493);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 11;
            // 
            // txtL_name
            // 
            this.txtL_name.Location = new System.Drawing.Point(1092, 230);
            this.txtL_name.Name = "txtL_name";
            this.txtL_name.Size = new System.Drawing.Size(100, 20);
            this.txtL_name.TabIndex = 12;
            // 
            // txtGmail
            // 
            this.txtGmail.Location = new System.Drawing.Point(1092, 366);
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Size = new System.Drawing.Size(100, 20);
            this.txtGmail.TabIndex = 13;
            // 
            // txtPel
            // 
            this.txtPel.Location = new System.Drawing.Point(1092, 320);
            this.txtPel.Name = "txtPel";
            this.txtPel.Size = new System.Drawing.Size(100, 20);
            this.txtPel.TabIndex = 14;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(1092, 277);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 15;
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Location = new System.Drawing.Point(1092, 423);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkStatus.Size = new System.Drawing.Size(59, 17);
            this.chkStatus.TabIndex = 16;
            this.chkStatus.Text = "פעילה";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(271, 125);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "רענן";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(143, 125);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 18;
            this.btnNew.Text = "חדש";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnErase
            // 
            this.btnErase.Location = new System.Drawing.Point(271, 184);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(75, 23);
            this.btnErase.TabIndex = 19;
            this.btnErase.Text = "מחק";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(271, 248);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 20;
            this.btnShow.Text = "הצג";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(143, 184);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "בטל";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(143, 248);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "עדכן";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(271, 310);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 39);
            this.btnNext.TabIndex = 23;
            this.btnNext.Text = "הנאמנת הבאה";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnCode
            // 
            this.btnCode.Location = new System.Drawing.Point(203, 366);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(75, 52);
            this.btnCode.TabIndex = 24;
            this.btnCode.Text = "לקבלת קוד אישי";
            this.btnCode.UseVisualStyleBackColor = true;
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(143, 310);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 39);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "שמור";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgSearch
            // 
            this.dgSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSearch.Location = new System.Drawing.Point(529, 125);
            this.dgSearch.Name = "dgSearch";
            this.dgSearch.Size = new System.Drawing.Size(456, 261);
            this.dgSearch.TabIndex = 26;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCode.Location = new System.Drawing.Point(1257, 100);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(71, 20);
            this.lblCode.TabIndex = 27;
            this.lblCode.Text = "קוד אישי ";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(1092, 100);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 28;
            // 
            // btnBefore
            // 
            this.btnBefore.Location = new System.Drawing.Point(1327, 22);
            this.btnBefore.Name = "btnBefore";
            this.btnBefore.Size = new System.Drawing.Size(75, 58);
            this.btnBefore.TabIndex = 29;
            this.btnBefore.Text = "חזרה לטופס קודם";
            this.btnBefore.UseVisualStyleBackColor = true;
            this.btnBefore.Click += new System.EventHandler(this.btnBefore_Click_1);
            // 
            // FrmMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 635);
            this.Controls.Add(this.btnBefore);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.dgSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCode);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.chkStatus);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtPel);
            this.Controls.Add(this.txtGmail);
            this.Controls.Add(this.txtL_name);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtF_name);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblGmail);
            this.Controls.Add(this.lblPel);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblL_name);
            this.Controls.Add(this.lblF_name);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblTitel);
            this.Name = "FrmMembers";
            this.Text = "FrmMembers";
            this.Load += new System.EventHandler(this.FrmMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblF_name;
        private System.Windows.Forms.Label lblL_name;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblPel;
        private System.Windows.Forms.Label lblGmail;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtF_name;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtL_name;
        private System.Windows.Forms.TextBox txtGmail;
        private System.Windows.Forms.TextBox txtPel;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCode;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgSearch;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Button btnBefore;
    }
}