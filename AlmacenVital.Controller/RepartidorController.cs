using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Almacen.Model;
namespace Almacen.Controller
{
    public class RepartidorController
    {
        private DataBase database = new DataBase();
        public int AgregarRepartidor(Repartidor repartidor)
        {
            string query = @"INSERT INTO Repartidores 
                (Nombre, Apellido, Email, Celular, Localidad, TipoDeVehiculo) 
                VALUES (@Nombre, @Apellido, @Email, @Celular, @Localidad, @TipoDeVehiculo)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Nombre", repartidor.Nombre),
                new SqlParameter("@Apellido", repartidor.Apellido),
                new SqlParameter("@Email", repartidor.Email),
                new SqlParameter("@Celular", repartidor.Celular),
                new SqlParameter("@Localidad", repartidor.Localidad),
                new SqlParameter("@TipoDeVehiculo", repartidor.TipoDeVehiculo)
            };

            return database.ExecuteNonQuery(query, parameters);
        }

        public int ModificarRepartidor(Repartidor repartidor)
        {
            string query = @"UPDATE Repartidores SET 
                Nombre = @Nombre, 
                Apellido = @Apellido, 
                Email = @Email, 
                Celular = @Celular, 
                Localidad = @Localidad, 
                TipoDeVehiculo = @TipoDeVehiculo 
                WHERE PersonaID = @ID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ID", repartidor.ID),
                new SqlParameter("@Nombre", repartidor.Nombre),
                new SqlParameter("@Apellido", repartidor.Apellido),
                new SqlParameter("@Email", repartidor.Email),
                new SqlParameter("@Celular", repartidor.Celular),
                new SqlParameter("@Localidad", repartidor.Localidad),
                new SqlParameter("@TipoDeVehiculo", repartidor.TipoDeVehiculo)
            };
            return database.ExecuteNonQuery(query, parameters);
        }

        public int EliminarRepartidor(int id)
        {
            string query = "DELETE FROM Repartidores WHERE PersonaID = @ID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ID", id)
            };
            return database.ExecuteNonQuery(query, parameters);
        }

        public DataTable ObtenerRepartidores()
        {
            string query = "SELECT PersonaID, Nombre, Apellido, Email, Celular, Localidad, TipoDeVehiculo FROM Repartidores";
            return database.Select(query);
        }
    }
}
