using ScottyApps.LoanCalc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ScottyApps.LoanCalc.LoanCalcTest
{
    public class LoanCalcUtilTextContext : TestContext
    {
        public override void AddResultFile(string fileName)
        {
            throw new NotImplementedException();
        }

        public override void BeginTimer(string timerName)
        {
            throw new NotImplementedException();
        }

        public override System.Data.Common.DbConnection DataConnection
        {
            get { throw new NotImplementedException(); }
        }

        public override System.Data.DataRow DataRow
        {
            get { throw new NotImplementedException(); }
        }

        public override void EndTimer(string timerName)
        {
            throw new NotImplementedException();
        }

        public override System.Collections.IDictionary Properties
        {
            get { throw new NotImplementedException(); }
        }

        public override void WriteLine(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public LoanCalcUtil AvgLoanBaseInMthUtil { get; set; }
        public LoanCalcUtil AvgLoanBaseInQtrUtil { get; set; }
        public LoanCalcUtil AvgLoanBaseMthUtil { get; set; }
        public LoanCalcUtil AvgLoanBaseQtrUtil { get; set; }
    }

    [TestClass()]
    public class LoanCalcUtilTest
    {


        public LoanCalcUtilTextContext TestContext
        {
            get;
            set;
        }

        #region 附加测试特性
        // 
        //编写测试时，还可使用以下特性:
        //
        //使用 ClassInitialize 在运行类中的第一个测试前先运行代码
        [ClassInitialize()]
        public static void MyClassInitialize(LoanCalcUtilTextContext context)
        {
            Decimal loanBase = 200000M;
            int years = 10;
            Decimal interestRate = 0.0558M;

            context.AvgLoanBaseInMthUtil = new LoanCalcUtil(loanBase, years, interestRate,
                PayLoanType.AvgLoanBaseAndInterests, PayCycleType.PerMonth);
            context.AvgLoanBaseInQtrUtil = new LoanCalcUtil(loanBase, years, interestRate,
                PayLoanType.AvgLoanBaseAndInterests, PayCycleType.PerQuarter);
            context.AvgLoanBaseMthUtil = new LoanCalcUtil(loanBase, years, interestRate,
                PayLoanType.AvgLoanBase, PayCycleType.PerMonth);
            context.AvgLoanBaseQtrUtil = new LoanCalcUtil(loanBase, years, interestRate,
                PayLoanType.AvgLoanBase, PayCycleType.PerQuarter);
        }
        //
        //使用 ClassCleanup 在运行完类中的所有测试后再运行代码
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //使用 TestInitialize 在运行每个测试前先运行代码
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //使用 TestCleanup 在运行完每个测试后运行代码
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        [TestMethod()]
        public void CalcInterestTest()
        {
            //int whichCycle = 0; // TODO: 初始化为适当的值
            //Decimal expected = 2790M;
            //Decimal actual;
            //actual = TestContext..CalcInterest(whichCycle);
            //Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("验证此测试方法的正确性。");
        }

        [TestMethod()]
        public void CalcInterestForAvgLoanBaseTest()
        {
            //Decimal loanBase = new Decimal(); // TODO: 初始化为适当的值
            //int years = 0; // TODO: 初始化为适当的值
            //Decimal interestRate = new Decimal(); // TODO: 初始化为适当的值
            //PayLoanType payLoan = new PayLoanType(); // TODO: 初始化为适当的值
            //PayCycleType cycleType = new PayCycleType(); // TODO: 初始化为适当的值
            //LoanCalcUtil target = new LoanCalcUtil(loanBase, years, interestRate, payLoan, cycleType); // TODO: 初始化为适当的值
            //int whichCycle = 0; // TODO: 初始化为适当的值
            //Decimal expected = new Decimal(); // TODO: 初始化为适当的值
            //Decimal actual;
            //actual = target.CalcInterestForAvgLoanBase(whichCycle);
            //Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("验证此测试方法的正确性。");
        }

        [TestMethod()]
        public void CalcInterestForAvgLoanBaseAndInterestsTest()
        {
            //Decimal loanBase = new Decimal(); // TODO: 初始化为适当的值
            //int years = 0; // TODO: 初始化为适当的值
            //Decimal interestRate = new Decimal(); // TODO: 初始化为适当的值
            //PayLoanType payLoan = new PayLoanType(); // TODO: 初始化为适当的值
            //PayCycleType cycleType = new PayCycleType(); // TODO: 初始化为适当的值
            //LoanCalcUtil target = new LoanCalcUtil(loanBase, years, interestRate, payLoan, cycleType); // TODO: 初始化为适当的值
            //Decimal expected = new Decimal(); // TODO: 初始化为适当的值
            //Decimal actual;
            //actual = target.CalcInterestForAvgLoanBaseAndInterests();
            //Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("验证此测试方法的正确性。");
        }

        [TestMethod()]
        public void CalcTotalInterestTest()
        {
            //Decimal loanBase = new Decimal(); // TODO: 初始化为适当的值
            //int years = 0; // TODO: 初始化为适当的值
            //Decimal interestRate = new Decimal(); // TODO: 初始化为适当的值
            //PayLoanType payLoan = new PayLoanType(); // TODO: 初始化为适当的值
            //PayCycleType cycleType = new PayCycleType(); // TODO: 初始化为适当的值
            //LoanCalcUtil target = new LoanCalcUtil(loanBase, years, interestRate, payLoan, cycleType); // TODO: 初始化为适当的值
            //Decimal expected = new Decimal(); // TODO: 初始化为适当的值
            //Decimal actual;
            //actual = target.CalcTotalInterest();
            //Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("验证此测试方法的正确性。");
        }
    }
}
