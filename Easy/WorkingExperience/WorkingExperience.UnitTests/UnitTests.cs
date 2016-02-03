using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkingExperience.ConsoleApp;

namespace WorkingExperience.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "Feb 2004-Dec 2009; Sep 2004-Jul 2008";
            int expected = 5;

            int result = Resumer.GetActualWorkExperience(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = "Aug 2013-Mar 2014; Apr 2013-Aug 2013; Jun 2014-Aug 2015; Apr 2003-Nov 2004; Apr 2014-Jan 2015";
            int expected = 4;

            int result = Resumer.GetActualWorkExperience(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string input = "Mar 2003-Jul 2003; Nov 2003-Jan 2004; Apr 1999-Nov 1999";
            int expected = 1;

            int result = Resumer.GetActualWorkExperience(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string input = "Apr 1992-Dec 1993; Feb 1996-Sep 1997; Jan 2002-Jun 2002; Sep 2003-Apr 2004; Feb 2010-Nov 2011";
            int expected = 6;

            int result = Resumer.GetActualWorkExperience(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            string input = "Feb 2004-May 2004; Jun 2004-Jul 2004";
            int expected = 0;

            int result = Resumer.GetActualWorkExperience(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            string input = "Dec 2003-Nov 2004; Apr 2008-May 2008; Apr 1996-Apr 1997; Nov 2006-Feb 2007; Aug 2008-Dec 2009; Jul 1991-Dec 1992; Sep 1998-Apr 2000; Dec 1997-Jun 1999; Jan 2006-Sep 2007; Feb 2010-Nov 2010; Aug 1996-Apr 1998; Oct 1990-Mar 1992; Jun 1990-Nov 1990; Jul 2009-Feb 2011; Dec 1998-Jan 2000; Apr 1995-Jul 1996";
            int expected = 13;

            int result = Resumer.GetActualWorkExperience(input);

            Assert.AreEqual(expected, result);
        }
    }
}
