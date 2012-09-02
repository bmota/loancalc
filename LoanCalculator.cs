using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScottyApps.LoanCalc
{
    public partial class LoanCalculator : Form
    {
        const string MSG_WELCOME = "欢迎使用scotty开发的贷款计数器，技术含量不高，仅希望以作便利之用！";
        public LoanCalculator()
        {
            InitializeComponent();
        }

        private void LoanCalculator_Load(object sender, EventArgs e)
        {
            BindYearsCount();
        }

        private void BindYearsCount()
        {
            cbxYears.DataSource = Enumerable.Range(1, 30).ToList();
            cbxYears.SelectedIndex = (cbxYears.Items.Count - 1) / 2;
        }

        private bool ValidateUI()
        {
            if (string.IsNullOrEmpty(txtTotalLoanBase.Text.Trim()))
            {
                lblMsg.Text = "请先输入贷款金额";
                return false;
            }
            double loanBase = 0;
            if (!double.TryParse(txtTotalLoanBase.Text.Trim(), out loanBase))
            {
                lblMsg.Text = "贷款金额必须为数字";
                return false;
            }
            if (string.IsNullOrEmpty(txtYearInterestRate.Text.Trim()))
            {
                lblMsg.Text = "请先输入贷款年利率";
                return false;
            }
            double interestRatio = 0;
            if (!double.TryParse(txtYearInterestRate.Text.Trim(), out interestRatio))
            {
                lblMsg.Text = "贷款年利率必须为数字";
                return false;
            }

            return true;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (!ValidateUI())
            {
                return;
            }

            lblMsg.Text = MSG_WELCOME;

            DisplayAvgLoanBaseAndInterests();
            DisplayAvgLoanBase();
        }

        private void DisplayAvgLoanBaseAndInterests()
        {
            var calcUtil = new LoanCalcUtil(
                10000 * decimal.Parse(txtTotalLoanBase.Text.Trim()),
                int.Parse(cbxYears.Text),
                0.01M * decimal.Parse(txtYearInterestRate.Text.Trim()),
                PayLoanType.AvgLoanBaseAndInterests,
                rbtnQuarterly.Checked ? PayCycleType.PerQuarter : PayCycleType.PerMonth);

            var cyclePay = calcUtil.CalcCyclePayForAvgLoanBaseAndInterests();
            txtCyclePayForInterests.Text = cyclePay.ToString("F2");
            txtInterestsForLoanBaseAndInterests.Text = (cyclePay * calcUtil.Cycles - (double)calcUtil.TotalLoanBase).ToString("F2");
        }

        private void DisplayAvgLoanBase()
        {
            var calcUtil = new LoanCalcUtil(
                    10000 * decimal.Parse(txtTotalLoanBase.Text.Trim()),
                    int.Parse(cbxYears.Text),
                    0.01M * decimal.Parse(txtYearInterestRate.Text.Trim()),
                    PayLoanType.AvgLoanBase,
                    rbtnQuarterly.Checked ? PayCycleType.PerQuarter : PayCycleType.PerMonth);

            Dictionary<int, decimal> interestsDic = new Dictionary<int, decimal>();
            List<string> cyclePayList = new List<string>();


            decimal cycleInterest = 0.0M;
            decimal cycleLoanBase = calcUtil.TotalLoanBase / calcUtil.Cycles;
            for (int cycle = 0; cycle < calcUtil.Cycles; cycle++)
            {
                cycleInterest = calcUtil.CalcInterestForAvgLoanBase(cycle);
                interestsDic.Add(cycle, cycleInterest);

                string cyclePay = string.Format("第 {0} {1}: 本金（{2:F2}），利息（{3:F2}），共（{4:F2}）元;{5}",
                                    cycle + 1,
                                    calcUtil.PayCycle == PayCycleType.PerMonth ? "月" : "季",
                                    cycleLoanBase,
                                    cycleInterest,
                                    cycleLoanBase + cycleInterest,
                                    Environment.NewLine);
                cyclePayList.Add(cyclePay);
            }

            var totalInterests = interestsDic.Aggregate(0.0M, (seed, kvp) => { return seed + kvp.Value; });
            txtInterestsForLoanBase.Text = totalInterests.ToString("F2");

            string showText = cyclePayList.Aggregate(string.Empty, (seed, cyclePay) => { return seed + cyclePay; });
            rtxtCyclePays.Text = showText;
        }
    }
}
