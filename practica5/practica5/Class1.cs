using System;
using MySql.Data.MySqlClient;
namespace practica55
{
/// <summary>
/// Description of MySQL.
/// </summary>
public class MySQL
{
protected MySqlConnection myConnection;
public MySQL()
{
}
protected void abrirConexion(){
string connectionString =
"Server=localhost;" +
"Database=agenda;" +
"User ID=root;" +
"Password=pepe;" +
"Pooling=false;";
this.myConnection = new MySqlConnection(connectionString);
this.myConnection.Open();
}
protected void cerrarConexion(){
this.myConnection.Close();
this.myConnection = null;
}
}
}
