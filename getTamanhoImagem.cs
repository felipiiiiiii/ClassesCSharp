using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class getTamanhoImagem
{
    public static int alturaImg(string diretorioImg)
    {
        System.Drawing.Image img = System.Drawing.Image.FromFile(diretorioImg);
        return img.Height;
    }

    public static int larguraImg(string diretorioImg)
    {
        System.Drawing.Image img = System.Drawing.Image.FromFile(diretorioImg);
        return img.Width;
    }
}

