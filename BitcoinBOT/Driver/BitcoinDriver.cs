using EasyAutomationFramework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinBOT.Driver
{
    public class BitcoinDriver : Web
    {
        public EasyReturn.Web StartBrowser(TypeDriver typeDriver = TypeDriver.GoogleChorme)
        {
            try
            {

                ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
                chromeDriverService.HideCommandPromptWindow = true;
                ChromeOptions chromeOptions = new ChromeOptions();
                chromeOptions.AddArgument("--incognito");
                chromeOptions.AddArgument("--headless");
                chromeOptions.AddExcludedArgument("enable-automation");
                chromeOptions.AddAdditionalCapability("useAutomationExtension", false);
                chromeOptions.AddArgument("--start-maximized");
                driver = new ChromeDriver(chromeDriverService, chromeOptions);

                return new EasyReturn.Web
                {
                    driver = driver,
                    Sucesso = true
                };
            }
            catch (Exception ex)
            {
                return new EasyReturn.Web
                {
                    driver = driver,
                    Sucesso = false,
                    Error = ex.Message.ToString()
                };
            }
        }
        public decimal obterCotação()
        {
            if (driver == null)
            {
                this.StartBrowser();

                Navigate("https://www.google.com/");

                AssignValue(TypeElement.Name, "q", "Cotação Bitcoin").element.SendKeys(OpenQA.Selenium.Keys.Enter);
            }
            else
                ExecuteScript("location.reload()");


            WaitForLoad();

            var response = GetValue(TypeElement.Xpath, "//*[@id='crypto-updatable_2']/div[3]/div[2]/span[1]");

            return Convert.ToDecimal(response.Value);
        }

        public void ComprarBitcoin()
        {
            Web web = new Web();
            web.StartBrowser();
            web.Navigate("https://www.mercadobitcoin.com.br/conta/login/");
            web.AssignValue(TypeElement.Id, "id_cpfcnpj", "064555445561");
            web.AssignValue(TypeElement.Id, "id_password", "123456789").element.SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(5));
            web.CloseBrowser();
        }
    }
}