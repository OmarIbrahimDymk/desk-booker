using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DeskBooker.Core.Processor
{
    public class DeskBookingRequestProcessorTests
    {
        [Fact]
        public void ShouldReturnDeskBookingResultWithRequestValues()
        {
            // Arrange
            var request = new DeskBookingRequest
            {
                FirstName = "John",
                LastName = "Smith",
                Email = "John.Smith@hotmail.com",
                Date = new DateTime(2020, 1, 28)
            };

            var processor = new DeskBookingRequestProcessor();

            // Act
            DeskBookingResult result = processor.BookDesk(request);

            // Assert
            Assert.NotNull(request);
            Assert.Equal(request.FirstName, result.FirstName);
            Assert.Equal(request.LastName, result.LastName);
            Assert.Equal(request.Email, result.Email);
            Assert.Equal(request.Date, result.Date);
        }
    }
}
