using NUnit.Framework;

namespace RosalindTemplate {
    [TestFixture]
    public class Solver_Tests {
        [Test]
        public void Solve_GivenSomeInput_ProducesCorrectOutput() {
            var input = "What is the answer?";

            var expectedResult = "42";

            Assert.That(Solver.Solve(input), Is.EqualTo(expectedResult));
        }
    }
}
