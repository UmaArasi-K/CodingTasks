namespace CommandSimulator
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethodForCommandSimulator()
        {
            //Arrange
            var input = new[]
            {
                "cd /home",
                "cd user",
                "pwd",
                "cd ..",
                "pwd",
                "cd ./projects/../code",
                "pwd"
            };

            var Output = new[]
            {
                "/home/user/",
                "/home/",
                "/home/code/"
            };

            //Act
            var result = CommandSimulator.Simulate(input);

            //Assert
            Assert.AreEqual(Output, result.ToArray());
        }
        [TestMethod]
        public void TestMethodForCommandSimulator2() { 
        
            //Arrange
            var input = new[]
            {
                "cd /",
                "cd home",
                "cd ./user//",
                "cd ../..",
                "cd ../..",
                "cd var/log",
                "pwd",
                "cd /etc/./nginx/../ssh",
                "pwd",
                "cd ..",
                "pwd"
            };
            var Output = new[]
            {
                "/var/log/",
                "/etc/ssh/",
                "/etc/"
            };
            //Act
            var result = CommandSimulator.Simulate(input);
            //Assert
            Assert.AreEqual(Output, result.ToArray());
        }
    }
}
