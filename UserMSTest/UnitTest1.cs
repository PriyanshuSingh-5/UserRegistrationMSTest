using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationTest;

namespace UserMSTest
{
    
        
            [TestClass]
            public class Test
            {
            private readonly UserDetailsPattern userDetailsPattern;
            private readonly object DataRow;

            public Test()
            {
            userDetailsPattern = new UserDetailsPattern();
            }

            /// <summary>
            /// Validate first name
            /// </summary>
            [TestMethod]
            [DataRow("Shaloo")]
            [DataRow("ranu")]
            [DataRow("Bajaj")]
            [DataRow("Shambhavi")]
            [DataRow("Raj")]
            [DataRow("ashwin")]
            [DataRow("Priyanshu")]
            [DataRow("Akhil")]
            [DataRow("Nithya")]
            [DataRow("Shivam")]
            [DataRow("Ajay")]
            public void Given_FirstName_StartsWithCapital_MinThreeCharacter_ShouldReturnTrue(string name)
            {
                try
                {
                    string result = userDetailsPattern.ValidateFirstName(name);
                }
                catch (HandleException e)
                {
                    Assert.AreEqual("Valid First Name", e.Message);
                }
            }

            /// <summary>
            /// If entered Invalid last name should return false.
            /// </summary>
            [TestMethod]
            [DataRow("priyanshu")]
            [DataRow("shivam")]
            [DataRow("anshu")]
            [DataRow("Ajay")]
            [DataRow("shambhavi")]
            [DataRow("nithya")]
            [DataRow("ranu")]
            public void GivenFirstName_IfNotStartsWithCapital_ButMinThreeCharacter_ShouldReturnFalse(string invalidFirstName)
            {
                try
                {
                    string result = userDetailsPattern.ValidateFirstName(invalidFirstName);
                }
                catch (HandleException e)
                {
                    Assert.AreEqual("Invalid First Name", e.Message);
                }
            }

            /// <summary>
            /// Test Method to validate first name
            /// </summary>
            [TestMethod]
            [DataRow("PRIYANSHU")]
            [DataRow("SHIVAM")]
            [DataRow("ANSHU")]
            [DataRow("NITHYA")]
            [DataRow("SHAMBHAVI")]
            [DataRow("BAJAJ")]
            [DataRow("AJAY")]
            public void GivenFirstName_IfAll_LettersAreCapital_AndMinThreeCharacters_ShouldReturnFalse(string invalidFirstName)
            {
                try
                {
                    string result = userDetailsPattern.ValidateFirstName(invalidFirstName);
                }
                catch (HandleException e)
                {
                    Assert.AreEqual("Invalid First Name", e.Message);
                }
            }


            /// <summary>
            /// InValidate last name
            /// </summary>
            [TestMethod]
            [DataRow("PR")]
            [DataRow("SH")]
            [DataRow("AN")]
            [DataRow("NI")]
            [DataRow("SH")]
            [DataRow("BA")]
            [DataRow("AJ")]
            public void GivenlastName_WhenStartsWithCapital_AndLessThanThreeCharacter_ShouldReturnFalse(string invalidLastName)
            {
                try
                {
                    string result = userDetailsPattern.ValidateLastName(invalidLastName);
                }
                catch (HandleException e)
                {
                    Assert.AreEqual("Invalid Last Name", e.Message);
                }
            }

            /// <summary>
            /// Validate last name
            /// </summary>
            [TestMethod]
            [DataRow("priyanshu")]
            [DataRow("shivam")]
            [DataRow("anshu")]
            [DataRow("nithya")]
            [DataRow("shambhavi")]
            [DataRow("bajaj")]
            [DataRow("ajay")]
            public void GivenLastName_WhenNotStartsWithCapAndMinThreeChar_ShouldReturnFalse(string invalidLastName)
            {
                try
                {
                    string result = userDetailsPattern.ValidateLastName(invalidLastName);
                }
                catch (HandleException e)
                {
                    Assert.AreEqual("Invalid Last Name", e.Message);
                }
            }

            /// <summary>
            /// Validate last name
            /// </summary>
            [TestMethod]
            [DataRow("PRIYANSHU")]
            [DataRow("SHIVAM")]
            [DataRow("ANSHU")]
            [DataRow("NITHYA")]
            [DataRow("SHAMBHAVI")]
            [DataRow("BAJAJ")]
            [DataRow("AJAY")]
            public void GivenLastName_WhenAllLettersAreCapital_AndMinThreeChar_ShouldReturnFalse(string invalidLastName)
            {
                try
                {
                    string result = userDetailsPattern.ValidateLastName(invalidLastName);
                }
                catch (HandleException e)
                {
                    Assert.AreEqual("Invalid Last Name", e.Message);
                }
            }

            /// <summary>
            /// Test Method to pass invalid email id.
            /// </summary>
            [TestMethod]
            [DataRow("shalu@gmail")]
            [DataRow("shalu@gmail.comm")]
            [DataRow("shalu@gmail.com.ind.us")]
            [DataRow("shalu.#100@gmail")]
            [DataRow("shalu11@gmail.com.a12")]
            [DataRow("shalu@gmail.com.12sa")]
            [DataRow("_shalu@gmail.com")]
            public void GivenEmailId_WhenIsNotProper_ShouldReturnFalse(string emailInvalid)
            {
                try
                {
                    string result = userDetailsPattern.ValidateEmail(emailInvalid);
                }
                catch (HandleException e)
                {
                    Assert.AreEqual("Invalid email id", e.Message);
                }
            }

            /// <summary>
            /// passing invalid mobile number patterns should return invalid mobile number
            /// </summary>
            [TestMethod]
            [DataRow("91 9976655")]
            [DataRow("91 776655")]
            [DataRow("91 8776655")]
            [DataRow("91 976655")]
            [DataRow("91 98776655")]
            [DataRow("91 988776655")]
            [DataRow("919445588776655")]
            [DataRow("91988776655")]
            public void GivenInvalidMobileNumber_ShouldReturnFalse(string invalidMobile)
            {
                try
                {
                    string result = userDetailsPattern.ValidateMobileNumber(invalidMobile);
                }
                catch (HandleException e)
                {
                    Assert.AreEqual("Invalid mobile number", e.Message);
                }
            }

            /// <summary>
            /// Pssing all possible invalid password patterns should return invalid password.
            /// </summary>
            [TestMethod]
            [DataRow("priya55")]
            [DataRow("priya.12")]
            [DataRow("priyanshu")]
            [DataRow("SADFGH12345")]
            [DataRow("priyaabc#")]
            [DataRow("Priyanabc_#")]
            [DataRow("priya55%djks")]
            [DataRow("priya55SDFGH")]
            [DataRow("priya_32SDFG")]
            [DataRow("priya55_Ghsjs")]
            [DataRow("priya55_@#$%")]
            public void GivenInvalidPassword_ShouldReturnFalse(string invalidPassword)
            {
                try
                {
                    string result = userDetailsPattern.ValidatePassword(invalidPassword);
                }
                catch (HandleException e)
                {
                    Assert.AreEqual("Invalid password", e.Message);
                }
            }

            /// <summary>
            /// Passing invalid email samples should return invalid nemail id.
            /// </summary>
            /// <param name="invlidEmailSamples"></param>
            [TestMethod]
            [DataRow("abc")]
            [DataRow("abc123@gmail.a")]
            [DataRow("abc123@.com")]
            [DataRow("abc123@.com.com")]
            [DataRow(".abc@abc.com")]
            [DataRow("abc()*@gmail.com")]
            [DataRow("abc@%*.com")]
            [DataRow("abc..2002@gmail.com")]
            [DataRow("abc.@gmail.com")]
            [DataRow("abc@abc@gmail.com")]
            [DataRow("abc@gmail.com.2a")]
            [DataRow("abc@gmail.com.aa.au")]
            public void GivenEmails_WhenChecked_ShouldReturnFalse(string invlidEmailSamples)
            {
                try
                {
                    string result = userDetailsPattern.ValidateEmail(invlidEmailSamples);
                }
                catch (HandleException e)
                {
                    Assert.AreEqual("Invalid email id", e.Message);
                }
            }

        }
    }


