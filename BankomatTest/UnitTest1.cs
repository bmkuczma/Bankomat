using NUnit.Framework;

namespace Bankomat
{
    public class Tests
    {
        MoneyChanger moneyChanger;
        [SetUp]
        public void Setup()
        {
            moneyChanger = new MoneyChanger();
        }

        [Test]
        public void CheckIfBankotsAmountEquals1()
        {
            var aHundred = moneyChanger.MoneyEncounter(100);
            Assert.That(aHundred.Values.Count, Is.EqualTo(1));
        }
        [Test]
        public void CheckIfBankotsAmountEquals3()
        {
            var twoTwoTwo = moneyChanger.MoneyEncounter(222);
            Assert.That(twoTwoTwo.Values.Count, Is.EqualTo(3));
        }
        [Test]
        public void CheckIfBankotsAmountEquals8()
        {
            var threeEightEight = moneyChanger.MoneyEncounter(388);
            Assert.That(threeEightEight.Values.Count, Is.EqualTo(8));
        }
        [Test]
        public void CheckIfContainsCoolValues()
        {
            var threeEightEight = moneyChanger.MoneyEncounter(388);
            Assert.That(threeEightEight.ContainsValue(200), Is.True);
            Assert.That(threeEightEight.ContainsValue(100), Is.True);
            Assert.That(threeEightEight.ContainsValue(50), Is.True);
            Assert.That(threeEightEight.ContainsValue(20), Is.True);
            Assert.That(threeEightEight.ContainsValue(10), Is.True);
        }
    }
}