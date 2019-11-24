// Serializable File (Persistent Object)  Class 
// Responsible for all processing related to a Serializable File
// Written in VB by Joseph Jupin     Fall 2009
// Converted to CSharp by Frank Friedman   Ver 3  Spring 2016
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// For serialization
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Collections;
using Final_Project.Classes;
/*
 * Rawnaz Anam & Wilson Diaz
 * CIS 3309
 * Final Project
 * Stage 1
 * 11/23/2019
 */
namespace BookCDDVDShop
{
    [Serializable]
    public class ProductList
    {
        private ArrayList products; //holds our products

        //initialize the arraylist
        public ProductList()
        {
            this.products = new ArrayList();
        }

        //find the product with the matching UPC in the list
        public Product find(int upc)
        {
            foreach (Product p in this.products)
            {
                if (p.ProductUPC.Equals(upc))
                {
                    return p;
                }
            }

            return null;
        }

        //add reference to a product to our list
        public void add(Product p)
        {
            this.products.Add(p);
        }

        //find the product with the passed UPC and remove it from the list
        public void delete(int upc)
        {
            this.products.Remove(this.find(upc));
        }

        //get size of array
        public int size()
        {
            return this.products.Count;
        }
    }
}