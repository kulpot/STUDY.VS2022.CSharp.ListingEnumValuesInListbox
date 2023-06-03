using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Ref link:https://www.youtube.com/watch?v=kUacOIJHieY&list=PLAIBPfq19p2EJ6JY0f5DyQfybwBGVglcR&index=60
// listing enum value in a listbox as well as getting the selected enum.

namespace ListingEnumValuesInListbox
{
    public partial class Form1 : Form
    {
        enum Rating {  Low, Medium, High };

        public Form1()
        {
            InitializeComponent();
            //listBox1.Items.AddRange(typeof(Rating).GetEnumNames());

            Array valArray = Enum.GetValues(typeof(Rating));
            //Array valArray = typeof(Rating).GetEnumValues();
            //Enum.GetValues(typeof(Rating)); // static method ...same 

            //foreach(object obj in valArray)
            foreach (Rating ratingValue in valArray)
            {
                //listBox1.Items.Add(obj);
                listBox1.Items.Add(ratingValue);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rating rating = (Rating)listBox1.SelectedItem; // check line break step in
        }
    }
}
