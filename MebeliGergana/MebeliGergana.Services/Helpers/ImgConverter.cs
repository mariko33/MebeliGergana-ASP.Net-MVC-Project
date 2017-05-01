
using System.IO;
using System.Web.UI.WebControls;

namespace MebeliGergana.Services.Helpers
{
   public  class ImgConverter
    {
        public static byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        public static System.Drawing.Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);
            return returnImage;
        }
    }
}
