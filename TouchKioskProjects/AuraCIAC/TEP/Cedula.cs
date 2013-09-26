using System;
using System.Drawing;
using System.IO;
using DPFP;

namespace Aura.Kioski.Webservices.Client
 
{
    /// <summary>
    /// Representa una soloa instancia de Cedula
    /// </summary>
    public sealed class Cedula
    {
        object[] _data = new object[10];
        public Byte[] Digital { get; private set; }
        public String NroCedula { get; private set; }
        public Sample sample;
        private static readonly Cedula _instance = new Cedula();

        public static Cedula Instance
        {
            get { return _instance; }
        }

        /// <summary>
        /// Default empty constructor
        /// </summary>

        public Cedula()
        {
        }
 
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        /// <param name="digital">Impresion digital del Tribunal Electoral</param>
        /// <param name="cedula">Nro de cedula</param>
        public Cedula(Byte[] digital, String cedula)
        {
            this.Digital = digital;
            this.NroCedula = cedula;
        }

        /// <summary>
        /// Crea una Cedula a partir de una imagen.
        /// </summary>
        /// <param name="digital"></param>
        /// <param name="cedula"></param>
        public Cedula(Bitmap digital, String cedula)
        {
            this.Digital = BitmaptoArray(digital);
            this.NroCedula = cedula;
        }


        /// <summary>
        /// Convierte imagen Bipmap en Bytes []
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        private Byte[] BitmaptoArray(Bitmap image)
        {
            this.Digital = default(byte[]);
            MemoryStream stream = new MemoryStream();
            image.Save(stream,System.Drawing.Imaging.ImageFormat.Bmp);
            return stream.ToArray();
        }
        /// <summary>
        /// Convierte imagen Bitmap en Stream
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public Stream BitmaptoStream(Bitmap image)
        {
            this.Digital = default(byte[]);
            Stream stream = new MemoryStream();
            image.Save(stream,System.Drawing.Imaging.ImageFormat.Bmp);
            return stream;
        }
 }
}
