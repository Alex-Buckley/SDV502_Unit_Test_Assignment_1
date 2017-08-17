using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FastwayCourier;
using System.Collections.Generic;

namespace Alex_Buckley_Assign_1
{
    [TestClass]
    public class GettingAZoneFromNelson_ForAGivenDestination_Should
    {
        [TestMethod]
        public void ReturnBlue_WhenDestinationIsRiwaka()
        {
            //arrange
            var PQ = new ParcelQuoteFromNelson();
            string Destination = "Riwaka";

            //act
            var zone = PQ.GetDestinationZone(Destination);

            //assert
            Assert.AreEqual("Blue", zone);
        }

        [TestMethod]
        public void ReturnPink_WhenDestinationIsMotueka()
        {
            //arrange
            var PQ = new ParcelQuoteFromNelson();
            var Destination = "Motueka";

            //act
            var zone = PQ.GetDestinationZone(Destination);

            //assert
            Assert.AreEqual("Pink", zone);
        }

        [TestMethod]
        public void ReturnBlue_WhenDestinationIsWaihopaiValley()
        {
            //arrange
            var PQ = new ParcelQuoteFromNelson();
            var Destination = "Waihopai Valley";

            //act
            var zone = PQ.GetDestinationZone(Destination);

            //assert
            Assert.AreEqual("Blue", zone);
        }

        [TestMethod]
        public void ReturnLime_WhenDestinationIsNelsonLakes()
        {
            //arrange
            var PQ = new ParcelQuoteFromNelson();
            var Destination = "Nelson Lakes National Park";

            //act
            var zone = PQ.GetDestinationZone(Destination);

            //assert
            Assert.AreEqual("Lime", zone);
        }

        [TestMethod]
        public void ReturnBlue_WhenDestinationIsTakaka()
        {
            //arrange
            var PQ = new ParcelQuoteFromNelson();
            var Destination = "Takaka";

            //act
            var zone = PQ.GetDestinationZone(Destination);

            //assert
            Assert.AreEqual("Blue", zone);
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void ReturnLime_WhenDestinationIsCollingwood()
        {
            //arrange
            var PQ = new ParcelQuoteFromNelson();
            var Destination = "Collingwood";

            //act
            var zone = PQ.GetDestinationZone(Destination);

            //assert
            Assert.AreEqual("Lime", zone);
        }

        [TestMethod]
        public void ReturnOrange_WhenDestinationIsKaikoura()
        {
            //arrange
            var PQ = new ParcelQuoteFromNelson();
            var Destination = "Kaikoura";

            //act
            var zone = PQ.GetDestinationZone(Destination);

            //assert
            Assert.AreEqual("Orange", zone);
        }


        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void ReturnKeyException_WhenDestinationIsAuckland()
        {
            //arrange
            var PQ = new ParcelQuoteFromNelson();
            var Destination = "Auckland";

            //act
            var zone = PQ.GetDestinationZone(Destination);

            //assert
            Assert.AreEqual("KeyNotFoundException", zone);
        }
    }

    [TestClass]
    public class GettingAParcelAndTicketQuoteFromNelson_ToAGivenDestination_Should
    {

        //Pink zone
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void ReturnArgumentException_WhenPink0()
        {
            //arrange
            var PQ = new ParcelQuoteFromNelson();
            decimal Weight = 0;
            string Zone = "Pink";
            
            //act
            ParcelQuoteResult QuoteResult = PQ.CalculateQuote(Weight, Zone);

            //assert
            Assert.AreEqual("ArgumentOutOfRangeException", QuoteResult.ExcessTickets);
            Assert.AreEqual("ArgumentOutOfRangeException", QuoteResult.Price);
        }

        [TestMethod]
        public void ReturnPriceAndExcessTicket_WhenPink0To2()
        {
            //arrange
            var PQ = new ParcelQuoteFromNelson();
            decimal Weight = 0.1M;
            string Zone = "Pink";

            //act
            ParcelQuoteResult QuoteResult = PQ.CalculateQuote(Weight, Zone);

            //assert
            Assert.AreEqual(0, QuoteResult.ExcessTickets);
            Assert.AreEqual(4.15M, QuoteResult.Price);
        }

        [TestMethod]
        public void ReturnPriceAndExcessTicket_WhenPink2To5()
        {
            //arrange
            var PQ = new ParcelQuoteFromNelson();
            decimal Weight = 2M;
            string Zone = "Pink";

            //act
            ParcelQuoteResult QuoteResult = PQ.CalculateQuote(Weight, Zone);

            //assert
            Assert.AreEqual(0, QuoteResult.ExcessTickets);
            Assert.AreEqual(4.15M, QuoteResult.Price);
        }

        [TestMethod]
        public void ReturnPriceAndExcessTicket_WhenPink5To10()
        {
            //arrange
            var PQ = new ParcelQuoteFromNelson();
            decimal Weight = 5M;
            string Zone = "Pink";

            //act
            ParcelQuoteResult QuoteResult = PQ.CalculateQuote(Weight, Zone);

            //assert
            Assert.AreEqual(0, QuoteResult.ExcessTickets);
            Assert.AreEqual(4.15M, QuoteResult.Price);
        }

        [TestMethod]
        public void ReturnPriceAndExcessTicket_WhenPink10To15()
        {
            //arrange
            var PQ = new ParcelQuoteFromNelson();
            decimal Weight = 10M;
            string Zone = "Pink";

            //act
            ParcelQuoteResult QuoteResult = PQ.CalculateQuote(Weight, Zone);

            //assert
            Assert.AreEqual(0, QuoteResult.ExcessTickets);
            Assert.AreEqual(4.15M, QuoteResult.Price);
        }

        [TestMethod]
        public void ReturnPriceAndExcessTicket_WhenPink15To20()
        {
            //arrange
            var PQ = new ParcelQuoteFromNelson();
            decimal Weight = 15M;
            string Zone = "Pink";

            //act
            ParcelQuoteResult QuoteResult = PQ.CalculateQuote(Weight, Zone);

            //assert
            Assert.AreEqual(0, QuoteResult.ExcessTickets);
            Assert.AreEqual(4.15M, QuoteResult.Price);
        }

        [TestMethod]
        public void ReturnPriceAndExcessTicket_WhenPink20To25()
        {
            //arrange
            var PQ = new ParcelQuoteFromNelson();
            decimal Weight = 20M;
            string Zone = "Pink";

            //act
            ParcelQuoteResult QuoteResult = PQ.CalculateQuote(Weight, Zone);

            //assert
            Assert.AreEqual(0, QuoteResult.ExcessTickets);
            Assert.AreEqual(4.15M, QuoteResult.Price);
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void ReturnArgumentException_WhenPinkGreaterThan25()
        {
            //arrange
            var PQ = new ParcelQuoteFromNelson();
            decimal Weight = 25.1M;
            string Zone = "Pink";

            //act
            ParcelQuoteResult QuoteResult = PQ.CalculateQuote(Weight, Zone);

            //assert
            Assert.AreEqual("ArgumentOutOfRangeException", QuoteResult.ExcessTickets);
            Assert.AreEqual("ArgumentOutOfRangeException", QuoteResult.Price);
        }

        //Blue zone

        
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ReturnArgumentException_WhenBlue0()
        {
            //arrange
            var PQ = new ParcelQuoteFromNelson();
            decimal Weight = 0;
            string Zone = "Blue";

            //act
            ParcelQuoteResult QuoteResult = PQ.CalculateQuote(Weight, Zone);

            //assert
            Assert.AreEqual("ArgumentOutOfRangeException", QuoteResult.ExcessTickets);
            Assert.AreEqual("ArgumentOutOfRangeException", QuoteResult.Price);
        }

        [TestMethod]
        public void ReturnPriceAndExcessTicket_WhenBlue0To2()
        {
            //arrange
            var PQ = new ParcelQuoteFromNelson();
            decimal Weight = 0.1M;
            string Zone = "Blue";

            //act
            ParcelQuoteResult QuoteResult = PQ.CalculateQuote(Weight, Zone);

            //assert
            Assert.AreEqual(0, QuoteResult.ExcessTickets);
            Assert.AreEqual(6.95M, QuoteResult.Price);
        }

        [TestMethod]
        public void ReturnPriceAndExcessTicket_WhenBlue2To5()
        {
            //arrange
            var PQ = new ParcelQuoteFromNelson();
            decimal Weight = 2M;
            string Zone = "Blue";

            //act
            ParcelQuoteResult QuoteResult = PQ.CalculateQuote(Weight, Zone);

            //assert
            Assert.AreEqual(0, QuoteResult.ExcessTickets);
            Assert.AreEqual(6.95M, QuoteResult.Price);
        }

        [TestMethod]
        public void ReturnPriceAndExcessTicket_WhenBlue5To10()
        {
            //arrange
            var PQ = new ParcelQuoteFromNelson();
            decimal Weight = 5M;
            string Zone = "Blue";

            //act
            ParcelQuoteResult QuoteResult = PQ.CalculateQuote(Weight, Zone);

            //assert
            Assert.AreEqual(0, QuoteResult.ExcessTickets);
            Assert.AreEqual(6.95M, QuoteResult.Price);
        }

        [TestMethod]
        public void ReturnPriceAndExcessTicket_WhenBlue10To15()
        {
            //arrange
            var PQ = new ParcelQuoteFromNelson();
            decimal Weight = 10M;
            string Zone = "Blue";

            //act
            ParcelQuoteResult QuoteResult = PQ.CalculateQuote(Weight, Zone);

            //assert
            Assert.AreEqual(0, QuoteResult.ExcessTickets);
            Assert.AreEqual(6.95M, QuoteResult.Price);
        }

        [TestMethod]
        public void ReturnPriceAndExcessTicket_WhenBlue15To20()
        {
            //arrange
            var PQ = new ParcelQuoteFromNelson();
            decimal Weight = 15M;
            string Zone = "Blue";

            //act
            ParcelQuoteResult QuoteResult = PQ.CalculateQuote(Weight, Zone);

            //assert
            Assert.AreEqual(0, QuoteResult.ExcessTickets);
            Assert.AreEqual(6.95M, QuoteResult.Price);
        }

        [TestMethod]
        public void ReturnPriceAndExcessTicket_WhenBlue20To25()
        {
            //arrange
            var PQ = new ParcelQuoteFromNelson();
            decimal Weight = 20M;
            string Zone = "Blue";

            //act
            ParcelQuoteResult QuoteResult = PQ.CalculateQuote(Weight, Zone);

            //assert
            Assert.AreEqual(0, QuoteResult.ExcessTickets);
            Assert.AreEqual(6.95M, QuoteResult.Price);
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void ReturnArgumentException_WhenBlueGreaterThan25()
        {
            //arrange
            var PQ = new ParcelQuoteFromNelson();
            decimal Weight = 25.1M;
            string Zone = "Blue";

            //act
            ParcelQuoteResult QuoteResult = PQ.CalculateQuote(Weight, Zone);

            //assert
            Assert.AreEqual("ArgumentOutOfRangeException", QuoteResult.ExcessTickets);
            Assert.AreEqual("ArgumentOutOfRangeException", QuoteResult.Price);
        }

        //Lime zone

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void ReturnArgumentException_WhenLime0()
        {
            //arrange
            var PQ = new ParcelQuoteFromNelson();
            decimal Weight = 0;
            string Zone = "Lime";

            //act
            ParcelQuoteResult QuoteResult = PQ.CalculateQuote(Weight, Zone);

            //assert
            Assert.AreEqual("ArgumentOutOfRangeException", QuoteResult.ExcessTickets);
            Assert.AreEqual("ArgumentOutOfRangeException", QuoteResult.Price);
        }

        [TestMethod]
        public void ReturnPriceAndExcessTicket_WhenLime0To2()
        {
            //arrange
            var PQ = new ParcelQuoteFromNelson();
            decimal Weight = 0.1M;
            string Zone = "Lime";

            //act
            ParcelQuoteResult QuoteResult = PQ.CalculateQuote(Weight, Zone);

            //assert
            Assert.AreEqual(0, QuoteResult.ExcessTickets);
            Assert.AreEqual(8.7M, QuoteResult.Price);
        }

        [TestMethod]
        public void ReturnPriceAndExcessTicket_WhenLime2To5()
        {
            //arrange
            var PQ = new ParcelQuoteFromNelson();
            decimal Weight = 2M;
            string Zone = "Lime";

            //act
            ParcelQuoteResult QuoteResult = PQ.CalculateQuote(Weight, Zone);

            //assert
            Assert.AreEqual(0, QuoteResult.ExcessTickets);
            Assert.AreEqual(8.7M, QuoteResult.Price);
        }

        [TestMethod]
        public void ReturnPriceAndExcessTicket_WhenLime5To10()
        {
            //arrange
            var PQ = new ParcelQuoteFromNelson();
            decimal Weight = 5M;
            string Zone = "Lime";

            //act
            ParcelQuoteResult QuoteResult = PQ.CalculateQuote(Weight, Zone);

            //assert
            Assert.AreEqual(0, QuoteResult.ExcessTickets);
            Assert.AreEqual(8.7M, QuoteResult.Price);
        }

        [TestMethod]
        public void ReturnPriceAndExcessTicket_WhenLime10To15()
        {
            //arrange
            var PQ = new ParcelQuoteFromNelson();
            decimal Weight = 10M;
            string Zone = "Lime";

            //act
            ParcelQuoteResult QuoteResult = PQ.CalculateQuote(Weight, Zone);

            //assert
            Assert.AreEqual(0, QuoteResult.ExcessTickets);
            Assert.AreEqual(8.7M, QuoteResult.Price);
        }

        [TestMethod]
        public void ReturnPriceAndExcessTicket_WhenLime15To20()
        {
            //arrange
            var PQ = new ParcelQuoteFromNelson();
            decimal Weight = 15M;
            string Zone = "Lime";

            //act
            ParcelQuoteResult QuoteResult = PQ.CalculateQuote(Weight, Zone);

            //assert
            Assert.AreEqual(1, QuoteResult.ExcessTickets);
            Assert.AreEqual(14.9M, QuoteResult.Price);
            
        }

        [TestMethod]
        public void ReturnPriceAndExcessTicket_WhenLime20To25()
        {
            //arrange
            var PQ = new ParcelQuoteFromNelson();
            decimal Weight = 20M;
            string Zone = "Lime";

            //act
            ParcelQuoteResult QuoteResult = PQ.CalculateQuote(Weight, Zone);

            //assert
            Assert.AreEqual(1, QuoteResult.ExcessTickets);
            Assert.AreEqual(14.9M, QuoteResult.Price);
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void ReturnArgumentException_WhenLimeGreaterThan25()
        {
            //arrange
            var PQ = new ParcelQuoteFromNelson();
            decimal Weight = 25.1M;
            string Zone = "Lime";

            //act
            ParcelQuoteResult QuoteResult = PQ.CalculateQuote(Weight, Zone);

            //assert
            Assert.AreEqual("ArgumentOutOfRangeException", QuoteResult.ExcessTickets);
            Assert.AreEqual("ArgumentOutOfRangeException", QuoteResult.Price);
        }


        //Orange zone 
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void ReturnArgumentException_WhenOrange0()
        {
            //arrange
            var PQ = new ParcelQuoteFromNelson();
            decimal Weight = 0;
            string Zone = "Orange";

            //act
            ParcelQuoteResult QuoteResult = PQ.CalculateQuote(Weight, Zone);

            //assert
            Assert.AreEqual("ArgumentOutOfRangeException", QuoteResult.ExcessTickets);
            Assert.AreEqual("ArgumentOutOfRangeException", QuoteResult.Price);
        }

        [TestMethod]
        public void ReturnPriceAndExcessTicket_WhenOrange0To2()
        {
            //arrange
            var PQ = new ParcelQuoteFromNelson();
            decimal Weight = 0.1M;
            string Zone = "Orange";

            //act
            ParcelQuoteResult QuoteResult = PQ.CalculateQuote(Weight, Zone);

            //assert
            Assert.AreEqual(0, QuoteResult.ExcessTickets);
            Assert.AreEqual(12.95M, QuoteResult.Price);
        }

        [TestMethod]
        public void ReturnPriceAndExcessTicket_WhenOrange2To5()
        {
            //arrange
            var PQ = new ParcelQuoteFromNelson();
            decimal Weight = 2M;
            string Zone = "Orange";

            //act
            ParcelQuoteResult QuoteResult = PQ.CalculateQuote(Weight, Zone);

            //assert
            Assert.AreEqual(0, QuoteResult.ExcessTickets);
            Assert.AreEqual(12.95M, QuoteResult.Price);
        }

        [TestMethod]
        public void ReturnPriceAndExcessTicket_WhenOrange5To10()
        {
            //arrange
            var PQ = new ParcelQuoteFromNelson();
            decimal Weight = 5M;
            string Zone = "Orange";

            //act
            ParcelQuoteResult QuoteResult = PQ.CalculateQuote(Weight, Zone);

            //assert
            Assert.AreEqual(0, QuoteResult.ExcessTickets);
            Assert.AreEqual(12.95M, QuoteResult.Price);
        }

        [TestMethod]
        public void ReturnPriceAndExcessTicket_WhenOrange10To15()
        {
            //arrange
            var PQ = new ParcelQuoteFromNelson();
            decimal Weight = 10M;
            string Zone = "Orange";

            //act
            ParcelQuoteResult QuoteResult = PQ.CalculateQuote(Weight, Zone);

            //assert
            Assert.AreEqual(0, QuoteResult.ExcessTickets);
            Assert.AreEqual(12.95M, QuoteResult.Price);
        }

        [TestMethod]
        public void ReturnPriceAndExcessTicket_WhenOrange15To20()
        {
            //arrange
            var PQ = new ParcelQuoteFromNelson();
            decimal Weight = 15M;
            string Zone = "Orange";

            //act
            ParcelQuoteResult QuoteResult = PQ.CalculateQuote(Weight, Zone);

            //assert
            Assert.AreEqual(1, QuoteResult.ExcessTickets);
            Assert.AreEqual(19.15M, QuoteResult.Price);
            
        }

        [TestMethod]
        public void ReturnPriceAndExcessTicket_WhenOrange20To25()
        {
            //arrange
            var PQ = new ParcelQuoteFromNelson();
            decimal Weight = 20M;
            string Zone = "Orange";

            //act
            ParcelQuoteResult QuoteResult = PQ.CalculateQuote(Weight, Zone);

            //assert
            Assert.AreEqual(2, QuoteResult.ExcessTickets);
            Assert.AreEqual(25.35M, QuoteResult.Price);
            
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void ReturnArgumentException_WhenOrangeGreaterThan25()
        {
            //arrange
            var PQ = new ParcelQuoteFromNelson();
            decimal Weight = 25.1M;
            string Zone = "Orange";

            //act
            ParcelQuoteResult QuoteResult = PQ.CalculateQuote(Weight, Zone);

            //assert
            Assert.AreEqual("ArgumentOutOfRangeException", QuoteResult.ExcessTickets);
            Assert.AreEqual("ArgumentOutOfRangeException", QuoteResult.Price);
        }
    }
}
