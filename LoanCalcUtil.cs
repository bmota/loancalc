using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScottyApps.LoanCalc
{
    public class LoanCalcUtil
    {
        public decimal TotalLoanBase { get; set; }
        public int YearCount { get; set; }
        public decimal YearInterestRate { get; set; }
        public PayLoanType PayLoan { get; set; }

        private PayCycleType _payCycle;
        public PayCycleType PayCycle
        {
            get { return this._payCycle; }
            set
            {
                this._payCycle = value;
                _cycles = -1;
            }
        }
        private int _cycles = -1;
        public int Cycles
        {
            get
            {
                if (_cycles == -1)
                {
                    switch (this.PayCycle)
                    {
                        case PayCycleType.PerMonth:
                            _cycles = this.YearCount * 12;
                            break;
                        case PayCycleType.PerQuarter:
                            _cycles = this.YearCount * 12 / 3;
                            break;
                    }
                }

                return _cycles;
            }
        }

        public LoanCalcUtil(decimal loanBase, int years, decimal interestRate, PayLoanType payLoan, PayCycleType cycleType)
        {
            this.TotalLoanBase = loanBase;
            this.YearCount = years;
            this.YearInterestRate = interestRate;
            this.PayLoan = payLoan;
            this.PayCycle = cycleType;
        }

        public decimal CalcInterest(int whichCycle)
        {
            // TODO should validate if cycle is in range (less than total cycles)
            switch (this.PayLoan)
            {
                default:
                    return 0.0M;
                case PayLoanType.AvgLoanBase:
                    return CalcInterestForAvgLoanBase(whichCycle);
                case PayLoanType.AvgLoanBaseAndInterests:
                    return CalcInterestForAvgLoanBaseAndInterests();
            }
        }

        public decimal CalcInterestForAvgLoanBaseAndInterests()
        {
            var totalInterests = CalcTotalInterest();
            var totalMoney = this.TotalLoanBase + totalInterests;

            return totalMoney / Cycles;
        }
        public decimal CalcInterestForAvgLoanBase(int whichCycle)
        {
            var payBase = this.TotalLoanBase / this.Cycles;
            var paidBase = (whichCycle - 1) * payBase;
            var remainBase = this.TotalLoanBase - paidBase;
            var interestRate = PayCycle == PayCycleType.PerMonth ? YearInterestRate / 12 : YearInterestRate / 4;
            var payInterest = remainBase * interestRate;

            return payBase + payInterest;
        }


        public decimal CalcTotalInterest()
        {
            return
                this.TotalLoanBase * this.YearInterestRate * this.YearCount;
        }
    }

    public enum PayLoanType
    {
        AvgLoanBaseAndInterests = 0,
        AvgLoanBase
    }
    public enum PayCycleType
    {
        PerMonth = 0,
        PerQuarter
    }
}
