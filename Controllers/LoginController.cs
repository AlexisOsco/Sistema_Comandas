using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using Sistema_Comandas.Models; // Asegúrate de que el modelo Usuario esté definido aquí

namespace Sistema_Comandas.Controllers
{
    public class LoginController : Controller
    {
        private readonly string _connectionString;

        // Constructor que obtiene la cadena de conexión desde appsettings.json
        public LoginController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        // Acción GET que devuelve la vista del formulario de login
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string usuario, string clave)
        {
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(clave))
            {
                // Si el usuario o la clave están vacíos, mostramos un mensaje de error
                ViewBag.ErrorMessage = "Usuario y contraseña son obligatorios.";
                return View();
            }

            // Llamamos al método que verifica el usuario y la contraseña en la base de datos
            var user = VerificarUsuario(usuario, clave);

            if (user != null)
            {
                // Almacena el nombre del usuario en TempData para mostrarlo en la siguiente vista
                TempData["UserName"] = user.T_Usuario;

                // Si el usuario existe y la contraseña es correcta, redirigimos a la página principal (o al dashboard)
                return RedirectToAction("Index", "Home");
            }

            // Si no se encuentra el usuario o la contraseña es incorrecta
            ViewBag.ErrorMessage = "Usuario o contraseña incorrectos.";
            return View();
        }


        // Método que verifica las credenciales de usuario en la base de datos
        private Usuario VerificarUsuario(string usuario, string clave)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand("sp_LoginUsuario", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Usuario", usuario);
                    command.Parameters.AddWithValue("@Clave", clave);

                    var reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        return new Usuario
                        {
                            ID_Usuario = Convert.ToInt32(reader["ID_Usuario"]),
                            T_Usuario = reader["T_Usuario"].ToString(),
                            T_EstadoRegistro = reader["T_EstadoRegistro"].ToString()
                        };
                    }
                }
            }

            return null;  // Si no encuentra el usuario, retorna null
        }
    }
}
