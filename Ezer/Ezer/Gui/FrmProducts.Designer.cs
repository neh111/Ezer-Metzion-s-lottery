namespace Ezer.Gui
{
    partial class FrmProducts
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
            this.dgProducts = new System.Windows.Forms.DataGridView();
            this.lblTitel = new System.Windows.Forms.Label();
            this.LblAmount = new System.Windows.Forms.Label();
            this.lblCardCode = new System.Windows.Forms.Label();
            this.lblBusinessOwnerCode = new System.Windows.Forms.Label();
            this.lblProducrNane = new System.Windows.Forms.Label();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtxCardCode = new System.Windows.Forms.TextBox();
            this.txtBusinessOwnerCode = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnForm1Before = new System.Windows.Forms.Button();
            this.btnBusinessOwnerBefore = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProducts
            // 
            this.dgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProducts.Location = new System.Drawing.Point(517, 150);
            this.dgProducts.Margin = new System.Windows.Forms.Padding(4);
            this.dgProducts.Name = "dgProducts";
            this.dgProducts.Size = new System.Drawing.Size(724, 336);
            this.dgProducts.TabIndex = 0;
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTitel.Location = new System.Drawing.Point(996, 27);
            this.lblTitel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(165, 54);
            this.lblTitel.TabIndex = 1;
            this.lblTitel.Text = "מוצרים";
            // 
            // LblAmount
            // 
            this.LblAmount.AutoSize = true;
            this.LblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LblAmount.Location = new System.Drawing.Point(1623, 340);
            this.LblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAmount.Name = "LblAmount";
            this.LblAmount.Size = new System.Drawing.Size(99, 25);
            this.LblAmount.TabIndex = 2;
            this.LblAmount.Text = "מספר זכיות";
            // 
            // lblCardCode
            // 
            this.lblCardCode.AutoSize = true;
            this.lblCardCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCardCode.Location = new System.Drawing.Point(1635, 292);
            this.lblCardCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCardCode.Name = "lblCardCode";
            this.lblCardCode.Size = new System.Drawing.Size(91, 25);
            this.lblCardCode.TabIndex = 3;
            this.lblCardCode.Text = "קוד כרטיס";
            // 
            // lblBusinessOwnerCode
            // 
            this.lblBusinessOwnerCode.AutoSize = true;
            this.lblBusinessOwnerCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblBusinessOwnerCode.Location = new System.Drawing.Point(1468, 240);
            this.lblBusinessOwnerCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBusinessOwnerCode.Name = "lblBusinessOwnerCode";
            this.lblBusinessOwnerCode.Size = new System.Drawing.Size(224, 25);
            this.lblBusinessOwnerCode.TabIndex = 4;
            this.lblBusinessOwnerCode.Text = "תעודת זהות של תורם המוצר";
            // 
            // lblProducrNane
            // 
            this.lblProducrNane.AutoSize = true;
            this.lblProducrNane.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblProducrNane.Location = new System.Drawing.Point(1639, 197);
            this.lblProducrNane.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducrNane.Name = "lblProducrNane";
            this.lblProducrNane.Size = new System.Drawing.Size(77, 25);
            this.lblProducrNane.TabIndex = 5;
            this.lblProducrNane.Text = "שם מוצר";
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblProductCode.Location = new System.Drawing.Point(1641, 150);
            this.lblProductCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(82, 25);
            this.lblProductCode.TabIndex = 6;
            this.lblProductCode.Text = "קוד מוצר";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(1473, 340);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(132, 22);
            this.txtAmount.TabIndex = 7;
            // 
            // txtxCardCode
            // 
            this.txtxCardCode.Location = new System.Drawing.Point(1473, 292);
            this.txtxCardCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtxCardCode.Name = "txtxCardCode";
            this.txtxCardCode.Size = new System.Drawing.Size(132, 22);
            this.txtxCardCode.TabIndex = 8;
            // 
            // txtBusinessOwnerCode
            // 
            this.txtBusinessOwnerCode.Location = new System.Drawing.Point(1315, 240);
            this.txtBusinessOwnerCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusinessOwnerCode.Name = "txtBusinessOwnerCode";
            this.txtBusinessOwnerCode.Size = new System.Drawing.Size(132, 22);
            this.txtBusinessOwnerCode.TabIndex = 9;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(1493, 197);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(132, 22);
            this.txtProductName.TabIndex = 10;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(1493, 150);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(132, 22);
            this.txtProductCode.TabIndex = 11;
            this.txtProductCode.TextChanged += new System.EventHandler(this.txtProductCode_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(976, 567);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 81);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "הצג את כל המוצרים הקיימים";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1084, 532);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 28);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "המוצר הבא";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(1084, 567);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(100, 81);
            this.btnShow.TabIndex = 16;
            this.btnShow.Text = "הצג מוצר זה";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(868, 532);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "שמור";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(976, 532);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "עדכן";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnForm1Before
            // 
            this.btnForm1Before.Location = new System.Drawing.Point(1825, 27);
            this.btnForm1Before.Margin = new System.Windows.Forms.Padding(4);
            this.btnForm1Before.Name = "btnForm1Before";
            this.btnForm1Before.Size = new System.Drawing.Size(100, 73);
            this.btnForm1Before.TabIndex = 19;
            this.btnForm1Before.Text = "חזרה לטופס ראשי";
            this.btnForm1Before.UseVisualStyleBackColor = true;
            this.btnForm1Before.Click += new System.EventHandler(this.btnForm1Before_Click);
            // 
            // btnBusinessOwnerBefore
            // 
            this.btnBusinessOwnerBefore.Location = new System.Drawing.Point(1695, 27);
            this.btnBusinessOwnerBefore.Margin = new System.Windows.Forms.Padding(4);
            this.btnBusinessOwnerBefore.Name = "btnBusinessOwnerBefore";
            this.btnBusinessOwnerBefore.Size = new System.Drawing.Size(123, 73);
            this.btnBusinessOwnerBefore.TabIndex = 20;
            this.btnBusinessOwnerBefore.Text = "חזרה לטופס תורמי מוצרים";
            this.btnBusinessOwnerBefore.UseVisualStyleBackColor = true;
            this.btnBusinessOwnerBefore.Click += new System.EventHandler(this.btnBusinessOwnerBefore_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(755, 532);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(95, 28);
            this.btnNew.TabIndex = 21;
            this.btnNew.Text = "חדש";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // FrmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 784);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnBusinessOwnerBefore);
            this.Controls.Add(this.btnForm1Before);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtBusinessOwnerCode);
            this.Controls.Add(this.txtxCardCode);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblProductCode);
            this.Controls.Add(this.lblProducrNane);
            this.Controls.Add(this.lblBusinessOwnerCode);
            this.Controls.Add(this.lblCardCode);
            this.Controls.Add(this.LblAmount);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.dgProducts);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmProducts";
            this.Text = "FrmProducts";
            this.Load += new System.EventHandler(this.FrmProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProducts;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label LblAmount;
        private System.Windows.Forms.Label lblCardCode;
        private System.Windows.Forms.Label lblBusinessOwnerCode;
        private System.Windows.Forms.Label lblProducrNane;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtxCardCode;
        private System.Windows.Forms.TextBox txtBusinessOwnerCode;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBusinessOwnerBefore;
        private System.Windows.Forms.Button btnForm1Before;
        private System.Windows.Forms.Button btnNew;
    }
}