using BookCDDVDShop;
using Final_Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class frmBookCDDVDShop : Form
    {
        int i = 0; //used to know which product type we are dealing with

        Product p; //temp ref for products
        private ProductList productList; //our list of products

        public frmBookCDDVDShop()
        {
            InitializeComponent();
        }

        private void FrmBookCDDVDShop_Load(object sender, EventArgs e)
        {
            //read from file and set productlist to saved data if it exists/create new productlist if there is no previous data
            SFManager.readFromFile(ref productList, "ourFile.dat");

            //button tooltips
            toolTipHints.SetToolTip(btnCreateBook, "Click button to create new book");
            toolTipHints.SetToolTip(btnCreateBookCIS, "Click button to create new CIS book");
            toolTipHints.SetToolTip(btnCreateDVD, "Click button to create new DVD");
            toolTipHints.SetToolTip(btnCreateCDOrchestra, "Click button to create new Orchestra CD");
            toolTipHints.SetToolTip(btnCreateCDChamber, "Click button to create new Chamber Music CD");
            toolTipHints.SetToolTip(btnSearchUPC, "Click button to search entered UPC");

            //search tooltip
            toolTipHints.SetToolTip(txtProductUPCSearch,"Enter 5 digit integer for UPC to search");

            //product tooltips
            toolTipHints.SetToolTip(txtProductUPC,"Please input 5 digit integer for UPC number");
            toolTipHints.SetToolTip(txtProductPrice, "Please input decimal value to 2 decimal places for price");
            toolTipHints.SetToolTip(txtProductTitle, "Please input the name of the product, can be more than one word and alphanumerical");
            toolTipHints.SetToolTip(txtProductQuantity, "Please input integer value for the amount of product");

            //dvd tooltips
            toolTipHints.SetToolTip(txtDVDLeadActor, "Only one space between names. Only the last may be hyphenated. No trailing spaces.");
            toolTipHints.SetToolTip(txtDVDReleaseDate, "Please choose a date between 11/01/1996 and 12/31/2019.");
            toolTipHints.SetToolTip(txtDVDRunTime, "Please input a positive integer value less than 240.");

            //cd tooltips
            toolTipHints.SetToolTip(txtCDChamberInstrumentList, "Please input a list of comma separated instruments. Instrument names may have spaces.");
            toolTipHints.SetToolTip(txtCDClassicalArtists, "Input comma separated names. Names may have spaces, but only the last may be hyphenated. No trailing spaces.");
            toolTipHints.SetToolTip(txtCDClassicalLabel, "Please input the name of the label");
            toolTipHints.SetToolTip(txtCDOrchestraConductor, "Only one space between names. Only the last may be hyphenated. No trailing spaces.");

            //book tooltips
            toolTipHints.SetToolTip(txtBookISBNLeft, "Please input 3 integer positive digits for the ISBN of product");
            toolTipHints.SetToolTip(txtBookISBNRight, "Please input 3 integer positive digits for the ISBN of product");
            toolTipHints.SetToolTip(txtBookAuthor, "Please input name of the author, include only 1 space after each name, allows hyphenated last name");
            toolTipHints.SetToolTip(txtBookPages, "Please input integer value for the number of pages in the book");

            this.txtBookCISCISArea.DropDownStyle = ComboBoxStyle.DropDownList; //dont allow user input in combobox
        }

        //this is a book
        private void BtnCreateBook_Click(object sender, EventArgs e)
        {
            i = 1;
            FormController.CreateBook(this);

        }

        //this is a cis book
        private void BtnCreateBookCIS_Click(object sender, EventArgs e)
        {
            i = 2;
            FormController.CreateBookCIS(this);

        }
        //this is a dvd

        private void BtnCreateDVD_Click(object sender, EventArgs e)
        {
            i = 3;
            FormController.CreateDVD(this);
        }
        //this is a orchestra cd

        private void BtnCreateCDOrchestra_Click(object sender, EventArgs e)
        {
            i = 4;
            FormController.CreateCDOrchestra(this);
        }
        //this is a chamber cd

        private void BtnCreateCDChamber_Click(object sender, EventArgs e)
        {
            i = 5;
            FormController.CreateCDChamber(this);
        }

        //this is a clear form operation

        private void BtnClearForm_Click(object sender, EventArgs e)
        {

            FormController.clearForm(this);

        }
        //this is a reset form operation

        private void BtnResetForm_Click(object sender, EventArgs e)
        {
            i = 0;
            FormController.resetForm(this);
        }

        //this is what happens when you click search

        private void BtnSearchUPC_Click(object sender, EventArgs e)
        {
            bool temp = Validator.validateUPC(txtProductUPCSearch.Text); //first make sure the format is correct
            if (temp)
            {

                 p = productList.find(Convert.ToInt32(txtProductUPCSearch.Text)); //search our list for this upc
                if (p == null) //not found
                {
                    MessageBox.Show("Product not found");
                    txtProductUPCSearch.Clear();
                    txtProductUPCSearch.Focus();

                }
                else //found -- call display method to show attrs on form
                {
                    p.Display(this);
                    FormController.searchForm(this);
                    txtProductUPCSearch.Clear();

                }
            }
            else //user needs to fix format
            {
                MessageBox.Show("Invalid UPC format");
                txtProductUPCSearch.Clear();
                txtProductUPCSearch.Focus();


            }
        }

        //this is what happens when we try to save an object
        private void BtnSave_Click(object sender, EventArgs e)
        {
            //first check that all product attrs have the correct formats
            bool correct = Validator.validateUPC(txtProductUPC.Text) && Validator.validatePrice(txtProductPrice.Text)
                && Validator.validateTitle(txtProductTitle.Text) && Validator.validateIntNumber(txtProductQuantity.Text);
            if (correct) //next check each if the upc entered is not already taken (unique)
            {
                Product t = productList.find(Convert.ToInt32(txtProductUPC.Text));
                if (t == null) //not found == means unique == ok to continue
                {
                    //check each product types' specific attr formats depending on the product type
                    //create the product if format is ok and add it to the list

                    if (i == 1)
                    {

                        bool temp = Validator.validateName(txtBookAuthor.Text) && Validator.validateISBN(txtBookISBNLeft.Text) &&
                            Validator.validateISBN(txtBookISBNRight.Text) && Validator.validateIntNumber(txtBookPages.Text);
                        if (temp)
                        {
                            Book book = new Book(Convert.ToInt32(txtProductUPC.Text), Convert.ToDecimal(txtProductPrice.Text), txtProductTitle.Text, Convert.ToInt32(txtProductQuantity.Text),
                                txtBookISBNLeft.Text, txtBookISBNRight.Text, txtBookAuthor.Text, Convert.ToInt32(txtBookPages.Text));
                            productList.add(book);
                            MessageBox.Show("Book Added to Library");
                            FormController.resetForm(this);

                        }
                        else
                        {
                            MessageBox.Show("Please check input in Book Fields");

                        }
                    }
                    else if (i == 2)
                    {
                        bool temp = Validator.validateName(txtBookAuthor.Text) && Validator.validateISBN(txtBookISBNLeft.Text) &&
                            Validator.validateISBN(txtBookISBNRight.Text) && Validator.validateIntNumber(txtBookPages.Text) && (txtBookCISCISArea.Text != "");
                        if (temp)
                        {
                            BookCIS book = new BookCIS(Convert.ToInt32(txtProductUPC.Text), Convert.ToDecimal(txtProductPrice.Text), txtProductTitle.Text, Convert.ToInt32(txtProductQuantity.Text),
                                txtBookISBNLeft.Text, txtBookISBNRight.Text, txtBookAuthor.Text, Convert.ToInt32(txtBookPages.Text), txtBookCISCISArea.Text);
                            productList.add(book);
                            MessageBox.Show("Book Added to Library");
                            FormController.resetForm(this);

                        }
                        else
                        {
                            MessageBox.Show("Please check input in Book Fields");

                        }

                    }
                    else if (i == 3)
                    {
                        bool temp = Validator.validateName(txtDVDLeadActor.Text) && Validator.validateRunTime(txtDVDRunTime.Text) &&
                            Validator.validateReleaseDate(txtDVDReleaseDate.Value);
                        if (temp)
                        {
                            DVD dvd = new DVD(Convert.ToInt32(txtProductUPC.Text), Convert.ToDecimal(txtProductPrice.Text), txtProductTitle.Text, Convert.ToInt32(txtProductQuantity.Text),
                                txtDVDLeadActor.Text, txtDVDReleaseDate.Value, Convert.ToInt32(txtDVDRunTime.Text));
                            productList.add(dvd);
                            MessageBox.Show("DVD Added to Library");
                            FormController.resetForm(this);

                        }
                        else
                        {
                            MessageBox.Show("Please check input in DVD Fields");

                        }
                    }
                    else if (i == 4)
                    {
                        bool temp = Validator.validateName(txtCDClassicalLabel.Text) && Validator.validateArtists(txtCDClassicalArtists.Text) &&
                            Validator.validateName(txtCDOrchestraConductor.Text);
                        if (temp)
                        {
                            CDOrchestra cd = new CDOrchestra(Convert.ToInt32(txtProductUPC.Text), Convert.ToDecimal(txtProductPrice.Text), txtProductTitle.Text, Convert.ToInt32(txtProductQuantity.Text),
                                txtCDClassicalLabel.Text, txtCDClassicalArtists.Text, txtCDOrchestraConductor.Text);
                            productList.add(cd);
                            MessageBox.Show("CD Added to Library");
                            FormController.resetForm(this);

                        }
                        else
                        {
                            MessageBox.Show("Please check input in CD Fields");

                        }

                    }
                    else if (i == 5)
                    {
                        bool temp = Validator.validateName(txtCDClassicalLabel.Text) && Validator.validateArtists(txtCDClassicalArtists.Text) &&
                            Validator.validateInstruments(txtCDChamberInstrumentList.Text);
                        if (temp)
                        {
                            CDChamber cd = new CDChamber(Convert.ToInt32(txtProductUPC.Text), Convert.ToDecimal(txtProductPrice.Text), txtProductTitle.Text, Convert.ToInt32(txtProductQuantity.Text),
                                txtCDClassicalLabel.Text, txtCDClassicalArtists.Text, txtCDChamberInstrumentList.Text);
                            productList.add(cd);
                            MessageBox.Show("CD Added to Library");
                            FormController.resetForm(this);

                        }
                        else
                        {
                            MessageBox.Show("Please check input in CD Fields");

                        }

                    }
                }
                else //not unique
                {
                    MessageBox.Show("Product with same UPC already exists");
                }
            }
            else //incorrect format used in general product fields
            {
                MessageBox.Show("Please check input in Prodcut Fields");
            }
        }

        //after clicking update, this will execute
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            FormController.formUpdate(this);
            this.btnResetForm.Enabled = false; //don't let user exit or reset without saving again
            this.btnExit.Enabled = false;

            //check what is visible to know the type of object we're dealing with and set i accordingly
            //delete the object from the list

            if (txtBookCISCISArea.Visible) 
            {
                i = 2;
                int del = p.ProductUPC;
                productList.delete(del);
            }
            else if (grpBook.Visible)
            {
                i = 1;
                int del = p.ProductUPC;
                productList.delete(del);
            }
            
            else if (grpDVD.Visible)
            {
                i = 3;
                int del = p.ProductUPC;
                productList.delete(del);
            }
            else if (txtCDOrchestraConductor.Visible)
            {
                i = 4;
                int del = p.ProductUPC;
                productList.delete(del);
            }
            else if (txtCDChamberInstrumentList.Visible)
            {
                i = 5;
                int del = p.ProductUPC;
                productList.delete(del);
            }
            
        }

        //this happens when you click delete
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int del = p.ProductUPC;
            productList.delete(del);
            FormController.resetForm(this);
        }

        //we need to write out our list to the serializable file on exiting
        private void BtnExit_Click(object sender, EventArgs e)
        {
            SFManager.writeToFile(productList, "ourFile.dat");
            this.Close();
        }
    }
}
