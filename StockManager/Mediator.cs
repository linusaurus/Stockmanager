using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace StockManager
{

    public sealed class Mediator

    {

        private static readonly Mediator _Instance = new Mediator();
        private Mediator() { }


        //public event EventHandler<OrderChangedArgs> OrderOpen;
       


        public static Mediator GetInstance()
        { return _Instance; }

        //#region Order Changed

        
        //public event EventHandler<Part> PartOpenForEdit;

        //public void OnPartOpened(object sender, Part part)
        //{

        //    var OrderChangedDelegate = PartOpenForEdit as EventHandler<Part>;
        //    if (OrderChangedDelegate != null)
        //    {
        //        OrderChangedDelegate(this, part);
        //    }
        //}

        //public event EventHandler<OrderChangedArgs> OrderChanged;

        //public void OnOrderChanged(object sender, PurchaseOrder order)
        //{

        //    var OrderChangedDelegate = OrderChanged as EventHandler<OrderChangedArgs>;
        //    if (OrderChangedDelegate != null)
        //    {
        //        OrderChangedDelegate(this, new OrderChangedArgs { Order = order });
        //    }
        //}
        ///// <summary>
        ///// When an Order needs to be Rendered
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="order"></param>
        ////public void OnOrderOpened(object sender, PurchaseOrder order)
        ////{

        ////    var OrderOpenedDelegate = OrderOpen as EventHandler<OrderChangedArgs>;
        ////    if (OrderOpenedDelegate != null)
        ////    {
        ////        OrderOpenedDelegate(this, new OrderChangedArgs { Order = order });
        ////    }
        ////}


        //#endregion

        #region TabChanged

        public event EventHandler<TabPageChangedArgs> TabChanged;
        public void OnTabChanged(object sender, System.Windows.Forms.TabPage SelectedPage)
        {
            var TabChangedDelegate = TabChanged as EventHandler<TabPageChangedArgs>;
            if (TabChangedDelegate != null)
            {
                TabChangedDelegate(this, new TabPageChangedArgs { Tabpage = SelectedPage });
            }
        }

        #endregion


        #region EventArgs

        public class OrderIsDirtyChangedArgs : EventArgs
        {      
            public bool IsDirty { get; set; }
        }



        public class TabPageChangedArgs : EventArgs
        {
            public System.Windows.Forms.TabPage Tabpage { get; set; }
        }


        #endregion

    }

}