namespace ExpressionSolverTest
{
    [TestClass]
    public sealed class ExpressionSolverTest
    {
        [TestMethod]
        public void TestmethodForGivenExpressionSolving()
        {
            //Arrange
            string strExpression = "3+(2*4)-5/(1+1)";

            var e = strExpression.GetEnumerator();
            e.MoveNext();
            //Act
            double result = ExpressionSolver.ExpressionSolver.Evaluate(e);
            //Assert
            Assert.AreEqual(8.5, result);
        }



        [TestMethod]
        public void TestmethodForExpressionSolving1()
        {
            //Arrange
            string strExpression = "2+3*3*2+((3+5)/(2*4))+1+(1/2*3)";
            
            //Act
            bool isValid = ExpressionSolver.ExpressionValidator.IsValidExpression(strExpression);
            var e = strExpression.GetEnumerator();
            e.MoveNext();
            double result = ExpressionSolver.ExpressionSolver.Evaluate(e);
            
            //Assert
            Assert.IsTrue(isValid);
            Assert.AreEqual(23.5, result);
        }
        [TestMethod]
        public void TestmethodForExpressionValidation()
        {
            //Arrange
            string strExpression = "2+3*3*2+((3+5)/(2*4))+1+(1/2*3";
            
            //Act
            bool isValid = ExpressionSolver.ExpressionValidator.IsValidExpression(strExpression);

            //Assert
            Assert.IsFalse(isValid);
        }
        [TestMethod]
        public void TestmethodForExpressionSolving() {
            //Arrange
            string strExpression = "(2*4)+1+(1/2*3)";
            var e = strExpression.GetEnumerator();
            e.MoveNext();

            //Act
            double result = ExpressionSolver.ExpressionSolver.Evaluate(e);

            //Assert
            Assert.AreEqual(10.5, result);
        }
    }
}
