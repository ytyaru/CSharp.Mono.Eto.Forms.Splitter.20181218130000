using System;
using Eto.Forms;
using Eto.Drawing;

namespace Hello0
{
    public partial class MainForm : Form
    {
        private RichTextArea textarea1;
        private WebView webView1;
        public MainForm()
        {
            Title = "Splitter";
            ClientSize = new Size(800, 600);
            CreateUi();
        }
        private void CreateUi()
        {
            //textarea1 = new RichTextArea() { Width=this.Width/2, Height=this.Height, Text="何かしらの文字列。" };
            textarea1 = new RichTextArea() { Width=1, Height=1, Text="何かしらの文字列。" };
            textarea1.Focus();
            webView1 = new WebView() { Width=1, Height=1, Url=new Uri("https://www.google.co.jp") } ;
            //webView1 = new WebView() { Width=this.Width/2, Height=this.Height, Url=new Uri("https://www.google.co.jp") } ;
            var splitter= new Eto.Forms.Splitter();
            splitter.Panel1 = textarea1;
            splitter.Panel2 = webView1;
            //splitter.Panel1.Width = this.Width / 2;
            Content = new TableLayout() {
                Padding = 0,
                Spacing = new Size(0, 0),
                Rows = {
                    new TableRow(splitter),
                }
            };
        }
    }
}
