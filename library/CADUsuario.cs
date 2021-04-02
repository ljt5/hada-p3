using System;
using System.Configuration;
using System.Data.SqlClient;

namespace library
{
    public class CADUsuario
    {
        private string constring;

        public CADUsuario()
        {
            constring = ConfigurationManager.ConnectionStrings["miconexion"].ToString();
        }
        public bool createUsuario(ENUsuario en)
        {
            bool ret = true;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("INSERT INTO Usuarios (nif, nombre, edad) " +
                    "VALUES ('" + en.nifUsuario + "', '" + en.nombreUsuario + "', '" + en.edadUsuario + "')", c);
                com.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                ret = false;
            }
            finally
            {
                c.Close();
            }

            return ret;
        }
        public bool readUsuario(ENUsuario en)
        {
            bool ret = true;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Select * from Usuarios " +
                    "where nif='" + en.nifUsuario +
                    "' and nombre='" + en.nombreUsuario +
                    "' and edad='" + en.edadUsuario + "'", c);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    ret = true;
                }
                else
                {
                    ret = false;
                    Console.WriteLine("User operation has failed. No hay un usuario con los campos indicados.");
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                ret = false;
            }
            finally
            {
                c.Close();
            }

            return ret;
        }
        public bool readFirstUsuario(ENUsuario en)
        {
            bool ret = true;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Select * from Usuarios", c);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    ret = true;
                    en.nifUsuario = dr["nif"].ToString();
                    en.nombreUsuario = dr["nombre"].ToString();
                    en.edadUsuario = Int32.Parse(dr["edad"].ToString());
                }
                else
                {
                    ret = false;
                    Console.WriteLine("User operation has failed. No hay usuarios.");
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                ret = false;
            }
            finally
            {
                c.Close();
            }

            return ret;
        }
        public bool readNextUsuario(ENUsuario en)
        {
            bool ret = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Select * from Usuarios", c);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    if (en.nifUsuario == dr["nif"].ToString() &&
                        en.nombreUsuario == dr["nombre"].ToString() &&
                        en.edadUsuario == Int32.Parse(dr["edad"].ToString()))
                    {
                        if (dr.Read())
                        {
                            ret = true;
                            en.nifUsuario = dr["nif"].ToString();
                            en.nombreUsuario = dr["nombre"].ToString();
                            en.edadUsuario = Int32.Parse(dr["edad"].ToString());
                        }
                        else
                        {
                            Console.WriteLine("User operation failed. No hay usuarios después del indicado.");
                        }
                        break;
                    }
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                ret = false;
            }
            finally
            {
                c.Close();
            }

            return ret;
        }
        public bool readPrevUsuario(ENUsuario en)
        {
            bool ret = false;
            SqlConnection c = new SqlConnection(constring);
            ENUsuario prevUser = null;
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Select * from Usuarios", c);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    if (en.nifUsuario == dr["nif"].ToString() &&
                        en.nombreUsuario == dr["nombre"].ToString() &&
                        en.edadUsuario == Int32.Parse(dr["edad"].ToString()))
                    {
                        if (prevUser == null)
                        {
                            Console.WriteLine("User operation has failed. No hay usuarios antes del indicado.");
                        }
                        else
                        {
                            ret = true;
                            en.nifUsuario = dr["nif"].ToString();
                            en.nombreUsuario = dr["nombre"].ToString();
                            en.edadUsuario = Int32.Parse(dr["edad"].ToString());
                        }
                        break;
                    }
                    else
                    {
                        prevUser = new ENUsuario(dr["nif"].ToString(), dr["nombre"].ToString(), Int32.Parse(dr["edad"].ToString()));
                    }
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                ret = false;
            }
            finally
            {
                c.Close();
            }

            return ret;
        }
        public bool updateUsuario(ENUsuario en)
        {
            return false;
        }
        public bool deleteUsuario(ENUsuario en)
        {
            return false;
        }
    }
}
