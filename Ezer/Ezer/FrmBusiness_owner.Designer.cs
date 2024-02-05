namespace Ezer
{
    partial class frmBusiness_owner
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
            this.lblTitel = new System.Windows.Forms.Label();
            this.dgSearch = new System.Windows.Forms.DataGridView();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblZip_code = new System.Windows.Forms.Label();
            this.lblPel = new System.Windows.Forms.Label();
            this.lblBusiness_tel = new System.Windows.Forms.Label();
            this.lblGmail = new System.Windows.Forms.Label();
            this.lblF_name = new System.Windows.Forms.Label();
            this.lblL_name = new System.Windows.Forms.Label();
            this.lblItem_description = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtBusiness_name = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtZip_code = new System.Windows.Forms.TextBox();
            this.txtPel = new System.Windows.Forms.TextBox();
            this.txtBusiness_tel = new System.Windows.Forms.TextBox();
            this.txtGmail = new System.Windows.Forms.TextBox();
            this.txtF_name = new System.Windows.Forms.TextBox();
            this.txtItem_description = new System.Windows.Forms.TextBox();
            this.txtL_name = new System.Windows.Forms.TextBox();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTitel.Location = new System.Drawing.Point(581, 26);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(301, 42);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "בעלי עסק תורמים";
            this.lblTitel.Click += new System.EventHandler(this.lblTitel_Click);
            // 
            // dgSearch
            // 
            this.dgSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSearch.Location = new System.Drawing.Point(461, 113);
            this.dgSearch.Name = "dgSearch";
            this.dgSearch.Size = new System.Drawing.Size(290, 305);
            this.dgSearch.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblId.Location = new System.Drawing.Point(1221, 89);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(102, 24);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "תעודת זהות";
            this.lblId.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblName.Location = new System.Drawing.Point(1245, 135);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 24);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "שם עסק";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblAddress.Location = new System.Drawing.Point(1256, 179);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(57, 24);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "כתובת";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCity.Location = new System.Drawing.Point(1277, 221);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(36, 24);
            this.lblCity.TabIndex = 5;
            this.lblCity.Text = "עיר";
            // 
            // lblZip_code
            // 
            this.lblZip_code.AutoSize = true;
            this.lblZip_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblZip_code.Location = new System.Drawing.Point(1262, 263);
            this.lblZip_code.Name = "lblZip_code";
            this.lblZip_code.Size = new System.Drawing.Size(54, 24);
            this.lblZip_code.TabIndex = 6;
            this.lblZip_code.Text = "מיקוד";
            // 
            // lblPel
            // 
            this.lblPel.AutoSize = true;
            this.lblPel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPel.Location = new System.Drawing.Point(1253, 305);
            this.lblPel.Name = "lblPel";
            this.lblPel.Size = new System.Drawing.Size(63, 24);
            this.lblPel.TabIndex = 7;
            this.lblPel.Text = "פלאפון";
            // 
            // lblBusiness_tel
            // 
            this.lblBusiness_tel.AutoSize = true;
            this.lblBusiness_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblBusiness_tel.Location = new System.Drawing.Point(1222, 349);
            this.lblBusiness_tel.Name = "lblBusiness_tel";
            this.lblBusiness_tel.Size = new System.Drawing.Size(91, 24);
            this.lblBusiness_tel.TabIndex = 8;
            this.lblBusiness_tel.Text = "טלפון עסק";
            // 
            // lblGmail
            // 
            this.lblGmail.AutoSize = true;
            this.lblGmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblGmail.Location = new System.Drawing.Point(1271, 394);
            this.lblGmail.Name = "lblGmail";
            this.lblGmail.Size = new System.Drawing.Size(42, 24);
            this.lblGmail.TabIndex = 9;
            this.lblGmail.Text = "מייל";
            this.lblGmail.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblF_name
            // 
            this.lblF_name.AutoSize = true;
            this.lblF_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblF_name.Location = new System.Drawing.Point(1239, 439);
            this.lblF_name.Name = "lblF_name";
            this.lblF_name.Size = new System.Drawing.Size(74, 24);
            this.lblF_name.TabIndex = 10;
            this.lblF_name.Text = "שם פרטי";
            // 
            // lblL_name
            // 
            this.lblL_name.AutoSize = true;
            this.lblL_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblL_name.Location = new System.Drawing.Point(1221, 483);
            this.lblL_name.Name = "lblL_name";
            this.lblL_name.Size = new System.Drawing.Size(95, 24);
            this.lblL_name.TabIndex = 11;
            this.lblL_name.Text = "שם משפחה";
            // 
            // lblItem_description
            // 
            this.lblItem_description.AutoSize = true;
            this.lblItem_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblItem_description.Location = new System.Drawing.Point(1167, 529);
            this.lblItem_description.Name = "lblItem_description";
            this.lblItem_description.Size = new System.Drawing.Size(156, 24);
            this.lblItem_description.TabIndex = 12;
            this.lblItem_description.Text = "תאור פריט התרומה";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(1095, 94);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 13;
            // 
            // txtBusiness_name
            // 
            this.txtBusiness_name.Location = new System.Drawing.Point(1095, 139);
            this.txtBusiness_name.Name = "txtBusiness_name";
            this.txtBusiness_name.Size = new System.Drawing.Size(100, 20);
            this.txtBusiness_name.TabIndex = 14;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(1095, 179);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 15;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(1095, 226);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 16;
            // 
            // txtZip_code
            // 
            this.txtZip_code.Location = new System.Drawing.Point(1095, 268);
            this.txtZip_code.Name = "txtZip_code";
            this.txtZip_code.Size = new System.Drawing.Size(100, 20);
            this.txtZip_code.TabIndex = 17;
            // 
            // txtPel
            // 
            this.txtPel.Location = new System.Drawing.Point(1095, 310);
            this.txtPel.Name = "txtPel";
            this.txtPel.Size = new System.Drawing.Size(100, 20);
            this.txtPel.TabIndex = 18;
            // 
            // txtBusiness_tel
            // 
            this.txtBusiness_tel.Location = new System.Drawing.Point(1095, 354);
            this.txtBusiness_tel.Name = "txtBusiness_tel";
            this.txtBusiness_tel.Size = new System.Drawing.Size(100, 20);
            this.txtBusiness_tel.TabIndex = 19;
            // 
            // txtGmail
            // 
            this.txtGmail.Location = new System.Drawing.Point(1095, 399);
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Size = new System.Drawing.Size(100, 20);
            this.txtGmail.TabIndex = 20;
            // 
            // txtF_name
            // 
            this.txtF_name.Location = new System.Drawing.Point(1095, 439);
            this.txtF_name.Name = "txtF_name";
            this.txtF_name.Size = new System.Drawing.Size(100, 20);
            this.txtF_name.TabIndex = 21;
            // 
            // txtItem_description
            // 
            this.txtItem_description.Location = new System.Drawing.Point(1034, 529);
            this.txtItem_description.Name = "txtItem_description";
            this.txtItem_description.Size = new System.Drawing.Size(100, 20);
            this.txtItem_description.TabIndex = 22;
            // 
            // txtL_name
            // 
            this.txtL_name.Location = new System.Drawing.Point(1095, 483);
            this.txtL_name.Name = "txtL_name";
            this.txtL_name.Size = new System.Drawing.Size(100, 20);
            this.txtL_name.TabIndex = 23;
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Location = new System.Drawing.Point(1271, 580);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkStatus.Size = new System.Drawing.Size(52, 17);
            this.chkStatus.TabIndex = 24;
            this.chkStatus.Text = "פעיל";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(204, 89);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 25;
            this.btnRefresh.Text = "רענן";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(86, 89);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 26;
            this.btnNew.Text = "חדש";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(204, 164);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 27;
            this.btnDel.Text = "מחק";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(86, 164);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 28;
            this.btnShow.Text = "הצג";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(204, 226);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "עדכן";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(86, 226);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 30;
            this.btnNext.Text = "התורם הבא";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(86, 296);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "בטל";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(204, 296);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "שמור";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // frmBusiness_owner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 628);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.chkStatus);
            this.Controls.Add(this.txtL_name);
            this.Controls.Add(this.txtItem_description);
            this.Controls.Add(this.txtF_name);
            this.Controls.Add(this.txtGmail);
            this.Controls.Add(this.txtBusiness_tel);
            this.Controls.Add(this.txtPel);
            this.Controls.Add(this.txtZip_code);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtBusiness_name);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblItem_description);
            this.Controls.Add(this.lblL_name);
            this.Controls.Add(this.lblF_name);
            this.Controls.Add(this.lblGmail);
            this.Controls.Add(this.lblBusiness_tel);
            this.Controls.Add(this.lblPel);
            this.Controls.Add(this.lblZip_code);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dgSearch);
            this.Controls.Add(this.lblTitel);
            this.Name = "frmBusiness_owner";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmBusiness_owner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.DataGridView dgSearch;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblZip_code;
        private System.Windows.Forms.Label lblPel;
        private System.Windows.Forms.Label lblBusiness_tel;
        private System.Windows.Forms.Label lblGmail;
        private System.Windows.Forms.Label lblF_name;
        private System.Windows.Forms.Label lblL_name;
        private System.Windows.Forms.Label lblItem_description;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtBusiness_name;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtZip_code;
        private System.Windows.Forms.TextBox txtPel;
        private System.Windows.Forms.TextBox txtBusiness_tel;
        private System.Windows.Forms.TextBox txtGmail;
        private System.Windows.Forms.TextBox txtF_name;
        private System.Windows.Forms.TextBox txtItem_description;
        private System.Windows.Forms.TextBox txtL_name;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}

