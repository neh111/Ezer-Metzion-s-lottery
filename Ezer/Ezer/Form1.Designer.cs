namespace Ezer
{
    partial class Form1
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
            this.btnOffice = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.lblSisma = new System.Windows.Forms.Label();
            this.txtSisma = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnDonors = new System.Windows.Forms.Button();
            this.btnCards = new System.Windows.Forms.Button();
            this.btnPackages = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnBusinessOwner = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.BtnOrders = new System.Windows.Forms.Button();
            this.btnWinners = new System.Windows.Forms.Button();
            this.btnBefore = new System.Windows.Forms.Button();
            this.btnFrmProducts = new System.Windows.Forms.Button();
            this.lblIfNew = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOffice
            // 
            this.btnOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnOffice.Location = new System.Drawing.Point(1265, 190);
            this.btnOffice.Margin = new System.Windows.Forms.Padding(4);
            this.btnOffice.Name = "btnOffice";
            this.btnOffice.Size = new System.Drawing.Size(148, 75);
            this.btnOffice.TabIndex = 0;
            this.btnOffice.Text = "לכניסת מזכירה";
            this.btnOffice.UseVisualStyleBackColor = true;
            this.btnOffice.Click += new System.EventHandler(this.btnOffice_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCustomer.Location = new System.Drawing.Point(540, 188);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(128, 77);
            this.btnCustomer.TabIndex = 1;
            this.btnCustomer.Text = "לתרומות";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // lblSisma
            // 
            this.lblSisma.AutoSize = true;
            this.lblSisma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSisma.Location = new System.Drawing.Point(1352, 338);
            this.lblSisma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSisma.Name = "lblSisma";
            this.lblSisma.Size = new System.Drawing.Size(107, 25);
            this.lblSisma.TabIndex = 2;
            this.lblSisma.Text = "הקש סיסמה";
            this.lblSisma.Visible = false;
            // 
            // txtSisma
            // 
            this.txtSisma.Location = new System.Drawing.Point(1197, 338);
            this.txtSisma.Margin = new System.Windows.Forms.Padding(4);
            this.txtSisma.Name = "txtSisma";
            this.txtSisma.Size = new System.Drawing.Size(132, 22);
            this.txtSisma.TabIndex = 3;
            this.txtSisma.UseSystemPasswordChar = true;
            this.txtSisma.Visible = false;
            this.txtSisma.TextChanged += new System.EventHandler(this.txtSisma_TextChanged);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnOk.Location = new System.Drawing.Point(1217, 384);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(92, 46);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Visible = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnDonors
            // 
            this.btnDonors.Location = new System.Drawing.Point(1072, 190);
            this.btnDonors.Margin = new System.Windows.Forms.Padding(4);
            this.btnDonors.Name = "btnDonors";
            this.btnDonors.Size = new System.Drawing.Size(100, 54);
            this.btnDonors.TabIndex = 8;
            this.btnDonors.Text = "לטופס תורמים";
            this.btnDonors.UseVisualStyleBackColor = true;
            this.btnDonors.Click += new System.EventHandler(this.btnDonors_Click);
            // 
            // btnCards
            // 
            this.btnCards.Location = new System.Drawing.Point(1072, 252);
            this.btnCards.Margin = new System.Windows.Forms.Padding(4);
            this.btnCards.Name = "btnCards";
            this.btnCards.Size = new System.Drawing.Size(100, 59);
            this.btnCards.TabIndex = 9;
            this.btnCards.Text = "לטופס כרטיסים";
            this.btnCards.UseVisualStyleBackColor = true;
            this.btnCards.Click += new System.EventHandler(this.btnCards_Click);
            // 
            // btnPackages
            // 
            this.btnPackages.Location = new System.Drawing.Point(1072, 322);
            this.btnPackages.Margin = new System.Windows.Forms.Padding(4);
            this.btnPackages.Name = "btnPackages";
            this.btnPackages.Size = new System.Drawing.Size(100, 59);
            this.btnPackages.TabIndex = 10;
            this.btnPackages.Text = "עדכון חבילות";
            this.btnPackages.UseVisualStyleBackColor = true;
            this.btnPackages.Click += new System.EventHandler(this.btnPackages_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1924, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnBusinessOwner
            // 
            this.btnBusinessOwner.Location = new System.Drawing.Point(1072, 402);
            this.btnBusinessOwner.Margin = new System.Windows.Forms.Padding(4);
            this.btnBusinessOwner.Name = "btnBusinessOwner";
            this.btnBusinessOwner.Size = new System.Drawing.Size(100, 65);
            this.btnBusinessOwner.TabIndex = 14;
            this.btnBusinessOwner.Text = "לטופס תורמי מוצרים";
            this.btnBusinessOwner.UseVisualStyleBackColor = true;
            this.btnBusinessOwner.Click += new System.EventHandler(this.btnBusinessOwner_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.Location = new System.Drawing.Point(1072, 475);
            this.btnMembers.Margin = new System.Windows.Forms.Padding(4);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(100, 62);
            this.btnMembers.TabIndex = 15;
            this.btnMembers.Text = "לטופס נאמנות";
            this.btnMembers.UseVisualStyleBackColor = true;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // BtnOrders
            // 
            this.BtnOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BtnOrders.Location = new System.Drawing.Point(365, 446);
            this.BtnOrders.Margin = new System.Windows.Forms.Padding(4);
            this.BtnOrders.Name = "BtnOrders";
            this.BtnOrders.Size = new System.Drawing.Size(123, 59);
            this.BtnOrders.TabIndex = 17;
            this.BtnOrders.Text = "להזמנות";
            this.BtnOrders.UseVisualStyleBackColor = true;
            this.BtnOrders.Click += new System.EventHandler(this.BtnOrders_Click);
            // 
            // btnWinners
            // 
            this.btnWinners.Location = new System.Drawing.Point(1072, 544);
            this.btnWinners.Margin = new System.Windows.Forms.Padding(4);
            this.btnWinners.Name = "btnWinners";
            this.btnWinners.Size = new System.Drawing.Size(100, 68);
            this.btnWinners.TabIndex = 18;
            this.btnWinners.Text = "לטופס מגרילים";
            this.btnWinners.UseVisualStyleBackColor = true;
            this.btnWinners.Click += new System.EventHandler(this.btnWinners_Click);
            // 
            // btnBefore
            // 
            this.btnBefore.Location = new System.Drawing.Point(1456, 100);
            this.btnBefore.Margin = new System.Windows.Forms.Padding(4);
            this.btnBefore.Name = "btnBefore";
            this.btnBefore.Size = new System.Drawing.Size(92, 60);
            this.btnBefore.TabIndex = 19;
            this.btnBefore.Text = "חזרה לטופס קודם";
            this.btnBefore.UseVisualStyleBackColor = true;
            this.btnBefore.Click += new System.EventHandler(this.btnBefore_Click);
            // 
            // btnFrmProducts
            // 
            this.btnFrmProducts.Location = new System.Drawing.Point(1072, 132);
            this.btnFrmProducts.Margin = new System.Windows.Forms.Padding(4);
            this.btnFrmProducts.Name = "btnFrmProducts";
            this.btnFrmProducts.Size = new System.Drawing.Size(100, 50);
            this.btnFrmProducts.TabIndex = 20;
            this.btnFrmProducts.Text = "לטופס מוצרים";
            this.btnFrmProducts.UseVisualStyleBackColor = true;
            this.btnFrmProducts.Click += new System.EventHandler(this.btnFrmProducts_Click);
            // 
            // lblIfNew
            // 
            this.lblIfNew.AutoSize = true;
            this.lblIfNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblIfNew.ForeColor = System.Drawing.Color.DarkRed;
            this.lblIfNew.Location = new System.Drawing.Point(143, 252);
            this.lblIfNew.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIfNew.Name = "lblIfNew";
            this.lblIfNew.Size = new System.Drawing.Size(321, 25);
            this.lblIfNew.TabIndex = 21;
            this.lblIfNew.Text = "?האם תרמת פעם באמצעות מערכת זו";
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(397, 298);
            this.btnYes.Margin = new System.Windows.Forms.Padding(4);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(100, 28);
            this.btnYes.TabIndex = 22;
            this.btnYes.Text = "כן";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(272, 298);
            this.btnNo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(100, 28);
            this.btnNo.TabIndex = 23;
            this.btnNo.Text = "לא";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblId.Location = new System.Drawing.Point(360, 357);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(141, 25);
            this.lblId.TabIndex = 24;
            this.lblId.Text = "הקש תעודת זהות";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(365, 396);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(132, 22);
            this.txtId.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 777);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblIfNew);
            this.Controls.Add(this.btnFrmProducts);
            this.Controls.Add(this.btnBefore);
            this.Controls.Add(this.btnWinners);
            this.Controls.Add(this.BtnOrders);
            this.Controls.Add(this.btnMembers);
            this.Controls.Add(this.btnBusinessOwner);
            this.Controls.Add(this.btnPackages);
            this.Controls.Add(this.btnCards);
            this.Controls.Add(this.btnDonors);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtSisma);
            this.Controls.Add(this.lblSisma);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnOffice);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOffice;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Label lblSisma;
        private System.Windows.Forms.TextBox txtSisma;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnDonors;
        private System.Windows.Forms.Button btnCards;
        private System.Windows.Forms.Button btnPackages;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnBusinessOwner;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button BtnOrders;
        private System.Windows.Forms.Button btnWinners;
        private System.Windows.Forms.Button btnBefore;
        private System.Windows.Forms.Button btnFrmProducts;
        private System.Windows.Forms.Label lblIfNew;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
    }
}

