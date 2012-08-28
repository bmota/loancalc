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

        private void btnCalc_Click(object sender, EventArgs e)
        {
            DisplayAvgLoanBaseAndInterests();
            DisplayAvgLoanBase();
        }

        private void DisplayAvgLoanBaseAndInterests()
        {
            var calcUtil = new LoanCalcUtil(
                decimal.Parse(txtTotalLoanBase.Text.Trim()),
                int.Parse(cbxYears.Text),
                decimal.Parse(txtYearInterestRate.Text.Trim()),
                PayLoanType.AvgLoanBaseAndInterests,
                rbtnQuarterly.Checked ? PayCycleType.PerQuarter : PayCycleType.PerMonth);

            var theoryTotalInterests = calcUtil.CalcTotalInterest();
            txtInterestsForLoanBaseAndInterests.Text = theoryTotalInterests.ToString();

            var interests = calcUtil.CalcInterestForAvgLoanBaseAndInterests();
            var totalMoney = decimal.Parse(txtTotalLoanBase.Text.Trim()) + interests;

            txtCyclePayForInterests.Text = (totalMoney / calcUtil.Cycles).ToString();
        }

        private void DisplayAvgLoanBase()
        {
            var calcUtil = new LoanCalcUtil(
                    decimal.Parse(txtTotalLoanBase.Text.Trim()),
                    int.Parse(cbxYears.Text),
                    decimal.Parse(txtYearInterestRate.Text.Trim()),
                    PayLoanType.AvgLoanBase,
                    rbtnQuarterly.Checked ? PayCycleType.PerQuarter : PayCycleType.PerMonth);

            Dictionary<int, decimal> interestsDic = new Dictionary<int, decimal>();
            List<string> cyclePayList = new List<string>();


            decimal cycleInterest = 0.0M;
            decimal cycleLoanBase = decimal.Parse(txtTotalLoanBase.Text.Trim()) / calcUtil.Cycles;
            for (int cycle = 0; cycle < calcUtil.Cycles; cycle++)
            {
                cycleInterest = calcUtil.CalcInterestForAvgLoanBase(cycle);
                interestsDic.Add(cycle, cycleInterest);

                string cyclePay = string.Format("第 {0} {1}: 本金（{2}），利息（{3}），共（{4}）元;{5}",
                                    cycle + 1,
                                    calcUtil.PayCycle == PayCycleType.PerMonth ? "月" : "季",
                                    cycleLoanBase,
                                    cycleInterest,
                                    cycleLoanBase + cycleInterest,
                                    Environment.NewLine);
                cyclePayList.Add(cyclePay);
            }

            var totalInterests = interestsDic.Aggregate(0.0M, (seed, kvp) => { return seed + kvp.Value; });
            txtInterestsForLoanBase.Text = totalInterests.ToString();

            string showText = cyclePayList.Aggregate(string.Empty, (seed, cyclePay) => { return seed + cyclePay; });
            rtxtCyclePays.Text = showText;
        }
    }
}
