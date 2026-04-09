using static System.Net.Mime.MediaTypeNames;
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

        // 폼 전체에서 방향키를 감시하여 리스트 박스를 건너뛰는 핵심 로직
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Up || keyData == Keys.Down)
            {
                // 현재 포커스된 컨트롤 기준으로 다음 대상을 찾음
                Control next = this.GetNextControl(this.ActiveControl, keyData == Keys.Down);

                // [핵심] 다음 포커스 대상이 리스트 박스(lstCheckList)라면 한 번 더 건너뛰기
                if (next != null && next == lstCheckList)
                {
                    next = this.GetNextControl(next, keyData == Keys.Down);
                }

                if (next != null)
                {
                    next.Focus();
                    return true; // 기본 동작 방지
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
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

            // 메뉴 선택 로직
            if (rdoHamBurger.Checked)
            {
                totalCost += 5000;
                lstCheckList.Items.Add("햄버거 5,000원");
            }
            else if (rdoBulBurger.Checked)
            {
                totalCost += 4000;
                lstCheckList.Items.Add("불고기버거 4,000원");
            }
            else if (rdoGalicBurger.Checked)
            {
                totalCost += 3000;
                lstCheckList.Items.Add("갈릭버거 3,000원");
            }

            // 사이드 선택 로직
            if (cbFrenchFries.Checked)
            {
                totalCost += 3500;
                lstCheckList.Items.Add("감자튀김 3,500원");
            }
            if (cbCola.Checked)
            {
                totalCost += 2500;
                lstCheckList.Items.Add("콜라 2,500원");
            }
            if (cbCheese.Checked)
            {
                totalCost += 1500;
                lstCheckList.Items.Add("치즈추가 1,500원");
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
            lblTotalCost.ForeColor = Color.Blue;
        }

        // 기존의 모든 개별 KeyDown 함수들(rdoHamBurger_KeyDown 등)은 이제 지우셔도 무방합니다.
    }
}