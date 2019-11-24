using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// For serialization
using System.Runtime.Serialization.Formatters.Binary;
using Final_Project.Classes;
using Final_Project;
// using BookCDDVDShop.Classes;
/*
 * Rawnaz Anam & Wilson Diaz
 * CIS 3309
 * Final Project
 * Stage 1
 * 11/23/2019
 */
namespace Final_Project.Classes
{
    // CDOrchestra inherits the data and methods in Product
    [Serializable()]
     class CDOrchestra : CDClassical
    {
        private string hiddenConductor; //one name

        // Parameterless Constructor
        public CDOrchestra()
        {
            hiddenConductor = "";
        }  // end Parameterless Constructor


        // Parameterized constructor
        public CDOrchestra(int UPC, decimal price, string title, int quantity,  // For Product Constructor
            string label, string artists, string Conductor) : base(UPC, price, title, quantity, label, artists)
        {
            hiddenConductor = Conductor;
        }  // end parameterized constructor



        // These six methods replace what were VB Properties
        // get or set an item in the List
        // Accessor/mutator for Tuition, Year and Credits
        public string getCDOrchestraConductor()
        {
            return hiddenConductor;
        }  // end getgradHourlyPay


        public void setCDOrchestraConductor(string value)
        {
            hiddenConductor = value;
        }  // end get



        // Save data from form to object
        public override void Save(frmBookCDDVDShop f)
        {
            base.Save(f);
            hiddenConductor = f.txtCDOrchestraConductor.Text;
        }  // end Save


        // Display data in object on form
        public override void Display(frmBookCDDVDShop f)
        {
            //f.txtCDOrchestraConductor.Enabled = true;
            f.lblConductor.Visible = true;
            f.lblConductor.Enabled = true;
            f.txtCDOrchestraConductor.Visible = true;
            base.Display(f);
            f.txtCDOrchestraConductor.Text = hiddenConductor;
        }  // end Display


        // This toString function overrides the Student toString
        // function.  The base refers to the Student because this class
        // inherits Student by definition.
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "Conductor:  " + hiddenConductor;
            return s;
        } //  end ToString

    }  // end CDClChamber Class
}  // end namespace  