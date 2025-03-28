using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Media.Imaging;

namespace t_project.DB.Classes
{
    public class ImageConvert
    {
        public static BitmapImage DisplayImage(byte[] imageData)
        {

            if (imageData != null && imageData.Length > 0)
            {
                try
                {
                    var bitmapImage = new BitmapImage();

                    using (var stream = new MemoryStream(imageData))
                    {
                        bitmapImage.BeginInit();
                        bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                        bitmapImage.StreamSource = stream;
                        bitmapImage.EndInit();
                        return bitmapImage;
                    }

                    
                }
                catch (Exception ex)
                {
                    Uri uri = new Uri("/Images/Logo.png", UriKind.Relative);
                    return new BitmapImage(uri);

                    
                }
            }
            else
            {
                Uri uri = new Uri("/Images/Logo.png", UriKind.Relative);
                return new BitmapImage(uri);
            }
        }
    }
}
