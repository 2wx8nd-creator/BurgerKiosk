namespace BurgerKiosk
{
    partial class FormTitle
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAppName = new Label();
            rdoGalicBurger = new RadioButton();
            rdoBulBurger = new RadioButton();
            rdoHamBurger = new RadioButton();
            pbGalicBurger = new PictureBox();
            pbBulBurger = new PictureBox();
            pbHamBurger = new PictureBox();
            cbSauce = new CheckBox();
            cbCheese = new CheckBox();
            cbFrenchFries = new CheckBox();
            cbCola = new CheckBox();
            btnCancel = new Button();
            btnConfirm = new Button();
            lblTotalCost = new Label();
            lstCheckList = new ListBox();
            gbMainMenu = new GroupBox();
            gbSideMenu = new GroupBox();
            gbCheckList = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pbGalicBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBulBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHamBurger).BeginInit();
            gbMainMenu.SuspendLayout();
            gbSideMenu.SuspendLayout();
            gbCheckList.SuspendLayout();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 30F);
            lblAppName.Location = new Point(34, 26);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(371, 54);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "버거 주문 키오스크";
            // 
            // rdoGalicBurger
            // 
            rdoGalicBurger.AutoSize = true;
            rdoGalicBurger.Font = new Font("맑은 고딕", 14F);
            rdoGalicBurger.ForeColor = Color.Black;
            rdoGalicBurger.Location = new Point(17, 232);
            rdoGalicBurger.Name = "rdoGalicBurger";
            rdoGalicBurger.Size = new Size(113, 29);
            rdoGalicBurger.TabIndex = 5;
            rdoGalicBurger.TabStop = true;
            rdoGalicBurger.Text = "갈릭 버거";
            rdoGalicBurger.UseVisualStyleBackColor = true;
            // 
            // rdoBulBurger
            // 
            rdoBulBurger.AutoSize = true;
            rdoBulBurger.Font = new Font("맑은 고딕", 14F);
            rdoBulBurger.ForeColor = Color.Black;
            rdoBulBurger.Location = new Point(17, 144);
            rdoBulBurger.Name = "rdoBulBurger";
            rdoBulBurger.Size = new Size(132, 29);
            rdoBulBurger.TabIndex = 4;
            rdoBulBurger.TabStop = true;
            rdoBulBurger.Text = "불고기 버거";
            rdoBulBurger.UseVisualStyleBackColor = true;
            // 
            // rdoHamBurger
            // 
            rdoHamBurger.AutoSize = true;
            rdoHamBurger.Font = new Font("맑은 고딕", 14F);
            rdoHamBurger.ForeColor = Color.Black;
            rdoHamBurger.Location = new Point(17, 55);
            rdoHamBurger.Name = "rdoHamBurger";
            rdoHamBurger.Size = new Size(87, 29);
            rdoHamBurger.TabIndex = 3;
            rdoHamBurger.TabStop = true;
            rdoHamBurger.Text = "햄버거";
            rdoHamBurger.UseVisualStyleBackColor = true;
            // 
            // pbGalicBurger
            // 
            pbGalicBurger.Image = Properties.Resources.GB;
            pbGalicBurger.Location = new Point(174, 216);
            pbGalicBurger.Name = "pbGalicBurger";
            pbGalicBurger.Size = new Size(88, 69);
            pbGalicBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            pbGalicBurger.TabIndex = 2;
            pbGalicBurger.TabStop = false;
            // 
            // pbBulBurger
            // 
            pbBulBurger.Image = Properties.Resources.BB;
            pbBulBurger.Location = new Point(174, 127);
            pbBulBurger.Name = "pbBulBurger";
            pbBulBurger.Size = new Size(88, 70);
            pbBulBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBulBurger.TabIndex = 1;
            pbBulBurger.TabStop = false;
            // 
            // pbHamBurger
            // 
            pbHamBurger.Image = Properties.Resources.B;
            pbHamBurger.Location = new Point(174, 42);
            pbHamBurger.Name = "pbHamBurger";
            pbHamBurger.Size = new Size(88, 59);
            pbHamBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            pbHamBurger.TabIndex = 0;
            pbHamBurger.TabStop = false;
            // 
            // cbSauce
            // 
            cbSauce.AutoSize = true;
            cbSauce.Font = new Font("맑은 고딕", 12F);
            cbSauce.ForeColor = Color.Black;
            cbSauce.Location = new Point(19, 154);
            cbSauce.Name = "cbSauce";
            cbSauce.Size = new Size(93, 25);
            cbSauce.TabIndex = 3;
            cbSauce.Text = "소스추가";
            cbSauce.UseVisualStyleBackColor = true;
            // 
            // cbCheese
            // 
            cbCheese.AutoSize = true;
            cbCheese.Font = new Font("맑은 고딕", 12F);
            cbCheese.ForeColor = Color.Black;
            cbCheese.Location = new Point(19, 112);
            cbCheese.Name = "cbCheese";
            cbCheese.Size = new Size(93, 25);
            cbCheese.TabIndex = 2;
            cbCheese.Text = "치즈추가";
            cbCheese.UseVisualStyleBackColor = true;
            // 
            // cbFrenchFries
            // 
            cbFrenchFries.AutoSize = true;
            cbFrenchFries.Font = new Font("맑은 고딕", 12F);
            cbFrenchFries.ForeColor = Color.Black;
            cbFrenchFries.Location = new Point(19, 67);
            cbFrenchFries.Name = "cbFrenchFries";
            cbFrenchFries.Size = new Size(93, 25);
            cbFrenchFries.TabIndex = 1;
            cbFrenchFries.Text = "감자튀김";
            cbFrenchFries.UseVisualStyleBackColor = true;
            // 
            // cbCola
            // 
            cbCola.AutoSize = true;
            cbCola.Font = new Font("맑은 고딕", 12F);
            cbCola.ForeColor = Color.Black;
            cbCola.Location = new Point(19, 30);
            cbCola.Name = "cbCola";
            cbCola.Size = new Size(61, 25);
            cbCola.TabIndex = 0;
            cbCola.Text = "콜라";
            cbCola.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.Font = new Font("맑은 고딕", 12F);
            btnCancel.ForeColor = Color.FromArgb(0, 0, 64);
            btnCancel.Location = new Point(120, 279);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(87, 40);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "취소";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(0, 192, 0);
            btnConfirm.Font = new Font("맑은 고딕", 12F);
            btnConfirm.ForeColor = Color.FromArgb(0, 0, 64);
            btnConfirm.Location = new Point(25, 279);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(89, 40);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "주문";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Font = new Font("맑은 고딕", 14F);
            lblTotalCost.ForeColor = Color.Blue;
            lblTotalCost.Location = new Point(25, 234);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(104, 25);
            lblTotalCost.TabIndex = 1;
            lblTotalCost.Text = "총액 : 0 원";
            // 
            // lstCheckList
            // 
            lstCheckList.FormattingEnabled = true;
            lstCheckList.Location = new Point(25, 29);
            lstCheckList.Name = "lstCheckList";
            lstCheckList.Size = new Size(182, 193);
            lstCheckList.TabIndex = 0;
            // 
            // gbMainMenu
            // 
            gbMainMenu.Controls.Add(rdoGalicBurger);
            gbMainMenu.Controls.Add(rdoHamBurger);
            gbMainMenu.Controls.Add(rdoBulBurger);
            gbMainMenu.Controls.Add(pbHamBurger);
            gbMainMenu.Controls.Add(pbBulBurger);
            gbMainMenu.Controls.Add(pbGalicBurger);
            gbMainMenu.Font = new Font("맑은 고딕", 12F);
            gbMainMenu.ForeColor = Color.Olive;
            gbMainMenu.Location = new Point(34, 96);
            gbMainMenu.Name = "gbMainMenu";
            gbMainMenu.Size = new Size(281, 308);
            gbMainMenu.TabIndex = 7;
            gbMainMenu.TabStop = false;
            gbMainMenu.Text = "메인 메뉴";
            // 
            // gbSideMenu
            // 
            gbSideMenu.Controls.Add(cbSauce);
            gbSideMenu.Controls.Add(cbCola);
            gbSideMenu.Controls.Add(cbCheese);
            gbSideMenu.Controls.Add(cbFrenchFries);
            gbSideMenu.Font = new Font("맑은 고딕", 12F);
            gbSideMenu.ForeColor = Color.Olive;
            gbSideMenu.Location = new Point(336, 96);
            gbSideMenu.Name = "gbSideMenu";
            gbSideMenu.Size = new Size(144, 197);
            gbSideMenu.TabIndex = 8;
            gbSideMenu.TabStop = false;
            gbSideMenu.Text = "사이드 메뉴";
            // 
            // gbCheckList
            // 
            gbCheckList.Controls.Add(btnCancel);
            gbCheckList.Controls.Add(lstCheckList);
            gbCheckList.Controls.Add(btnConfirm);
            gbCheckList.Controls.Add(lblTotalCost);
            gbCheckList.Font = new Font("맑은 고딕", 12F);
            gbCheckList.ForeColor = Color.Green;
            gbCheckList.Location = new Point(525, 62);
            gbCheckList.Name = "gbCheckList";
            gbCheckList.Size = new Size(233, 342);
            gbCheckList.TabIndex = 9;
            gbCheckList.TabStop = false;
            gbCheckList.Text = "주문 내역";
            // 
            // FormTitle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbCheckList);
            Controls.Add(gbSideMenu);
            Controls.Add(gbMainMenu);
            Controls.Add(lblAppName);
            Name = "FormTitle";
            Text = "B";
            ((System.ComponentModel.ISupportInitialize)pbGalicBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBulBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHamBurger).EndInit();
            gbMainMenu.ResumeLayout(false);
            gbMainMenu.PerformLayout();
            gbSideMenu.ResumeLayout(false);
            gbSideMenu.PerformLayout();
            gbCheckList.ResumeLayout(false);
            gbCheckList.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private PictureBox pbGalicBurger;
        private PictureBox pbBulBurger;
        private PictureBox pbHamBurger;

        private RadioButton rdoHamBurger;
        private RadioButton rdoGalicBurger;
        private RadioButton rdoBulBurger;
        private CheckBox cbSauce;
        private CheckBox cbCheese;
        private CheckBox cbFrenchFries;
        private CheckBox cbCola;

        private ListBox lstCheckList;
        private Button btnConfirm;
        private Label lblTotalCost;
        private Button btnCancel;

        private GroupBox gbMainMenu;
        private GroupBox gbSideMenu;
        private GroupBox gbCheckList;
    }
}
