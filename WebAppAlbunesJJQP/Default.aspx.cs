using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Agente;
using Newtonsoft.Json;
using WebAppAlbunesJJQP.Models;


namespace WebAppAlbunesJJQP
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                try
                {
                    string Lista = AgenteAlbum.fn_listaAlbum_Consultar();
                    List<album> album = JsonConvert.DeserializeObject<List<album>>(Lista);
                    ddlalbunes.DataSource = album;
                    ddlalbunes.DataBind();
                }
                catch (Exception ex)
                {

                    ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), new Guid().ToString(), "alert('se producjo el error:  " + ex.Message + "') ;", true);

                }

            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                string seleccion = ddlalbunes.SelectedItem.Value;
                string listaFotos = AgenteAlbum.fn_listaFotos_Consultar();
                List<foto> fotos = JsonConvert.DeserializeObject<List<foto>>(listaFotos);
                List<foto> fotosfiltrada = fotos.Where(f => f.albumId == Convert.ToInt32(seleccion)).ToList();

                gvwFotos.DataSource = fotosfiltrada;
                gvwFotos.DataBind();
            }
            catch (Exception ex)
            {

                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), new Guid().ToString(), "alert('se producjo el error:  " + ex.Message + "') ;", true);
            }
        }

        protected void gvwFotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string seleccion = gvwFotos.SelectedRow.Cells[0].Text;
                string listacomentarios = AgenteAlbum.fn_listaComentario_Consultar();
                List<Comentario> comment = JsonConvert.DeserializeObject<List<Comentario>>(listacomentarios);
                List<Comentario>commentfiltrada = comment.Where(f => f.postId == Convert.ToInt32(seleccion)).ToList();
                gvwcomentarios.DataSource=commentfiltrada;
                gvwcomentarios.DataBind();
            }
            catch (Exception ex)
            {

                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), new Guid().ToString(), "alert('se producjo el error:  " + ex.Message + "') ;", true);
            }
        }
    }
}