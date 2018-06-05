using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        static List<Book> Books = new List<Book>();
        static List<Author> Authors = new List<Author>();
        static List<Publisher> Publishers = new List<Publisher>();
        public Form1()
        {

            InitializeComponent();
            
            foreach(Language c in Enum.GetValues(typeof(Language)))
            {
                comboBox4.Items.Add(c);
            }
            foreach (Condition c in Enum.GetValues(typeof(Condition)))
            {
                comboBox5.Items.Add(c);
            }
            foreach (Category c in Enum.GetValues(typeof(Category)))
            {
                comboBox3.Items.Add(c);
            }

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Publisher publisher1 = new Publisher();
            publisher1.Name = textBox19.Text;
            publisher1.Email = textBox20.Text;
            publisher1.Phone = textBox21.Text;
            publisher1.Address = textBox22.Text;
            Publishers.Add(publisher1);
            MessageBox.Show(publisher1.Name);
            foreach (var c in Publishers)
            {
                comboBox2.Items.Add(c.Name);
            }
            textBox19.Text = "";
            textBox20.Text = "";
            textBox21.Text = "";
            textBox22.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Author author = new Author();
            author.Name = textBox8.Text;
            author.Surname = textBox13.Text;
            author.Email = textBox14.Text;
            author.Phone = Convert.ToInt32(textBox15.Text);
            author.About = textBox17.Text;
            Authors.Add(author);
            foreach (var c in Authors)
            {
                comboBox1.Items.Add(c.Name);
            }
            textBox8.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox17.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Name = textBox1.Text;
            book.Author = comboBox1.SelectedItem.ToString();
            book.Publisher = comboBox2.SelectedItem.ToString();
            book.PublishDate =DateTime.Parse(textBox4.Text);
            book.Category = comboBox3.SelectedItem.ToString();
            book.Lang = comboBox4.SelectedItem.ToString();
            book.Price =Convert.ToDecimal( textBox7.Text);
            book.PaperCount = Convert.ToInt32(textBox12.Text);
            book.Stock = Convert.ToUInt32(textBox10.Text);
            book.Conditions = comboBox5.SelectedItem.ToString();
            book.Edition = Convert.ToByte(textBox2.Text);
            Books.Add(book);
            textBox1.Text = "";
            textBox4.Text = "";
            textBox7.Text = "";
            textBox12.Text = "";
            textBox10.Text = "";
            textBox2.Text = "";
            foreach (var item in Books)
            {
                richTextBox1.Text += item.Name;
            }
        }

       
    }
    enum Language { En, Az, Ru, Tr,Fr};
    enum Condition { New, Used };
    enum Category { Nezm, Nesr };
    class Book
    {
        public string Name;
        public string Author;
        public string Publisher;
        public DateTime PublishDate;
        //public string[] Category = new string[] { "Nesr", "Nezm" };
        public string Category;
        public string Lang;
        public decimal Price;
        public int PaperCount;
        public uint Stock;
        public string Conditions;
        public byte Edition;
        //public Book(string _name,Author _author,Publisher _publisher,DateTime _publishdate,Language _Lang,float _price,int _papercount,uint _stock,Condition _condition,byte _edition )
        //{
        //    Name = _name;
        //    Authors.Add(_author);
        //    Publishers.Add(_publisher);
        //    PublishDate = _publishdate;
        //    Lang = _Lang;
        //    Price = _price;
        //    PaperCount = _papercount;
        //    Stock = _stock;
        //    Conditions = _condition;
        //    Edition = _edition;
        //}


    }
    class Author
    {
        public string Name;
        public string Surname;
        public string Email;
        public int Phone;
        //public List<Book> book = new List<Book>();
        public string About;
        //public Author(string _name,string _surname,string _email,int _phone,string _about)
        //{
        //    Name = _name;
        //    Surname = _surname;
        //    Email = _email;
        //    Phone = _phone;
        //    About = _about;

        //}
    }

    class Publisher
    {
        public string Name;
        public string Email;
        public string Phone;
        public string Address;
        //public Publisher(string _name, string _email, string _phone, string _adress)
        //{
        //    Name = _name;
        //    Email = _email;
        //    Phone = _phone;
        //    Address = _adress;
        //}

    }
}
