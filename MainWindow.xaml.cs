using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.Windows.Threading;


namespace _2doDelExamen
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

        int auxp = 0;
        int click = 0;
 
private void SldProgress_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            auxp = Convert.ToInt32(this.sldProgress.Value);
            
            if (auxp == 0)
            {
                txt1.Text = "La Feria Estatal de León es un evento que se celebra cada año entre los meses de enero y febrero en León (Guanajuato). Es una tradición no solo en el estado de Guanajuato, sino en todo México. Recibe a más de 6 millones de visitantes, tanto del país como extranjeros1​ ";
                Image.Source = new BitmapImage(new Uri("Images/feria.jpg", UriKind.Relative));

            }
            else
            {
                txt1.Text = "";
                txt2.Text = "";
                Image.Source = new BitmapImage(new Uri("Images/.jpg", UriKind.Relative));
            }
            if (auxp == 6)
            {
                txt1.Text = "Exposiciones artesanales, comerciales y ganaderas, presentaciones de artistas del momento, festivales taurinos, juegos mecánicos y show de pirotecnia y música son algunos de los atractivos que durante 26 días abren sus puertas al público.";
                txt2.Text = "2006";
                Image.Source = new BitmapImage(new Uri("Images/feria2006.jpg", UriKind.Relative));

            }
            if (auxp == 8)
            {
                txt1.Text = "Tiene un costo de acceso general de $11, con Inapam $6. Las taquillas tienen horario de 10:00 a.m. a 1:00 a.m.";
                txt2.Text = "2008";
                Image.Source = new BitmapImage(new Uri("Images/feria2008.jpg", UriKind.Relative));

            }
            if (auxp == 9)
            {
                txt1.Text = "Fue una edicion especialya que se esperaba mucho de la feria y fue de las ultimas veces que aparecio el arlequin";
                txt2.Text = "2009";
                Image.Source = new BitmapImage(new Uri("Images/feria2009.jpg", UriKind.Relative));

            }
            if (auxp == 11)
            {
                txt1.Text = "Despues de una edicion del bicentenario de mexico, fue una gran edicion ya que cambiaron los espectaculos de gratuitos aque todo cobraran";
                txt2.Text = "2011";
                Image.Source = new BitmapImage(new Uri("Images/feria2011.jpg", UriKind.Relative));

            }
            if (auxp ==12)
            {
                txt1.Text = "En esta edicion se desato la locura, ya que se plagio el logo de la feria de leon 2012";
                txt2.Text = "2012";
                Image.Source = new BitmapImage(new Uri("Images/feria1.jpg", UriKind.Relative));

            }
            if (auxp == 13)
            {
                txt1.Text = "El tradicional desfile fue unrotundo exito ya que los carros alegoricos fueron de los mejores que se pudieron mostrar en el bajio, el tradicional defile se lleva el 3er domingo de enero";
                txt2.Text = "2013";
                Image.Source = new BitmapImage(new Uri("Images/feria2013.jpg", UriKind.Relative));

            }
            if (auxp == 14)
            {
                txt1.Text = "Desde entonces el logo no se ha modificado en su totalidad, solo unas cuantas cosas y unos cuantos lemas, ya que agrado mucho al publico y dio una identidad al pueblo";
                txt2.Text = "2014";
                Image.Source = new BitmapImage(new Uri("Images/feria2014.jpg", UriKind.Relative));

            }
            if (auxp ==15)
            {
                txt1.Text = "La feria fue cada vez fue expandiendose hasta tomar por completo las instalaciones de explora y metieron mas juegos mecanicos como la Mega King Tower";
                txt2.Text = "2015";
                Image.Source = new BitmapImage(new Uri("Images/feria2015.jpg", UriKind.Relative));

            }
            if (auxp == 16)
            {
                txt1.Text = "Fue un año muy sencillo, los diseños no fueron lo esperado ha sido de las peores ediciones";
                txt2.Text = "2016";
                Image.Source = new BitmapImage(new Uri("Images/feria2016.jpg", UriKind.Relative));

            }
            if (auxp == 17)
            {
                txt1.Text = "La edicion de este año de nuevo volvio a tener los shows gratuitos solo implementaron la linea 0 para poder recuperar monto economico";
                txt2.Text = "2017";
                Image.Source = new BitmapImage(new Uri("Images/feria2017.jpg", UriKind.Relative));

            }
            if (auxp == 18)
            {
                txt1.Text = "La ultima edicion, fue un total exito ya que como siempre inovaron en traer diferentes artistas";
                txt2.Text = "2018";
                Image.Source = new BitmapImage(new Uri("Images/feria2019.jpg", UriKind.Relative));

            }
      
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            click = click + 1;
            sldProgress.Value = sldProgress.Value + 1;
            if (click<0)
            {
                click = 19;
            }
        }

        private void ImgAntes_MouseDown(object sender, MouseButtonEventArgs e)
        {
            click = click - 1;
            sldProgress.Value = sldProgress.Value - 1;
            if (click < 0)
            {
                click = 0;
            }
        }
    }
}
