using EasyAutomationFramework;

namespace ChatBotApp
{
    public class SendMessage: Web
    {
        public void Perform(string body, string to)
        {
            StartBrowser(TypeDriver.GoogleChorme, "C:\\Users\\usuario\\AppData\\Local\\Google\\Chrome\\User Data");
            Navigate("https://web.whatsapp.com/");
            WaitForLoad();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            var elementSearch = AssignValue(
                TypeElement.Xpath,
                "/html/body/div[1]/div/div[2]/div[3]/div/div[1]/div/div[2]/div[2]/div/div[1]/p",
                to
            );
                elementSearch.element.SendKeys(OpenQA.Selenium.Keys.Enter);
            var elementMessage = AssignValue(
                TypeElement.Xpath,
                "/html/body/div[1]/div/div[2]/div[4]/div/footer/div[1]/div/span[2]/div/div[2]/div[1]/div[2]/div[1]/p", 
                body
            );
            elementMessage.element.SendKeys(OpenQA.Selenium.Keys.Enter);
        }
    }
}
