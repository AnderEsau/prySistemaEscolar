using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//agregar los using de la libreria QuestPDF
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace prySistemaEscolar
{
    internal class clsReporte
    {
        DataTable tabla;
        MySqlDataAdapter consulta;
        public DataTable ConsultarAlumnosRiesgo()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT A.matricula AS Matricula, " +
                                 "A.nombreAlumno AS Nombre, " +
                                 "A.apellidoP AS 'A. Paterno', " +
                                 "A.apellidoM AS 'A. Materno', " +
                                 "C.nombreCarrera AS Carrera, " +
                                 "A.promedioBachillerato AS Promedio " +
                                 "FROM tblAlumnos A " +
                                 "INNER JOIN tblcarreras C ON A.idCarrera = C.idCarrera " +
                                 "WHERE A.promedioBachillerato <= 8.0;";

                    using (consulta = new MySqlDataAdapter(sql, conexion))//CONDICION
                    {
                        consulta.Fill(tabla);
                    }//se libera la consulta

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar alumnos en riesgo:" + ex.Message);
            }
            return tabla;
        }

        public DataTable consultarAlumnosTutores()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT A.matricula AS Matricula, " +
                                 "A.nombreAlumno AS Nombre, " +
                                 "A.apellidoP AS 'A. Paterno', " +
                                 "A.apellidoM AS 'A. Materno', " +
                                 "A.promedioBachillerato AS Promedio, " +
                                 "T.nombreTutor " +
                                 "FROM tblAlumnos A " +
                                 "INNER JOIN tbltutores T ON A.idTutor = T.idTutor " +
                                 "WHERE A.promedioBachillerato >= 9.0;";

                    using (consulta = new MySqlDataAdapter(sql, conexion))//CONDICION
                    {
                        consulta.Fill(tabla);
                    }//se libera la consulta

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar alumnos y tutores:" + ex.Message);
            }
            return tabla;
        }

        //ahora el metodo es una "plantilla" universal para cualquier reporte del sistema 
        
        public void ExportarPDF(DataTable tabla,string titulOReporte,string nombreArchivoSugerido)
        {
            if(tabla == null || tabla.Rows.Count==0)
            {
                MessageBox.Show("no hay datos para convertir a PDF","Atención", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            // abre la ventana para guardar el archivo PDF 
            SaveFileDialog guardarArchivo = new SaveFileDialog();
            guardarArchivo.FileName = nombreArchivoSugerido;
            guardarArchivo.Filter = "Archivos PDF (*.pdf)|*.pdf";

            if (guardarArchivo.ShowDialog() == DialogResult.OK)
            {
              try
              {
                    Document.Create(container =>
                    {
                        container.Page(page =>
                        {
                            page.Size(PageSizes.Letter.Landscape());
                            page.Margin(1.5f, Unit.Centimetre);
                            page.PageColor(Colors.White);
                            page.DefaultTextStyle(x => x.FontFamily(Fonts.Arial));
                            // Esto es para poner un título al reporte
                            page.Header().Row(row =>
                            {
                                row.RelativeItem().AlignLeft().AlignMiddle().Column(col =>
                                {
                                    col.Item().Text("UNIVERSIDAD TECNOLÓGICA DE LA HUASTECA HIDALGUENSE")
                                     .FontSize(18)
                                     .Bold()
                                     .FontColor("#10407A");

                                    col.Item().PaddingTop(5).LineHorizontal(1).LineColor(Colors.Grey.Lighten2);

                                });
                                
                                if (Properties.Resources.uthh != null)
                                {
                                    byte[] byteslogo = Properties.Resources.uthh;
                                    row.ConstantItem(90).AlignRight().AlignMiddle().Image(byteslogo);

                                }

                            });

                            //----Parte 2: contenido central ----
                            page.Content().PaddingTop(20).Column(column =>
                            {

                                //AQUI SE IMPRIME EL TITULO QUE LE PASES POR PARAMETRO 
                                column.Item().PaddingBottom(15).Text(titulOReporte) // <--DINAMICO
                                           .FontSize(12).Bold().FontColor(Colors.Black);

                                //LA TABLA SE CONSTRUYE SOLA SUGUN LAS COLUMNAS QUE TRAIGA EL DATATABLE 
                                column.Item().Table(table =>
                                {
                                    int totalcolumas = tabla.Columns.Count;

                                    table.ColumnsDefinition(columns =>
                                    {
                                        for (int i = 0; i < totalcolumas; i++)
                                        {
                                            if (i > 0 && i < totalcolumas - 1)
                                                columns.RelativeColumn(2f);
                                            else
                                                columns.RelativeColumn(1.2f);
                                        }

                                    });

                                    //Nombres de las columnas en automatico de acuerdo a la tabla 
                                    foreach (DataColumn columnaobjn in tabla.Columns)
                                    {
                                        table.Cell().Background("#4272CB").Padding(8).AlignLeft().AlignMiddle()
                                        .Text(columnaobjn.ColumnName).FontSize(10).Bold().FontColor(Colors.White);
                                    }
                                    //filas automaticas 
                                    bool alternarFila = true;
                                    foreach (DataRow fila in tabla.Rows)
                                    {
                                        string colorFondo = alternarFila ? "#E6EBF5" : "#FFFFFF";

                                        for (int i = 0; i < totalcolumas; i++)
                                        {
                                            var celda = table.Cell().Background(colorFondo)
                                                   .BorderBottom(1).BorderColor(Colors.Grey.Lighten3)
                                                   .Padding(7).AlignMiddle();
                                            if (i == 0 || i == (totalcolumas - 1))
                                                celda.AlignCenter();
                                            else
                                                celda.AlignCenter();

                                            celda.Text(fila[i].ToString()).FontSize(9).FontColor(Colors.Black);
                                        }
                                        alternarFila = !alternarFila;
                                    }

                                });

                            });

                            //este es el pie de  la pagina 
                            page.Footer().AlignRight().Text(x =>
                            {
                                x.Span("pagina").FontSize(9).FontColor(Colors.Grey.Darken1);
                                x.CurrentPageNumber().FontSize(9).Bold();
                                x.Span("  de  ").FontSize(9).FontColor(Colors.Grey.Darken1);
                                x.TotalPages().FontSize(9).Bold();
                            });

                        });

                    }).GeneratePdf(guardarArchivo.FileName);

                    MessageBox.Show("Reporte insititucional generado con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
              catch (Exception ex)
              {
                    MessageBox.Show("Error al generar el PDF "+ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
              }
              
            }

        }//finaliza metodo de conversión 
    }

}
