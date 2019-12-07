using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Contratista.Empleado
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VercatalogoServicio : ContentPage
	{
        private int IdCatalogo;
        private string Nombre;
        private string Imagen_1;
        private string Imagen_2;
        private string Descripcion;
        private int Id_Servicio;
        public VercatalogoServicio(int id_catalogo, string nombre, string imagen_1, string imagen_2, string descripcion, int id_servicio)
        {
            InitializeComponent();
            IdCatalogo = id_catalogo;
            Nombre = nombre;
            Imagen_1 = imagen_1;
            Imagen_2 = imagen_2;
            Descripcion = descripcion;
            Id_Servicio = id_servicio;
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            List<CustomData> GetDataSource()
            {
                List<CustomData> list = new List<CustomData>();
                list.Add(new CustomData("http://dmrbolivia.online" + Imagen_1));
                list.Add(new CustomData("http://dmrbolivia.online" + Imagen_2));

                return list;
            }
            rotator.ItemsSource = GetDataSource();
            TituloTxt.Text = Nombre;
            DescripcionTxt.Text = Descripcion;
        }

        private void BtnEditar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EditarCatalogo(IdCatalogo, Nombre, Imagen_1, Imagen_2, Descripcion, Id_Servicio));
        }
    }
}