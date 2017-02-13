using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object ob = null;
            if (ob.Equals(null))
            {
                MessageBox.Show("null");
            }
            else
            {
                MessageBox.Show("not null");
            }
        }


        


        public static async Task<string> GetJsonAsync(Uri uri)
        {
            using (var client = new HttpClient())
            {
                var jsonString = await client.GetStringAsync(uri).ConfigureAwait(false);
                //return JsonConvert.DeserializeObject<LiPost>(jsonString);
                return jsonString;
            }
        }

        private async void btnExcuteApi_Click(object sender, EventArgs e)
        {
            // http://blog.stephencleary.com/2012/07/dont-block-on-async-code.html
            var jsonTask = await GetJsonAsync(new Uri("https://jsonplaceholder.typicode.com/posts"));
            MessageBox.Show("result: " + jsonTask);
            //textBox1.Text = jsonTask.Result;
        }
    }

    public class Post
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }
}
