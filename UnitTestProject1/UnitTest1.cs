using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ReflectionDemo;
using UnitTestProject1;


namespace UnitTestProject1
{
    [TestClass]

    public class MsTestForMoodAnalyzer
    {
        //[TestMethod]
        //[TestCategory("Customexception")]
        //public void GivenNullShouldReturnCustomNullException()
        //{
        //    //AAA Methology

        //    //Arrange
        //    string excepted = "Message should not be null";
        //    MoodAnalyzer moodAnalyser = new MoodAnalyzer(null);
        //    try
        //    {
        //        //ACT
        //        string actual = moodAnalyser.AnalyzeMood();
        //    }
        //    catch (CustomMoodAnalyzerException ex)
        //    {
        //        //ASSERT
        //        Assert.AreEqual(excepted, ex.Message);
        //    }
        //}

        //[TestMethod]
        //public void GivenEmptyShouldReturnCustomEmptyException()
        //{
        //    //AAA Methology

        //    //Arrange
        //    string excepted = "Message should not be empty";
        //    MoodAnalyzer moodAnalyser = new MoodAnalyzer(string.Empty);
        //    try
        //    {
        //        //ACT
        //        string actual = moodAnalyser.AnalyzeMood();
        //    }
        //    catch (CustomMoodAnalyzerException ex)
        //    {
        //        //ASSERT
        //        Assert.AreEqual(excepted, ex.Message);
        //    }
        //}

        ///// <summary>
        ///// UC-4 Create Default Constructor Using Reflection
        ///// </summary>
        //[TestMethod]
        //[TestCategory("Reflection")]
        //public void Given_MoodAnalyzer_Using_Reflection_Return_defaultConstructor()
        //{
        //    MoodAnalyzer excepted = new MoodAnalyzer();
        //    object obj = null;
        //    try
        //    {
        //        //ACT
        //        MoodAnalyzerFactory058 factory = new MoodAnalyzerFactory058();
        //       // obj = factory.CreatMoodAnalyzerObject("ReflectionDemo.MoodAnalyzer", "MoodAnalyzer");
        //    }
        //    catch (CustomMoodAnalyzerException execption)
        //    {
        //        //ASSERT
        //        throw new Exception(execption.Message);
        //    }
        //    obj.Equals(excepted);

        //}
        //[TestMethod]
        //[TestCategory("Reflection")]
        //public void Given_MoodAnalyzer_Using_Reflection_Return_Exception()
        //{
        //    string excepted = "constructor not found";
        //    object obj = null;
        //    try
        //    {
        //        //ACT
        //        MoodAnalyzerFactory058 factory = new MoodAnalyzerFactory058();
        //      //  obj = factory.CreatMoodAnalyzerObject("Exception058.MoodAnalyzer", "MoodAnal");
        //    }
        //    catch (CustomMoodAnalyzerException execption)
        //    {
        //        //ASSERT
        //        Assert.AreEqual(excepted, execption.Message);
        //    }

        //}
        //[TestMethod]
        //[TestCategory("Reflection")]
        //public void Given_MoodAnalyzer_Using_Reflection_Return_ClassException()
        //{
        //    string excepted = "class not found";
        //    object obj = null;
        //    try
        //    {
        //        //ACT
        //        MoodAnalyzerFactory058 factory = new MoodAnalyzerFactory058();
        //       // obj = factory.CreatMoodAnalyzerObject("Exception058.EmployeeWage", "EmployeeWage");
        //    }
        //    catch (CustomMoodAnalyzerException execption)
        //    {
        //        //ASSERT
        //        Assert.AreEqual(excepted, execption.Message);
        //    }

        //}
        /// <summary>
        ///  UC-5   Givens the mood analyzer using reflection return parametarized constructor.
        /// </summary>
        /// <exception cref="System.Exception"></exception>
        [TestMethod]
        [TestCategory("Reflection")]
        public void Given_MoodAnalyzer_Using_Reflection_Return_ParametarizedConstructor()
        {
            string message = "i am in a happy mood";
            MoodAnalyzer excepted = new MoodAnalyzer(message);
            object actual = null;
            try
            {
                //ACT
                MoodAnalyzerFactory058 factory = new MoodAnalyzerFactory058();
                actual = factory.CreateMoodAnalyzerParametarizedObject("MoodAnalyzer", "MoodAnalyzer", message);
            }
            catch (CustomMoodAnalyzerException execption)
            {
                //ASSERT
                throw new Exception(execption.Message);
            }


        }
        [TestMethod]
        [TestCategory("Reflection")]
        public void Given_MoodAnalyzer_Using_Reflection_Return_classException_ParametarizedConstructor()
        {
            string excepted = "class not found";
            string message = "i am in a happy mood";
            object actual = null;
            try
            {
                //ACT
                MoodAnalyzerFactory058 factory = new MoodAnalyzerFactory058();
                actual = factory.CreateMoodAnalyzerParametarizedObject("EmpWage", "EmpWage", message);
            }
            catch (CustomMoodAnalyzerException execption)
            {
                //ASSERT
                Assert.AreEqual(excepted, execption.Message);
            }


        }
        [TestMethod]
        [TestCategory("Reflection")]
        public void Given_MoodAnalyzer_Using_Reflection_Return_Constructor_Exception_ParametarizedConstructor()
        {
            string excepted = "constructor not found";
            string message = "I am in a happy mood";
            object actual = null;
            try
            {
                //ACT
                MoodAnalyzerFactory058 factory = new MoodAnalyzerFactory058();
                actual = factory.CreateMoodAnalyzerParametarizedObject("MoodAnalyzer", "Empwage", message);
            }
            catch (CustomMoodAnalyzerException execption)
            {
                //ASSERT
                Assert.AreEqual(excepted, execption.Message);
            }

        }


        [TestMethod]
        [TestCategory("Reflection")]
        public void Given_MoodAnalyzer_Using_Reflection_Return_Method()
        {
            string methodName = "AnalyzeMood";
            string excepted = "happy";
            string message = "I am in a happy mood";
            object actual = "";
            try
            {
                //ACT
                MoodAnalyzerFactory058 factory = new MoodAnalyzerFactory058();
                actual = factory.InvokeAnalyzerMethod( message,methodName);
            }
            catch (CustomMoodAnalyzerException execption)
            {
                //ASSERT
                throw new Exception(execption.Message);
            }
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        [TestCategory("Reflection")]
        public void Given_MoodAnalyzer_Using_Reflection_Return_No_Such_Method()
        {
            string methodName = "EmployeeWage";
            string excepted = "happy";
            string message = "I am in a happy mood";
            object actual = "";
            try
            {
                //ACT
                MoodAnalyzerFactory058 factory = new MoodAnalyzerFactory058();
                actual = factory.InvokeAnalyzerMethod(message,methodName);
            }
            catch (CustomMoodAnalyzerException execption)
            {
                //ASSERT
                throw new Exception(execption.Message);
            }
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        [TestCategory("Reflection")]
        public void Given_MoodAnalyzer_Using_Reflection_SetField()
        {
            string methodName = "AnalyzeMood";
            string excepted = "sad";
            string message = "I am in a sad mood";
            object actual = "";
            try
            {
                //ACT
                MoodAnalyzerFactory058 factory = new MoodAnalyzerFactory058();
                actual = factory.SetField(message, methodName);
            }
            catch (CustomMoodAnalyzerException execption)
            {
                //ASSERT
                throw new Exception(execption.Message);
            }
            Assert.AreEqual(excepted, actual);
        }



    }
}

