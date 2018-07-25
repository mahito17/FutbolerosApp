namespace FutbolerosApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Text;
    public class Cancha
    {
        #region Propiedades
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        #endregion
    }



    public class ListaCanchas
    {
        public ObservableCollection<Cancha> Canchas { get; set; }
        
        #region Constructor
        public ListaCanchas()
        {
            Canchas = new ObservableCollection<Cancha>();
            ListCanchas();
            //se instancia y se cargan los elementos de la lista "cancha"
            #endregion
        }

        #region Metodos


        public void ListCanchas()
        {
            Canchas.Add(new Cancha
            {
                Nombre = "Cancha Sintetica Los Trigales",
                Descripcion = "Cancha sintetica cubierta con parqueadero...",
                Imagen = "img1"
            });


            Canchas.Add(new Cancha
            {
                Nombre = "Cancha Sintetica Los Colegas",
                Descripcion = "Cancha sintetica para futbol 5 y 8 con parqueadero...",
                Imagen = "img2"
            });


            Canchas.Add(new Cancha
            {
                Nombre = "Cancha Sintetica Los Colegas",
                Descripcion = "Cancha sintetica para futbol 5 y 8 con parqueadero...",
                Imagen = "img3"
            });


            Canchas.Add(new Cancha
            {
                Nombre = "Cancha Sintetica Los Colegas",
                Descripcion = "Cancha sintetica para futbol 5 y 8 con parqueadero...",
                Imagen = "img4"
            });

            Canchas.Add(new Cancha
            {
                Nombre = "Cancha Sintetica Los Colegas",
                Descripcion = "Cancha sintetica para futbol 5 y 8 con parqueadero...",
                Imagen = "img5"
            });
        }


        #endregion

    }
}
