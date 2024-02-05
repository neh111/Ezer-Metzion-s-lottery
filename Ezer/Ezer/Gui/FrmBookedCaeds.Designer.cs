namespace Ezer.Gui
{
    partial class FrmBookedCaeds
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
            this.dgBookedCards = new System.Windows.Forms.DataGridView();
            this.btnShowCards = new System.Windows.Forms.Button();
            this.btnSaveNumCards = new System.Windows.Forms.Button();
            this.lblRestCards = new System.Windows.Forms.Label();
            this.txtRestCards = new System.Windows.Forms.TextBox();
            this.lblCardCode = new System.Windows.Forms.Label();
            this.lblCardName = new System.Windows.Forms.Label();
            this.txtCardName = new System.Windows.Forms.TextBox();
            this.txtCardCode = new System.Windows.Forms.TextBox();
            this.lblNumCards = new System.Windows.Forms.Label();
            this.txtNumCards = new System.Windows.Forms.TextBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBefore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookedCards)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(704, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "הזמנת כרטיסים";
            // 
            // dgBookedCards
            // 
            this.dgBookedCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBookedCards.Location = new System.Drawing.Point(272, 101);
            this.dgBookedCards.Name = "dgBookedCards";
            this.dgBookedCards.Size = new System.Drawing.Size(413, 222);
            this.dgBookedCards.TabIndex = 1;
            // 
            // btnShowCards
            // 
            this.btnShowCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnShowCards.Location = new System.Drawing.Point(467, 358);
            this.btnShowCards.Name = "btnShowCards";
            this.btnShowCards.Size = new System.Drawing.Size(134, 58);
            this.btnShowCards.TabIndex = 2;
            this.btnShowCards.Text = "הצג את הכרטיסים האפשריים";
            this.btnShowCards.UseVisualStyleBackColor = true;
            this.btnShowCards.Click += new System.EventHandler(this.btnShowCards_Click);
            // 
            // btnSaveNumCards
            // 
            this.btnSaveNumCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSaveNumCards.Location = new System.Drawing.Point(467, 443);
            this.btnSaveNumCards.Name = "btnSaveNumCards";
            this.btnSaveNumCards.Size = new System.Drawing.Size(75, 40);
            this.btnSaveNumCards.TabIndex = 3;
            this.btnSaveNumCards.Text = "שמור";
            this.btnSaveNumCards.UseVisualStyleBackColor = true;
            this.btnSaveNumCards.Click += new System.EventHandler(this.btnSaveBookedCards_Click);
            // 
            // lblRestCards
            // 
            this.lblRestCards.AutoSize = true;
            this.lblRestCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblRestCards.Location = new System.Drawing.Point(1108, 127);
            this.lblRestCards.Name = "lblRestCards";
            this.lblRestCards.Size = new System.Drawing.Size(254, 20);
            this.lblRestCards.TabIndex = 4;
            this.lblRestCards.Text = "מספר הכרטיסים שנותר לך לבחור";
            // 
            // txtRestCards
            // 
            this.txtRestCards.Location = new System.Drawing.Point(1226, 177);
            this.txtRestCards.Name = "txtRestCards";
            this.txtRestCards.Size = new System.Drawing.Size(100, 20);
            this.txtRestCards.TabIndex = 5;
            // 
            // lblCardCode
            // 
            this.lblCardCode.AutoSize = true;
            this.lblCardCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCardCode.Location = new System.Drawing.Point(861, 127);
            this.lblCardCode.Name = "lblCardCode";
            this.lblCardCode.Size = new System.Drawing.Size(77, 20);
            this.lblCardCode.TabIndex = 6;
            this.lblCardCode.Text = "קוד כרטיס";
            // 
            // lblCardName
            // 
            this.lblCardName.AutoSize = true;
            this.lblCardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCardName.Location = new System.Drawing.Point(864, 177);
            this.lblCardName.Name = "lblCardName";
            this.lblCardName.Size = new System.Drawing.Size(74, 20);
            this.lblCardName.TabIndex = 7;
            this.lblCardName.Text = "שם כרטיס";
            // 
            // txtCardName
            // 
            this.txtCardName.Location = new System.Drawing.Point(727, 177);
            this.txtCardName.Name = "txtCardName";
            this.txtCardName.Size = new System.Drawing.Size(100, 20);
            this.txtCardName.TabIndex = 8;
            // 
            // txtCardCode
            // 
            this.txtCardCode.Location = new System.Drawing.Point(727, 129);
            this.txtCardCode.Name = "txtCardCode";
            this.txtCardCode.Size = new System.Drawing.Size(100, 20);
            this.txtCardCode.TabIndex = 9;
            // 
            // lblNumCards
            // 
            this.lblNumCards.AutoSize = true;
            this.lblNumCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblNumCards.Location = new System.Drawing.Point(1024, 323);
            this.lblNumCards.Name = "lblNumCards";
            this.lblNumCards.Size = new System.Drawing.Size(404, 20);
            this.lblNumCards.TabIndex = 10;
            this.lblNumCards.Text = "הקש את כמות הכרטיסים מסוג זה שאתה מעונין לרכוש";
            // 
            // txtNumCards
            // 
            this.txtNumCards.Location = new System.Drawing.Point(1237, 358);
            this.txtNumCards.Name = "txtNumCards";
            this.txtNumCards.Size = new System.Drawing.Size(100, 20);
            this.txtNumCards.TabIndex = 11;
            // 
            // btnChoose
            // 
            this.btnChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnChoose.Location = new System.Drawing.Point(367, 358);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(75, 58);
            this.btnChoose.TabIndex = 12;
            this.btnChoose.Text = "בחר כרטיס";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnShow.Location = new System.Drawing.Point(358, 444);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 39);
            this.btnShow.TabIndex = 13;
            this.btnShow.Text = "הצג";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnNext.Location = new System.Drawing.Point(272, 358);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 55);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "הכרטיס הבא";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBefore
            // 
            this.btnBefore.Location = new System.Drawing.Point(1237, 25);
            this.btnBefore.Name = "btnBefore";
            this.btnBefore.Size = new System.Drawing.Size(75, 54);
            this.btnBefore.TabIndex = 15;
            this.btnBefore.Text = "חזרה לטופס קודם";
            this.btnBefore.UseVisualStyleBackColor = true;
            this.btnBefore.Click += new System.EventHandler(this.btnBefore_Click);
            // 
            // FrmBookedCaeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1820, 636);
            this.Controls.Add(this.btnBefore);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.txtNumCards);
            this.Controls.Add(this.lblNumCards);
            this.Controls.Add(this.txtCardCode);
            this.Controls.Add(this.txtCardName);
            this.Controls.Add(this.lblCardName);
            this.Controls.Add(this.lblCardCode);
            this.Controls.Add(this.txtRestCards);
            this.Controls.Add(this.lblRestCards);
            this.Controls.Add(this.btnSaveNumCards);
            this.Controls.Add(this.btnShowCards);
            this.Controls.Add(this.dgBookedCards);
            this.Controls.Add(this.label1);
            this.Name = "FrmBookedCaeds";
            this.Text = "FrmBookedCaeds";
            this.Load += new System.EventHandler(this.FrmBookedCaeds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBookedCards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgBookedCards;
        private System.Windows.Forms.Button btnShowCards;
        private System.Windows.Forms.Button btnSaveNumCards;
        private System.Windows.Forms.Label lblRestCards;
        private System.Windows.Forms.TextBox txtRestCards;
        private System.Windows.Forms.Label lblCardCode;
        private System.Windows.Forms.Label lblCardName;
        private System.Windows.Forms.TextBox txtCardName;
        private System.Windows.Forms.TextBox txtCardCode;
        private System.Windows.Forms.Label lblNumCards;
        private System.Windows.Forms.TextBox txtNumCards;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBefore;
    }
}