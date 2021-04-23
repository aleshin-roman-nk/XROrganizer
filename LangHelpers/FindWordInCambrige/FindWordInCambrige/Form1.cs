using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindWordInCambrige
{
	public partial class Form1 : Form
	{
		enum WebMode { DictionaryCambridge, TranslatorGoogle, TranslatorYandex }

		public ChromiumWebBrowser browser;
		public ChromiumWebBrowser browserR;

		string base_cambrige = "https://dictionary.cambridge.org/ru/%D1%81%D0%BB%D0%BE%D0%B2%D0%B0%D1%80%D1%8C/%D0%B0%D0%BD%D0%B3%D0%BB%D0%B8%D0%B9%D1%81%D0%BA%D0%B8%D0%B9/";
		string base_translator_google = "https://translate.google.ru/";
		string base_translator_yandex = "https://translate.yandex.ru/";
		string base_study_50lang = "https://www.50languages.com/phrasebook/lesson/ru/tr";
		string base_study_native_english = "https://www.native-english.ru/";
		string base_verb123 = "http://verb123.com/";
		string base_dopeoplesay = "https://dopeoplesay.com/";

		string main_form_title_base = "CAMBRIDGE DICTIONARY";
		public Form1()
		{
			InitializeComponent();

			InitBrowser();

			btnBack.Enabled = browser.CanGoBack;
			btnForw.Enabled = browser.CanGoForward;
		}



		private string dictionaryCambridgeUrl(string word)
		{
			StringBuilder builder = new StringBuilder($"{base_cambrige}{word}");
			return builder.ToString();
		}

		private void goWithWord(string word)
		{
			browser.Load(dictionaryCambridgeUrl(word));
			btnBack.Enabled = browser.CanGoBack;
			btnForw.Enabled = browser.CanGoForward;
		}

		private void textBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if(Keys.Enter == e.KeyCode)
			{
				goWithWord(textBox1.Text);
				e.Handled = true;
			}
		}

		////////////////////////

		private void InitBrowser()
		{
			try
			{
				if (!Cef.IsInitialized)
				{
					CefSettings settings = new CefSettings();
					settings.BrowserSubprocessPath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "CefSharp.BrowserSubprocess.exe");

					Cef.Initialize(settings);
				}
				string url = base_translator_yandex;

				browser = new ChromiumWebBrowser(url);
				Thread.Sleep(2000);
				browserR = new ChromiumWebBrowser(url);
				this.browserPanel.Controls.Add(browser);
				this.panel2.Controls.Add(browserR);
				browser.Dock = DockStyle.Fill;
				browserR.Dock = DockStyle.Fill;

				browser.TitleChanged += Browser_TitleChanged;
				browser.AddressChanged += Browser_AddressChanged;
				//browser.IsBrowserInitializedChanged += Browser_IsBrowserInitializedChanged;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString());
			}
		}

		private void Browser_AddressChanged(object sender, AddressChangedEventArgs e)
		{
			this.InvokeOnUiThreadIfRequired(() =>
			{
				btnBack.Enabled = browser.CanGoBack;
				btnForw.Enabled = browser.CanGoForward;
				Text = $"{main_form_title_base} : {e.Address}";
			});
		}

		private void Browser_TitleChanged(object sender, TitleChangedEventArgs e)
		{
			this.InvokeOnUiThreadIfRequired(() => txtTitle.Text = e.Title);
		}

		private void btnTranslatorGoogle_Click(object sender, EventArgs e)
		{
			browser.Load(base_translator_google);
			btnBack.Enabled = browser.CanGoBack;
			btnForw.Enabled = browser.CanGoForward;
		}

		private void btnTranslatorYandex_Click(object sender, EventArgs e)
		{
			browser.Load(base_translator_yandex);
			btnBack.Enabled = browser.CanGoBack;
			btnForw.Enabled = browser.CanGoForward;
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			browser.Back();
			btnBack.Enabled = browser.CanGoBack;
			btnForw.Enabled = browser.CanGoForward;
		}

		private void btnForw_Click(object sender, EventArgs e)
		{
			browser.Forward();
			btnBack.Enabled = browser.CanGoBack;
			btnForw.Enabled = browser.CanGoForward;
		}

		private void btn50Langs_Click(object sender, EventArgs e)
		{
			browser.Load(base_study_50lang);
			btnBack.Enabled = browser.CanGoBack;
			btnForw.Enabled = browser.CanGoForward;
		}

		private void btnNativeEnglish_Click(object sender, EventArgs e)
		{
			browser.Load(base_study_native_english);
			btnBack.Enabled = browser.CanGoBack;
			btnForw.Enabled = browser.CanGoForward;
		}

		private void btnVerb123_Click(object sender, EventArgs e)
		{
			browser.Load(base_verb123);
			btnBack.Enabled = browser.CanGoBack;
			btnForw.Enabled = browser.CanGoForward;
		}

		private void btnDoPeopleSay_Click(object sender, EventArgs e)
		{
			browser.Load(base_dopeoplesay);
			btnBack.Enabled = browser.CanGoBack;
			btnForw.Enabled = browser.CanGoForward;
		}

		private void btnRGoggle_Click(object sender, EventArgs e)
		{
			browserR.Load(base_translator_google);
		}

		private void btnRYandex_Click(object sender, EventArgs e)
		{
			browserR.Load(base_translator_yandex);
		}

		private void btnR50Lang_Click(object sender, EventArgs e)
		{
			browserR.Load(base_study_50lang);
		}

		private void btnRNative_Click(object sender, EventArgs e)
		{
			browserR.Load(base_study_native_english);
		}

		private void btnRV123_Click(object sender, EventArgs e)
		{
			browserR.Load(base_verb123);
		}

		private void btnRDoPeopleSay_Click(object sender, EventArgs e)
		{
			browserR.Load(base_dopeoplesay);
		}
	}
}
