using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PulsacionGUI
{
    public partial class ConsultaPersonaFrm : Form
    {
        PersonaService personaService;
        public ConsultaPersonaFrm()
        {
            InitializeComponent();
            personaService = new PersonaService();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            if (CmbFiltro.Text=="Todos")
            {
                DtgPersona.DataSource = null;
                RespuestaConsulta respuesta = new RespuestaConsulta();
                respuesta = personaService.Consultar();
                DtgPersona.DataSource = respuesta.Personas;
                TxtTotal.Text = personaService.TotalPersonas().ToString();
                TxtTotalMujeres.Text = personaService.TotalporTipo("F").ToString();
                txtTotalHombres.Text = personaService.TotalporTipo("M").ToString();
            }
            else if (CmbFiltro.Text == "F")
            {
                DtgPersona.DataSource = null;
                RespuestaListaTipo respuesta = new RespuestaListaTipo();
                respuesta = personaService.ListarPorTipo("F");
                DtgPersona.DataSource = respuesta.Personas;
                TxtTotal.Text = "";
                TxtTotalMujeres.Text = personaService.TotalporTipo("F").ToString();
                txtTotalHombres.Text = "";
            }
            else if (CmbFiltro.Text == "M")
            {
                DtgPersona.DataSource = null;
                RespuestaListaTipo respuesta = new RespuestaListaTipo();
                respuesta = personaService.ListarPorTipo("M");
                DtgPersona.DataSource = respuesta.Personas;
                TxtTotal.Text = "";
                TxtTotalMujeres.Text = "";
                txtTotalHombres.Text = personaService.TotalporTipo("M").ToString();
            }

            
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            string identificacion = TxtFiltro.Text;
            if (TxtFiltro.Text!="")
            {
                DtgPersona.DataSource = personaService.BuscarContiene(identificacion);
            }
        }

        private void TxtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void a(object sender, EventArgs e)
        {

        }
    }
}
