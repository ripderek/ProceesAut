using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tecla = OpenQA.Selenium.Keys;
using Microsoft.VisualBasic.FileIO;
using System.Diagnostics;
namespace WhatsappMensajes
{
    public partial class Form1 : Form
    {
        IWebDriver driver;
        string LocalPath = Directory.GetCurrentDirectory();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EnviarMensajes("593983671274");
            EnviarMensajes("593980570742");

        }
        private void EnviarMensajes(string numero)
        {
            string mensaje = "BODEGA 01 PRODUCTO TERMINADO CND EN SEMAFORO ROJO 🔴 901001036 FIDEO CHINO FINO 200g. EL STOCK ES  2137.96 CJ SE ENCUENTRA POR DEBAJO DEL STOCK MINIMO: 3039.02 CJ\r\nBODEGA 01 PRODUCTO TERMINADO CND EN SEMAFORO ROJO 🔴 901004005 FIDEO RAPIDITO\"POLLO\" 100 GR EL STOCK ES  3637.46 CJ SE ENCUENTRA POR DEBAJO DEL STOCK MINIMO: 4506.04 CJ\r\nBODEGA 01 PRODUCTO TERMINADO CND EN SEMAFORO ROJO 🔴 901001037 FIDEO CHINO FINO 400g. EL STOCK ES  2631.67 CJ SE ENCUENTRA POR DEBAJO DEL STOCK MINIMO: 2947.67 CJ\r\nBODEGA 01 PRODUCTO TERMINADO CND EN SEMAFORO ROJO 🔴 906010038 AGUA MIN.NAT. SG MANA 500ml EL STOCK ES  3898.40 CJ SE ENCUENTRA POR DEBAJO DEL STOCK MINIMO: 5912.07 CJ\r\nBODEGA 01 PRODUCTO TERMINADO CND EN SEMAFORO AMARILLO \U0001f7e1  906010037 AGUA MIN.NAT SG MANA 1 LT EL STOCK ES  3977.00 CJ SE ENCUENTRA POR DEBAJO DEL STOCK SEGURO: 5642.67 CJ\r\nBODEGA 01 PRODUCTO TERMINADO CND EN SEMAFORO ROJO 🔴 901004132 RAPIDITO POLLO PACK 500gr EL STOCK ES  1659.46 CJ SE ENCUENTRA POR DEBAJO DEL STOCK MINIMO: 2799.92 CJ\r\nBODEGA 01 PRODUCTO TERMINADO CND EN SEMAFORO ROJO 🔴 902002011 SALSA CHINA MEDIANA 200ml EL STOCK ES  1506.38 CJ SE ENCUENTRA POR DEBAJO DEL STOCK MINIMO: 1515.33 CJ\r\nBODEGA 01 PRODUCTO TERMINADO CND EN SEMAFORO AMARILLO \U0001f7e1  901001067 FIDEO CHIFA YATEKOMO 400GR EL STOCK ES  610.90 CJ SE ENCUENTRA POR DEBAJO DEL STOCK SEGURO: 783.55 CJ\r\nBODEGA 01 PRODUCTO TERMINADO CND EN SEMAFORO ROJO 🔴 901001039 FIDEO CHINO GRUESO 400 GR EL STOCK ES  730.88 CJ SE ENCUENTRA POR DEBAJO DEL STOCK MINIMO: 1313.92 CJ\r\nBODEGA 01 PRODUCTO TERMINADO CND EN SEMAFORO AMARILLO \U0001f7e1  901004136 RAPIDITO MIX 500gr EL STOCK ES  709.42 CJ SE ENCUENTRA POR DEBAJO DEL STOCK SEGURO: 713.71 CJ\r\nBODEGA 01 PRODUCTO TERMINADO CND EN SEMAFORO ROJO 🔴 901004102 F.RAP VASO INSTANT POLLO 65G EL STOCK ES  225.15 CJ SE ENCUENTRA POR DEBAJO DEL STOCK MINIMO: 2129.63 CJ\r\nBODEGA 01 PRODUCTO TERMINADO CND EN SEMAFORO ROJO 🔴 902009001 SALSA DE OSTION 200g EL STOCK ES  380.88 CJ SE ENCUENTRA POR DEBAJO DEL STOCK MINIMO: 412.29 CJ\r\nBODEGA 01 PRODUCTO TERMINADO CND EN SEMAFORO ROJO 🔴 901005001 FIDEO SOPITA CRIOLLA 200 GR EL STOCK ES  133.52 CJ SE ENCUENTRA POR DEBAJO DEL STOCK MINIMO: 429.92 CJ\r\nBODEGA 01 PRODUCTO TERMINADO CND EN SEMAFORO ROJO 🔴 901004015 FIDEO JUNIOR POLLO COMBO 50 GR EL STOCK ES  1054.33 CJ SE ENCUENTRA POR DEBAJO DEL STOCK MINIMO: 1228.83 CJ\r\nBODEGA 01 PRODUCTO TERMINADO CND EN SEMAFORO ROJO 🔴 903001003 HARINA DE PLATANO 400g. EL STOCK ES  234.54 CJ SE ENCUENTRA POR DEBAJO DEL STOCK MINIMO: 361.83 CJ\r\nBODEGA 01 PRODUCTO TERMINADO CND EN SEMAFORO ROJO 🔴 903001001 HARINA DE PLATANO 200g. EL STOCK ES  98.58 CJ SE ENCUENTRA POR DEBAJO DEL STOCK MINIMO: 477.96 CJ\r\nBODEGA 01 PRODUCTO TERMINADO CND EN SEMAFORO ROJO 🔴 902002012 SALSA CHINA NEGRA GALON. EL STOCK ES  589.17 CJ SE ENCUENTRA POR DEBAJO DEL STOCK MINIMO: 846.50 CJ\r\nBODEGA 01 PRODUCTO TERMINADO CND EN SEMAFORO ROJO 🔴 906011001 AGUA MIN.NAT. SG MANA 20LTS EL STOCK ES  2201.00 CJ SE ENCUENTRA POR DEBAJO DEL STOCK MINIMO: 11082.00 CJ\r\nBODEGA 01 PRODUCTO TERMINADO CND EN SEMAFORO ROJO 🔴 902001002 SALSA AJI MEDIANO 200ml EL STOCK ES  86.83 CJ SE ENCUENTRA POR DEBAJO DEL STOCK MINIMO: 1083.96 CJ\r\nBODEGA 01 PRODUCTO TERMINADO CND EN SEMAFORO ROJO 🔴 901004133 RAPIDITO CARNE PACK 500gr EL STOCK ES  66.33 CJ SE ENCUENTRA POR DEBAJO DEL STOCK MINIMO: 359.38 CJ\r\nBODEGA 01 PRODUCTO TERMINADO CND EN SEMAFORO ROJO 🔴 902009003 SALSA DE OSTION 400g EL STOCK ES  40.04 CJ SE ENCUENTRA POR DEBAJO DEL STOCK MINIMO: 220.75 CJ\r\nBODEGA 01 PRODUCTO TERMINADO CND EN SEMAFORO ROJO 🔴 901005002 FIDEO SOPITA CRIOLLA 70 GR EL STOCK ES  4.04 CJ SE ENCUENTRA POR DEBAJO DEL STOCK MINIMO: 449.69 CJ\r\nBODEGA 01 PRODUCTO TERMINADO CND EN SEMAFORO ROJO 🔴 903002003 VIDASOYA ORIENTAL 400g. EL STOCK ES  0.63 CJ SE ENCUENTRA POR DEBAJO DEL STOCK MINIMO: 222.71 CJ";
            Process p = new Process();
            Clipboard.SetText(mensaje);

            // Se establece la ruta del archivo ejecutable de WhatsApp
            //C:\Program Files\WindowsApps\5319275A.WhatsAppDesktop_2.2414.8.0_x64__cv1g1gvanyjgm
            //p.StartInfo.FileName = @"C:\Users\TU USUARIO\AppData\Local\WhatsApp\WhatsApp.exe";
            p.StartInfo.FileName = @"C:\Program Files\WindowsApps\5319275A.WhatsAppDesktop_2.2414.8.0_x64__cv1g1gvanyjgm\WhatsApp.exe";
            // Se inicia la aplicación de WhatsApp
            p.Start();

            // Se espera 5 segundos para que se cargue la aplicación
            System.Threading.Thread.Sleep(5000);

            // Se envía la combinación de teclas "Ctrl + N" para abrir la ventana de nuevo mensaje
            SendKeys.SendWait("^n");

            // Se espera 2 segundos para que se abra la ventana de nuevo mensaje
            System.Threading.Thread.Sleep(2000);

            // Se escribe el número de teléfono en la ventana de nuevo mensaje
            SendKeys.SendWait(numero);

            // Se envía la tecla "Enter" para buscar el número de teléfono
            SendKeys.SendWait("{ENTER}");
            SendKeys.SendWait("{TAB}");

            // Se espera 1 segundo para que se cargue el número de teléfono
            System.Threading.Thread.Sleep(1000);

            // Se envía la combinación de teclas "Ctrl + V" para pegar
            // la imagen en la ventana de nuevo mensaje
            

            SendKeys.SendWait("{ENTER}");
            // Se espera 2 segundos para que se cargue la imagen
            System.Threading.Thread.Sleep(2000);

            // Se escribe el mensaje en la ventana de nuevo mensaje
            // SendKeys.SendWait(mensaje);
            SendKeys.SendWait("^v");
            // Se envía la tecla "Enter" para enviar el mensaje
            SendKeys.SendWait("{ENTER}");
        }
    }
}
