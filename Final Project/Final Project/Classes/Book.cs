using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Rawnaz Anam & Wilson Diaz
 * CIS 3309
 * Final Project
 * Stage 1
 * 11/23/2019
 */
namespace Final_Project.Classes
{
    [Serializable()]
    class Book : Product
    {
        private string isbnLeft; //three digits
        private string isbnRight;// ^^^
        private string author;//a name
        private int pages;//positive int

        //paramenterless construcor
        public Book()
        {
            this.isbnLeft = "";
            this.isbnRight = "";
            this.author = "";
            this.pages = 0;
        }

        //parameterized constructor
        public Book(int UPC, decimal price, string title, int quantity,
            string isbnLeft, string isbnRight, string author, int pages) : base(UPC, price, title, quantity)
        {
            this.isbnLeft = isbnLeft;
            this.isbnRight = isbnRight;
            this.author = author;
            this.pages = pages;
        }

        //display this product's attributes on the form

        public override void Display(frmBookCDDVDShop f)
        {
            f.grpBook.Enabled = true;
            f.grpBook.Visible = true;
            base.Display(f);
            f.txtBookISBNLeft.Text = isbnLeft;
            f.txtBookISBNRight.Text = isbnRight;
            f.txtBookAuthor.Text = author;
            f.txtBookPages.Text = Convert.ToString(pages); 
        }  // end Display


    }
}
