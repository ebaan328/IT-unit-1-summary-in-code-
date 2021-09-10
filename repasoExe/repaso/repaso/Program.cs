  using System;

namespace repaso
{
    class mainr
    {
        static void Main(string[] args)
        {
			auto.method();
			legend.legls();
			anomalies.outAnoma();
        }
	//contiene "variables" conteniendo definiciones
	public class definiciones
		{
			public string computadora = "dispositivo electronico que completa tareas bajo la direccion de una secuencia de instrucciones para producir resultados utiles para las personas.";
			public string hardware = "equipos fisicos asociados con una computadora.";
			public string software = "serie de instrucciones que dirige a los componentes fisicos para que puedan realizar tares.";
			public string data = "incluye palabras, numeros, videos, graficos, y audio, los cuales son manipulados, mostrados y procesados por los programas";
			public string baseDatos = "coleccion de datos organizada de forma que permita el acceso, recuperacion y uso de datos";
			public string lenguajeProgramacion = "serie de palabras, simbolos y codigos escritos siguiendo un estricto conjunto de reglas de uso llamado syntaxis. El desarrollador debe seguir la sintaxis del lenguaje de programacion con precision.";
			public string syntaxis = "reglas de programacion.";
			public string GUI = "graphical user interface por sus siglas en ingles. El usuario se comunica con la interfaz a traves de una interfaz grafica. ";
			public string dotNETFramework = "proporciona herramientas y procesos que los desarrolladores pueden usar para producir y ejecutar programas.";
			public string dotNETClassLibrary = "lugar donde se almacenan las clases una vez creadas y las hacen y las hacen disponibles a todos.";
			public string clase = "grupo nombrado de codigos de programas.";
			public string classLibrary = "conjunto de codigos(clases) reusables.";
			public string instanciacion = "objeto de una clase.";
			public string ADOdotNET = "provee la habilidad de leer y escribir data en una base de datos.";
			public string ASPdotNeT = "provee la habilidad de desarrollar aplicaciones web para computadoras desktop, tabletas, y navegadores moviles.";
			public string CLR = "permite a los programas ejecutar en diferentes computadoras que operan bajo sistemas operativos diferentes.";

		}

		//contiene metodo de iniciacion del programa.
		public class auto
		{
			public static void method()
			{
				Console.WriteLine("insert sec. key. (47)");
				int key = Convert.ToInt32(Console.ReadLine());
			if(key==47) 
				{

				}
				else
				{
					Console.WriteLine("invalid key.");
				}
			}
		}

		//tabla contenido(definiciones disponibles)
		public class legend
		{

			static string[] arr = { "computadora", "hardware", "software", "data", "baseDatos", "lenguajeProgramacion", "syntaxis", "GUI", "dotNETFramework", "dotNETClassLibrary", "clase", "classLibrary", "instanciacion", "ADOdotNET", "ASPdotNeT", "CLR" };
			//list legend method	
			public static void legls()
			{
				Console.WriteLine("input command (list) for definition list");
				string command = Console.ReadLine();
			if(command=="list")
				{
					Console.WriteLine(arr[0]);
					Console.WriteLine(arr[1]);
					Console.WriteLine(arr[2]);
					Console.WriteLine(arr[3]);
					Console.WriteLine(arr[4]);
					Console.WriteLine(arr[5]);
					Console.WriteLine(arr[6]);
					Console.WriteLine(arr[7]);
					Console.WriteLine(arr[8]);
					Console.WriteLine(arr[9]);
					Console.WriteLine(arr[10]);
					Console.WriteLine(arr[11]);
					Console.WriteLine(arr[12]);
					Console.WriteLine(arr[13]);
					Console.WriteLine(arr[14]);
					Console.WriteLine(arr[15]);
				}

			}
		}
		//conceptos y sus definiciones
		public class anomalies
		{

			public static void outAnoma()
			{
				Console.WriteLine("would you like to print class anomalies contents?1 for yes, 0 for no.");
				int input = Convert.ToInt32(Console.ReadLine());
				if (input==1)
				{
					FuncionesBasicas();
					OperacionesBasicas();
					Almacenamiento();
					VisualStudio();
					TiposAplicacionesVB();
				}
				else
				{
					Console.WriteLine("ok.");
				}
			}

			public static void FuncionesBasicas()
			{
				static void FunBa(){
					Console.WriteLine("1.Las funciones basicas de cualquier programa de computadora son: -aceptar data, input -procesar la data -crear resultados, output");
				}
				FunBa();
			}
			public static void OperacionesBasicas()
			{
				static void OpBa(){
					Console.WriteLine("2.Todos los programas, sin importar su tamaño o complejidad, ejecutan solo unas pocas operaciones fundamentales: operaciones de entrada, operaciones de salida, operaciones basicas de aritmetica, y operaciones de logica");
			};
				OpBa();
		}
			public static void Almacenamiento() {
				static void Alm() {
					Console.WriteLine("3.Al guardar un programa en un disco, este se puede ejecutar las veces que sea necesario sin la necesidad de volver a escribir los códigos. Los programas también pueden almacenar data, la cual se puede generar a partir del procesamiento del programa. En muchos casos se utilizan las bases de datos (database) como medio de almacenamiento de datos.");
				}
				Alm();
			}
			public static void VisualStudio()
			{
				static void VisStu() {
					Console.WriteLine("4.Visual Studio es un programa de aplicación que permite a los usuarios desarrollar programas utilizando diferentes lenguajes de programación.Este programa cuenta con un tipo de entorno de desarrollo integrado (IDE por sus siglas en inglés).  IDE proporciona servicios y herramientas que permiten a un desarrollador codificar, probar e implementar un programa, o una serie de programas, que comprenden una aplicación. ");
				}
				VisStu();
			}
		public static void TiposAplicacionesVB()
		{
				static void TipoApp()
				{
					Console.WriteLine("5.Cuando creamos programas en Visual Basic, utilizando Visual Studio, debemos elegir el tipo de aplicación que deseamos desarrollar.Los cinco tipos principales de aplicaciones son: -aplicaciones de escritori clasico de windows. -aplicaciones universales de windows. -aplicaciones web o cloud. -aplicaciones de base de datos. -aplicaciones para HoloLens.");
				}
				TipoApp();
		}
	}
}
}
