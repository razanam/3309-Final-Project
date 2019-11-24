// Form Controller Class
// Responsible for all processing related to frmEmpMan 

// Written in VB by Joseph Jupin     Fall 2009
// Converted to CSharp by Frank Friedman     Spring 2016

// Modified June 17, 2017 by Frank Friedman
// Modifed again in June 17, 2019

// This class contains "static" methods to automate complex tasks
//     on frmEmpMan components


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using Final_Project;
/*
 * Rawnaz Anam & Wilson Diaz
 * CIS 3309
 * Final Project
 * Stage 1
 * 11/23/2019
 */
namespace BookCDDVDShop
{
    public static class FormController
    {
    
        //this is what happens when we click on the button to save a new book
        public static void CreateBook(frmBookCDDVDShop f)
        {
            f.txtProductUPC.Clear();
            f.txtProductUPC.Enabled = true;
            f.grpProduct.Enabled = true;
            f.grpProduct.Visible = true;
            f.grpBook.Enabled = true;
            f.grpBook.Visible = true;
            f.btnSave.Enabled = true;
            f.btnSave.Visible = true;
            f.btnCreateBookCIS.Enabled = false;
            f.btnCreateDVD.Enabled = false;
            f.btnCreateCDOrchestra.Enabled = false;
            f.btnCreateCDChamber.Enabled = false;
            f.btnSearchUPC.Enabled = false;
            f.btnClearForm.Enabled = true;
            f.btnResetForm.Enabled = true;
            f.btnClearForm.Visible = true;
            f.btnResetForm.Visible = true;
        }
        //this is what happens when we click on the button to save a new cisbook

        public static void CreateBookCIS(frmBookCDDVDShop f)
        {
            f.txtProductUPC.Clear();
            f.txtProductUPC.Enabled = true;
            f.grpProduct.Enabled = true;
            f.grpProduct.Visible = true;
            f.grpBook.Enabled = true;
            f.grpBook.Visible = true;
            f.btnSave.Enabled = true;
            f.btnSave.Visible = true;
            f.lblCIS.Visible = true;
            f.lblCIS.Enabled = true;
            f.txtBookCISCISArea.Visible = true;
            f.txtBookCISCISArea.Enabled = true;
            f.btnCreateBook.Enabled = false;
            f.btnCreateDVD.Enabled = false;
            f.btnCreateCDOrchestra.Enabled = false;
            f.btnCreateCDChamber.Enabled = false;
            f.btnSearchUPC.Enabled = false;
            f.btnClearForm.Enabled = true;
            f.btnResetForm.Enabled = true;
            f.btnClearForm.Visible = true;
            f.btnResetForm.Visible = true;

        }
        //this is what happens when we click on the button to save a new dvd

        public static void CreateDVD(frmBookCDDVDShop f)
        {
            f.txtProductUPC.Clear();
            f.txtProductUPC.Enabled = true;
            f.grpDVD.Location = f.grpBook.Location;
            f.grpProduct.Enabled = true;
            f.grpProduct.Visible = true;
            f.grpDVD.Enabled = true;
            f.grpDVD.Visible = true;
            f.btnSave.Enabled = true;
            f.btnSave.Visible = true;
            f.btnCreateBookCIS.Enabled = false;
            f.btnCreateBook.Enabled = false;
            f.btnCreateCDOrchestra.Enabled = false;
            f.btnCreateCDChamber.Enabled = false;
            f.btnSearchUPC.Enabled = false;
            f.btnClearForm.Enabled = true;
            f.btnResetForm.Enabled = true;
            f.btnClearForm.Visible = true;
            f.btnResetForm.Visible = true;
        }
        //this is what happens when we click on the button to save a new orchestra cd

        public static void CreateCDOrchestra(frmBookCDDVDShop f)
        {
            f.txtProductUPC.Clear();
            f.txtProductUPC.Enabled = true;
            f.grpCDClassical.Location = f.grpBook.Location;
            f.grpProduct.Enabled = true;
            f.grpProduct.Visible = true;
            f.grpCDClassical.Enabled = true;
            f.grpCDClassical.Visible = true;
            f.lblOrchestraMusic.Enabled = true;
            f.lblOrchestraMusic.Visible = true;
            f.lblConductor.Enabled = true;
            f.lblConductor.Visible = true;
            f.txtCDOrchestraConductor.Enabled = true;
            f.txtCDOrchestraConductor.Visible = true;
            f.lblCDChamber.Enabled = false;
            f.lblCDChamber.Visible = false;
            f.lblInstrument.Enabled = false;
            f.lblInstrument.Visible = false;
            f.txtCDChamberInstrumentList.Enabled = false;
            f.txtCDChamberInstrumentList.Visible = false;
            f.btnSave.Enabled = true;
            f.btnSave.Visible = true;
            f.btnCreateBookCIS.Enabled = false;
            f.btnCreateDVD.Enabled = false;
            f.btnCreateBook.Enabled = false;
            f.btnCreateCDChamber.Enabled = false;
            f.btnSearchUPC.Enabled = false;
            f.btnClearForm.Enabled = true;
            f.btnResetForm.Enabled = true;
            f.btnClearForm.Visible = true;
            f.btnResetForm.Visible = true;
        }
        //this is what happens when we click on the button to save a new chamber music cd

        public static void CreateCDChamber(frmBookCDDVDShop f)
        {
            f.txtProductUPC.Clear();
            f.txtProductUPC.Enabled = true;
            f.grpCDClassical.Location = f.grpBook.Location;
            f.grpProduct.Enabled = true;
            f.grpProduct.Visible = true;
            f.grpCDClassical.Enabled = true;
            f.grpCDClassical.Visible = true;
            f.lblCDChamber.Enabled = true;
            f.lblCDChamber.Visible = true;
            f.lblInstrument.Enabled = true;
            f.lblInstrument.Visible = true;
            f.txtCDChamberInstrumentList.Enabled = true;
            f.txtCDChamberInstrumentList.Visible = true;
            f.lblOrchestraMusic.Enabled = false;
            f.lblOrchestraMusic.Visible = false;
            f.lblConductor.Enabled = false;
            f.lblConductor.Visible = false;
            f.txtCDOrchestraConductor.Enabled = false;
            f.txtCDOrchestraConductor.Visible = false;
            f.btnSave.Enabled = true;
            f.btnSave.Visible = true;
            f.btnCreateBookCIS.Enabled = false;
            f.btnCreateDVD.Enabled = false;
            f.btnCreateCDOrchestra.Enabled = false;
            f.btnCreateBook.Enabled = false;
            f.btnSearchUPC.Enabled = false;
            f.btnClearForm.Enabled = true;
            f.btnResetForm.Enabled = true;
            f.btnClearForm.Visible = true;
            f.btnResetForm.Visible = true;
        }
        // Resets form to initial state after form is loaded or
        //    an add operation is performed
        public static void formUpdate(frmBookCDDVDShop f)
        {
            f.txtProductPrice.Enabled = true;
            f.txtProductTitle.Enabled = true;
            f.txtProductQuantity.Enabled = true;
            f.txtBookISBNLeft.Enabled = true;
            f.txtBookISBNRight.Enabled = true;
            f.txtBookAuthor.Enabled = true;
            f.txtBookPages.Enabled = true;
            f.txtDVDLeadActor.Enabled = true;
            f.txtDVDReleaseDate.Enabled = true;
            f.txtDVDRunTime.Enabled = true;
            f.txtCDClassicalLabel.Enabled = true;
            f.txtCDClassicalArtists.Enabled = true;
            f.txtCDChamberInstrumentList.Enabled = true;
            f.txtCDOrchestraConductor.Enabled = true;
            f.txtBookCISCISArea.Enabled = true;
            f.btnSave.Enabled = true;
            f.btnSave.Visible = true;
        }
        //resets the form to the status of when the program starts
            public static void resetForm(frmBookCDDVDShop f)
        {
            clearForm(f);
            f.btnSearchUPC.Enabled = true;
            f.btnCreateBook.Enabled = true;
            f.btnCreateBookCIS.Enabled = true;
            f.btnCreateDVD.Enabled = true;
            f.btnCreateCDOrchestra.Enabled = true;
            f.btnCreateCDChamber.Enabled = true;
            f.btnSearchUPC.Visible = true;
            f.btnCreateBook.Visible = true;
            f.btnCreateBookCIS.Visible = true;
            f.btnCreateDVD.Visible = true;
            f.btnCreateCDOrchestra.Visible = true;
            f.btnCreateCDChamber.Visible = true;
            f.grpBook.Enabled = false;
            f.grpProduct.Enabled = false;
            f.grpDVD.Enabled = false;
            f.grpCDClassical.Enabled = false;
            f.grpBook.Visible = false;
            f.grpProduct.Visible = false;
            f.grpDVD.Visible = false;
            f.grpCDClassical.Visible = false;
            f.btnSave.Enabled = false;
            f.btnDelete.Enabled = false;
            f.btnUpdate.Enabled = false;
            f.btnClearForm.Enabled = false;
            f.btnResetForm.Enabled = false;
            f.btnSave.Visible = false;
            f.btnDelete.Visible = false;
            f.btnUpdate.Visible = false;
            f.btnClearForm.Visible = false;
            f.btnResetForm.Visible = false;
            f.btnClearForm.Enabled = false;
            f.btnResetForm.Enabled = false;
            f.btnClearForm.Visible = false;
            f.btnResetForm.Visible = false;
            f.lblCIS.Visible = false;
            f.lblCIS.Enabled = false;
            f.txtBookCISCISArea.Visible = false;
            f.txtBookCISCISArea.Enabled = false;
            f.lblOrchestraMusic.Enabled = false;
            f.lblOrchestraMusic.Visible = false;
            f.lblConductor.Enabled = false;
            f.lblConductor.Visible = false;
            f.txtCDOrchestraConductor.Enabled = false;
            f.txtCDOrchestraConductor.Visible = false;
            f.lblCDChamber.Enabled = false;
            f.lblCDChamber.Visible = false;
            f.lblInstrument.Enabled = false;
            f.lblInstrument.Visible = false;
            f.txtCDChamberInstrumentList.Enabled = false;
            f.txtCDChamberInstrumentList.Visible = false;
            f.btnExit.Enabled = true;

        } // end Clear

        //clears the textboxes
        public static void clearForm(frmBookCDDVDShop f)
        {
            //f.txtProductUPC.Clear(); don't clear upc in order to prevent modification after search
            f.txtProductPrice.Clear();
            f.txtProductTitle.Clear();
            f.txtProductQuantity.Clear();
            f.txtBookISBNLeft.Clear();
            f.txtBookISBNRight.Clear();
            f.txtBookAuthor.Clear();
            f.txtBookPages.Clear();
            f.txtDVDLeadActor.Clear();
            //f.txtDVDReleaseDate.Clear();
            f.txtDVDRunTime.Clear();
            f.txtCDClassicalLabel.Clear();
            f.txtCDClassicalArtists.Clear();
            //f.txtCDChamberInstrumentList.SelectedIndex=-1;
            f.txtCDOrchestraConductor.Clear();
            f.txtBookCISCISArea.SelectedIndex = -1 ;

        }
        //this is what happens after hitting search btn
        public static void searchForm(frmBookCDDVDShop f)
        {
            f.txtProductUPC.Enabled = false;
            f.txtProductPrice.Enabled = false;
            f.txtProductTitle.Enabled = false;
            f.txtProductQuantity.Enabled = false;
            f.txtBookISBNLeft.Enabled = false;
            f.txtBookISBNRight.Enabled = false;
            f.txtBookAuthor.Enabled = false;
            f.txtBookPages.Enabled = false;
            f.txtDVDLeadActor.Enabled = false;
            f.txtDVDReleaseDate.Enabled = false;
            f.txtDVDRunTime.Enabled = false;
            f.txtCDClassicalLabel.Enabled = false;
            f.txtCDClassicalArtists.Enabled = false;
            f.txtCDChamberInstrumentList.Enabled = false;
            f.txtCDOrchestraConductor.Enabled = false;
            f.txtBookCISCISArea.Enabled = false;

           // f.btnSearchUPC.Enabled = false;
            f.btnCreateBook.Enabled = false;
            f.btnCreateBookCIS.Enabled = false;
            f.btnCreateDVD.Enabled = false;
            f.btnCreateCDOrchestra.Enabled = false;
            f.btnCreateCDChamber.Enabled = false;
           // f.btnSearchUPC.Enabled = true;
            f.btnCreateBook.Visible = false;
            f.btnCreateBookCIS.Visible = false;
            f.btnCreateDVD.Visible = false;
            f.btnCreateCDOrchestra.Visible = false;
            f.btnCreateCDChamber.Visible = false;
            f.btnUpdate.Enabled = true;
            f.btnUpdate.Visible = true;
            f.btnDelete.Enabled = true;
            f.btnDelete.Visible = true;
            f.btnSave.Enabled = false;
            f.btnSave.Visible = false;
            f.btnSearchUPC.Enabled = false;
            f.btnClearForm.Enabled = true;
            f.btnResetForm.Enabled = true;
            f.btnClearForm.Visible = true;
            f.btnResetForm.Visible = true;

        }

    }  // end FormController class
}  // end namespace
