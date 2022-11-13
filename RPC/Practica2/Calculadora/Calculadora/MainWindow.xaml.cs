using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Security.Permissions;
using System.Windows;

namespace Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        bool aux = false;

        private void btnInitService_Click(object sender, RoutedEventArgs e)
        {
            if (aux) Application.Current.Shutdown();
            InitializeComponent();
            TcpChannel channel = new TcpChannel(8889); // USAREMOS EL PUERTO 8888 P/COMUNICARNOS
            ChannelServices.RegisterChannel(channel);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteClass), "cincom", WellKnownObjectMode.SingleCall); // EL NOMBRE DEL OBJETO QUE BUSCAREMOS EN LA RED SE LLAMA cincom
            MessageBox.Show("El servidor esta listo...");
            System.Console.ReadLine();
            //button1.Text = "Detener Servicio";
            aux = true;
        }
    }
}
