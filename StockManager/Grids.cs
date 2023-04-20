using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StockManager
{
    public class Grids
    {
        private static bool isDirty;

        public static bool IsDirty
        {
            get { return isDirty; }
            set 
            {
                isDirty = value;              
            }
        }

        public static void BuildPartSearchGrid(DataGridView dg)
        {
            dg.AutoGenerateColumns = false;

            dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Currency Decimal Style
            DataGridViewCellStyle dstyleCurrency = new DataGridViewCellStyle();
            dstyleCurrency.Format = "C";
            dstyleCurrency.NullValue = "";
            dstyleCurrency.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Date Style
            DataGridViewCellStyle dstyleDate = new DataGridViewCellStyle();
            dstyleCurrency.Format = "d";
            dstyleCurrency.NullValue = "";
            dstyleCurrency.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Currency Decimal Style
            DataGridViewCellStyle dstyleDecimal = new DataGridViewCellStyle();
            dstyleDecimal.Format = "N2";
            dstyleDecimal.NullValue = "0.00";
            dstyleDecimal.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Wrapping Text Style
            DataGridViewCellStyle dstyleWrapText = new DataGridViewCellStyle();
            dstyleWrapText.NullValue = "";
            dstyleWrapText.Alignment = DataGridViewContentAlignment.TopLeft;
            dstyleWrapText.WrapMode = DataGridViewTriState.True;

            // PartID Column --
            DataGridViewTextBoxColumn col_ID = new DataGridViewTextBoxColumn();
            col_ID.HeaderText = "ID";
            col_ID.DataPropertyName = "PartID";
            col_ID.Width = 55;

            // Receipt Description Column --
            DataGridViewTextBoxColumn col_Description = new DataGridViewTextBoxColumn();
            col_Description.HeaderText = "Description";
            col_Description.DataPropertyName = "ItemDescription";
            col_Description.Width = 120;
            col_Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // ManufacturerPartNumber Column --
            DataGridViewTextBoxColumn col_Manufacturer = new DataGridViewTextBoxColumn();
            col_Manufacturer.HeaderText = "Manufacturer";
            col_Manufacturer.DataPropertyName = "ManuName";
            col_Manufacturer.Width = 140;

            // ManufacturerPartNumber Column --
            DataGridViewTextBoxColumn col_ManufacturerPart = new DataGridViewTextBoxColumn();
            col_ManufacturerPart.HeaderText = "Manu-PartNumber";
            col_ManufacturerPart.DataPropertyName = "PartNumber";
            col_ManufacturerPart.Width = 140;
            // DateAdded Column --
            DataGridViewTextBoxColumn col_DateAdded = new DataGridViewTextBoxColumn();
            col_DateAdded.DefaultCellStyle = dstyleDate;
            col_DateAdded.HeaderText = "Date Added";
            col_DateAdded.DataPropertyName = "DateAdded";
            col_DateAdded.Width =85;

            // Addedby Column --
            DataGridViewTextBoxColumn col_Addedby=  new DataGridViewTextBoxColumn();
            col_Addedby.HeaderText = "Added by";
            col_Addedby.DataPropertyName = "AddedBy";
            col_Addedby.Width = 140;


            dg.Columns.AddRange(col_ID, col_Description, col_Manufacturer, col_ManufacturerPart, col_DateAdded, col_Addedby);

        }
        /// <summary>
        /// OrderRecipt Line Items
        /// </summary>
        /// <param name="dg"></param>
        internal static void BuildOrderLineItemsGrid(DataGridView dg)
        {
            dg.AutoGenerateColumns = false;

            dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Currency Decimal Style
            DataGridViewCellStyle dstyleCurrency = new DataGridViewCellStyle();
            dstyleCurrency.Format = "C";
            dstyleCurrency.NullValue = "";
            dstyleCurrency.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Currency Decimal Style
            DataGridViewCellStyle dstyleDecimal = new DataGridViewCellStyle();
            dstyleDecimal.Format = "N2";
            dstyleDecimal.NullValue = "0.00";
            dstyleDecimal.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Wrapping Text Style
            DataGridViewCellStyle dstyleWrapText = new DataGridViewCellStyle();
            dstyleWrapText.NullValue = "";
            dstyleWrapText.Alignment = DataGridViewContentAlignment.TopLeft;
            dstyleWrapText.WrapMode = DataGridViewTriState.True;

            // LineID Column --
            DataGridViewTextBoxColumn col_ID = new DataGridViewTextBoxColumn();
            col_ID.HeaderText = "ID";
            col_ID.DataPropertyName = "LineID";
            col_ID.Width = 55;

            //Description Column --
            DataGridViewTextBoxColumn col_Description = new DataGridViewTextBoxColumn();
            col_Description.HeaderText = "Description";
            col_Description.DataPropertyName = "description";
            col_Description.Width = 120;
            col_Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Unit Column --
            DataGridViewTextBoxColumn col_Unit = new DataGridViewTextBoxColumn();
            col_Unit.HeaderText = "Unit";
            col_Unit.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            col_Unit.DataPropertyName = "UnitOrderMeasureName";
            col_Unit.Width = 80;

            // Qnty Column --
            DataGridViewTextBoxColumn col_Qnty = new DataGridViewTextBoxColumn();
            col_Qnty.DefaultCellStyle = dstyleDecimal;
            col_Qnty.HeaderText = "Qnty";
            col_Qnty.DataPropertyName = "Quantity";
            col_Qnty.Width = 100;

            // Cost Column --
            DataGridViewTextBoxColumn col_Price = new DataGridViewTextBoxColumn();
            col_Price.DefaultCellStyle = dstyleDecimal;
            col_Price.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            col_Price.HeaderText = "Unit Cost";
            col_Price.DataPropertyName = "Price";
            col_Price.Width = 100;

            // Extended Column --
            DataGridViewTextBoxColumn col_Extended = new DataGridViewTextBoxColumn();
            col_Extended.DefaultCellStyle = dstyleDecimal;
            col_Extended.HeaderText = "Extension";
            col_Extended.DataPropertyName = "Extended";
            col_Extended.Width = 100;



            dg.Columns.AddRange(col_ID, col_Description, col_Unit, col_Qnty, col_Price, col_Extended);
        }

        public static void BuildJobOrdersGrid(DataGridView dg)
        {
            dg.AutoGenerateColumns = false;

            dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Currency Decimal Style
            DataGridViewCellStyle dstyleCurrency = new DataGridViewCellStyle();
            dstyleCurrency.Format = "C";
            dstyleCurrency.NullValue = "";
            dstyleCurrency.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Currency Decimal Style
            DataGridViewCellStyle dstyleDecimal = new DataGridViewCellStyle();
            dstyleDecimal.Format = "N2";
            dstyleDecimal.NullValue = "0.00";
            dstyleDecimal.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Wrapping Text Style
            DataGridViewCellStyle dstyleWrapText = new DataGridViewCellStyle();
            dstyleWrapText.NullValue = "";
            dstyleWrapText.Alignment = DataGridViewContentAlignment.TopLeft;
            dstyleWrapText.WrapMode = DataGridViewTriState.True;

            // PartID Column --
            DataGridViewTextBoxColumn col_ID = new DataGridViewTextBoxColumn();
            col_ID.HeaderText = "ID";
            col_ID.DataPropertyName = "PurchaseOrderID";
            col_ID.Width = 55;

            // Receipt Description Column --
            DataGridViewTextBoxColumn col_Description = new DataGridViewTextBoxColumn();
            col_Description.HeaderText = "Description";
            col_Description.DataPropertyName = "ItemDescription";
            col_Description.Width = 120;
            col_Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Manufacturer Column --
            DataGridViewTextBoxColumn col_Manufacturer = new DataGridViewTextBoxColumn();
            col_Manufacturer.HeaderText = "PartNum";
            col_Manufacturer.DataPropertyName = "PartNumber";
            col_Manufacturer.Width = 160;



            dg.Columns.AddRange(col_ID, col_Description, col_Manufacturer);

        }

        public static void BuildJobDeliveriesGrid(DataGridView dg)
        {
            dg.AutoGenerateColumns = false;

            dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Currency Decimal Style
            DataGridViewCellStyle dstyleCurrency = new DataGridViewCellStyle();
            dstyleCurrency.Format = "C";
            dstyleCurrency.NullValue = "";
            dstyleCurrency.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Currency Decimal Style
            DataGridViewCellStyle dstyleDecimal = new DataGridViewCellStyle();
            dstyleDecimal.Format = "N2";
            dstyleDecimal.NullValue = "0.00";
            dstyleDecimal.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Wrapping Text Style
            DataGridViewCellStyle dstyleWrapText = new DataGridViewCellStyle();
            dstyleWrapText.NullValue = "";
            dstyleWrapText.Alignment = DataGridViewContentAlignment.TopLeft;
            dstyleWrapText.WrapMode = DataGridViewTriState.True;

            // PID Column --
            DataGridViewTextBoxColumn col_ID = new DataGridViewTextBoxColumn();
            col_ID.HeaderText = "PID";
            col_ID.DataPropertyName = "PickListID";
            col_ID.Width = 55;

            //Preparer Column --
            DataGridViewTextBoxColumn col_Preparer = new DataGridViewTextBoxColumn();
            col_Preparer.HeaderText = "Preparer";
            col_Preparer.DataPropertyName = "Preparer";
            col_Preparer.Width = 120;
            
            // DateStamp Column --
            DataGridViewTextBoxColumn col_DateStamp = new DataGridViewTextBoxColumn();
            col_DateStamp.HeaderText = "Date Created";
            col_DateStamp.DataPropertyName = "DateStamp";
            col_DateStamp.Width = 160;

            // Destination Name Column --
            DataGridViewTextBoxColumn col_Destination = new DataGridViewTextBoxColumn();
            col_Destination.HeaderText = "Destination";
            col_Destination.DataPropertyName = "DestinationName";
            col_Destination.Width = 160;
            col_Destination.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Delivered Column --
            DataGridViewCheckBoxColumn col_Delivered = new DataGridViewCheckBoxColumn();
            col_Delivered.HeaderText = "Delivered";
            col_Delivered.DataPropertyName = "Delivered";
            col_Delivered.Width = 90;

            // Delivered Date Column --
            DataGridViewTextBoxColumn col_DeliveryDate = new DataGridViewTextBoxColumn();
            col_DeliveryDate.HeaderText = "Delivery Date";
            col_DeliveryDate.DataPropertyName = "DeliveryDate";
           
            col_DeliveryDate.Width = 110;



            dg.Columns.AddRange(col_ID, col_Preparer, col_DateStamp, col_Destination, col_Delivered, col_DeliveryDate);

        }
        // Display listing of Job Order with Purchaser, Supplier, Date --------
        public static void BuildJobOrderDetailGrid(DataGridView dg)
        {
            dg.AutoGenerateColumns = false;

            dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Currency Decimal Style
            DataGridViewCellStyle dstyleCurrency = new DataGridViewCellStyle();
            dstyleCurrency.Format = "C";
            dstyleCurrency.NullValue = "";
            dstyleCurrency.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Currency Decimal Style
            DataGridViewCellStyle dstyleDecimal = new DataGridViewCellStyle();
            dstyleDecimal.Format = "N2";
            dstyleDecimal.NullValue = "0.00";
            dstyleDecimal.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Wrapping Text Style
            DataGridViewCellStyle dstyleWrapText = new DataGridViewCellStyle();
            dstyleWrapText.NullValue = "";
            dstyleWrapText.Alignment = DataGridViewContentAlignment.TopLeft;
            dstyleWrapText.WrapMode = DataGridViewTriState.True;

            // PartID Column --
            DataGridViewTextBoxColumn col_ID = new DataGridViewTextBoxColumn();
            col_ID.HeaderText = "ID";
            col_ID.Name = "ID";
            col_ID.DataPropertyName = "PurchaseOrderID";
            col_ID.Width = 55;

            // Order Date Description Column --
            DataGridViewTextBoxColumn col_OrderDate = new DataGridViewTextBoxColumn();
            col_OrderDate.HeaderText = "OrderDate";
            col_OrderDate.DataPropertyName = "OrderDate";
            col_OrderDate.Width = 90;
            col_OrderDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Purchuser Column --
            DataGridViewTextBoxColumn col_Purchaser = new DataGridViewTextBoxColumn();
            col_Purchaser.HeaderText = "Purchaser";
            col_Purchaser.DataPropertyName = "Purchaser";
            col_Purchaser.Width = 100;
            
            // Supplier Column --
            DataGridViewTextBoxColumn col_Supplier = new DataGridViewTextBoxColumn();
            col_Supplier.HeaderText = "Supplier";
            col_Supplier.DataPropertyName = "SupplierName";
            col_Supplier.Width = 160;
            col_Supplier.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Supplier Column --
            DataGridViewTextBoxColumn col_OrderTotal = new DataGridViewTextBoxColumn();
            col_OrderTotal.HeaderText = "OrderTotal";
            col_OrderTotal.DataPropertyName = "OrderTotal";
            col_OrderTotal.DefaultCellStyle = dstyleCurrency;
            col_OrderTotal.Width = 160;


            dg.Columns.AddRange(col_ID, col_Purchaser, col_OrderDate, col_Supplier, col_OrderTotal);

        }

        public static void BuildLineItemSearchGrid(DataGridView dg)
        {
            dg.AutoGenerateColumns = false;

            dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Currency Decimal Style
            DataGridViewCellStyle dstyleCurrency = new DataGridViewCellStyle();
            dstyleCurrency.Format = "C";
            dstyleCurrency.NullValue = "";
            dstyleCurrency.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Date Style
            DataGridViewCellStyle dstyleDate = new DataGridViewCellStyle();
            dstyleCurrency.Format = "d";
            dstyleCurrency.NullValue = "";
            dstyleCurrency.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Currency Decimal Style
            DataGridViewCellStyle dstyleDecimal = new DataGridViewCellStyle();
            dstyleDecimal.Format = "N2";
            dstyleDecimal.NullValue = "0.00";
            dstyleDecimal.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Wrapping Text Style
            DataGridViewCellStyle dstyleWrapText = new DataGridViewCellStyle();
            dstyleWrapText.NullValue = "";
            dstyleWrapText.Alignment = DataGridViewContentAlignment.TopLeft;
            dstyleWrapText.WrapMode = DataGridViewTriState.True;

            // LineID Column --
            DataGridViewTextBoxColumn col_ID = new DataGridViewTextBoxColumn();
            col_ID.HeaderText = "ID";
            col_ID.DataPropertyName = "LineID";
            col_ID.Width = 55;

            // PurchaseOrderID Column --
           // DataGridViewTextBoxColumn col_PurchaseOrderID = new DataGridViewTextBoxColumn();
           // col_PurchaseOrderID.HeaderText = "PO";
           // col_PurchaseOrderID.DataPropertyName = "PurchaseOrderID";
           // col_PurchaseOrderID.Width = 55;

            // PurchaseOrderID Column --
            DataGridViewLinkColumn col_PurchaseOrderID = new DataGridViewLinkColumn();
            col_PurchaseOrderID.HeaderText = "PO";
            col_PurchaseOrderID.DataPropertyName = "PurchaseOrderID";
            col_PurchaseOrderID.Width = 55;

            // Receipt Description Column --
            DataGridViewTextBoxColumn col_Description = new DataGridViewTextBoxColumn();
            col_Description.HeaderText = "Description";
            col_Description.DataPropertyName = "Description";
            col_Description.Width = 120;
            col_Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Quantity Column --
            DataGridViewTextBoxColumn col_Qnty = new DataGridViewTextBoxColumn();
            col_Qnty.DefaultCellStyle = dstyleDecimal;
            col_Qnty.HeaderText = "Quanity";
            col_Qnty.DataPropertyName = "Quantity";
            col_Qnty.Width = 65;

            // ManufacturerPartNumber Column --
            DataGridViewTextBoxColumn col_JobName = new DataGridViewTextBoxColumn();
            col_JobName.HeaderText = "JobName";
            col_JobName.DataPropertyName = "JobName";
            col_JobName.Width = 180;

            // ManufacturerPartNumber Column --
            DataGridViewTextBoxColumn col_Supplier = new DataGridViewTextBoxColumn();
            col_Supplier.HeaderText = "Supplier";
            col_Supplier.DataPropertyName = "SupplierName";
            col_Supplier.Width = 180;
            // DateAdded Column --
            DataGridViewTextBoxColumn col_OrderDate = new DataGridViewTextBoxColumn();
            col_OrderDate.DefaultCellStyle = dstyleDate;
            col_OrderDate.HeaderText = "Order Date";
            col_OrderDate.DataPropertyName = "OrderDate";
            col_OrderDate.Width = 85;

            

            dg.Columns.AddRange(col_ID, col_PurchaseOrderID, col_OrderDate, col_Description, col_Qnty, col_JobName, col_Supplier);

        }

        public static void BuildSupplierOrdersGrid(DataGridView dg)
        {
            dg.AutoGenerateColumns = false;

            dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Currency Decimal Style
            DataGridViewCellStyle dstyleCurrency = new DataGridViewCellStyle();
            dstyleCurrency.Format = "C";
            dstyleCurrency.NullValue = "";
            dstyleCurrency.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Currency Decimal Style
            DataGridViewCellStyle dstyleDecimal = new DataGridViewCellStyle();
            dstyleDecimal.Format = "N2";
            dstyleDecimal.NullValue = "0.00";
            dstyleDecimal.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Wrapping Text Style
            DataGridViewCellStyle dstyleWrapText = new DataGridViewCellStyle();
            dstyleWrapText.NullValue = "";
            dstyleWrapText.Alignment = DataGridViewContentAlignment.TopLeft;
            dstyleWrapText.WrapMode = DataGridViewTriState.True;

            // PurchaseOrderID Column --
            DataGridViewTextBoxColumn col_ID = new DataGridViewTextBoxColumn();
            col_ID.HeaderText = "ID";
            col_ID.DataPropertyName = "OrderNumber";
            col_ID.Width = 55;

            // Order Date Column --
            DataGridViewTextBoxColumn col_Date = new DataGridViewTextBoxColumn();
            col_Date.HeaderText = "Order Date";
            col_Date.DataPropertyName = "OrderDate";
            col_Date.DefaultCellStyle.Format = "d";
            col_Date.Width = 100;

            // Purchaser Column --
            DataGridViewTextBoxColumn col_purchaser = new DataGridViewTextBoxColumn();
            col_purchaser.HeaderText = "Purchaser";
            col_purchaser.DataPropertyName = "Purchaser";
            col_purchaser.Width = 160;

            // Jobname Column --
            DataGridViewTextBoxColumn col_Jobname = new DataGridViewTextBoxColumn();
            col_Jobname.HeaderText = "Job Name";
            col_Jobname.DataPropertyName = "JobName";
            col_Jobname.Width = 160;
            col_Jobname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // OrderTotal Column --
            DataGridViewTextBoxColumn col_orderTotal = new DataGridViewTextBoxColumn();
            col_orderTotal.HeaderText = "Order Total";
            col_orderTotal.DataPropertyName = "OrderTotal";
            col_orderTotal.Width = 100;
            col_orderTotal.DefaultCellStyle = dstyleCurrency;

            // Recieved COlumn --
            DataGridViewCheckBoxColumn col_received = new DataGridViewCheckBoxColumn();
            col_received.HeaderText = "Revd";
            col_received.DataPropertyName = "Received";
            col_received.Width = 75;


            dg.Columns.AddRange(col_ID, col_Date, col_purchaser, col_Jobname, col_orderTotal, col_received);

        }

        public static void BuildPartOrdersGrid(DataGridView dg)
        {
            dg.AutoGenerateColumns = false;

            dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Currency Decimal Style
            DataGridViewCellStyle dstyleCurrency = new DataGridViewCellStyle();
            dstyleCurrency.Format = "C";
            dstyleCurrency.NullValue = "";
            dstyleCurrency.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Currency Decimal Style
            DataGridViewCellStyle dstyleDecimal = new DataGridViewCellStyle();
            dstyleDecimal.Format = "N2";
            dstyleDecimal.NullValue = "0.00";
            dstyleDecimal.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Wrapping Text Style
            DataGridViewCellStyle dstyleWrapText = new DataGridViewCellStyle();
            dstyleWrapText.NullValue = "";
            dstyleWrapText.Alignment = DataGridViewContentAlignment.TopLeft;
            dstyleWrapText.WrapMode = DataGridViewTriState.True;

            // PurchaseOrderID Column --
            DataGridViewTextBoxColumn col_ID = new DataGridViewTextBoxColumn();
            col_ID.HeaderText = "ID";
            col_ID.DataPropertyName = "PurchaseOrderID";
            col_ID.Width = 55;

            // Order Date Column --
            DataGridViewTextBoxColumn col_Date = new DataGridViewTextBoxColumn();
            col_Date.HeaderText = "Order Date";
            col_Date.DataPropertyName = "OrderDate";
            col_Date.Width = 100;

            // Purchaser Column --
            DataGridViewTextBoxColumn col_purchaser = new DataGridViewTextBoxColumn();
            col_purchaser.HeaderText = "Supplier";
            col_purchaser.DataPropertyName = "SupplierName";
            col_purchaser.Width = 160;

            // Jobname Column --
            DataGridViewTextBoxColumn col_Jobname = new DataGridViewTextBoxColumn();
            col_Jobname.HeaderText = "Job Name";
            col_Jobname.DataPropertyName = "JobName";
            col_Jobname.Width = 160;
            col_Jobname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

           

            dg.Columns.AddRange(col_ID, col_Date, col_purchaser, col_Jobname);

        }


        public static void BuildPartResourcesGrid(DataGridView dg)
        {
            // Grid Width 430 --


            dg.AutoGenerateColumns = false;

            dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Currency Decimal Style
            DataGridViewCellStyle dstyleCurrency = new DataGridViewCellStyle();
            dstyleCurrency.Format = "C";
            dstyleCurrency.NullValue = "";
            dstyleCurrency.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Currency Decimal Style
            DataGridViewCellStyle dstyleDecimal = new DataGridViewCellStyle();
            dstyleDecimal.Format = "N2";
            dstyleDecimal.NullValue = "0.00";
            dstyleDecimal.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Wrapping Text Style
            DataGridViewCellStyle dstyleWrapText = new DataGridViewCellStyle();
            dstyleWrapText.NullValue = "";
            dstyleWrapText.Alignment = DataGridViewContentAlignment.TopLeft;
            dstyleWrapText.WrapMode = DataGridViewTriState.True;


            // ResourceID Column --
            DataGridViewTextBoxColumn col_ID = new DataGridViewTextBoxColumn();
            col_ID.HeaderText = "ID";
            col_ID.DataPropertyName = "ResourceID";
            col_ID.Width = 55;

            // Resource Description Column --
            DataGridViewTextBoxColumn col_Description = new DataGridViewTextBoxColumn();
            col_Description.HeaderText = "Description";
            col_Description.DataPropertyName = "ResourceDescription";
            col_Description.Width = 120;
            col_Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //FileSize Column --
            DataGridViewTextBoxColumn col_filesize = new DataGridViewTextBoxColumn();
            col_filesize.HeaderText = "FileSize";
            col_filesize.DataPropertyName = "FileSize";
            col_filesize.Width = 90;

            //Create Colum--------
            DataGridViewTextBoxColumn col_Created = new DataGridViewTextBoxColumn();
            col_Created.HeaderText = "Created";
            col_Created.DataPropertyName = "CreationDate";
            col_Created.Width = 100;
            // Creator------------------------
            DataGridViewTextBoxColumn col_Createdby = new DataGridViewTextBoxColumn();
            col_Createdby.HeaderText = "Createdby";
            col_Createdby.DataPropertyName = "Createdby";
            col_Createdby.Width = 150;
            // LastMod------------------------
            DataGridViewTextBoxColumn col_LastMod = new DataGridViewTextBoxColumn();
            col_LastMod.HeaderText = "LastMod";
            col_LastMod.DataPropertyName = "LastMod";
            col_LastMod.Width = 90;


            dg.Columns.AddRange(col_ID, col_Description);
        }
        public static void BuildOrderReceiptItemsGrid(DataGridView dg)
        {
            dg.AutoGenerateColumns = false;
            dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            

            // Currency Decimal Style
            DataGridViewCellStyle dstyleCurrency = new DataGridViewCellStyle();
            dstyleCurrency.Format = "C";
            dstyleCurrency.NullValue = "";
            dstyleCurrency.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Currency Decimal Style
            DataGridViewCellStyle dstyleDecimal = new DataGridViewCellStyle();
            dstyleDecimal.Format = "N2";
            dstyleDecimal.NullValue = "0.00";
            dstyleDecimal.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dstyleDecimal.BackColor = Color.Cornsilk;
            // Wrapping Text Style
            DataGridViewCellStyle dstyleWrapText = new DataGridViewCellStyle();
            dstyleWrapText.NullValue = "";
            dstyleWrapText.Alignment = DataGridViewContentAlignment.TopLeft;
            dstyleWrapText.WrapMode = DataGridViewTriState.True;



       
            // OrderReceiptLineID Column -- 0
            DataGridViewTextBoxColumn col_OrderReceiptLineID = new DataGridViewTextBoxColumn();
            col_OrderReceiptLineID.HeaderText = "ID";
            col_OrderReceiptLineID.DataPropertyName = "OrderReceiptLineID";
            col_OrderReceiptLineID.Width = 55;

            // OrderReceiptLineID Column -- 0
            DataGridViewTextBoxColumn col_partID = new DataGridViewTextBoxColumn();
            col_partID.HeaderText = "PartID";
            col_partID.DataPropertyName = "PartID";
            col_partID.Width = 55;
            col_partID.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Description Column -- 1
            DataGridViewTextBoxColumn col_Description = new DataGridViewTextBoxColumn();
            col_Description.HeaderText = "Description";
            col_Description.DataPropertyName = "Description";
            col_Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_Description.DefaultCellStyle = dstyleWrapText;

            // Units Of Measure Column -- 2
            DataGridViewTextBoxColumn col_UnitOfMeasureName = new DataGridViewTextBoxColumn();
            col_UnitOfMeasureName.HeaderText = "Units";
            col_UnitOfMeasureName.DataPropertyName = "UnitOfMeasureName";
            col_UnitOfMeasureName.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_UnitOfMeasureName.Width = 60;

            // QntyOrdered Column -- 3
            DataGridViewTextBoxColumn col_QntyOrdered = new DataGridViewTextBoxColumn();
            col_QntyOrdered.HeaderText = "Qty-Ordered";
            col_QntyOrdered.DataPropertyName = "QntyOrdered";
            col_QntyOrdered.DefaultCellStyle = dstyleDecimal;
            //col_QntyOrdered.ReadOnly = true;
            col_QntyOrdered.Width = 80;

            // OrderComplete Column -- 4
            DataGridViewCheckBoxColumn col_ReceivedComplete = new DataGridViewCheckBoxColumn();
            col_ReceivedComplete.HeaderText = "Complete";
            col_ReceivedComplete.DataPropertyName = "ItemsRecievedComplete";        
            col_ReceivedComplete.Width = 80;

            // QntyReceived Column --
            DataGridViewTextBoxColumn col_QntyRecieved = new DataGridViewTextBoxColumn();
            col_QntyRecieved.HeaderText = "Qty-Received";
            col_QntyRecieved.DataPropertyName = "QntyReceived";
            col_QntyRecieved.DefaultCellStyle = dstyleDecimal;
            col_QntyRecieved.Width = 80;

            // QntyBalance Column --
            DataGridViewTextBoxColumn col_QntyBalance = new DataGridViewTextBoxColumn();
            col_QntyBalance.HeaderText = "Qty-Balance";
            col_QntyBalance.DataPropertyName = "QntyBalance";
            col_QntyBalance.DefaultCellStyle = dstyleDecimal;
            col_QntyBalance.Width = 80;

            // QntyToInventory Column --
            DataGridViewTextBoxColumn col_QntyToInventory = new DataGridViewTextBoxColumn();
            col_QntyToInventory.HeaderText = "Qty-To-Inv";
            col_QntyToInventory.DataPropertyName = "QntyToInventory";
            col_QntyToInventory.DefaultCellStyle = dstyleDecimal;

            col_QntyToInventory.Width = 80;

            dg.Columns.AddRange( col_OrderReceiptLineID, col_partID, col_Description, col_UnitOfMeasureName, col_ReceivedComplete, col_QntyOrdered, 
                col_QntyRecieved, col_QntyBalance, col_QntyToInventory);
        }
         //-xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
         // Pending Order Grid View
         //-xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
        public static  void BuildPendingOrdersGrid(DataGridView dg)
        {

            dg.AutoGenerateColumns = false;
            dg.AllowUserToAddRows = false;
            dg.AllowUserToDeleteRows = false;
            dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Currency Decimal Style
            DataGridViewCellStyle dstyleCurrency = new DataGridViewCellStyle();
            dstyleCurrency.Format = "C";
            dstyleCurrency.NullValue = "";
            dstyleCurrency.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Currency Decimal Style
            DataGridViewCellStyle dstyleDecimal = new DataGridViewCellStyle();
            dstyleDecimal.Format = "N2";
            dstyleDecimal.NullValue = "0.00";
            dstyleDecimal.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Wrapping Text Style
            DataGridViewCellStyle dstyleWrapText = new DataGridViewCellStyle();
            dstyleWrapText.NullValue = "";
            dstyleWrapText.Alignment = DataGridViewContentAlignment.TopLeft;
            dstyleWrapText.WrapMode = DataGridViewTriState.True;

            // OrderReceiptID Column --
            DataGridViewTextBoxColumn col_ID = new DataGridViewTextBoxColumn();
            col_ID.HeaderText = "ID";
            col_ID.DataPropertyName = "PurchaseOrderID";
            col_ID.Width = 55;

            // JobNamee Column --
            DataGridViewTextBoxColumn col_JobName = new DataGridViewTextBoxColumn();
            col_JobName.HeaderText = "JobName";
            col_JobName.DataPropertyName = "JobName";
            col_JobName.Width = 160;
            col_JobName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Supplier Name Column --
            DataGridViewTextBoxColumn col_Supplier = new DataGridViewTextBoxColumn();
            col_Supplier.HeaderText = "Supplier";
            col_Supplier.DataPropertyName = "Supplier";
            col_Supplier.Width = 260;

            // Employee Name Column --
            DataGridViewTextBoxColumn col_Employee = new DataGridViewTextBoxColumn();
            col_Employee.HeaderText = "Purchaser";
            col_Employee.DataPropertyName = "EmployeeName";
            col_Employee.Width = 90;

            // Order Date Column --
            DataGridViewTextBoxColumn col_OrderDate = new DataGridViewTextBoxColumn();
            col_OrderDate.HeaderText = "Order Date";
            col_OrderDate.DataPropertyName = "OrderDate";
            col_OrderDate.Width = 90;


            dg.Columns.AddRange(col_ID, col_JobName,col_Supplier,  col_Employee, col_OrderDate);

        }

        public static void BuildSupplierOrderItems(DataGridView dg)
        {
            dg.AutoGenerateColumns = false;

            dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Currency Decimal Style
            DataGridViewCellStyle dstyleCurrency = new DataGridViewCellStyle();
            dstyleCurrency.Format = "C";
            dstyleCurrency.NullValue = "";
            dstyleCurrency.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Currency Decimal Style
            DataGridViewCellStyle dstyleDecimal = new DataGridViewCellStyle();
            dstyleDecimal.Format = "N2";
            dstyleDecimal.NullValue = "0.00";
            dstyleDecimal.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Wrapping Text Style
            DataGridViewCellStyle dstyleWrapText = new DataGridViewCellStyle();
            dstyleWrapText.NullValue = "";
            dstyleWrapText.Alignment = DataGridViewContentAlignment.TopLeft;
            dstyleWrapText.WrapMode = DataGridViewTriState.True;

            // LineID Column --
            DataGridViewTextBoxColumn col_ID = new DataGridViewTextBoxColumn();
            col_ID.HeaderText = "ID";
            col_ID.DataPropertyName = "LineID";
            col_ID.Width = 55;

            // PartID Column --
            DataGridViewTextBoxColumn col_partid = new DataGridViewTextBoxColumn();
            col_partid.HeaderText = "ID";
            col_partid.DataPropertyName = "LineID";
            col_partid.Width = 55;


            // Description Column --
            DataGridViewTextBoxColumn col_description = new DataGridViewTextBoxColumn();
            col_description.HeaderText = "Description";
            col_description.DataPropertyName = "Description";
            col_description.Width = 120;
            col_description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // UnitCost Column --
            DataGridViewTextBoxColumn col_unitCost = new DataGridViewTextBoxColumn();
            col_unitCost.HeaderText = "UnitCost";
            col_unitCost.DataPropertyName = "UnitCost";
            col_unitCost.Width = 90;

            // Qnty Column --
            DataGridViewTextBoxColumn col_qnty = new DataGridViewTextBoxColumn();
            col_qnty.HeaderText = "Qnty";
            col_qnty.DataPropertyName = "Qnty";
            col_qnty.Width = 90;

            // extended Column --
            DataGridViewTextBoxColumn col_extended = new DataGridViewTextBoxColumn();
            col_extended.HeaderText = "Extension";
            col_extended.DataPropertyName = "Extended";
            col_extended.Width = 90;


            dg.Columns.AddRange(col_ID, col_partid,col_description, col_unitCost, col_qnty, col_extended);
        }

        public static void BuildReceiptsHistoryGrid(DataGridView dg)
        {
            dg.AutoGenerateColumns = false;

            dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Currency Decimal Style
            DataGridViewCellStyle dstyleCurrency = new DataGridViewCellStyle();
            dstyleCurrency.Format = "C";
            dstyleCurrency.NullValue = "";
            dstyleCurrency.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Currency Decimal Style
            DataGridViewCellStyle dstyleDecimal = new DataGridViewCellStyle();
            dstyleDecimal.Format = "N2";
            dstyleDecimal.NullValue = "0.00";
            dstyleDecimal.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Wrapping Text Style
            DataGridViewCellStyle dstyleWrapText = new DataGridViewCellStyle();
            dstyleWrapText.NullValue = "";
            dstyleWrapText.Alignment = DataGridViewContentAlignment.TopLeft;
            dstyleWrapText.WrapMode = DataGridViewTriState.True;

            // PartID Column --
            DataGridViewTextBoxColumn col_ID = new DataGridViewTextBoxColumn();
            col_ID.HeaderText = "ID";
            col_ID.DataPropertyName = "OrderReceiptID";
            col_ID.Width = 55;

            // Receipt Recieved On Column --
            DataGridViewTextBoxColumn col_ReceiveOn = new DataGridViewTextBoxColumn();
            col_ReceiveOn.HeaderText = "Received On";
            col_ReceiveOn.DataPropertyName = "ReceivedOn";
            col_ReceiveOn.Width = 120;
            

            // PurchaseOrderID Column --
            DataGridViewTextBoxColumn col_PurchaseOrderID = new DataGridViewTextBoxColumn();
            col_PurchaseOrderID.HeaderText = "PO";
            col_PurchaseOrderID.DataPropertyName = "PurchaseOrderID";
            col_PurchaseOrderID.Width = 55;

            // Employee Column --
            DataGridViewTextBoxColumn col_Employee = new DataGridViewTextBoxColumn();
            col_Employee.HeaderText = "Employee";
            col_Employee.DataPropertyName = "Employee";
            col_Employee.Width = 110;

            // Manufacturer Column --
            DataGridViewTextBoxColumn col_SupplierName = new DataGridViewTextBoxColumn();
            col_SupplierName.HeaderText = "Supplier";
            col_SupplierName.DataPropertyName = "SupplierName";
            col_SupplierName.Width = 160;
            col_SupplierName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // JobName Column --
            DataGridViewTextBoxColumn col_Jobname = new DataGridViewTextBoxColumn();
            col_Jobname.HeaderText = "JobName";
            col_Jobname.DataPropertyName = "JobName";
            col_Jobname.Width = 260;

            // Order Total Column --
            DataGridViewTextBoxColumn col_OrderTotal = new DataGridViewTextBoxColumn();
            col_OrderTotal.DefaultCellStyle = dstyleCurrency;
            col_OrderTotal.HeaderText = "Total";
            col_OrderTotal.DataPropertyName = "OrderTotal";
            col_OrderTotal.Width = 100;

            // Order State Column --
            DataGridViewTextBoxColumn col_OrderState = new DataGridViewTextBoxColumn();
            col_OrderState.HeaderText = "Status";
            col_OrderState.DataPropertyName = "OrderState";
            col_OrderState.Width = 140;



            dg.Columns.AddRange(col_ID, col_ReceiveOn, col_PurchaseOrderID, col_Employee, col_SupplierName, col_Jobname, col_OrderTotal, col_OrderState);

        }
        public static void CheckForDirtyState(ListChangedEventArgs e, Button btn)
        {

            if (e.ListChangedType == System.ComponentModel.ListChangedType.ItemChanged)
            {
                btn.Enabled = true;
                isDirty = true;
                ToogleButtonStyle(isDirty, btn);
            }
            if (e.ListChangedType == ListChangedType.ItemDeleted)
            {
                btn.Enabled = true;
                isDirty = true;
                ToogleButtonStyle(isDirty, btn);
            }
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
                btn.Enabled = true;
                isDirty = true;
                ToogleButtonStyle(isDirty, btn);
            }
        }

        public static void BuildPlistGrid(DataGridView dg)
        {
            dg.AutoGenerateColumns = false;

            dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dg.AllowUserToAddRows = false;
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Currency Decimal Style
            DataGridViewCellStyle dstyleCurrency = new DataGridViewCellStyle();
            dstyleCurrency.Format = "C";
            dstyleCurrency.NullValue = "";
            dstyleCurrency.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Date Style
            DataGridViewCellStyle dstyleDate = new DataGridViewCellStyle();
            dstyleCurrency.Format = "d";
            dstyleCurrency.NullValue = "";
            dstyleCurrency.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Currency Decimal Style
            DataGridViewCellStyle dstyleDecimal = new DataGridViewCellStyle();
            dstyleDecimal.Format = "N2";
            dstyleDecimal.NullValue = "0.00";
            dstyleDecimal.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Wrapping Text Style
            DataGridViewCellStyle dstyleWrapText = new DataGridViewCellStyle();
            dstyleWrapText.NullValue = "";
            dstyleWrapText.Alignment = DataGridViewContentAlignment.TopLeft;
            dstyleWrapText.WrapMode = DataGridViewTriState.True;

            // PickListID Column --
            DataGridViewTextBoxColumn col_PickListID = new DataGridViewTextBoxColumn();
            col_PickListID.Name = "DogShit";
            col_PickListID.HeaderText = "PID";
            col_PickListID.DataPropertyName = "PickListID";
            col_PickListID.Width = 40;

            // Employee Column --
            DataGridViewTextBoxColumn col_Employee = new DataGridViewTextBoxColumn();
            col_Employee.HeaderText = "Creator";
            col_Employee.DataPropertyName = "Preparer";
            col_Employee.Width = 120;
            col_Employee.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            // ManufacturerPartNumber Column --
            DataGridViewTextBoxColumn col_Date = new DataGridViewTextBoxColumn();
            col_Date.DefaultCellStyle = dstyleDate;
            col_Date.HeaderText = "Date";
            col_Date.DataPropertyName = "DateStamp";
            col_Date.Width = 65;

            // Processed Column --
            DataGridViewCheckBoxColumn col_Processed = new DataGridViewCheckBoxColumn();
            col_Processed.HeaderText = "Processed";
            col_Processed.DataPropertyName = "Submitted";
            col_Processed.Width = 65;

            dg.Columns.AddRange(col_PickListID, col_Employee, col_Date, col_Processed);

        }
        /// <summary>
        /// used for building list of scanned pick items
        /// </summary>
        /// <param name="dg"></param>
        public static void BuildScannedPartGrid(DataGridView dg)
        {
            #region Headers

            dg.AutoGenerateColumns = false;
            dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Currency Decimal Style
            DataGridViewCellStyle dstyleCurrency = new DataGridViewCellStyle();
            dstyleCurrency.Format = "C";
            dstyleCurrency.NullValue = "";
            dstyleCurrency.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Date Style
            DataGridViewCellStyle dstyleDate = new DataGridViewCellStyle();
            dstyleCurrency.Format = "d";
            dstyleCurrency.NullValue = "";
            dstyleCurrency.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Currency Decimal Style
            DataGridViewCellStyle dstyleDecimal = new DataGridViewCellStyle();
            dstyleDecimal.Format = "N2";
            dstyleDecimal.NullValue = "0.00";
            dstyleDecimal.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Wrapping Text Style
            DataGridViewCellStyle dstyleWrapText = new DataGridViewCellStyle();
            dstyleWrapText.NullValue = "";
            dstyleWrapText.Alignment = DataGridViewContentAlignment.TopLeft;
            dstyleWrapText.WrapMode = DataGridViewTriState.True;

            #endregion

            // SKU Column --
            DataGridViewTextBoxColumn col_SKU= new DataGridViewTextBoxColumn();
            col_SKU.HeaderText = "SKU#";
            col_SKU.DataPropertyName = "SKU";
            col_SKU.Width = 120;

            // PartID Column --
            DataGridViewTextBoxColumn col_PickListItemID = new DataGridViewTextBoxColumn();
            col_PickListItemID.HeaderText = "ID";
            col_PickListItemID.DataPropertyName = "PartID";
            col_PickListItemID.Width = 60;

            // Receipt Description Column --
            DataGridViewTextBoxColumn col_Description = new DataGridViewTextBoxColumn();
            col_Description.HeaderText = "Description";
            col_Description.DataPropertyName = "Description";
            col_Description.Width = 120;
            col_Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Qnty Column --
            DataGridViewTextBoxColumn col_Qnty = new DataGridViewTextBoxColumn();
            col_Qnty.HeaderText = "Qnty";
            col_Qnty.DataPropertyName = "InventoryAmount";
            col_Qnty.Width = 55;

            // Location Column --
            DataGridViewTextBoxColumn col_Location = new DataGridViewTextBoxColumn();
            col_Location.HeaderText = "Location";
            col_Location.DataPropertyName = "Location";
            col_Location.Width = 60;

            // DateStamp Column --
            DataGridViewTextBoxColumn col_DateStamp = new DataGridViewTextBoxColumn();
            col_DateStamp.HeaderText = "Date";
            col_DateStamp.DataPropertyName = "DateStamp";
            col_DateStamp.Width = 120;

            dg.Columns.AddRange(col_PickListItemID, col_SKU, col_Qnty, col_Description, col_Location, col_DateStamp);

        }

        public static void ToogleButtonStyle(bool dirtyState, Button btn)
        {
            

            if (dirtyState == true)
            {
                btn.BackColor = System.Drawing.Color.Cornsilk;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.Red;
                btn.FlatAppearance.BorderSize = 3;
            }

            else if (dirtyState == false)
            {
                btn.BackColor = Color.Gainsboro;
                btn.FlatAppearance.BorderColor = Color.AliceBlue;
                btn.FlatAppearance.BorderColor = Color.Cornsilk;
            }
        }

        public static void ToogleToolStripButtonStyle(bool dirtyState, ToolStripButton btn)
        {


            if (dirtyState == true)
            {
                btn.BackColor = System.Drawing.Color.Cornsilk;

            }

            else if (dirtyState == false)
            {
                btn.BackColor = Color.Gainsboro;

            }
        }

        // <T> is the type of data in the list.
        // If you have a List<int>, for example, then call this as follows:
        // List<int> ListOfInt;
        // DataTable ListTable = BuildDataTable<int>(ListOfInt);
        public static DataTable BuildDataTable<T>(IList<T> lst)
        {
            //create DataTable Structure
            DataTable tbl = CreateTable<T>();
            Type entType = typeof(T);
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entType);
            //get the list item and add into the list
            foreach (T item in lst)
            {
                DataRow row = tbl.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item);
                }
                tbl.Rows.Add(row);
            }
            return tbl;
        }

        private static DataTable CreateTable<T>()
        {
            //T –> ClassName
            Type entType = typeof(T);
            //set the datatable name as class name
            DataTable tbl = new DataTable(entType.Name);
            //get the property list
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entType);
            foreach (PropertyDescriptor prop in properties)
            {
                //add property as column
                tbl.Columns.Add(prop.Name, prop.PropertyType);
            }
            return tbl;
        }

        public static void BuildStockPartsGrid(DataGridView dg)
        {
            dg.AutoGenerateColumns = false;

            dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Currency Decimal Style
            DataGridViewCellStyle dstyleCurrency = new DataGridViewCellStyle();
            dstyleCurrency.Format = "C";
            dstyleCurrency.NullValue = "";
            dstyleCurrency.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Date Style
            DataGridViewCellStyle dstyleDate = new DataGridViewCellStyle();
            dstyleCurrency.Format = "d";
            dstyleCurrency.NullValue = "";
            dstyleCurrency.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Currency Decimal Style
            DataGridViewCellStyle dstyleDecimal = new DataGridViewCellStyle();
            dstyleDecimal.Format = "N2";
            dstyleDecimal.NullValue = "0.00";
            dstyleDecimal.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Wrapping Text Style
            DataGridViewCellStyle dstyleWrapText = new DataGridViewCellStyle();
            dstyleWrapText.NullValue = "";
            dstyleWrapText.Alignment = DataGridViewContentAlignment.TopLeft;
            dstyleWrapText.WrapMode = DataGridViewTriState.True;

            

            // PartID Column --
            DataGridViewTextBoxColumn col_PartID = new DataGridViewTextBoxColumn();
            col_PartID.HeaderText = "ID";
            col_PartID.DataPropertyName = "PartID";
            col_PartID.Width = 55;

          
            // Receipt Description Column --
            DataGridViewTextBoxColumn col_Description = new DataGridViewTextBoxColumn();
            col_Description.HeaderText = "Description";
            col_Description.DataPropertyName = "ItemDescription";
            col_Description.Width = 120;
            col_Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dg.Columns.AddRange(col_PartID, col_Description);
        }

        internal static void BuildPartsTransActionsGrid(DataGridView dg)
        {
            dg.AutoGenerateColumns = false;

            dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;

            // Currency Decimal Style
            DataGridViewCellStyle dstyleCurrency = new DataGridViewCellStyle();
            dstyleCurrency.Format = "C";
            dstyleCurrency.NullValue = "";
            dstyleCurrency.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Date Style
            DataGridViewCellStyle dstyleDate = new DataGridViewCellStyle();
            dstyleCurrency.Format = "d";
            dstyleCurrency.NullValue = "";
            dstyleCurrency.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Currency Decimal Style
            DataGridViewCellStyle dstyleDecimal = new DataGridViewCellStyle();
            dstyleDecimal.Format = "N2";
            dstyleDecimal.NullValue = "0.00";
            dstyleDecimal.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Wrapping Text Style
            DataGridViewCellStyle dstyleWrapText = new DataGridViewCellStyle();
            dstyleWrapText.NullValue = "";
            dstyleWrapText.Alignment = DataGridViewContentAlignment.TopLeft;
            dstyleWrapText.WrapMode = DataGridViewTriState.True;


            // PartID Column --
            DataGridViewTextBoxColumn col_StartTransActionID = new DataGridViewTextBoxColumn();
            col_StartTransActionID.HeaderText = "ID";
            col_StartTransActionID.DataPropertyName = "StockTransactionID";
            col_StartTransActionID.Width = 60;

            // Location Column --
            DataGridViewTextBoxColumn col_Location = new DataGridViewTextBoxColumn();
            col_Location.HeaderText = "Location";
            col_Location.DataPropertyName = "Location";
            col_Location.Width = 75;

            // DateStamp Column --
            DataGridViewTextBoxColumn col_DateStamp = new DataGridViewTextBoxColumn();
            col_DateStamp.HeaderText = "Date";
            col_DateStamp.DataPropertyName = "DateStamp";
            col_DateStamp.Width = 80;

            // Inventory Amount Column --
            DataGridViewTextBoxColumn col_InventoryAmount = new DataGridViewTextBoxColumn();
            col_InventoryAmount.HeaderText = "Amount";
            col_InventoryAmount.DataPropertyName = "Amount";
            col_InventoryAmount.DefaultCellStyle = dstyleDecimal;
            col_InventoryAmount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_InventoryAmount.DefaultCellStyle.BackColor = Color.Cornsilk;
            col_InventoryAmount.Width = 90;

            // Unit of Measure Column --
            DataGridViewTextBoxColumn col_UnitOfMeasure = new DataGridViewTextBoxColumn();
            col_UnitOfMeasure.HeaderText = "Unit";
            col_UnitOfMeasure.DataPropertyName = "Unit";
            col_UnitOfMeasure.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_UnitOfMeasure.Width = 70;


            // TransActionType Column --
            DataGridViewTextBoxColumn col_TransActionTypeName = new DataGridViewTextBoxColumn();
            col_TransActionTypeName.HeaderText = "Transaction";
            col_TransActionTypeName.DataPropertyName = "TransActionName";
            col_TransActionTypeName.Width = 90;

            // EmployeeName Column --
            DataGridViewTextBoxColumn col_EmployeeName = new DataGridViewTextBoxColumn();
            col_EmployeeName.HeaderText = "Employee";
            col_EmployeeName.DataPropertyName = "EmployeeName";
            col_EmployeeName.Width = 90;
            col_EmployeeName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            dg.Columns.AddRange(col_StartTransActionID, col_Location, col_DateStamp, col_InventoryAmount, col_UnitOfMeasure, col_EmployeeName, col_TransActionTypeName);
        }

        public static void BuildLocationsGrid(DataGridView dg)
        {
            dg.AutoGenerateColumns = false;

            dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

  

            // Location Column --
            DataGridViewTextBoxColumn col_Location = new DataGridViewTextBoxColumn();
            col_Location.HeaderText = "Location";
            col_Location.DataPropertyName = "LocationName";
            col_Location.Width = 75;

  
            // Area Column --
            DataGridViewTextBoxColumn col_Area = new DataGridViewTextBoxColumn();
            col_Area.HeaderText = "Area";
            col_Area.DataPropertyName = "Area";
            col_Area.Width = 75;
            col_Area.AutoSizeMode= DataGridViewAutoSizeColumnMode.Fill;

           
            dg.Columns.AddRange(col_Location, col_Area);
        }

        public  static void BuildLocationPartsGrid(DataGridView dg)
        {
            dg.AutoGenerateColumns = false;

            dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Currency Decimal Style ---------------------------------------
            DataGridViewCellStyle dstyleDecimal = new DataGridViewCellStyle();
            dstyleDecimal.Format = "N2";
            dstyleDecimal.NullValue = "0.00";
            dstyleDecimal.Alignment = DataGridViewContentAlignment.MiddleRight;
            //----------------------------------------------------------------

            // PartID Column --
            DataGridViewTextBoxColumn col_PartID = new DataGridViewTextBoxColumn();
            col_PartID.HeaderText = "PartID";
            col_PartID.DataPropertyName = "PartID";
            col_PartID.Width = 55;
            
            //ItemDescription Column
            DataGridViewTextBoxColumn col_ItemDescription = new DataGridViewTextBoxColumn();
            col_ItemDescription.HeaderText = "Description";
            col_ItemDescription.DataPropertyName = "ItemDescription";
            col_ItemDescription.Width = 65;
            col_ItemDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //Location Column
            DataGridViewTextBoxColumn col_Location = new DataGridViewTextBoxColumn();
            col_Location.HeaderText = "Location";
            col_Location.DataPropertyName = "Location";
            col_Location.Width = 60;
           

            //Manufacturer Column
            DataGridViewTextBoxColumn col_Manufactuer = new DataGridViewTextBoxColumn();
            col_Manufactuer.ReadOnly = true;
            col_Manufactuer.HeaderText = "Source";
            col_Manufactuer.DataPropertyName = "Manufacturer";
            col_Manufactuer.Width = 85;

            //ManuPart Column
            DataGridViewTextBoxColumn col_ManuPart = new DataGridViewTextBoxColumn();
            col_ManuPart.HeaderText = "Manu-Part";
            col_ManuPart.DataPropertyName = "Manupart";
            col_ManuPart.DefaultCellStyle.BackColor = System.Drawing.Color.Cornsilk;
            col_ManuPart.Width = 95;

            //UnitOfMeasure Column
            DataGridViewTextBoxColumn col_UnitofMeasure = new DataGridViewTextBoxColumn();
            col_UnitofMeasure.HeaderText = "Unit";
            col_UnitofMeasure.DataPropertyName = "UnitOfMeasure";
            col_UnitofMeasure.Width = 50;

            //Stock on Hand Column
            DataGridViewTextBoxColumn col_StockLevel = new DataGridViewTextBoxColumn();
            col_StockLevel.HeaderText = "Stock";
            col_StockLevel.DataPropertyName = "StockOnHand";
            col_StockLevel.DefaultCellStyle.BackColor = System.Drawing.Color.Cornsilk;
            col_StockLevel.DefaultCellStyle.DataSourceNullValue = 0.00;
            col_StockLevel.Width = 60;

            dg.Columns.AddRange(col_PartID, col_ItemDescription,col_Location ,col_Manufactuer, col_ManuPart, col_UnitofMeasure, col_StockLevel);

        }
    }
}
