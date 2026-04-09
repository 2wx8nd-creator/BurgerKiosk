

using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BurgerKiosk
{
    public partial class FormTitle : Form
    {
        int totalCost = 0;
        public FormTitle()
        {
            InitializeComponent();
        }
        

        private void rbHamBurger_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            totalCost = 0;
            lstCheckList.Items.Clear();
            bool isAnyBurgerSelected = rdoHamBurger.Checked || rdoBulBurger.Checked || rdoGalicBurger.Checked;
            bool isAnySideSelected = cbCola.Checked || cbFrenchFries.Checked || cbCheese.Checked || cbSauce.Checked;

            if (!isAnyBurgerSelected && !isAnySideSelected)
            {

                lblTotalCost.Text = "메뉴를 선택하세요";
                lblTotalCost.ForeColor = Color.Red;
                return;
            }

                lblTotalCost.ForeColor = Color.Blue;
                totalCost = 0;
                lstCheckList.Items.Clear();

                if (rdoHamBurger.Checked)
                {
                    totalCost += 5000;
                    lstCheckList.Items.Add("햄버거5,000원");
                }
                else if (rdoBulBurger.Checked)
                {
                    totalCost += 4000;
                    lstCheckList.Items.Add("불고기버거 4,000원");
                }
                else if (rdoGalicBurger.Checked)
                {
                    totalCost += 3000;
                    lstCheckList.Items.Add("갈릭버거 4,000원");

                }
                if (cbFrenchFries.Checked)
                {
                    totalCost += 3500;
                    lstCheckList.Items.Add("감자튀김3,500원");
                }
                if (cbCola.Checked)
                {
                    totalCost += 2500;
                    lstCheckList.Items.Add("콜라 2,500원");
                }
                if (cbCheese.Checked)
                {
                    totalCost += 1500;
                    lstCheckList.Items.Add("치즈추가 1,000원");
                }
                if (cbSauce.Checked)
                {
                    totalCost += 500;
                    lstCheckList.Items.Add("소스추가 500원");
                }


                lblTotalCost.Text = $"총액 : {totalCost:N0} 원";
            }
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            rdoHamBurger.Checked = false;
            rdoBulBurger.Checked = false;
            rdoGalicBurger.Checked = false;
            cbFrenchFries.Checked = false; 
            cbCola.Checked = false; 
            cbCheese.Checked = false; 
            cbSauce.Checked = false; 
            lstCheckList.Items.Clear(); 
            lblTotalCost.Text = "총액 : 0 원";
        }
    }
}
