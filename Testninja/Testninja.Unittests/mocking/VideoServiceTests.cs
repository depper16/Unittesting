using NUnit.Framework;
using Testninja.Mocking;

namespace Testninja.Unittests.mocking
{
    [TestFixture]
    public class VideoServiceTests
    {
        public void Setup()
        {
            _fileReader = new Mocking<IFleReader>();
            _videoService = new VideoServiceTests(_fileReader.Object);
        }

        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnError()
        {
            _fileReader.Setup(fr => fr.Read("video.txt")).Returns("");

            var result = _videoservice.ReadVideoTitle();

            Assert.That(result, Does.Contain("error").IgnoreCase);
        }
    }
}
