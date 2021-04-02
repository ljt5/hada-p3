using library;
using System;

namespace usuWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Read(object sender, EventArgs e)
        {
            if (nifTextBox.Text == "")
            {
                Label1.Text = "Es necesario indicar un NIF";
                LabelUser.Text = "";
                return;
            }
            ENUsuario en = new ENUsuario();
            en.nifUsuario = nifTextBox.Text;
            if (en.readUsuario())
            {
                Label1.Text = "Success";
                LabelUser.Text = en.ToString();
            }
            else
            {
                Label1.Text = "Failed";
                LabelUser.Text = "";
            }
        }

        protected void ReadFirst(object sender, EventArgs e)
        {
            ENUsuario en = new ENUsuario();
            if (en.readFirstUsuario())
            {
                Label1.Text = "Success";
                LabelUser.Text = en.ToString();
            }
            else
            {
                Label1.Text = "Failed";
                LabelUser.Text = "";
            }
        }

        protected void ReadPrevious(object sender, EventArgs e)
        {
            if (nifTextBox.Text == "")
            {
                Label1.Text = "Es necesario indicar un NIF";
                LabelUser.Text = "";
                return;
            }
            ENUsuario en = new ENUsuario();
            en.nifUsuario = nifTextBox.Text;
            if (en.readPrevUsuario())
            {
                Label1.Text = "Success";
                LabelUser.Text = en.ToString();
            }
            else
            {
                Label1.Text = "Failed";
                LabelUser.Text = "";
            }
        }

        protected void ReadNext(object sender, EventArgs e)
        {
            if (nifTextBox.Text == "")
            {
                Label1.Text = "Es necesario indicar un NIF";
                LabelUser.Text = "";
                return;
            }
            ENUsuario en = new ENUsuario();
            en.nifUsuario = nifTextBox.Text; 
            if (en.readNextUsuario())
            {
                Label1.Text = "Success";
                LabelUser.Text = en.ToString();
            }
            else
            {
                Label1.Text = "Failed";
                LabelUser.Text = "";
            }
        }
        protected void Create(object sender, EventArgs e)
        {
            if (nifTextBox.Text == "" || nombreTextBox.Text == "" || edadTextBox.Text == "")
            {
                Label1.Text = "Es necesario rellenar todos los campos";
                LabelUser.Text = "";
                return;
            }
            ENUsuario en = new ENUsuario(nifTextBox.Text, nombreTextBox.Text, Int32.Parse(edadTextBox.Text));
            if (en.createUsuario())
            {
                Label1.Text = "Success";
                LabelUser.Text = "";
            }
            else
            {
                Label1.Text = "Failed";
                LabelUser.Text = "";
            }
        }

        protected void Update(object sender, EventArgs e)
        {
            if (nifTextBox.Text == "" || nombreTextBox.Text == "" || edadTextBox.Text == "")
            {
                Label1.Text = "Es necesario rellenar todos los campos";
                LabelUser.Text = "";
                return;
            }
            ENUsuario en = new ENUsuario(nifTextBox.Text, nombreTextBox.Text, Int32.Parse(edadTextBox.Text));
            if (en.updateUsuario())
            {
                Label1.Text = "Success";
                LabelUser.Text = "";
            }
            else
            {
                Label1.Text = "Failed";
                LabelUser.Text = "";
            }
        }

        protected void Delete(object sender, EventArgs e)
        {
            if (nifTextBox.Text == "")
            {
                Label1.Text = "Es necesario indicar un NIF";
                LabelUser.Text = "";
                return;
            }
            ENUsuario en = new ENUsuario();
            en.nifUsuario = nifTextBox.Text; 
            if (en.deleteUsuario())
            {
                Label1.Text = "Success";
                LabelUser.Text = "";
            }
            else
            {
                Label1.Text = "Failed";
                LabelUser.Text = "";
            }
        }
    }
}