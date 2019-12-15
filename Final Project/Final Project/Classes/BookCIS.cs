using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Classes
{
    [Serializable()]
    class BookCIS : Book
    {
        private string cisArea; //chosen from dropdown menu

        //parameterless constructor
        public BookCIS()
        {
            this.cisArea = "";
        }

        //paratemterized constructor
        public BookCIS(int UPC, decimal price, string title, int quantity,
            string isbnLeft, string isbnRight, string author, int pages, string cisArea) : base(UPC, price, title, quantity,
            isbnLeft, isbnRight, author, pages)
        {
            this.cisArea = cisArea;
        }

        //display this product's attributes on the form
        public override void Display(frmBookCDDVDShop f)
        {
            f.grpBook.Enabled = true;
            f.grpBook.Visible = true;
            f.txtBookCISCISArea.Visible = true;
            f.lblCIS.Visible = true;
            f.lblCIS.Enabled = true;
            base.Display(f);
            f.txtBookCISCISArea.Text = cisArea.ToString();
            
        }  // end Display 


    }
}
