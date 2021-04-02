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
                    "where nif='" + en.nifUsuario + "'", c);
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
                    if (en.nifUsuario == dr["nif"].ToString())
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
                    if (en.nifUsuario == dr["nif"].ToString())
                    {
                        if (prevUser == null)
                        {
                            Console.WriteLine("User operation has failed. No hay usuarios antes del indicado.");
                        }
                        else
                        {
                            ret = true;
                            en.nifUsuario = prevUser.nifUsuario;
                            en.nombreUsuario = prevUser.nombreUsuario;
                            en.edadUsuario = prevUser.edadUsuario;
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
            bool ret = true;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Update Usuarios set " +
                    "nombre='" + en.nombreUsuario + "', " +
                    "edad='" + en.edadUsuario + "' " +
                    "where nif='" + en.nifUsuario + "'", c);
                int affected = com.ExecuteNonQuery();
                if (affected == 0)
                {
                    ret = false;
                    Console.WriteLine("User operation has failed. No hay usuarios con el nif indicado para actualizar.");
                }
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
        public bool deleteUsuario(ENUsuario en)
        {
            bool ret = true;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("DELETE FROM Usuarios WHERE " +
                    "nif='" + en.nifUsuario + "' ", c);
                int affected = com.ExecuteNonQuery();
                if (affected == 0)
                {
                    ret = false;
                    Console.WriteLine("User operation has failed. No hay usuarios con los datos indicados para actualizar.");
                }
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
    }
}
