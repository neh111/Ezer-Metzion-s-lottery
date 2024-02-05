namespace Ezer.Gui
{
    partial class FrmOrders
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
            this.dgBookedPackages = new System.Windows.Forms.DataGridView();
            this.lblOrderCode = new System.Windows.Forms.Label();
            this.lblOrderAmount = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblIdDonor = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.txtIdDonor = new System.Windows.Forms.TextBox();
            this.txtOrderCode = new System.Windows.Forms.TextBox();
            this.lblBp = new System.Windows.Forms.Label();
            this.txtOrderAmount = new System.Windows.Forms.TextBox();
            this.dgDonor = new System.Windows.Forms.DataGridView();
            this.lblDonor = new System.Windows.Forms.Label();
            this.btnPayments = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.cmbMembers = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgPackages = new System.Windows.Forms.DataGridView();
            this.lblPackages = new System.Windows.Forms.Label();
            this.btnChoosePackage = new System.Windows.Forms.Button();
            this.dgBookedCards = new System.Windows.Forms.DataGridView();
            this.lblBookedCards = new System.Windows.Forms.Label();
            this.btnGetDetailsDonors = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnBefore = new System.Windows.Forms.Button();
            this.chooseCards = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblNumCards = new System.Windows.Forms.Label();
            this.txtNumCards = new System.Windows.Forms.TextBox();
            this.btnUpdateDonorDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookedPackages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDonor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPackages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookedCards)).BeginInit();
            this.SuspendLayout();
            // 
            // dgBookedPackages
            // 
            this.dgBookedPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBookedPackages.Location = new System.Drawing.Point(1241, 430);
            this.dgBookedPackages.Margin = new System.Windows.Forms.Padding(4);
            this.dgBookedPackages.Name = "dgBookedPackages";
            this.dgBookedPackages.Size = new System.Drawing.Size(661, 209);
            this.dgBookedPackages.TabIndex = 6;
            // 
            // lblOrderCode
            // 
            this.lblOrderCode.AutoSize = true;
            this.lblOrderCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblOrderCode.Location = new System.Drawing.Point(339, 44);
            this.lblOrderCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderCode.Name = "lblOrderCode";
            this.lblOrderCode.Size = new System.Drawing.Size(101, 20);
            this.lblOrderCode.TabIndex = 9;
            this.lblOrderCode.Text = "הזמנה מספר";
            // 
            // lblOrderAmount
            // 
            this.lblOrderAmount.AutoSize = true;
            this.lblOrderAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblOrderAmount.Location = new System.Drawing.Point(209, 647);
            this.lblOrderAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderAmount.Name = "lblOrderAmount";
            this.lblOrderAmount.Size = new System.Drawing.Size(85, 20);
            this.lblOrderAmount.TabIndex = 10;
            this.lblOrderAmount.Text = "סכום סופי";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblOrderDate.Location = new System.Drawing.Point(328, 94);
            this.lblOrderDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(109, 20);
            this.lblOrderDate.TabIndex = 11;
            this.lblOrderDate.Text = "תאריך הזמנה";
            // 
            // lblIdDonor
            // 
            this.lblIdDonor.AutoSize = true;
            this.lblIdDonor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblIdDonor.Location = new System.Drawing.Point(360, 144);
            this.lblIdDonor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdDonor.Name = "lblIdDonor";
            this.lblIdDonor.Size = new System.Drawing.Size(83, 20);
            this.lblIdDonor.TabIndex = 12;
            this.lblIdDonor.Text = "ת.ז. תורם";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Location = new System.Drawing.Point(120, 94);
            this.dtpOrderDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(185, 22);
            this.dtpOrderDate.TabIndex = 13;
            // 
            // txtIdDonor
            // 
            this.txtIdDonor.Location = new System.Drawing.Point(173, 144);
            this.txtIdDonor.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdDonor.Name = "txtIdDonor";
            this.txtIdDonor.Size = new System.Drawing.Size(132, 22);
            this.txtIdDonor.TabIndex = 14;
            // 
            // txtOrderCode
            // 
            this.txtOrderCode.Location = new System.Drawing.Point(173, 44);
            this.txtOrderCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrderCode.Name = "txtOrderCode";
            this.txtOrderCode.Size = new System.Drawing.Size(132, 22);
            this.txtOrderCode.TabIndex = 15;
            this.txtOrderCode.TextChanged += new System.EventHandler(this.txtOrderCode_TextChanged);
            // 
            // lblBp
            // 
            this.lblBp.AutoSize = true;
            this.lblBp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblBp.Location = new System.Drawing.Point(1697, 396);
            this.lblBp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBp.Name = "lblBp";
            this.lblBp.Size = new System.Drawing.Size(182, 20);
            this.lblBp.TabIndex = 16;
            this.lblBp.Text = "פירוט חבילות מוזמנות";
            // 
            // txtOrderAmount
            // 
            this.txtOrderAmount.Location = new System.Drawing.Point(68, 642);
            this.txtOrderAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrderAmount.Name = "txtOrderAmount";
            this.txtOrderAmount.Size = new System.Drawing.Size(132, 22);
            this.txtOrderAmount.TabIndex = 17;
            // 
            // dgDonor
            // 
            this.dgDonor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDonor.Location = new System.Drawing.Point(1289, 69);
            this.dgDonor.Margin = new System.Windows.Forms.Padding(4);
            this.dgDonor.Name = "dgDonor";
            this.dgDonor.Size = new System.Drawing.Size(613, 225);
            this.dgDonor.TabIndex = 18;
            this.dgDonor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDonor_CellContentClick);
            // 
            // lblDonor
            // 
            this.lblDonor.AutoSize = true;
            this.lblDonor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblDonor.Location = new System.Drawing.Point(1789, 44);
            this.lblDonor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDonor.Name = "lblDonor";
            this.lblDonor.Size = new System.Drawing.Size(101, 20);
            this.lblDonor.TabIndex = 19;
            this.lblDonor.Text = "פרטי התורם";
            // 
            // btnPayments
            // 
            this.btnPayments.Location = new System.Drawing.Point(257, 356);
            this.btnPayments.Margin = new System.Windows.Forms.Padding(4);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(100, 60);
            this.btnPayments.TabIndex = 22;
            this.btnPayments.Text = "לתשלום";
            this.btnPayments.UseVisualStyleBackColor = true;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblQuestion.Location = new System.Drawing.Point(77, 501);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(411, 20);
            this.lblQuestion.TabIndex = 23;
            this.lblQuestion.Text = "האם תוכל לשתף אותנו מי סיפרה לך אודות ההגרלה?";
            this.lblQuestion.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbMembers
            // 
            this.cmbMembers.FormattingEnabled = true;
            this.cmbMembers.Location = new System.Drawing.Point(173, 546);
            this.cmbMembers.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMembers.Name = "cmbMembers";
            this.cmbMembers.Size = new System.Drawing.Size(160, 24);
            this.cmbMembers.TabIndex = 26;
            this.cmbMembers.SelectedIndexChanged += new System.EventHandler(this.cmbMembers_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dgPackages
            // 
            this.dgPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPackages.Location = new System.Drawing.Point(567, 71);
            this.dgPackages.Margin = new System.Windows.Forms.Padding(4);
            this.dgPackages.Name = "dgPackages";
            this.dgPackages.Size = new System.Drawing.Size(613, 225);
            this.dgPackages.TabIndex = 27;
            this.dgPackages.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPackages_CellContentClick);
            // 
            // lblPackages
            // 
            this.lblPackages.AutoSize = true;
            this.lblPackages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPackages.Location = new System.Drawing.Point(1104, 44);
            this.lblPackages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPackages.Name = "lblPackages";
            this.lblPackages.Size = new System.Drawing.Size(64, 20);
            this.lblPackages.TabIndex = 28;
            this.lblPackages.Text = "חבילות";
            // 
            // btnChoosePackage
            // 
            this.btnChoosePackage.Location = new System.Drawing.Point(1080, 304);
            this.btnChoosePackage.Margin = new System.Windows.Forms.Padding(4);
            this.btnChoosePackage.Name = "btnChoosePackage";
            this.btnChoosePackage.Size = new System.Drawing.Size(100, 74);
            this.btnChoosePackage.TabIndex = 29;
            this.btnChoosePackage.Text = "לבחירת חבילה ";
            this.btnChoosePackage.UseVisualStyleBackColor = true;
            this.btnChoosePackage.Click += new System.EventHandler(this.btnChoosePackage_Click);
            // 
            // dgBookedCards
            // 
            this.dgBookedCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBookedCards.Location = new System.Drawing.Point(567, 430);
            this.dgBookedCards.Margin = new System.Windows.Forms.Padding(4);
            this.dgBookedCards.Name = "dgBookedCards";
            this.dgBookedCards.Size = new System.Drawing.Size(604, 209);
            this.dgBookedCards.TabIndex = 30;
            // 
            // lblBookedCards
            // 
            this.lblBookedCards.AutoSize = true;
            this.lblBookedCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblBookedCards.Location = new System.Drawing.Point(959, 396);
            this.lblBookedCards.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookedCards.Name = "lblBookedCards";
            this.lblBookedCards.Size = new System.Drawing.Size(191, 20);
            this.lblBookedCards.TabIndex = 31;
            this.lblBookedCards.Text = "פירוט כרטיסים מוזמנים";
            // 
            // btnGetDetailsDonors
            // 
            this.btnGetDetailsDonors.Location = new System.Drawing.Point(1768, 302);
            this.btnGetDetailsDonors.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetDetailsDonors.Name = "btnGetDetailsDonors";
            this.btnGetDetailsDonors.Size = new System.Drawing.Size(100, 58);
            this.btnGetDetailsDonors.TabIndex = 32;
            this.btnGetDetailsDonors.Text = "לקליטת פרטי התורם";
            this.btnGetDetailsDonors.UseVisualStyleBackColor = true;
            this.btnGetDetailsDonors.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(972, 304);
            this.btnChoose.Margin = new System.Windows.Forms.Padding(4);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(100, 74);
            this.btnChoose.TabIndex = 33;
            this.btnChoose.Text = "בחר חבילה זו";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnBefore
            // 
            this.btnBefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBefore.Location = new System.Drawing.Point(81, 204);
            this.btnBefore.Margin = new System.Windows.Forms.Padding(4);
            this.btnBefore.Name = "btnBefore";
            this.btnBefore.Size = new System.Drawing.Size(100, 64);
            this.btnBefore.TabIndex = 34;
            this.btnBefore.Text = "חזרה לטופס קודם";
            this.btnBefore.UseVisualStyleBackColor = true;
            this.btnBefore.Click += new System.EventHandler(this.btnBefore_Click);
            // 
            // chooseCards
            // 
            this.chooseCards.Location = new System.Drawing.Point(1671, 666);
            this.chooseCards.Margin = new System.Windows.Forms.Padding(4);
            this.chooseCards.Name = "chooseCards";
            this.chooseCards.Size = new System.Drawing.Size(100, 63);
            this.chooseCards.TabIndex = 36;
            this.chooseCards.Text = "בחר כרטיסים";
            this.chooseCards.UseVisualStyleBackColor = true;
            this.chooseCards.Click += new System.EventHandler(this.chooseCards_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblAmount.Location = new System.Drawing.Point(496, 304);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(360, 17);
            this.lblAmount.TabIndex = 37;
            this.lblAmount.Text = "נא הקש את כמות החבילות מסוג זה שאתה מעונין לרכוש";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(711, 335);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(132, 22);
            this.txtAmount.TabIndex = 38;
            // 
            // lblNumCards
            // 
            this.lblNumCards.AutoSize = true;
            this.lblNumCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblNumCards.Location = new System.Drawing.Point(1267, 666);
            this.lblNumCards.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumCards.Name = "lblNumCards";
            this.lblNumCards.Size = new System.Drawing.Size(199, 17);
            this.lblNumCards.TabIndex = 39;
            this.lblNumCards.Text = "מספר הכרטיסים שעליך לבחור";
            // 
            // txtNumCards
            // 
            this.txtNumCards.Location = new System.Drawing.Point(1319, 704);
            this.txtNumCards.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumCards.Name = "txtNumCards";
            this.txtNumCards.Size = new System.Drawing.Size(132, 22);
            this.txtNumCards.TabIndex = 40;
            this.txtNumCards.TextChanged += new System.EventHandler(this.txtNumCards_TextChanged);
            // 
            // btnUpdateDonorDetails
            // 
            this.btnUpdateDonorDetails.Location = new System.Drawing.Point(1660, 304);
            this.btnUpdateDonorDetails.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateDonorDetails.Name = "btnUpdateDonorDetails";
            this.btnUpdateDonorDetails.Size = new System.Drawing.Size(100, 55);
            this.btnUpdateDonorDetails.TabIndex = 41;
            this.btnUpdateDonorDetails.Text = "לעדכון פרטי תורם";
            this.btnUpdateDonorDetails.UseVisualStyleBackColor = true;
            this.btnUpdateDonorDetails.Click += new System.EventHandler(this.btnUpdateDonorDetails_Click);
            // 
            // FrmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 779);
            this.Controls.Add(this.btnUpdateDonorDetails);
            this.Controls.Add(this.txtNumCards);
            this.Controls.Add(this.lblNumCards);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.chooseCards);
            this.Controls.Add(this.btnBefore);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.btnGetDetailsDonors);
            this.Controls.Add(this.lblBookedCards);
            this.Controls.Add(this.dgBookedCards);
            this.Controls.Add(this.btnChoosePackage);
            this.Controls.Add(this.lblPackages);
            this.Controls.Add(this.dgPackages);
            this.Controls.Add(this.cmbMembers);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnPayments);
            this.Controls.Add(this.lblDonor);
            this.Controls.Add(this.dgDonor);
            this.Controls.Add(this.txtOrderAmount);
            this.Controls.Add(this.lblBp);
            this.Controls.Add(this.txtOrderCode);
            this.Controls.Add(this.txtIdDonor);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.lblIdDonor);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.lblOrderAmount);
            this.Controls.Add(this.lblOrderCode);
            this.Controls.Add(this.dgBookedPackages);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOrders";
            this.Text = "FrmOrders";
            this.Load += new System.EventHandler(this.FrmOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBookedPackages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDonor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPackages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookedCards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgBookedPackages;
        private System.Windows.Forms.Label lblOrderCode;
        private System.Windows.Forms.Label lblOrderAmount;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblIdDonor;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.TextBox txtIdDonor;
        private System.Windows.Forms.TextBox txtOrderCode;
        private System.Windows.Forms.Label lblBp;
        private System.Windows.Forms.TextBox txtOrderAmount;
        private System.Windows.Forms.DataGridView dgDonor;
        private System.Windows.Forms.Label lblDonor;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.ComboBox cmbMembers;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnChoosePackage;
        private System.Windows.Forms.Label lblPackages;
        private System.Windows.Forms.DataGridView dgPackages;
        private System.Windows.Forms.Label lblBookedCards;
        private System.Windows.Forms.DataGridView dgBookedCards;
        private System.Windows.Forms.Button btnGetDetailsDonors;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnBefore;
        private System.Windows.Forms.Button chooseCards;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtNumCards;
        private System.Windows.Forms.Label lblNumCards;
        private System.Windows.Forms.Button btnUpdateDonorDetails;
    }
}