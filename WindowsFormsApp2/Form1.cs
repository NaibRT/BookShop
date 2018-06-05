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
        public Form1()
        {

            InitializeComponent();
            foreach(Language c in Enum.GetValues(typeof(Language)))
            {
                comboBox4.Items.Add(c);
            }
            foreach (Language c in Enum.GetValues(typeof(Book.Condition)))
            {
                comboBox5.Items.Add(c);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    enum Language
    {
        En,
        Az,
        Ru,
        Tr,
        Fr
    }
   
    class Book
    {
        public string Name;
        public List<Author> Authors = new List<Author>();
        public List<Publisher> Publisher = new List<Publisher>();
        public DateTime PublishDate;
        //public string[] Category = new string[] { "Nesr", "Nezm" };
        public enum Category { Nezm, Nesr };
        public Language Lang;
        public float Price;
        public int PaperCount;
        public Discount Discount;
        public uint Stock;
        public enum Condition { New, Used };
        public byte Edition;



    }
    class Author
    {
        public string Name;
        public string Surname;
        public string Email;
        public string Phone;
        public List<Book> book = new List<Book>();
        public string About;
    }

    class Publisher
    {
        public string Name;
        public string Email;
        public string Phone;
        public string Address;
        public Publisher(string _name, string _email, string _phone, string _adress)
        {
            Name = _name;
            Email = _email;
            Phone = _phone;
            Address = _adress;
        }

    }

    class Discount
    {
        public bool discount;
        enum Compaign { NewYear = 10, Novruz = 20, IndependenceDay = 5, Ramadan = 50, Aid = 25 }

    }
}
