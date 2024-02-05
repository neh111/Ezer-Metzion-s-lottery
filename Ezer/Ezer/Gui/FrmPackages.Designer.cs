namespace Ezer.Gui
{
    partial class FrmPackages
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
            this.dgSearch = new System.Windows.Forms.DataGridView();
            this.lblPackage_code = new System.Windows.Forms.Label();
            this.lblPackage_Name = new System.Windows.Forms.Label();
            this.lblPackage_price = new System.Windows.Forms.Label();
            this.lblCards_num = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCards_num = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBeforeMain = new System.Windows.Forms.Button();
            this.btnBuyPackage = new System.Windows.Forms.Button();
            this.btnBeforeOrders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTitel.Location = new System.Drawing.Point(631, 49);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(108, 37);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "חבילות";
            // 
            // dgSearch
            // 
            this.dgSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSearch.Location = new System.Drawing.Point(440, 110);
            this.dgSearch.Name = "dgSearch";
            this.dgSearch.Size = new System.Drawing.Size(363, 234);
            this.dgSearch.TabIndex = 1;
            this.dgSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSearch_CellContentClick);
            // 
            // lblPackage_code
            // 
            this.lblPackage_code.AutoSize = true;
            this.lblPackage_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPackage_code.Location = new System.Drawing.Point(1126, 119);
            this.lblPackage_code.Name = "lblPackage_code";
            this.lblPackage_code.Size = new System.Drawing.Size(87, 20);
            this.lblPackage_code.TabIndex = 2;
            this.lblPackage_code.Text = "קוד חבילה";
            // 
            // lblPackage_Name
            // 
            this.lblPackage_Name.AutoSize = true;
            this.lblPackage_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPackage_Name.Location = new System.Drawing.Point(1130, 170);
            this.lblPackage_Name.Name = "lblPackage_Name";
            this.lblPackage_Name.Size = new System.Drawing.Size(83, 20);
            this.lblPackage_Name.TabIndex = 3;
            this.lblPackage_Name.Text = "שם חבילה";
            // 
            // lblPackage_price
            // 
            this.lblPackage_price.AutoSize = true;
            this.lblPackage_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPackage_price.Location = new System.Drawing.Point(1114, 216);
            this.lblPackage_price.Name = "lblPackage_price";
            this.lblPackage_price.Size = new System.Drawing.Size(99, 20);
            this.lblPackage_price.TabIndex = 4;
            this.lblPackage_price.Text = "מחיר חבילה";
            // 
            // lblCards_num
            // 
            this.lblCards_num.AutoSize = true;
            this.lblCards_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCards_num.Location = new System.Drawing.Point(1097, 264);
            this.lblCards_num.Name = "lblCards_num";
            this.lblCards_num.Size = new System.Drawing.Size(116, 20);
            this.lblCards_num.TabIndex = 5;
            this.lblCards_num.Text = "מספר כרטיסים";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(986, 119);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 6;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(986, 170);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(986, 216);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 8;
            this.txtPrice.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtCards_num
            // 
            this.txtCards_num.Location = new System.Drawing.Point(986, 264);
            this.txtCards_num.Name = "txtCards_num";
            this.txtCards_num.Size = new System.Drawing.Size(100, 20);
            this.txtCards_num.TabIndex = 9;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(219, 77);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 10;
            this.btnShow.Text = "הצג";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(116, 77);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "בטל";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(116, 119);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "חדש";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnErase
            // 
            this.btnErase.Location = new System.Drawing.Point(219, 119);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(75, 23);
            this.btnErase.TabIndex = 13;
            this.btnErase.Text = "מחק";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(219, 158);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 52);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "הצג את החבילות האפשריות";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(116, 158);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 52);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "שמור";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(219, 230);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 36);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "עדכן";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(116, 227);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 39);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = "החבילה הבאה";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnBeforeMain
            // 
            this.btnBeforeMain.Location = new System.Drawing.Point(1335, 32);
            this.btnBeforeMain.Name = "btnBeforeMain";
            this.btnBeforeMain.Size = new System.Drawing.Size(75, 54);
            this.btnBeforeMain.TabIndex = 18;
            this.btnBeforeMain.Text = "חזרה לטופס הקודם";
            this.btnBeforeMain.UseVisualStyleBackColor = true;
            this.btnBeforeMain.Click += new System.EventHandler(this.btnBefore_Click);
            // 
            // btnBuyPackage
            // 
            this.btnBuyPackage.Location = new System.Drawing.Point(219, 282);
            this.btnBuyPackage.Name = "btnBuyPackage";
            this.btnBuyPackage.Size = new System.Drawing.Size(75, 48);
            this.btnBuyPackage.TabIndex = 19;
            this.btnBuyPackage.Text = "רכישת חבילה זו";
            this.btnBuyPackage.UseVisualStyleBackColor = true;
            this.btnBuyPackage.Click += new System.EventHandler(this.btnBuyPackage_Click);
            // 
            // btnBeforeOrders
            // 
            this.btnBeforeOrders.BackColor = System.Drawing.Color.Red;
            this.btnBeforeOrders.Location = new System.Drawing.Point(1241, 32);
            this.btnBeforeOrders.Name = "btnBeforeOrders";
            this.btnBeforeOrders.Size = new System.Drawing.Size(75, 54);
            this.btnBeforeOrders.TabIndex = 20;
            this.btnBeforeOrders.Text = "חזרה לטופס קודם";
            this.btnBeforeOrders.UseVisualStyleBackColor = false;
            this.btnBeforeOrders.Click += new System.EventHandler(this.btnBeforeOrders_Click);
            // 
            // FrmPackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 636);
            this.Controls.Add(this.btnBeforeOrders);
            this.Controls.Add(this.btnBuyPackage);
            this.Controls.Add(this.btnBeforeMain);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtCards_num);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCards_num);
            this.Controls.Add(this.lblPackage_price);
            this.Controls.Add(this.lblPackage_Name);
            this.Controls.Add(this.lblPackage_code);
            this.Controls.Add(this.dgSearch);
            this.Controls.Add(this.lblTitel);
            this.Name = "FrmPackages";
            this.Text = "FrmPackages";
            this.Load += new System.EventHandler(this.FrmPackages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.DataGridView dgSearch;
        private System.Windows.Forms.Label lblPackage_code;
        private System.Windows.Forms.Label lblPackage_Name;
        private System.Windows.Forms.Label lblPackage_price;
        private System.Windows.Forms.Label lblCards_num;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCards_num;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnBeforeMain;
        private System.Windows.Forms.Button btnBuyPackage;
        private System.Windows.Forms.Button btnBeforeOrders;
    }
}