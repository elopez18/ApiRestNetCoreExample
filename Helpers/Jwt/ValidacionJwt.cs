using ANLA.Artemisa.GestionDocumentalApi.Dto;
using System.Security.Claims;

namespace ANLA.Artemisa.GestionDocumentalApi.Helpers.Jwt
{
    public class ValidacionJwt
    {
        public static dynamic validarToken(ClaimsIdentity identity)
        {

            try
            {
                if (identity.Claims.Count() == 0)
                {
                    return new
                    {
                        success = false,
                        message = "Token invalido o inexistente",
                        result = ""
                    };

                }
                else
                {
                    var User = identity.Claims.FirstOrDefault(x => x.Type == "usuario").Value;

                    SimulacionJWT DataUser = SimulacionJWT.BD().FirstOrDefault(x => x.User == User);

                    return new
                    {
                        success = true,
                        message = "Token valido",
                        result = DataUser
                    };

                }

            }
            catch (Exception Ex)
            {
                return new
                {
                    success = false,
                    message = "Catch: " + Ex.Message,
                    result = ""
                };

            }
        }
    }
}
