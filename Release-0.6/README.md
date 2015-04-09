# Micro Testing

Team names: 
Chao Zhu
Carlos Carbajal
Song Zhang
Han Kim

##Overview
We use two different way to testing our webpage, automated and manual.
We chose Selenium as the automation testing tool.

##Selenium
###Targeting Test 
Menu, Links, Wikipage, Login, Logout, Edit, Source View, ConferenceFinder, World Clock 
###Test Result
![alt tag](https://github.com/asu-cis-capstone/micro/blob/master/Release-0.6/TestResult.jpg)
###Code Examples

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://www.maxsong.us/";
            verificationErrors = new StringBuilder();
        }
        
        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
        
        [Test]
        public void TheLoginTest()
        {
            driver.Navigate().GoToUrl(baseURL + "/microwiki/index.php?title=Microwiki");
            driver.FindElement(By.LinkText("Log in")).Click();
            driver.FindElement(By.Id("wpLoginAttempt")).Click();
            driver.FindElement(By.Id("wpPassword1")).Clear();
            driver.FindElement(By.Id("wpPassword1")).SendKeys("microadmin");
            driver.FindElement(By.Id("wpLoginAttempt")).Click();
            driver.FindElement(By.LinkText("Admin")).Click();
            driver.FindElement(By.LinkText("Log out")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                acceptNextAlert = true;
            }
        }
    }


##Manual Testing
###Targeting Test 
Menu, Links, Wikipage, Login, Logout, Edit, Source View, ConferenceFinder, World Clock 
###Test Result
![alt tag](https://github.com/asu-cis-capstone/micro/blob/master/Release-0.6/TestResult.jpg)
