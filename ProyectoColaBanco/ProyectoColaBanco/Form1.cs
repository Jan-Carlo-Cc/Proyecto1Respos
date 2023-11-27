using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoColaBanco
{
    public partial class Form1 : Form
    {
        ColaBanco objCola = new ColaBanco();
        Cliente objCliente = new Cliente();
        Random NumRan = new Random();
        string tipo = string.Empty;
        int seleccion;
        int num1 = 1;
        int num2 = 1;
        int num3 = 1;
        int num4 = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            seleccion = NumRan.Next(4);
            string nombre = txtNombreCliente.Text;
            if (nombre == string.Empty || nombre == " ")
            {
                MessageBox.Show("Debe de Ingresar un nombre para poder agregar un nuevo Cliente");
            }
            else
            {
                switch (seleccion)
                {
                    case 0:
                        tipo = "Ciudadado de Oro";
                        objCola.ColaCiudadanoOro.Enqueue(new Cliente { nombre = nombre, ficha = num1, prioridad = tipo });
                        //listBox1.Items.Add("Nombre del Cliente: " + nombre + "\nFicha : " + num1 + "\nTipo de Tramite " + tipo);
                        int CO = dtgvCiudadanoOro.Rows.Add();
                        dtgvCiudadanoOro.Rows[CO].Cells[0].Value = nombre;
                        dtgvCiudadanoOro.Rows[CO].Cells[1].Value = num1;
                        dtgvCiudadanoOro.Rows[CO].Cells[2].Value = tipo;
                        num1++;
                        break;
                    case 1:
                        tipo = "Credito Bancario";
                        objCola.ColaCreditosBancarios.Enqueue(new Cliente { nombre = nombre, ficha = num2, prioridad = tipo });
                        int CB = dtgvCreditoBancario.Rows.Add();
                        dtgvCreditoBancario.Rows[CB].Cells[0].Value = nombre;
                        dtgvCreditoBancario.Rows[CB].Cells[1].Value = num2;
                        dtgvCreditoBancario.Rows[CB].Cells[2].Value = tipo;
                        num2++;
                        break;
                    case 2:
                        tipo = "Plataforma";
                        objCola.ColaPlataforma.Enqueue(new Cliente { nombre = nombre, ficha = num3, prioridad = tipo });
                        int Pl = dtgvPlataforma.Rows.Add();
                        dtgvPlataforma.Rows[Pl].Cells[0].Value = nombre;
                        dtgvPlataforma.Rows[Pl].Cells[1].Value = num3;
                        dtgvPlataforma.Rows[Pl].Cells[2].Value = tipo;
                        num3++;
                        break;
                    case 3:
                        tipo = "Tramite Unico";
                        objCola.ColaTramiteUnico.Enqueue(new Cliente { nombre = nombre, ficha = num4, prioridad = tipo });
                        int TU = dtgvTramiteUnico.Rows.Add();
                        dtgvTramiteUnico.Rows[TU].Cells[0].Value = nombre;
                        dtgvTramiteUnico.Rows[TU].Cells[1].Value = num4;
                        dtgvTramiteUnico.Rows[TU].Cells[2].Value = tipo;
                        num4++;
                        break;
                }
            }
        }

        private void btnCaja1_Click(object sender, EventArgs e)
        {
            //Caja de propocito preferencial con un orden lineal
            if (objCola.ColaCiudadanoOro.Count > 0)
            {
                object valorNombre = dtgvCiudadanoOro.Rows[0].Cells["NombreCO"].Value;
                object valorFicha = dtgvCiudadanoOro.Rows[0].Cells["FichaCO"].Value;
                object valorTramite = dtgvCiudadanoOro.Rows[0].Cells["TramiteCO"].Value;
                lblCaja1.Text = "Ficha : " + valorFicha.ToString() + " Nombre : " + valorNombre.ToString() + " " + valorTramite;
                objCola.ColaCiudadanoOro.Dequeue();
                dtgvCiudadanoOro.Rows.RemoveAt(0);
            }
            else if (objCola.ColaCreditosBancarios.Count > 0)
            {
                object valorNombre = dtgvCreditoBancario.Rows[0].Cells["NombreCB"].Value;
                object valorFicha = dtgvCreditoBancario.Rows[0].Cells["FichaCB"].Value;
                object valorTramite = dtgvCreditoBancario.Rows[0].Cells["TramiteCB"].Value;
                lblCaja1.Text = "Ficha : " + valorFicha.ToString() + " Nombre : " + valorNombre.ToString() + " " + valorTramite;
                dtgvCreditoBancario.Rows.RemoveAt(0);
                objCola.ColaCreditosBancarios.Dequeue();

            }
            else if (objCola.ColaPlataforma.Count > 0)
            {
                object valorNombre = dtgvPlataforma.Rows[0].Cells["NombrePL"].Value;
                object valorFicha = dtgvPlataforma.Rows[0].Cells["FichaPL"].Value;
                object valorTramite = dtgvPlataforma.Rows[0].Cells["TramitePL"].Value;
                lblCaja1.Text = "Ficha : " + valorFicha.ToString() + " Nombre : " + valorNombre.ToString() + " " + valorTramite;
                dtgvPlataforma.Rows.RemoveAt(0);
                objCola.ColaPlataforma.Dequeue();

            }
            else if (objCola.ColaTramiteUnico.Count > 0)
            {
                object valorNombre = dtgvTramiteUnico.Rows[0].Cells["NombreTU"].Value;
                object valorFicha = dtgvTramiteUnico.Rows[0].Cells["FichaTU"].Value;
                object valorTramite = dtgvTramiteUnico.Rows[0].Cells["TramiteTU"].Value;
                lblCaja1.Text = "Ficha : " + valorFicha.ToString() + " Nombre : " + valorNombre.ToString() + " " + valorTramite;
                dtgvTramiteUnico.Rows.RemoveAt(0);
                objCola.ColaTramiteUnico.Dequeue();

            }
            else
            {
                MessageBox.Show("No hay clientes que atender, agrega algunos para realizar esta acción");
            }
        }

        private void btnCaja2_Click(object sender, EventArgs e)
        {
            //Caja de propocito preferencial
            //Pero que al acabar los ciudadanos de oro atenderá aleatoriamente cualquier fila
            int n = NumRan.Next(3);
            if (objCola.ColaCiudadanoOro.Count > 0)
            {
                object valorNombre = dtgvCiudadanoOro.Rows[0].Cells["NombreCO"].Value;
                object valorFicha = dtgvCiudadanoOro.Rows[0].Cells["FichaCO"].Value;
                object valorTramite = dtgvCiudadanoOro.Rows[0].Cells["TramiteCO"].Value;
                lblCaja2.Text = "Ficha : " + valorFicha.ToString() + " Nombre : " + valorNombre.ToString() + " " + valorTramite;
                dtgvCiudadanoOro.Rows.RemoveAt(0);
                objCola.ColaCiudadanoOro.Dequeue();
            }
            else
            {
                switch (n)
                {
                    //case que borra los elementos de la cola de Creditos Bancarios
                    case 0:
                        if (objCola.ColaCreditosBancarios.Count > 0)
                        {
                            object valorNombre = dtgvCreditoBancario.Rows[0].Cells["NombreCB"].Value;
                            object valorFicha = dtgvCreditoBancario.Rows[0].Cells["FichaCB"].Value;
                            object valorTramite = dtgvCreditoBancario.Rows[0].Cells["TramiteCB"].Value;
                            lblCaja2.Text = "Ficha : " + valorFicha.ToString() + " Nombre : " + valorNombre.ToString() + " " + valorTramite;
                            dtgvCreditoBancario.Rows.RemoveAt(0);
                            objCola.ColaCreditosBancarios.Dequeue();
                        }
                        else if (objCola.ColaPlataforma.Count > 0)
                        {
                            object valorNombre = dtgvPlataforma.Rows[0].Cells["NombrePL"].Value;
                            object valorFicha = dtgvPlataforma.Rows[0].Cells["FichaPL"].Value;
                            object valorTramite = dtgvPlataforma.Rows[0].Cells["TramitePL"].Value;
                            lblCaja2.Text = "Ficha : " + valorFicha.ToString() + " Nombre : " + valorNombre.ToString() + " " + valorTramite;
                            dtgvPlataforma.Rows.RemoveAt(0);
                            objCola.ColaPlataforma.Dequeue();
                        }
                        else if (objCola.ColaTramiteUnico.Count > 0)
                        {
                            object valorNombre = dtgvTramiteUnico.Rows[0].Cells["NombreTU"].Value;
                            object valorFicha = dtgvTramiteUnico.Rows[0].Cells["FichaTU"].Value;
                            object valorTramite = dtgvTramiteUnico.Rows[0].Cells["TramiteTU"].Value;
                            lblCaja2.Text = "Ficha : " + valorFicha.ToString() + " Nombre : " + valorNombre.ToString() + " " + valorTramite;
                            dtgvTramiteUnico.Rows.RemoveAt(0);
                            objCola.ColaTramiteUnico.Dequeue();
                        }
                        else
                        {
                            MessageBox.Show("No hay clientes que atender, agrega algunos para realizar esta acción");
                        }
                        break;
                    //case que borra los elementos de la cola de Plataforma
                    case 1:

                        if (objCola.ColaPlataforma.Count > 0)
                        {
                            object valorNombre = dtgvPlataforma.Rows[0].Cells["NombrePL"].Value;
                            object valorFicha = dtgvPlataforma.Rows[0].Cells["FichaPL"].Value;
                            object valorTramite = dtgvPlataforma.Rows[0].Cells["TramitePL"].Value;
                            lblCaja2.Text = "Ficha : " + valorFicha.ToString() + " Nombre : " + valorNombre.ToString() + " " + valorTramite;
                            dtgvPlataforma.Rows.RemoveAt(0);
                            objCola.ColaPlataforma.Dequeue();
                        }
                        else if (objCola.ColaCreditosBancarios.Count > 0)
                        {
                            object valorNombre = dtgvCreditoBancario.Rows[0].Cells["NombreCB"].Value;
                            object valorFicha = dtgvCreditoBancario.Rows[0].Cells["FichaCB"].Value;
                            object valorTramite = dtgvCreditoBancario.Rows[0].Cells["TramiteCB"].Value;
                            lblCaja2.Text = "Ficha : " + valorFicha.ToString() + " Nombre : " + valorNombre.ToString() + " " + valorTramite;
                            dtgvCreditoBancario.Rows.RemoveAt(0);
                            objCola.ColaCreditosBancarios.Dequeue();
                        }
                        else if (objCola.ColaTramiteUnico.Count > 0)
                        {
                            object valorNombre = dtgvTramiteUnico.Rows[0].Cells["NombreTU"].Value;
                            object valorFicha = dtgvTramiteUnico.Rows[0].Cells["FichaTU"].Value;
                            object valorTramite = dtgvTramiteUnico.Rows[0].Cells["TramiteTU"].Value;
                            lblCaja2.Text = "Ficha : " + valorFicha.ToString() + " Nombre : " + valorNombre.ToString() + " " + valorTramite;
                            dtgvTramiteUnico.Rows.RemoveAt(0);
                            objCola.ColaTramiteUnico.Dequeue();
                        }
                        else
                        {
                            MessageBox.Show("No hay clientes que atender, agrega algunos para realizar esta acción");
                        }

                        break;
                    //case que borra los elementos de la cola Tramite unico
                    case 2:

                        if (objCola.ColaTramiteUnico.Count > 0)
                        {
                            object valorNombre = dtgvTramiteUnico.Rows[0].Cells["NombreTU"].Value;
                            object valorFicha = dtgvTramiteUnico.Rows[0].Cells["FichaTU"].Value;
                            object valorTramite = dtgvTramiteUnico.Rows[0].Cells["TramiteTU"].Value;
                            lblCaja2.Text = "Ficha : " + valorFicha.ToString() + " Nombre : " + valorNombre.ToString() + " " + valorTramite;
                            dtgvTramiteUnico.Rows.RemoveAt(0);
                            objCola.ColaTramiteUnico.Dequeue();
                        }
                        else if (objCola.ColaCreditosBancarios.Count > 0)
                        {
                            object valorNombre = dtgvCreditoBancario.Rows[0].Cells["NombreCB"].Value;
                            object valorFicha = dtgvCreditoBancario.Rows[0].Cells["FichaCB"].Value;
                            object valorTramite = dtgvCreditoBancario.Rows[0].Cells["TramiteCB"].Value;
                            lblCaja2.Text = "Ficha : " + valorFicha.ToString() + " Nombre : " + valorNombre.ToString() + " " + valorTramite;
                            dtgvCreditoBancario.Rows.RemoveAt(0);
                            objCola.ColaCreditosBancarios.Dequeue();
                        }
                        else if (objCola.ColaPlataforma.Count > 0)
                        {
                            object valorNombre = dtgvPlataforma.Rows[0].Cells["NombrePL"].Value;
                            object valorFicha = dtgvPlataforma.Rows[0].Cells["FichaPL"].Value;
                            object valorTramite = dtgvPlataforma.Rows[0].Cells["TramitePL"].Value;
                            lblCaja2.Text = "Ficha : " + valorFicha.ToString() + " Nombre : " + valorNombre.ToString() + " " + valorTramite;
                            dtgvPlataforma.Rows.RemoveAt(0);
                            objCola.ColaPlataforma.Dequeue();
                        }
                        else
                        {
                            MessageBox.Show("No hay clientes que atender, agrega algunos para realizar esta acción");
                        }

                        break;
                }
            }
        }


        private void btnCaja3_Click(object sender, EventArgs e)
        {
            //Caja de propocito general estará elegiendo a cualquier cola
            int n = NumRan.Next(4);

            switch (n)
            {
                //case que borra los elementos de la cola de Creditos Bancarios
                case 0:
                    if (objCola.ColaCreditosBancarios.Count > 0)
                    {
                        object valorNombre = dtgvCreditoBancario.Rows[0].Cells["NombreCB"].Value;
                        object valorFicha = dtgvCreditoBancario.Rows[0].Cells["FichaCB"].Value;
                        object valorTramite = dtgvCreditoBancario.Rows[0].Cells["TramiteCB"].Value;
                        lblCaja3.Text = "Ficha : " + valorFicha.ToString() + " Nombre : " + valorNombre.ToString() + " " + valorTramite;
                        dtgvCreditoBancario.Rows.RemoveAt(0);
                        objCola.ColaCreditosBancarios.Dequeue();
                    }
                    else if (objCola.ColaCiudadanoOro.Count > 0)
                    {
                        object valorNombre = dtgvCiudadanoOro.Rows[0].Cells["NombreCO"].Value;
                        object valorFicha = dtgvCiudadanoOro.Rows[0].Cells["FichaCO"].Value;
                        object valorTramite = dtgvCiudadanoOro.Rows[0].Cells["TramiteCO"].Value;
                        lblCaja3.Text = "Ficha : " + valorFicha.ToString() + " Nombre : " + valorNombre.ToString() + " " + valorTramite;
                        dtgvCiudadanoOro.Rows.RemoveAt(0);
                        objCola.ColaCiudadanoOro.Dequeue();
                    }
                    else if (objCola.ColaPlataforma.Count > 0)
                    {
                        object valorNombre = dtgvPlataforma.Rows[0].Cells["NombrePL"].Value;
                        object valorFicha = dtgvPlataforma.Rows[0].Cells["FichaPL"].Value;
                        object valorTramite = dtgvPlataforma.Rows[0].Cells["TramitePL"].Value;
                        lblCaja3.Text = "Ficha : " + valorFicha.ToString() + " Nombre : " + valorNombre.ToString() + " " + valorTramite;
                        dtgvPlataforma.Rows.RemoveAt(0);
                        objCola.ColaPlataforma.Dequeue();
                    }
                    else if (objCola.ColaTramiteUnico.Count > 0)
                    {
                        object valorNombre = dtgvTramiteUnico.Rows[0].Cells["NombreTU"].Value;
                        object valorFicha = dtgvTramiteUnico.Rows[0].Cells["FichaTU"].Value;
                        object valorTramite = dtgvTramiteUnico.Rows[0].Cells["TramiteTU"].Value;
                        lblCaja3.Text = "Ficha : " + valorFicha.ToString() + " Nombre : " + valorNombre.ToString() + " " + valorTramite;
                        dtgvTramiteUnico.Rows.RemoveAt(0);
                        objCola.ColaTramiteUnico.Dequeue();
                    }
                    else
                    {
                        MessageBox.Show("No hay clientes que atender, agrega algunos para realizar esta acción");
                    }
                    break;
                //case que borra los elementos de la cola de Plataforma
                case 1:
                    if (objCola.ColaPlataforma.Count > 0)
                    {
                        object valorNombre = dtgvPlataforma.Rows[0].Cells["NombrePL"].Value;
                        object valorFicha = dtgvPlataforma.Rows[0].Cells["FichaPL"].Value;
                        object valorTramite = dtgvPlataforma.Rows[0].Cells["TramitePL"].Value;
                        lblCaja3.Text = "Ficha : " + valorFicha.ToString() + " Nombre : " + valorNombre.ToString() + " " + valorTramite;
                        dtgvPlataforma.Rows.RemoveAt(0);
                        objCola.ColaPlataforma.Dequeue();
                    }
                    else if (objCola.ColaCreditosBancarios.Count > 0)
                    {
                        object valorNombre = dtgvCreditoBancario.Rows[0].Cells["NombreCB"].Value;
                        object valorFicha = dtgvCreditoBancario.Rows[0].Cells["FichaCB"].Value;
                        object valorTramite = dtgvCreditoBancario.Rows[0].Cells["TramiteCB"].Value;
                        lblCaja3.Text = "Ficha : " + valorFicha.ToString() + " Nombre : " + valorNombre.ToString() + " " + valorTramite;
                        dtgvCreditoBancario.Rows.RemoveAt(0);
                        objCola.ColaCreditosBancarios.Dequeue();
                    }
                    else if (objCola.ColaTramiteUnico.Count > 0)
                    {
                        object valorNombre = dtgvTramiteUnico.Rows[0].Cells["NombreTU"].Value;
                        object valorFicha = dtgvTramiteUnico.Rows[0].Cells["FichaTU"].Value;
                        object valorTramite = dtgvTramiteUnico.Rows[0].Cells["TramiteTU"].Value;
                        lblCaja3.Text = "Ficha : " + valorFicha.ToString() + " Nombre : " + valorNombre.ToString() + " " + valorTramite;
                        dtgvTramiteUnico.Rows.RemoveAt(0);
                        objCola.ColaTramiteUnico.Dequeue();
                    }
                    else if (objCola.ColaCiudadanoOro.Count > 0)
                    {
                        object valorNombre = dtgvCiudadanoOro.Rows[0].Cells["NombreCO"].Value;
                        object valorFicha = dtgvCiudadanoOro.Rows[0].Cells["FichaCO"].Value;
                        object valorTramite = dtgvCiudadanoOro.Rows[0].Cells["TramiteCO"].Value;
                        lblCaja3.Text = "Ficha : " + valorFicha.ToString() + " Nombre : " + valorNombre.ToString() + " " + valorTramite;
                        dtgvCiudadanoOro.Rows.RemoveAt(0);
                        objCola.ColaCiudadanoOro.Dequeue();
                    }
                    else
                    {
                        MessageBox.Show("No hay clientes que atender, agrega algunos para realizar esta acción");
                    }

                    break;
                //case que borra los elementos de la cola Tramite unico
                case 2:
                    if (objCola.ColaCiudadanoOro.Count > 0)
                    {
                        object valorNombre = dtgvCiudadanoOro.Rows[0].Cells["NombreCO"].Value;
                        object valorFicha = dtgvCiudadanoOro.Rows[0].Cells["FichaCO"].Value;
                        object valorTramite = dtgvCiudadanoOro.Rows[0].Cells["TramiteCO"].Value;
                        lblCaja3.Text = "Ficha : " + valorFicha.ToString() + " Nombre : " + valorNombre.ToString() + " " + valorTramite;
                        dtgvCiudadanoOro.Rows.RemoveAt(0);
                        objCola.ColaCiudadanoOro.Dequeue();
                    }
                    else if (objCola.ColaTramiteUnico.Count > 0)
                    {

                        object valorNombre = dtgvTramiteUnico.Rows[0].Cells["NombreTU"].Value;
                        object valorFicha = dtgvTramiteUnico.Rows[0].Cells["FichaTU"].Value;
                        object valorTramite = dtgvTramiteUnico.Rows[0].Cells["TramiteTU"].Value;
                        lblCaja3.Text = "Ficha : " + valorFicha.ToString() + " Nombre : " + valorNombre.ToString() + " " + valorTramite;
                        dtgvTramiteUnico.Rows.RemoveAt(0);
                        objCola.ColaTramiteUnico.Dequeue();
                    }
                    else if (objCola.ColaCreditosBancarios.Count > 0)
                    {
                        object valorNombre = dtgvCreditoBancario.Rows[0].Cells["NombreCB"].Value;
                        object valorFicha = dtgvCreditoBancario.Rows[0].Cells["FichaCB"].Value;
                        object valorTramite = dtgvCreditoBancario.Rows[0].Cells["TramiteCB"].Value;
                        lblCaja2.Text = "Ficha : " + valorFicha.ToString() + " Nombre : " + valorNombre.ToString() + " " + valorTramite;
                        dtgvCreditoBancario.Rows.RemoveAt(0);
                        objCola.ColaCreditosBancarios.Dequeue();
                    }
                    else if (objCola.ColaPlataforma.Count > 0)
                    {
                        object valorNombre = dtgvPlataforma.Rows[0].Cells["NombrePL"].Value;
                        object valorFicha = dtgvPlataforma.Rows[0].Cells["FichaPL"].Value;
                        object valorTramite = dtgvPlataforma.Rows[0].Cells["TramitePL"].Value;
                        lblCaja3.Text = "Ficha : " + valorFicha.ToString() + " Nombre : " + valorNombre.ToString() + " " + valorTramite;
                        dtgvPlataforma.Rows.RemoveAt(0);
                        objCola.ColaPlataforma.Dequeue();
                    }
                    else
                    {
                        MessageBox.Show("No hay clientes que atender, agrega algunos para realizar esta acción");
                    }

                    break;
                case 3:
                    if (objCola.ColaCiudadanoOro.Count > 0)
                    {
                        object valorNombre = dtgvCiudadanoOro.Rows[0].Cells["NombreCO"].Value;
                        object valorFicha = dtgvCiudadanoOro.Rows[0].Cells["FichaCO"].Value;
                        object valorTramite = dtgvCiudadanoOro.Rows[0].Cells["TramiteCO"].Value;
                        lblCaja3.Text = "Ficha : " + valorFicha.ToString() + " Nombre : " + valorNombre.ToString() + " " + valorTramite;
                        dtgvCiudadanoOro.Rows.RemoveAt(0);
                        objCola.ColaCiudadanoOro.Dequeue();
                    }
                    else if (objCola.ColaTramiteUnico.Count > 0)
                    {
                        object valorNombre = dtgvTramiteUnico.Rows[0].Cells["NombreTU"].Value;
                        object valorFicha = dtgvTramiteUnico.Rows[0].Cells["FichaTU"].Value;
                        object valorTramite = dtgvTramiteUnico.Rows[0].Cells["TramiteTU"].Value;
                        lblCaja3.Text = "Ficha : " + valorFicha.ToString() + " Nombre : " + valorNombre.ToString() + " " + valorTramite;
                        dtgvTramiteUnico.Rows.RemoveAt(0);
                        objCola.ColaTramiteUnico.Dequeue();
                    }
                    else if (objCola.ColaPlataforma.Count > 0)
                    {
                        object valorNombre = dtgvPlataforma.Rows[0].Cells["NombrePL"].Value;
                        object valorFicha = dtgvPlataforma.Rows[0].Cells["FichaPL"].Value;
                        object valorTramite = dtgvPlataforma.Rows[0].Cells["TramitePL"].Value;
                        lblCaja3.Text = "Ficha : " + valorFicha.ToString() + " Nombre : " + valorNombre.ToString() + " " + valorTramite;
                        dtgvPlataforma.Rows.RemoveAt(0);
                        objCola.ColaPlataforma.Dequeue();
                    }
                    else if (objCola.ColaCreditosBancarios.Count > 0)
                    {
                        object valorNombre = dtgvCreditoBancario.Rows[0].Cells["NombreCB"].Value;
                        object valorFicha = dtgvCreditoBancario.Rows[0].Cells["FichaCB"].Value;
                        object valorTramite = dtgvCreditoBancario.Rows[0].Cells["TramiteCB"].Value;
                        lblCaja3.Text = "Ficha : " + valorFicha.ToString() + " Nombre : " + valorNombre.ToString() + " " + valorTramite;
                        dtgvCreditoBancario.Rows.RemoveAt(0);
                        objCola.ColaCreditosBancarios.Dequeue();
                    }
                    else
                    {
                        MessageBox.Show("No hay clientes que atender, agrega algunos para realizar esta acción");
                    }
                    break;
            }
        }
    }
}
