﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MueblesTerminadosV2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            var presupuesto = new TeoWinEntities();
            var step1 = presupuesto.tpresupuesto.Where(p => p.observaciones == "URB088 MD");
            var query = step1.FirstOrDefault();

            if (query != null) MessageBox.Show(query.codigo);
        }

    }
}
