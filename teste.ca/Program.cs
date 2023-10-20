using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace teste.ca
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = @"AQAAABQAAACEAQAAAQASAAMAWQAAAAAAfAEAAEO0*ozqvH22/rIQ1S*hKHZF/eo*yfi6AazK3P5GoKl2wXTt6eo0ZUrHfDBO2xZkmUXXYdYjapejjzlVXE8PYshfm88TcQayhI6V7BUSOJtWMZr48YYMU38M3qbQPGbtK1yut9/1fgYxMkdfeDzIqPCAmbh/bATIGd9jespsfaKLQiS9uvU3iGJiQ1IlzflYBpXJEdRb0i9ZNOXw5XfDxDZLdP1ZKl/XGYxZpnddsLRVXYtAZ6x1MCccJ*wzielhG3Hgh8ag3HaV/h6aTLPzg9TLkECVZ5YQkzB/2jPDrd6OAAMs2Ib2HD4NRVZnGGJ/F81je4Z1rBPmhUxnKaDeCLnmxyKpH4EtLw3RsuvkhKh0lBdkN31RZ7On7YAKqRiOjWXU71p8qeRZYFqbXuUM1diYok8nMdU6X4vL3hkHh/RGKl8gLTVGjKbj5L4Ka5Mmvwl4PuH7ghcWjYuVGC/zXIspVuLx7a/76LHExCc5eDsWQnqnQUEuPLINO9w3Brr2NQ";
            byte[] bytes = Encoding.UTF8.GetBytes(texto);

            Image imagem = ConvertBytesToImage(bytes);

            imagem.Save("output.png", System.Drawing.Imaging.ImageFormat.Png);
        }

        static Image ConvertBytesToImage(byte[] bytes)
        {
            using (MemoryStream stream = new MemoryStream(bytes))
            {
                Image imagem = Image.FromStream(stream);
                return new Bitmap(imagem);
            }
        }

    }
}
