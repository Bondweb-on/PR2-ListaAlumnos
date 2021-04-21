using System;

namespace PR2_ListaAlumnos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alumnos de la carrera de Ingeniería en Multimedia:");
            Console.WriteLine("                    ");
            //Carrera de Ingeniería en Multimedia
            Carreras grupoMultimedia2do = new Carreras();
            grupoMultimedia2do.alumno.Add(new Alumnos("Ezreal", "Lyte", 201));
            grupoMultimedia2do.alumno.Add(new Alumnos("Jhin", "Comstock", 202));
            grupoMultimedia2do.alumno.Add(new Alumnos("Yasuo", "Harusame", 203));
            grupoMultimedia2do.alumno.Add(new Alumnos("Yone", "Harusame", 204));
            grupoMultimedia2do.alumno.Add(new Alumnos("Fiora", "Lafayette", 205));

            Carreras grupoMultimedia4to = new Carreras();
            grupoMultimedia4to.alumno.Add(new Alumnos("Garen", "Geneanet", 401));
            grupoMultimedia4to.alumno.Add(new Alumnos("Lux", "Geneanet", 402));
            grupoMultimedia4to.alumno.Add(new Alumnos("Sylas", "Seagem", 403));
            grupoMultimedia4to.alumno.Add(new Alumnos("Galio", "Fusebasher", 404));
            grupoMultimedia4to.alumno.Add(new Alumnos("Poppy", "Blackwatcher", 405));
            
            Carreras grupoMultimedia6xto = new Carreras();
            grupoMultimedia6xto.alumno.Add(new Alumnos("Kayn", "Shieda", 601));
            grupoMultimedia6xto.alumno.Add(new Alumnos("Rakan", "Mirthvalor", 602));
            grupoMultimedia6xto.alumno.Add(new Alumnos("Xayah", "Glowchaser", 603));
            grupoMultimedia6xto.alumno.Add(new Alumnos("Sett", "Hydragaze", 604));
            grupoMultimedia6xto.alumno.Add(new Alumnos("Akali", "Lunaleaf", 605));
            
            Carreras grupoMultimedia8vo = new Carreras();
            grupoMultimedia8vo.alumno.Add(new Alumnos("Katarina", "Hawkfang", 801));
            grupoMultimedia8vo.alumno.Add(new Alumnos("Darius", "Earthgleam", 802));
            grupoMultimedia8vo.alumno.Add(new Alumnos("Riven", "Freevale", 803));
            grupoMultimedia8vo.alumno.Add(new Alumnos("Swain", "Roughgrove", 804));
            grupoMultimedia8vo.alumno.Add(new Alumnos("Vladimir", "Leafwood", 805));

            for (int i = 0; i < grupoMultimedia6xto.alumno.Count; i++)
            {
                Console.WriteLine(grupoMultimedia6xto.alumno[i].nombre + " " + grupoMultimedia6xto.alumno[i].apellido);
            }

            Console.WriteLine("\n--------\n");

            Console.WriteLine("Información de la Carrera de Ingeniería en Multimedia: " + "El programa de Ingeniera en Multimedia, forma profesionistas competentes en el diseño, desarrollo y puesta en marcha de sistemas informáticos que utilicen intensivamente el potencial tecnológico de la multimedia.  Además desarrollará software y aplicaciones que aprovechen, mejoren o creen nuevas opciones tecnológicas sobre las herramientas de desarrollo que componen lo más avanzado  en tecnología multimedia. Sabrá dimensionar y administrar  proyectos de sistemas y multimedia con habilidades en la coordinación de equipos interdisciplinarios de desarrollo.");

            Console.WriteLine("\n--------\n");
            //Carrera de Licenciatura en Artes Visuales
            Console.WriteLine("Alumnos de la carrera de Licenciatura en Artes Visuales:");
            Console.WriteLine("                    ");

            Carreras grupoArtesVis2do = new Carreras();
            grupoArtesVis2do.alumno.Add(new Alumnos("Viego", "Blacksinger", 221));
            grupoArtesVis2do.alumno.Add(new Alumnos("Isolde", "Gloryshine", 222));
            grupoArtesVis2do.alumno.Add(new Alumnos("Leona", "Serpentcaller", 223));
            grupoArtesVis2do.alumno.Add(new Alumnos("Diana", "Downmoon", 224));
            grupoArtesVis2do.alumno.Add(new Alumnos("Zed", "Trueward", 225));

            Carreras grupoArtesVis4to = new Carreras();
            grupoArtesVis4to.alumno.Add(new Alumnos("Kha'Zix", "Blacksplitter", 421));
            grupoArtesVis4to.alumno.Add(new Alumnos("Ziggs", "Mourningblaze", 422));
            grupoArtesVis4to.alumno.Add(new Alumnos("Teemo", "Greatcaller", 423));
            grupoArtesVis4to.alumno.Add(new Alumnos("Rek'Sai", "Flatsky", 424));
            grupoArtesVis4to.alumno.Add(new Alumnos("Ekko", "Lionfist", 425));

            Carreras grupoArtesVis6xto = new Carreras();
            grupoArtesVis6xto.alumno.Add(new Alumnos("Kennen", "Woodenblood", 621));
            grupoArtesVis6xto.alumno.Add(new Alumnos("Kled", "Mourngrove", 622));
            grupoArtesVis6xto.alumno.Add(new Alumnos("Annie", "Sternarrow", 623));
            grupoArtesVis6xto.alumno.Add(new Alumnos("Caitlyn", "Fireshield", 624));
            grupoArtesVis6xto.alumno.Add(new Alumnos("Varus", "Alpenguard", 625));

            Carreras grupoArtesVis8vo = new Carreras();
            grupoArtesVis8vo.alumno.Add(new Alumnos("Aatrox", "Seaglade", 821));
            grupoArtesVis8vo.alumno.Add(new Alumnos("Gwen", "Mossscribe", 822));
            grupoArtesVis8vo.alumno.Add(new Alumnos("Azir", "Sunfist", 823));
            grupoArtesVis8vo.alumno.Add(new Alumnos("Sivir", "Sageaxe", 824));
            grupoArtesVis8vo.alumno.Add(new Alumnos("Senna", "Horsechewer", 825));

            for (int i = 0; i < grupoArtesVis6xto.alumno.Count; i++)
            {
                Console.WriteLine(grupoArtesVis6xto.alumno[i].nombre + " " + grupoArtesVis6xto.alumno[i].apellido);
            }

            Console.WriteLine("\n--------\n");

            Console.WriteLine("Información de la Carrera de Licenciatura en Artes Visuales: " + "En Artes Visuales aprenderás a ilustrar con diferentes técnicas, a crear imagen corporativa y branding (logotipos y sus aplicaciones, crear experiencia); fotografía comercial, documental y artística; diseño editorial (revistas, libros, catálogos y folletos); diseño y programación de páginas web y multimedia, así como desarrollo de proyectos audiovisuales como comerciales de TV, animación, cortometrajes, anuncios para la radio, Motion Graphics y más... También cuenta con materias que te permiten crear y administrar tu propio negocio si así lo deseas. La Lic. en Artes Visuales tiene una duración de 8 semestres, en turno matutino, con un horario entre 8am y 2pm. Estamos incorporados a la SEC y D y somos parte del Sistema Educativo Nacional (SEN).");

            Console.WriteLine("\n--------\n");

            Alumnos resultadoBusquedaMatricula = grupoMultimedia2do.ConsultarPorMatricula(201);
            Console.WriteLine("Resultado de la búsqueda: " + 
            resultadoBusquedaMatricula.nombre);
            
        }
    }
}
