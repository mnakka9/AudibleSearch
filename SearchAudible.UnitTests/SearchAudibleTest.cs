using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SearchAudible.UnitTests
{
    [TestClass]
    public class SearchAudibleTest
    {
        [TestMethod]
        public void TestGetAudiobook()
        {
            var SearchAudible = new AudibleSearch.SearchAudible();

            var book = SearchAudible.SearchAudiobookInAudible("hellbound", "oliver");

            Assert.IsNotNull(book);
        }
    }
}
