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
            ENUsuario en = new ENUsuario(nifTextBox.Text, nombreTextBox.Text, Int32.Parse(edadTextBox.Text));
            if (en.readUsuario())
                Label1.Text = "Success";
            else
                Label1.Text = "Failed";
        }

        protected void ReadFirst(object sender, EventArgs e)
        {
            ENUsuario en = new ENUsuario(nifTextBox.Text, nombreTextBox.Text, Int32.Parse(edadTextBox.Text));
            if (en.readFirstUsuario())
                Label1.Text = "Success";
            else
                Label1.Text = "Failed";
        }

        protected void ReadPrevious(object sender, EventArgs e)
        {
            ENUsuario en = new ENUsuario(nifTextBox.Text, nombreTextBox.Text, Int32.Parse(edadTextBox.Text));
            if (en.readPrevUsuario())
                Label1.Text = "Success";
            else
                Label1.Text = "Failed";
        }

        protected void ReadNext(object sender, EventArgs e)
        {
            ENUsuario en = new ENUsuario(nifTextBox.Text, nombreTextBox.Text, Int32.Parse(edadTextBox.Text));
            if (en.readNextUsuario())
                Label1.Text = "Success";
            else
                Label1.Text = "Failed";
        }
        protected void Create(object sender, EventArgs e)
        {
            ENUsuario en = new ENUsuario(nifTextBox.Text, nombreTextBox.Text, Int32.Parse(edadTextBox.Text));
            if (en.createUsuario())
                Label1.Text = "Success";
            else
                Label1.Text = "Failed";
        }

        protected void Update(object sender, EventArgs e)
        {

        }

        protected void Delete(object sender, EventArgs e)
        {

        }
    }
}