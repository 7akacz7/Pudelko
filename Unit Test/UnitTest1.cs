using System.Globalization;

namespace Unit_Test
{
    [TestClass]
    public class UnitTest1
    {
        public static class InitializeCulture
        {
            [AssemblyInitialize]
            public static void SetEnglishCultureOnAllUnitTest(TestContext context)
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            }
        }
        public class UnitTestsPudelkoConstructors
        {
            private static double defaultSize = 0.1; // w metrach
            private static double accuracy = 0.001; //dok³adnoœæ 3 miejsca po przecinku

            private void AssertPudelko(Pudelko p, double expectedA, double expectedB, double expectedC)
            {
                Assert.AreEqual(expectedA, p.A, delta: accuracy);
                Assert.AreEqual(expectedB, p.B, delta: accuracy);
                Assert.AreEqual(expectedC, p.C, delta: accuracy);
            }
        }
        }
}