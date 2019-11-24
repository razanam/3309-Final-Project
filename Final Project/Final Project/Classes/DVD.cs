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
    class DVD : Product
    {
        private string leadActor; //lead actor string   
        private DateTime releaseDate; //release date stored as a datetime object from datetimepicker on form
        private int runTime; //int runtime, should be less than 240 and greater than 0
       

        //paramaterless constructor
        public DVD()
        {
            this.leadActor = "";
            
            this.runTime = 0;
        }

        
        //parameterful constructor
            public DVD(int UPC, decimal price, string title, int quantity,
                string LActor, DateTime d, int rt) : base(UPC, price, title, quantity)
            {
                this.leadActor = LActor;
                this.releaseDate = d;
                this.runTime = rt;
                
            }

        //display this product's attributes on the form

        public override void Display(frmBookCDDVDShop f)
            {
                f.grpDVD.Enabled = true;
                f.grpDVD.Visible = true;
            f.grpDVD.Location = f.grpBook.Location;
            base.Display(f);
                f.txtDVDLeadActor.Text = leadActor;
                f.txtDVDReleaseDate.Value = releaseDate;
                f.txtDVDRunTime.Text = runTime.ToString();
                
            }  // end Display


        }
       


    }

