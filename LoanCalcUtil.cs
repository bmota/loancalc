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
        //private decimal _cycleInterestRatio = 0.0M;
        public decimal CycleInterestRatio
        {
            get
            {
                //if (_cycleInterestRatio == 0.0M)
                //{
                return
                    //_cycleInterestRatio =
                        (PayCycle == PayCycleType.PerMonth)
                            ? YearInterestRate / 12
                            : YearInterestRate / 4;
                //}
                //return _cycleInterestRatio;
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

        public decimal CalcInterestForAvgLoanBase(int whichCycle)
        {
            var payBase = this.TotalLoanBase / this.Cycles;
            var paidBase = whichCycle * payBase;
            var remainBase = this.TotalLoanBase - paidBase;
            var payInterest = remainBase * CycleInterestRatio;

            return payInterest;
        }

        public double CalcCyclePayForAvgLoanBaseAndInterests()
        {
            // NOTE based on below algorithm (http://baike.baidu.com/view/1180521.htm#3):
            // 等额本息还款公式推导 设贷款总额为A，银行月利率为β，总期数为m（个月），月还款额设为X，
            // 则各个月所欠银行贷款为：
            // 第一个月A(1+β)-X]
            // 第二个月[A(1+β)-X](1+β)-X = A(1+β)^2-X[1+(1+β)]
            // 第三个月{[A(1+β)-X](1+β)-X}(1+β)-X = A(1+β)^3-X[1+(1+β)+(1+β)^2]
            // …
            // 由此可得第n个月后所欠银行贷款为：
            // A(1+β)^n-X[1+(1+β)+(1+β)^2+…+(1+β)^(n-1)] = A(1+β)^n-X[(1+β)^n-1]/β
            // 由于还款总期数为m，也即第m月刚好还完银行所有贷款，因此有：
            // A(1+β)^m-X[(1+β)^m-1]/β = 0
            // 由此求得：
            // X = Aβ(1+β)^m/[(1+β)^m-1]
            double cyclePay = 0;

            var temp = System.Math.Pow((double)(1 + this.CycleInterestRatio), (double)Cycles);
            cyclePay = ((double)this.TotalLoanBase) * ((double)this.CycleInterestRatio) * temp / (temp - 1);

            
            return cyclePay;
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
