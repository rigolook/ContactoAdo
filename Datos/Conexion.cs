using System.Data.SqlClient;
namespace ContactoAdo.Datos
{
    public class Conexion
    {
        private string cadenaSql=string.Empty;
        public Conexion()
        {
            var builder= new ConfigurationBuilder().SetBasePath(
            Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json").Build();
            cadenaSql = builder.GetSection("ConnectionStrings:cadenaSql").Value;

        }
        public string getCadenaSql()
        {
            return cadenaSql;
        }
    }
}
