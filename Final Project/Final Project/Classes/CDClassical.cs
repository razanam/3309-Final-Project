﻿// Classical CD Class
// This node is inherited by the Classical Orchestra CD and Clasical Chamber Music CD classes
// Responsible for all processing related to a Classical Music CD

// Written in VB by Joseph Jupin     Fall 2009
// Converted to CSharp by Frank Friedman     Spring 2016

// Revised June 17, 2017 by Frank Friedman
// Revised June 16, 2019 by Frank Friedman

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
    // CDClassical inherits the data and methods in Product
    [Serializable()]
    class CDClassical : Product
    {
        private string hiddenLabel; //string treated like a title
        private string hiddenArtists; //comma separated list of names

        // Parameterless Constructor
        public CDClassical()
        {
            hiddenLabel = "";
            hiddenArtists = "";

        } // end CDClassical Parameterless Constructor


        // Parameterized Constructor
        public CDClassical(int UPC, decimal price, string title, int quantity,
            string label, string artists) : base(UPC, price, title, quantity)
        {
            hiddenLabel = label;
            hiddenArtists = artists;
        }  // end Employee Parameterized Constructor


        // Accessor/mutator for CD Label
        public string CDClassicalLabel
        {
            get
            {
                return hiddenLabel;
            }  // end get
            set   // (string value)
            {
                hiddenLabel = value;
            }  // end get
        }  // end Property


        // Accessor/mutator for CD Artists
        public string CDClassicalArtists
        {
            get
            {
                return hiddenArtists;
            }  // end get
            set   // (string value)
            {
                hiddenArtists = value;
            }  // end get
        }  // end Property

        // Save data from form to object
        public override void Save(frmBookCDDVDShop f)
        {
            base.Save(f);
            hiddenLabel = f.txtCDClassicalLabel.Text;
            hiddenArtists = f.txtCDClassicalArtists.Text;
        } // end Save


        // Display data in object on form
        public override void Display(frmBookCDDVDShop f)
        {
            
            f.grpCDClassical.Enabled = true;
            f.grpCDClassical.Visible = true;
            f.grpCDClassical.Location = f.grpBook.Location;

            base.Display(f);
           f.txtCDClassicalLabel.Text = hiddenLabel;
            f.txtCDClassicalArtists.Text = hiddenArtists;
        }  // end Display


        // This toString function overrides the Object toString
        //     function.  The base refers to Object because this class
        //     inherits Object by default.
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "CDClassical Info: " + hiddenArtists + hiddenArtists;
            return s;
        }  // end ToString

    }  // end CDClassical class
}  // end namespace  

