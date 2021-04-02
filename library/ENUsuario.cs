namespace library
{
    public class ENUsuario
    {
        private string nif;
        private string nombre;
        private int edad;
        public string nifUsuario
        {
            get => nif;
            set => nif = value;
        }
        public string nombreUsuario
        {
            get => nombre;
            set => nombre = value;
        }
        public int edadUsuario
        {
            get => edad;
            set => edad = value;
        }

        public ENUsuario()
        {
        }
        public ENUsuario(string nif, string nombre, int edad)
        {
            this.nif = nif;
            this.nombre = nombre;
            this.edad = edad;
        }
        public bool createUsuario()
        {
            CADUsuario cad = new CADUsuario();
            return cad.createUsuario(this);
        }
        public bool readUsuario()
        {
            CADUsuario cad = new CADUsuario();
            return cad.readUsuario(this);
        }
        public bool readFirstUsuario()
        {
            CADUsuario cad = new CADUsuario();
            return cad.readFirstUsuario(this);
        }
        public bool readNextUsuario()
        {
            CADUsuario cad = new CADUsuario();
            return cad.readNextUsuario(this);
        }
        public bool readPrevUsuario()
        {
            CADUsuario cad = new CADUsuario();
            return cad.readPrevUsuario(this);
        }
        public bool updateUsuario()
        {
            CADUsuario cad = new CADUsuario();
            return cad.updateUsuario(this);
        }
        public bool deleteUsuario()
        {
            CADUsuario cad = new CADUsuario();
            return cad.deleteUsuario(this);
        }
    }
}
