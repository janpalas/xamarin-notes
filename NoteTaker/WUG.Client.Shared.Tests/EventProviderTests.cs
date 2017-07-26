using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using WUG.Client.Shared.Models;
using WUG.Client.Shared.PlatformAbstractions;
using WUG.Core.Services.DataEntities;

namespace WUG.Client.Shared.Tests
{
    [TestFixture]
    public class EventProviderTests
    {
        [Test]
        public async Task GetUpcomingEventsAsync_Simple()
        {
            var webClientMock = new Mock<IWebClient>();
            webClientMock.Setup(x => x.GetStringAsync(It.IsAny<Uri>()))
                .ReturnsAsync((Uri uri) => TestData.GetUpcomingEvents);

            var eventProvider = new EventProvider(webClientMock.Object);

            //act
            List<EventInfo> events = await eventProvider.GetUpcomingEventsAsync();

            //assert
            Assert.That(events != null && events.Count == 5);
        }
    }
}
