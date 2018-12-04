using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp9
{
    public static class StaticForms
    {
        // Static Forms.
        public static ListTrackingMoney ListTrackingForm { get; } = new ListTrackingMoney();
        public static AddGasto GastoForm { get; } = new AddGasto();
        public static AddIngresos IngresoForm { get; } = new AddIngresos();
    }
    
    // Static values!
    public static class ControlIngresos
    {
        private  static double _IngresosDisponibles;
        private  static double _TotGasto;
        private  static double _TOTAL;
         
        static public double AddGasto
        {
            get { return _TotGasto; }
            set { _IngresosDisponibles = _IngresosDisponibles - value; _TotGasto = _TotGasto + value; }
               
        }
        
        static public double AddIngreso
        {
            get { return _IngresosDisponibles; }
            set { _IngresosDisponibles = _IngresosDisponibles + value; }
        }

        static public double TOTAL
        {
            get { return _TOTAL; }
            set { _TOTAL = _TOTAL + value; }
        }
        
       
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new PanelPrincipal());
        }
    }
}
