using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaracalViewBotv3
{
    public partial class Form1 : Form
    {
        //DEĞİŞKENLER
        int proxyAmount = 0, userAgentsAmount = 0;
        IWebDriver driver;

        public async void DriverBaslat(string proxy, string userAgent)
        {
            ChromeDriverService cds = ChromeDriverService.CreateDefaultService();
            cds.HideCommandPromptWindow = true;
            ChromeOptions co = new ChromeOptions();
            if (!string.IsNullOrEmpty(proxy) ||!string.IsNullOrEmpty(userAgent))
            {
                co.AddArgument("--proxy-server=" + proxy);
                co.AddArgument("--user-agent=" + userAgent);

            }
            driver = new ChromeDriver(cds, co);
            driver.Manage().Window.Size = new Size(650, 400);
            await Task.Delay(2000);
        }

        //USER-AGENT ICIN RANDOM SAYI URETECİ
        public int randomSayi(int maxLines)
        {
            Random rd = new Random();
            int satir = rd.Next(0, maxLines);
            return satir;

        }

        //VERİLEN URL'Yİ AÇIP TIKLATMA İŞLEMİ
        public async Task<bool> Islem(int s, int delay, int afterDelay) {
            bool basarili = false;
            try
            {
                DriverBaslat(proxyList_txtbox.Lines[s], userAgents_txtbox.Lines[randomSayi(userAgents_txtbox.Lines.Length)]);
                proxyUsed_lbl.Text = proxyList_txtbox.Lines[s].ToString();
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromMilliseconds(delay);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(delay);
                driver.Navigate().GoToUrl(url_txtbox.Text);
                await Task.Delay(afterDelay);
                //Reklamı geç butonuna tıklatma
                //IWebElement reklamiGecBtn = driver.FindElement(By.CssSelector("#movie_player > div.ytp-cued-thumbnail-overlay > button > div"));
                //((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", reklamiGecBtn);
                //await Task.Delay(10000);
                //driver.SwitchTo().Window(driver.WindowHandles.First());
                //await Task.Delay(2000);
                driver.Quit();
                basarili = true;
            }
            catch (Exception ex)
            {
                log_lstbox.Items.Add("ERROR: " + ex.Message);
                basarili = false;
                driver.Quit();

            }
            return basarili;

        }

        //START BUTONU
        private async void start_btn_Click(object sender, EventArgs e)
        {
            viewDone_progressbar.Maximum = proxyList_txtbox.Lines.Length;
            int delayTime = int.Parse(delay_numericUpDown.Value.ToString());
            int afterDelayTime = int.Parse(afterDelay_nud.Value.ToString());

            await Task.Run(async () =>
            {
                try
                {
                    for (int i = 0; i < proxyList_txtbox.Lines.Length; i++) {

                        if (await Islem(i,delayTime,afterDelayTime))
                        {
                            log_lstbox.Items.Add("Operation successfully completed: " + i);
                        }
                        else {
                            log_lstbox.Items.Add("Operation is not successful: " + i);
                        }

                        viewDone_progressbar.Value = i+1;
                        viewDone_lbl.Text = (i+1).ToString();

                    }
                }
                catch (Exception ex)
                {
                    log_lstbox.Items.Add("Operation is not successful: " + ex.Message);
                }
            });
        }

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void loadProxyList_btn_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.FileName = "Select Proxy List";
                openFileDialog1.Filter = "Proxy List (*txt) |*.txt";
                openFileDialog1.ShowDialog();
                StreamReader reader = new StreamReader(openFileDialog1.FileName);
                proxyList_txtbox.Text = reader.ReadToEnd();
                reader.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            //PROXY SAYISINI GÖSTER
            for (int i = 0; i < proxyList_txtbox.Lines.Length; i++)
            {
                proxyAmount++;
            }
            proxyAmount_lbl.Text = proxyAmount.ToString();
        }

        private void loadUserAgents_btn_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.FileName = "Select User-Agnets List";
                openFileDialog1.Filter = "User-Agents List (*txt) |*.txt";
                openFileDialog1.ShowDialog();
                StreamReader reader = new StreamReader(openFileDialog1.FileName);
                userAgents_txtbox.Text = reader.ReadToEnd();
                reader.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            //USER-AGENTS SAYISINI GÖSTER
            for (int j = 0; j < userAgents_txtbox.Lines.Length; j++)
            {
                userAgentsAmount++;
            }
            userAgentsAmount_lbl.Text = userAgentsAmount.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

    }
}
