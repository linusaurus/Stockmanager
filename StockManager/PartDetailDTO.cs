using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;


namespace StockManager
{ 
    // +++++++++++++++++++++++++++++++++++++++++++++
    // Aggregate DTO for part editing and creation
    // April 23-2020 -- v2
    // June 24-2020  -- v3
    // ++++++++++++++++++++++++++++++++++++++++++++
    public class PartDetailDTO : INotifyPropertyChanged
    {
        // private fields +++++++++++++++++
        private int partID;
        private string itemDescription;
        private string itemName;
        private string partNum;
        private int manuId;
        private int uID;
        private string unitOfMeasure;
        private decimal unitCost;
        private string addedBy;
        private DateTime dateAdded;
        private string modifiedBy;
        private DateTime modifiedDate;
        private string location;
        private int partTypeID;
        private string sku;
        private decimal weight;
        private decimal waste;
        private decimal markUp;
        private bool obsolete;
       
        // +++++++++++++++++++++++++++++++

        public string ItemName
        {
            get { return itemName; }
            set
            {
                itemName = value;
                OnPropertyChange();
            }
        }

        public bool Obsolete
        {
            get { return obsolete; }
            set
            {
                obsolete = value;
                OnPropertyChange();
            }
        }
        public int PartID
        {
            get { return partID; }
            set
            {
                partID = value;
                OnPropertyChange();
            }
        }

        public string ItemDescription
        {
            get { return itemDescription; }
            set
            {
                itemDescription = value;
                OnPropertyChange();
            } 
        }

        public string PartNum
        {
            get { return partNum; }
            set
            {
              partNum = value ;
              OnPropertyChange();
            }

        }

        public int ManuId
        {
            get {return manuId; }
            set
            {
                manuId = value;
                OnPropertyChange();
            } 
        }

        public int UID 
        {
            get {return uID; }
            set
            {
               uID = value ;
               OnPropertyChange();
            }
        }

        public string UnitOfMeasure 
        {
            get {return unitOfMeasure; }
            set
            {
               unitOfMeasure = value ;
               OnPropertyChange();
            }
        }

        public decimal UnitCost 
        {
            get {return unitCost; }
            set
            {
                unitCost = value;
                OnPropertyChange();
            }
        }

        public string AddedBy 
        {
            get {return addedBy; }
            set
            {
               addedBy = value ;
               OnPropertyChange();
            }
        }

        public DateTime DateAdded
        {
            get {return dateAdded; }
            set 
            {   
               dateAdded = value ;
               OnPropertyChange();
            }
        }

        public string ModifiedBy 
        {
            get {return modifiedBy; }
            set
            {
                modifiedBy = value;
                OnPropertyChange();
            }
        }

        public string Location
        {
            get {return location; }
            set
            {
               location = value ;
               OnPropertyChange();
            }
        }

        public DateTime ModifiedDate
        {
            get {return modifiedDate; }
            set
            {
               modifiedDate = value;
               OnPropertyChange();
            }
        }

        public int PartTypeID
        {
            get {return partTypeID; }
            set
            {
              partTypeID = value  ;
              OnPropertyChange();
            }
        }

        public string Sku 
        {
            get {return sku; }
            set
            {
               sku = value ;
               OnPropertyChange();
            }
        }

        public decimal Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                OnPropertyChange();
            }
        }

        public decimal MarkUp
        {
            get {return markUp; }
            set
            {
              markUp = value  ;
              OnPropertyChange();
            }
        }

        public decimal Waste
        {
            get { return waste; }
            set
            {
                waste = value;
                OnPropertyChange();
            }
        }

 

        public event PropertyChangedEventHandler PropertyChanged;

        

        protected void OnPropertyChange([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }


 
}
