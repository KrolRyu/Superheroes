using System.Collections.Generic;

class Superheroe
    {
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        public bool Vengador { get; set; }
        public bool Xmen { get; set; }
        public bool Heroe { get; set; }

        public Superheroe()
        {
        }

        public Superheroe(string nombre, string imagen, bool vengador, bool xmen, bool heroe)
        {
            Nombre = nombre;
            Imagen = imagen;
            Vengador = vengador;
            Xmen = xmen;
            Heroe = heroe;
        }

        public static List<Superheroe> GetSamples()
        {
            List<Superheroe> ejemplos = new List<Superheroe>();

            Superheroe ironman = new Superheroe("Ironman", @"https://dossierinteractivo.com/wp-content/uploads/2021/01/Iron-Man.png",true, false,true);
            Superheroe kingpin = new Superheroe("Kingpin", @"https://www.comicbasics.com/wp-content/uploads/2017/09/Kingpin.jpg", false, false,false);
            Superheroe spiderman = new Superheroe("Spiderman", @"https://wipy.tv/wp-content/uploads/2019/08/destino-de-%E2%80%98Spider-Man%E2%80%99-en-los-Comics.jpg", true, true,true);
            Superheroe mk = new Superheroe("Moon Knight", @"https://www.latercera.com/resizer/RbVI1djIwFhy0FIOLTor3EiXgKk=/arc-anglerfish-arc2-prod-copesa/public/D7R2UKHBYVGZXLL5ALHQNWNMKM.jpg", false, false, true);
            Superheroe carnage = new Superheroe("Carnage", @"https://www.latercera.com/resizer/puzZFpGdlVaLdmJjyCXCLDyTmwQ=/800x0/smart/cloudfront-us-east-1.images.arcpublishing.com/copesa/BQTUMIRB3ZE5XHPJ3NALO6KIXI.jpg", false, false, false);
            Superheroe prawler = new Superheroe("Prawler", @"https://seanmills6.files.wordpress.com/2019/10/two-prowlers-11.jpg", false, false, false);
            Superheroe nightcrawler = new Superheroe("Nightcrawler", @"https://i.pinimg.com/736x/40/ae/16/40ae166e92ec4782b1efdb4640a04d6e.jpg", false, true, true);
            Superheroe nova = new Superheroe("Nova", @"https://depor.com/resizer/tOikWgeh9JQ6YWhaoUaSOFP3icU=/580x330/smart/filters:format(jpeg):quality(75)/arc-anglerfish-arc2-prod-elcomercio.s3.amazonaws.com/public/JJSMKMHDSNA37PP7NWXCWX3CMU.jpg", true, false, true);
            Superheroe howard = new Superheroe("Howard el pato", @"https://i1.wp.com/fueradeseries.com/wp-content/uploads/2021/02/1Q0NU8jb8ACqfT6D-DY33MA.jpeg?ssl=1", false,false,true);


            ejemplos.Add(ironman);
            ejemplos.Add(kingpin);
            ejemplos.Add(spiderman);
            ejemplos.Add(mk);
            ejemplos.Add(carnage);
            ejemplos.Add(prawler);
            ejemplos.Add(nightcrawler);
            ejemplos.Add(nova);
            ejemplos.Add(howard);


            return ejemplos;
        }
      }