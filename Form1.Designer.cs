namespace BurgerKiosk
{
    partial class BurgerKiosk
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
            rbGalicBurger = new RadioButton();
            rbBulBurger = new RadioButton();
            rbHamBurger = new RadioButton();
            pbGalicBurger = new PictureBox();
            pbBulBurger = new PictureBox();
            pbHamBurger = new PictureBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            cbFrenchFries = new CheckBox();
            cbCola = new CheckBox();
            btnCancel = new Button();
            btnConfirm = new Button();
            lblCalculate = new Label();
            lstbCheckList = new ListBox();
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
            // rbGalicBurger
            // 
            rbGalicBurger.AutoSize = true;
            rbGalicBurger.Font = new Font("맑은 고딕", 14F);
            rbGalicBurger.ForeColor = Color.Black;
            rbGalicBurger.Location = new Point(17, 232);
            rbGalicBurger.Name = "rbGalicBurger";
            rbGalicBurger.Size = new Size(113, 29);
            rbGalicBurger.TabIndex = 5;
            rbGalicBurger.TabStop = true;
            rbGalicBurger.Text = "갈릭 버거";
            rbGalicBurger.UseVisualStyleBackColor = true;
            // 
            // rbBulBurger
            // 
            rbBulBurger.AutoSize = true;
            rbBulBurger.Font = new Font("맑은 고딕", 14F);
            rbBulBurger.ForeColor = Color.Black;
            rbBulBurger.Location = new Point(17, 144);
            rbBulBurger.Name = "rbBulBurger";
            rbBulBurger.Size = new Size(132, 29);
            rbBulBurger.TabIndex = 4;
            rbBulBurger.TabStop = true;
            rbBulBurger.Text = "불고기 버거";
            rbBulBurger.UseVisualStyleBackColor = true;
            // 
            // rbHamBurger
            // 
            rbHamBurger.AutoSize = true;
            rbHamBurger.Font = new Font("맑은 고딕", 14F);
            rbHamBurger.ForeColor = Color.Black;
            rbHamBurger.Location = new Point(17, 55);
            rbHamBurger.Name = "rbHamBurger";
            rbHamBurger.Size = new Size(87, 29);
            rbHamBurger.TabIndex = 3;
            rbHamBurger.TabStop = true;
            rbHamBurger.Text = "햄버거";
            rbHamBurger.UseVisualStyleBackColor = true;
            rbHamBurger.CheckedChanged += rbHamBurger_CheckedChanged;
            // 
            // pbGalicBurger
            // 
            pbGalicBurger.Image = global::BurgerKiosk.Properties.Resources.GB;
            pbGalicBurger.Location = new Point(174, 216);
            pbGalicBurger.Name = "pbGalicBurger";
            pbGalicBurger.Size = new Size(88, 69);
            pbGalicBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            pbGalicBurger.TabIndex = 2;
            pbGalicBurger.TabStop = false;
            // 
            // pbBulBurger
            // 
            pbBulBurger.Image = global::BurgerKiosk.Properties.Resources.BB;
            pbBulBurger.Location = new Point(174, 127);
            pbBulBurger.Name = "pbBulBurger";
            pbBulBurger.Size = new Size(88, 70);
            pbBulBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBulBurger.TabIndex = 1;
            pbBulBurger.TabStop = false;
            // 
            // pbHamBurger
            // 
            pbHamBurger.Image = global::BurgerKiosk.Properties.Resources.B;
            pbHamBurger.Location = new Point(174, 42);
            pbHamBurger.Name = "pbHamBurger";
            pbHamBurger.Size = new Size(88, 59);
            pbHamBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            pbHamBurger.TabIndex = 0;
            pbHamBurger.TabStop = false;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("맑은 고딕", 12F);
            checkBox4.ForeColor = Color.Black;
            checkBox4.Location = new Point(19, 154);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(93, 25);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "소스추가";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("맑은 고딕", 12F);
            checkBox3.ForeColor = Color.Black;
            checkBox3.Location = new Point(19, 112);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(93, 25);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "치즈추가";
            checkBox3.UseVisualStyleBackColor = true;
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
            // 
            // lblCalculate
            // 
            lblCalculate.AutoSize = true;
            lblCalculate.Font = new Font("맑은 고딕", 14F);
            lblCalculate.ForeColor = Color.Blue;
            lblCalculate.Location = new Point(25, 234);
            lblCalculate.Name = "lblCalculate";
            lblCalculate.Size = new Size(171, 25);
            lblCalculate.TabIndex = 1;
            lblCalculate.Text = "메뉴를 선택하세요";
            // 
            // lstbCheckList
            // 
            lstbCheckList.FormattingEnabled = true;
            lstbCheckList.Location = new Point(25, 29);
            lstbCheckList.Name = "lstbCheckList";
            lstbCheckList.Size = new Size(182, 193);
            lstbCheckList.TabIndex = 0;
            // 
            // gbMainMenu
            // 
            gbMainMenu.Controls.Add(rbGalicBurger);
            gbMainMenu.Controls.Add(rbHamBurger);
            gbMainMenu.Controls.Add(rbBulBurger);
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
            gbSideMenu.Controls.Add(checkBox4);
            gbSideMenu.Controls.Add(cbCola);
            gbSideMenu.Controls.Add(checkBox3);
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
            gbCheckList.Controls.Add(lstbCheckList);
            gbCheckList.Controls.Add(btnConfirm);
            gbCheckList.Controls.Add(lblCalculate);
            gbCheckList.Font = new Font("맑은 고딕", 12F);
            gbCheckList.ForeColor = Color.Green;
            gbCheckList.Location = new Point(525, 62);
            gbCheckList.Name = "gbCheckList";
            gbCheckList.Size = new Size(233, 342);
            gbCheckList.TabIndex = 9;
            gbCheckList.TabStop = false;
            gbCheckList.Text = "주문 내역";
            // 
            // BurgerKiosk
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbCheckList);
            Controls.Add(gbSideMenu);
            Controls.Add(gbMainMenu);
            Controls.Add(lblAppName);
            Name = "BurgerKiosk";
            Text = "BurgerKiosk";
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
        private RadioButton rbHamBurger;
        private RadioButton rbGalicBurger;
        private RadioButton rbBulBurger;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox cbFrenchFries;
        private CheckBox cbCola;
        private ListBox lstbCheckList;
        private Button btnConfirm;
        private Label lblCalculate;
        private Button btnCancel;
        private GroupBox gbMainMenu;
        private GroupBox gbSideMenu;
        private GroupBox gbCheckList;
    }
}
