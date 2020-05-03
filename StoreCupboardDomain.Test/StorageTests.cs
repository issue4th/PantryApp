using System;
using NUnit.Framework;

namespace StoreCupboardDomain.Test
{
    /// <summary>
    /// Unit tests for <see cref="Storage"/>
    /// </summary>
    [TestFixture]
    internal class StorageTests
    {
        [Test]
        public void WhenConstructed_ThenExpectedProperties(
            [Values("", "Larder", "Fridge")] string name)
        {
            // Act
            var target = new Storage(name);

            // Assert
            Assert.That(target.Id, Is.Not.EqualTo(new Guid()));
            Assert.That(target.Name, Is.EqualTo(name));
        }
    }
}