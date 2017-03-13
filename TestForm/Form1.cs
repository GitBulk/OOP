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
            List<Product> produts = new List<Product>();
            produts.Add(new Product()
            {
                color = new Color() { red = 0, green = 1, blue = 2 },
                name = "p1",
                price = 1
            });
            produts.Add(new Product()
            {   
                color = new Color() { red = 0, green = 1, blue = 2 },
                name = "p2",
                price = 2
            });
            string json =  JsonConvert.SerializeObject(produts);
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

        private void btnInheritance_Click(object sender, EventArgs e)
        {
            Child instance = new Child();
            instance.Increment();
        }

        private void btnLinq_Click(object sender, EventArgs e)
        {
            List<Person> people = new List<Person>()
            {
                new Person() { Age = 30, Hobbies = new List<string> () { "music", "food" }, Name = "toan" },
                new Person() { Age = 40, Hobbies = new List<string> () { "music", "food" }, Name = "tran" },
                new Person() { Age = 45, Hobbies = new List<string> () { "film" }, Name = "ngoc" },
                new Person() { Age = 5, Hobbies = new List<string> () { "car" }, Name = "ronaldo" },
                new Person() { Age = 32, Hobbies = new List<string> () { "tea" }, Name = "messi" }
            };


            var query = people.Where(p => p.Age > 20).SelectMany(x => x.Hobbies.Select(d => d)).Distinct().ToList();
            //var query = people.Where(p => p.Age > 20).SelectMany(x => x.Hobbies.Select(d => d)).ToList();
            int count = query.Count();
        }

        private void btnMulticastDelegate_Click(object sender, EventArgs e)
        {
            NumberChanger multicast;
            var sum = new NumberChanger(AddNum);
            var mul = new NumberChanger(MulNum);

            
            multicast = sum;
            multicast += mul;


            //sum(25);
            //string s = "Sum Cast: " + number;

            //mul(5);
            //s += Environment.NewLine + "Mul Cast: " + number;

            string s = "Multicast: " + multicast(5);
            MessageBox.Show(s);

        }

        static int number = 10;
        private static int AddNum(int input)
        {
            number += input;
            return number;
        }

        private static int MulNum(int input)
        {
            number *= input;
            return number;
        }

        private void btnNewMethod_Click(object sender, EventArgs e)
        {
            Child2 child = new Child2();
            child.DoNew();

            Father father = new Child2();
            father.DoNew();
        }

        private void btnOverride_Click(object sender, EventArgs e)
        {
            Child2 child = new Child2();
            child.DoOverride();

            Father father = new Child2();
            father.DoOverride();
        }
    }

    delegate int NumberChanger(int n);

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Hobbies { get; set; }
    }

    public class Post
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }


    class Parent
    {
        protected int Count;
        public Parent()
        {
            Count = 0;
        }
    }

    class Child : Parent
    {
        private string name;
        public Child()
        {
            name = "Child";
        }

        public void Increment()
        {
            Count = Count + 1;
        }
        
    }
        
    public class Product
    {
        public int price { get; set; }
        public string name { get; set; }
        public Color color { get; set; }
    }

    public class Color
    {
        public int red { get; set; }
        public int green { get; set; }
        public int blue { get; set; }
    }

    public class Father
    {
        public virtual void DoOverride()
        {
            Console.WriteLine("In father ovrride");
        }

        public void DoNew()
        {
            Console.WriteLine("In father new");
        }
    }

    public class Child2: Father
    {
        public override void DoOverride()
        {
            Console.WriteLine("In child2 ovrride");
        }

        public new int DoNew()
        {
            Console.WriteLine("In Child new");
            return 1;
        }
    }

}
