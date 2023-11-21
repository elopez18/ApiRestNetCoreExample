namespace ANLA.Artemisa.GestionDocumentalApi.Dto
{
    /// <summary>
    /// DTO SimulacionJWT
    /// </summary>
    public class SimulacionJWT
    {
        public int IdUser { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
        public string Rol { get; set; }

        public static List<SimulacionJWT> BD()
        {
            var list = new List<SimulacionJWT>()
            { new SimulacionJWT{

                IdUser=1,
                User="FuncionarioJWT",
                Pass="JWT123$",
                Rol = "Funcionario"
               },
               new SimulacionJWT{

                IdUser=2,
                User="CoordinadorJWT",
                Pass="JWT123$",
                Rol = "Coordinador"
               },
               new SimulacionJWT{

                IdUser=3,
                User="SupervisorJWT",
                Pass="JWT123$",
                Rol = "Supervisor"
               },
               new SimulacionJWT{

                IdUser=4,
                User="AdministradorJWT",
                Pass="JWT123$",
                Rol = "Administrador"
               }
            };

            return list;

        }
    }
}
