
using conectandoMysql;
using MySql.Data.MySqlClient;
using MySqlConnector;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Reflection.PortableExecutable;


//conexao.OpenBD();
//MySqlCommand myCommand = new MySqlCommand(consulta, conexao.GetConnection());
//MySqlDataReader reader = myCommand.ExecuteReader();
//myCommand.CommandText = consulta;
//Console.WriteLine(reader);
//var executa = myCommand.ExecuteNonQuery();
//Debug.WriteLine(executa);
//conexao.CloseBD();
//Console.ReadKey();


BancoContext conexao = new BancoContext();
var consulta = "select * from tbcliente";
MySqlCommand myCommand = new MySqlCommand(consulta, conexao.GetConnection());
MySqlDataReader reader = myCommand.ExecuteReader();

while (reader.Read())
{
    string id = reader.GetString(0);
    string nome = reader.GetString(1);
    Console.WriteLine("ID: {0}, Nome: {1}", id, nome);
}

conexao.CloseBD();
Console.ReadKey();





//var command = new MySqlCommand(consulta, conexao.GetConnection());



