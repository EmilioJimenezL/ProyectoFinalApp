using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Xaml;
using Microsoft.Msagl.Core.DataStructures;
using Microsoft.Msagl.Drawing;

namespace ProyectoFinalApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Inicializando el form
            InitializeComponent();
        }
        //Acciones que se realizaran al cargar el form
        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> nodeDictionary = new();
            //Crear una nueva entidad de grafo con nombre mapa
            Graph graph = new("mapa");
            //Try de leer el archivo del mapa
            try
            {
                //Nueva entidad de reader
                using StreamReader reader = new StreamReader("map.txt");
                //Nuevo string para almacenar localmente una linea del texto del mapa
                string line;
                //Ciclo para leer linea por linea
                while ((line = reader.ReadLine()) != null)
                {
                    //Array de strings para almacenar los datos separados por comas
                    string[] chars = line.Split(',');
                    //Se agregan los datos del mapa siendo [Nodo origen],[Ponderacion],[Nodo destino] el formato usado
                    graph.AddEdge(chars[0], chars[2], chars[1]);
                }
                //Adjuntar el grafo al viewer
                gViewer1.Graph = graph;
                //Cerrar reader
                reader.Close();
            }
            //Catch de excepciones del lector de archivos
            catch (IOException exception)
            {
                //Desplega una ventana de error con el log generado por exception
                MessageBox.Show(exception.Message, "No se pudo encontrar el mapa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //try de leer el archivo diccionario
            try
            {
                //Entidad contenida de streameReader
                using (var reader = new StreamReader("dictionary.txt"))
                {
                    //String para guardar linea en proceso
                    string line;
                    //Ciclo para leer linea
                    while ((line = reader.ReadLine()) != null)
                    {
                        //Array de strings para almacenar los datos separados por comas
                        string[] chars = line.Split(',');
                        //Se agregan los datos de la biblioteca
                        nodeDictionary.Add(chars[0], chars[1]);
                    }
                    //Cerrar reader
                    reader.Close();
                }
            }
            //Catch de reader de biblioteca
            catch(IOException exception)
            {
                //Mensaje de error en caso de no encontrar la biblioteca
                MessageBox.Show(exception.Message, "No se pudo encontrar la biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Ciclo para añadir los nodos a la combobox
            foreach (Node node in graph.Nodes)
            {
                //Añadir a las combobox los nodos traducidos
                desdeComboBox.Items.Add(nodeDictionary[node.Id]);
                haciaComboBox.Items.Add(nodeDictionary[node.Id]);
            }
        }
        //Acciones a realizar al presionar el boton de buscar camino
        private void buscarButton_Click(object sender, EventArgs e)
        {
            //Inicializando diccionario
            Dictionary<string, string> nodeDictionary = new();
            //Try para leer el diccionario
            try
            {
                //Nueva entidad reader
                using (var reader = new StreamReader("dictionary.txt"))
                {
                    //String para almacenar linea en analisis
                    string line;
                    //Ciclo para leer linea por linea
                    while ((line = reader.ReadLine()) != null)
                    {
                        //Array de strings para almacenar los datos separados por comas
                        string[] chars = line.Split(',');
                        //Se agregan los datos de la biblioteca
                        nodeDictionary.Add(chars[0], chars[1]);
                    }
                    //Cerrar reader
                    reader.Close();
                }
            }
            //Catch excepcion del reader
            catch (IOException exception)
            {
                //mensaje de error en caso de no encontrar el archivo de biblioteca
                MessageBox.Show(exception.Message, "No se pudo encontrar la biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Borrar archivos de lecturas previas
            File.Delete("request.txt");
            File.Delete("path.txt");
            //Regresar nodos a su color original despues de lecturas previas
            foreach (Node node in gViewer1.Graph.Nodes)
            {
                //Pintar de blanco el nodo seleccionado
                node.Attr.FillColor = Microsoft.Msagl.Drawing.Color.White;
            }
            //Se limpia la caja de instrucciones
            instructionLBox.Items.Clear();
            //Inicializando variables de requests
            string desdeRequest = "", haciaRequest = "";
            //Ciclo para traducir de valor de texto a key con diccionario para nodo inicio
            foreach (var kvp in nodeDictionary)
            {
                //Si el valor de la key seleccionada es igual al valor indicado en la combobox se asigna el valor key a la variable desdeRequest
                if (kvp.Value.Equals(desdeComboBox.Text))
                {
                    desdeRequest = kvp.Key;
                    break;
                }
            }
            //Ciclo para traducir de valor de texto a key con diccionario para nodo final
            foreach (var kvp in nodeDictionary)
            {
                //Si el valor de la key seleccionada es igual al valor indicado en la combobox se asigna el valor key a la variable haciaRequest 
                if (kvp.Value.Equals(haciaComboBox.Text))
                {
                    haciaRequest = kvp.Key;
                    break;
                }
            }
            //Se escribe el archivo request
            File.WriteAllText("request.txt", desdeRequest + "," + haciaRequest);
            //Se inicia el programa compilado en python y se espera a que termine
            Process.Start("main.exe").WaitForExit();
            //Inicializando la lista nodePath
            List<string> nodePath;
            //Try de lectura del path generado por el programa anterior
            try
            {
                //Reader para leer path.txt
                using (var reader = new StreamReader("path.txt"))
                {
                    //Se asigna nodePath las lineas de path.txt
                    nodePath = [.. reader.ReadToEnd().Split(",")];
                    //Cerrar el reader
                    reader.Close();
                }
                //Para cada string node en nodePath, es decir, cada linea en la lista de strings
                foreach (string node in nodePath)
                {
                    //Si el nodo no esta vacio
                    if (node != "")
                    {
                        //Se encuentra el nodo mencionado y se remarca con rojo
                        gViewer1.Graph.FindNode(node).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Red;
                        //Si el nodo es igual al nodo inicial se agrega a la caja de instrucciones la primera instruccion de navegacion
                        if (node.Equals(desdeRequest))
                        {
                            instructionLBox.Items.Add("Sal de " + desdeComboBox.Text);
                        }
                        //Se agregan las demas instrucciones de navegacion
                        else
                        {
                            instructionLBox.Items.Add("Camina a " + nodeDictionary[node]);
                        }
                    }
                }
                //Instruccion de termino de navegacion
                instructionLBox.Items.Add("Llegaste!");
                //Se refresca el forms para que se vea reflejado el cambio en el grafo
                this.Refresh();
            }
            //Excepcion del reader 
            catch (IOException exception)
            {
                //Mensaje de advertencia si no se encuentra el archivo de path
                MessageBox.Show(exception.Message, "No se pudo encontrar el archivo path", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Acciones al presionar el boton de mostrar mapa
        private void showMapButton_Click(object sender, EventArgs e)
        {
            //Se inicializa un segundo forms
            Form2 form2 = new Form2();
            //Se muestra el segundo forms
            form2.Show();
        }
    }
}