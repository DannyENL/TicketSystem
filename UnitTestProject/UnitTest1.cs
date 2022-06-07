using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WPFUI.Models;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ChildTicketTest() //Tests to see if the child ticket costs the right amount
        {
            TicketModel testingTicket = new ChildTicket();

            double expected = 5;
            double actual = testingTicket.Cost();
            
            Assert.AreEqual(expected, actual, "Child ticket price is incorrect");
        }

        [TestMethod]
        public void AdultTicketTest() //Tests to see if the adult ticket costs the right amount
        {
            TicketModel testingTicket = new AdultTicket();

            double expected = 10;
            double actual = testingTicket.Cost();

            Assert.AreEqual(expected, actual, "Adult ticket price is incorrect");
        }


        [TestMethod]
        public void MemberTicketTest() //Tests to see if the member ticket costs the right amount
        {
            TicketModel testingTicket = new MemberTicket();

            double expected = 7.50;
            double actual = testingTicket.Cost();

            Assert.AreEqual(expected, actual, "Member ticket price is incorrect");
        }


        [TestMethod]
        public void PiePriceTest() //Tests to see if the pie price is correctly added on top of the original price
        {
            TicketModel testingTicket = new MemberTicket();

            double expected = testingTicket.Cost()+12.50;

            testingTicket = new PieAdder(testingTicket);

            double actual = testingTicket.Cost();

            Assert.AreEqual(expected, actual, "Pie price is incorrect");
        }


        [TestMethod]
        public void TourPriceTest() //Tests to see if the tour price is correctly added on top of the original price
        {
            TicketModel testingTicket = new MemberTicket();

            double expected = testingTicket.Cost() + 20;

            testingTicket = new TourAdder(testingTicket);

            double actual = testingTicket.Cost();

            Assert.AreEqual(expected, actual, "Tour price is incorrect");
        }


        [TestMethod]
        public void FrontPriceTest() //Tests to see if the front row seat price is correctly added on top of the original price
        {
            TicketModel testingTicket = new MemberTicket();

            double expected = testingTicket.Cost() + 15;

            testingTicket = new FrontAdder(testingTicket);

            double actual = testingTicket.Cost();

            Assert.AreEqual(expected, actual, "Front price is incorrect");
        }
    }
}
