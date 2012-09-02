using ScottyApps.LoanCalc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ScottyApps.LoanCalc.LoanCalcTest
{
    [TestClass()]
    public class LoanCalcUtilTest
    {
        private TestContext testContextInstance;
        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        LoanCalcUtil avgLoanBaseInMthUtil;
        LoanCalcUtil avgLoanBaseInQtrUtil;
        LoanCalcUtil avgLoanBaseMthUtil;
        LoanCalcUtil avgLoanBaseQtrUtil;
        public LoanCalcUtilTest()
        {
            Decimal loanBase = 200000M;
            int years = 10;
            Decimal interestRate = 0.0558M;

            avgLoanBaseInMthUtil = new LoanCalcUtil(loanBase, years, interestRate,
                PayLoanType.AvgLoanBaseAndInterests, PayCycleType.PerMonth);
            avgLoanBaseInQtrUtil = new LoanCalcUtil(loanBase, years, interestRate,
                PayLoanType.AvgLoanBaseAndInterests, PayCycleType.PerQuarter);
            avgLoanBaseMthUtil = new LoanCalcUtil(loanBase, years, interestRate,
                PayLoanType.AvgLoanBase, PayCycleType.PerMonth);
            avgLoanBaseQtrUtil = new LoanCalcUtil(loanBase, years, interestRate,
                PayLoanType.AvgLoanBase, PayCycleType.PerQuarter);

        }

        #region 附加测试特性
        // 
        //编写测试时，还可使用以下特性:
        //
        //使用 ClassInitialize 在运行类中的第一个测试前先运行代码
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
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
        public void CalcInterestForAvgLoanBaseTest()
        {
            int whichCycle = 0; // TODO: 初始化为适当的值
            Decimal expected = 2790M;
            Decimal actual;
            actual = avgLoanBaseQtrUtil.CalcInterestForAvgLoanBase(whichCycle);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
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
