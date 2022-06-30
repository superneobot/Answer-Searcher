using AngleSharp;
using Answer_Searcher.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Answer_Searcher
{
    public partial class main : Form
    {
        public List<Info> collection;
        public string answer_link;
        public string sline;
        public string new_zapros;
        public string text_vopros;
        public string text_otvet;
        public bool naiden_otvet = false;
        public main()
        {
            InitializeComponent();
            collection = new List<Info>();
        }

        public async Task<string> ZaprosToLink(string zapros)
        {
            var config = Configuration.Default.WithDefaultLoader();
            var address = $"https://otvetzdes.ru/?s={zapros}";
            var context = BrowsingContext.New(config);
            var txt_zapros = zapros;
            var document = await context.OpenAsync(address);
            var cell = document.QuerySelector("h2[class='post-title']");
            if (cell == null)
            {
                naiden_otvet = false;
                cell = document.QuerySelector("div[class='maincol']");
                var al = cell.TextContent;
                answer_link = al;
            }
            else
            {
                naiden_otvet = true;
                var al = cell.QuerySelector("a");
                var al_url = al.GetAttribute("href");
                answer_link = al_url;
            }

            return answer_link;
        }

        public async Task<List<Info>> GetZaprosText(string zapros)
        {
            var config = Configuration.Default.WithDefaultLoader();
            if (zapros.Contains("http"))
            {
                var address = $"{zapros}";

                var context = BrowsingContext.New(config);
                var document = await context.OpenAsync(address);

                var cell = document.QuerySelector("div[class='post-content gp-clearfix']");

                var text_pl = cell.QuerySelector(@"p");
                var text_p_lines = text_pl.TextContent;
                var otvet = text_p_lines.Substring(text_p_lines.IndexOf("Ответ"));
                var vopros = text_p_lines.Substring(text_p_lines.IndexOf("Вопрос")).Replace(otvet, "");
                collection.Add(new Info(vopros, otvet));
            }
            else
            {
                collection.Add(new Info(sline, "Ничего не найдено"));
            }
            return collection;
        }

        private async void search_btn_Click(object sender, EventArgs e)
        {
            text_out.Clear();
            collection.Clear();
            sline = search_value.Text;
            var line = sline.Replace(' ', '+');
            text_out.AppendText("Ищем..." + "\r" + "\n");
            await ZaprosToLink(line);
            text_out.AppendText("\r" + "\n");
            if (naiden_otvet)
            {
                text_out.AppendText($"Найден ответ: {answer_link}" + "\r" + "\n");
            }
            text_out.AppendText("\r" + "\n");
            await GetZaprosText(answer_link);

            text_out.AppendText($"{collection[0].Zapros}" + "\r" + "\n");
            text_out.AppendText("\r" + "\n");
            text_out.AppendText($"{collection[0].Otvet}" + "\r" + "\n");
            text_out.AppendText("\r" + "\n");
            search_value.Clear();
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var s = text_out.SelectedText;
            if (s != string.Empty)
            {
                Clipboard.SetText(s);
            }
            else
            {
                MessageBox.Show(this,"Ничего не выбрано", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void search_value_Click(object sender, EventArgs e)
        {
            search_value.SelectAll();
        }
    }
}
