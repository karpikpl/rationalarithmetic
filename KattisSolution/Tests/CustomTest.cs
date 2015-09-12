using System.IO;
using System.Text;
using NUnit.Framework;

namespace KattisSolution.Tests
{
    [TestFixture]
    [Category("sample")]
    public class CustomTest
    {
        [Test]
        public void SampleTest_WithStringData_Should_Pass()
        {
            // Arrange
            const string expectedAnswer = "500000001 / 50000000\n";
            using (var input = new MemoryStream(Encoding.UTF8.GetBytes("1\n100000001 100000000 + 900000001 100000000")))
            using (var output = new MemoryStream())
            {
                // Act
                Program.Solve(input, output);
                var result = Encoding.UTF8.GetString(output.ToArray());

                // Assert
                Assert.That(result, Is.EqualTo(expectedAnswer));
            }
        }

        [Test]
        public void SampleTest_WithStringData_Should_Pass2()
        {
            // Arrange
            const string expectedAnswer = "1 / 1\n";
            using (var input = new MemoryStream(Encoding.UTF8.GetBytes("1\n99999999 99999999 * 99999999 99999999")))
            using (var output = new MemoryStream())
            {
                // Act
                Program.Solve(input, output);
                var result = Encoding.UTF8.GetString(output.ToArray());

                // Assert
                Assert.That(result, Is.EqualTo(expectedAnswer));
            }
        }

        [Test]
        public void SampleTest_WithStringData_Should_Pass3()
        {
            // Arrange
            const string expectedAnswer = "9999999800000001 / 9999999500000006\n";
            using (var input = new MemoryStream(Encoding.UTF8.GetBytes("1\n99999999 99999998 * 99999999 99999997")))
            using (var output = new MemoryStream())
            {
                // Act
                Program.Solve(input, output);
                var result = Encoding.UTF8.GetString(output.ToArray());

                // Assert
                Assert.That(result, Is.EqualTo(expectedAnswer));
            }
        }

        [Test]
        public void SampleTest_WithStringData_Should_Pass_When0()
        {
            // Arrange
            const string expectedAnswer = "0 / 1\n";
            using (var input = new MemoryStream(Encoding.UTF8.GetBytes("1\n0 5 + 0 99")))
            using (var output = new MemoryStream())
            {
                // Act
                Program.Solve(input, output);
                var result = Encoding.UTF8.GetString(output.ToArray());

                // Assert
                Assert.That(result, Is.EqualTo(expectedAnswer));
            }
        }

        [Test]
        public void SampleTest_WithStringData_Should_Pass4()
        {
            // Arrange
            const string expectedAnswer = "5 / 7\n";
            using (var input = new MemoryStream(Encoding.UTF8.GetBytes("1\n2 7 + 3 7")))
            using (var output = new MemoryStream())
            {
                // Act
                Program.Solve(input, output);
                var result = Encoding.UTF8.GetString(output.ToArray());

                // Assert
                Assert.That(result, Is.EqualTo(expectedAnswer));
            }
        }

        [Test]
        public void SampleTest_WithStringData_Should_Pass5()
        {
            // Arrange
            const string expectedAnswer = "-1 / 7\n";
            using (var input = new MemoryStream(Encoding.UTF8.GetBytes("1\n2 7 - 3 7")))
            using (var output = new MemoryStream())
            {
                // Act
                Program.Solve(input, output);
                var result = Encoding.UTF8.GetString(output.ToArray());

                // Assert
                Assert.That(result, Is.EqualTo(expectedAnswer));
            }
        }

        [Test]
        public void SampleTest_WithStringData_Should_Pass6()
        {
            // Arrange
            const string expectedAnswer = "6 / 49\n";
            using (var input = new MemoryStream(Encoding.UTF8.GetBytes("1\n2 7 * 3 7")))
            using (var output = new MemoryStream())
            {
                // Act
                Program.Solve(input, output);
                var result = Encoding.UTF8.GetString(output.ToArray());

                // Assert
                Assert.That(result, Is.EqualTo(expectedAnswer));
            }
        }

        [Test]
        public void SampleTest_WithStringData_Should_Pass7()
        {
            // Arrange
            const string expectedAnswer = "2 / 3\n";
            using (var input = new MemoryStream(Encoding.UTF8.GetBytes("1\n2 7 / 3 7")))
            using (var output = new MemoryStream())
            {
                // Act
                Program.Solve(input, output);
                var result = Encoding.UTF8.GetString(output.ToArray());

                // Assert
                Assert.That(result, Is.EqualTo(expectedAnswer));
            }
        }
    }
}
