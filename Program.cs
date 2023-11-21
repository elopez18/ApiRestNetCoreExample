using ANLA.Artemisa.GestionDocumentalApi.Extentions;
using ANLA.Artemisa.GestionDocumentalApi.Helpers.Configuration;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using NLog;
using NLog.Web;
using System.Reflection;
using System.Text;


internal class Program
{
    /// <summary>
    /// Main
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
        var logger = LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
        logger.Debug("init main");

        try
        {
            var serviceProvider = new ServiceCollection()
            .AddScoped<IGetConfig, GetConfig>()
            .BuildServiceProvider();

            var ConfigProperties = serviceProvider.GetService<IGetConfig>();
            var Configuration = ConfigProperties.GetConfiguration();

            var validissuer = Configuration["userSecret:Jwt:Issuer"];
            var validaudience = Configuration["userSecret:Jwt:Audience"];
            var issuersigningkey = Configuration["userSecret:Jwt:Key"];


            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            // Inicio: Agregar las extensiones de cada uno de los controles creados 
            builder.Services.AddTestExtentions();
            builder.Services.AddExpedienteExtentions();
            builder.Services.AddRadicadoExtentions();
            // Final: Agregar las extensiones de cada uno de los controles creados 
            builder.Services.AddGetConfigExtentions();
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(Options =>
            {
                Options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = validissuer,
                    ValidAudience = validaudience,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(issuersigningkey))
                };
            });

            var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

            builder.Services.AddSwaggerGen(config =>
            {
                config.SwaggerDoc("v1",
                    new OpenApiInfo()
                    {
                        Title = "ANLA.Artemisa.GestionDocumental",
                        Description = "API Rest que permite realizar el consumo de servicios del Gestor Documental Orfeo."
                    });

                config.IncludeXmlComments(xmlPath);
            });


            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "ANLA.Artemisa.GestionDocumental V1");
                });
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
        catch (Exception Ex)
        {
            logger.Error(Ex, "Program has stopped because there was an Exception");
            throw;
        }
        finally
        {
            LogManager.Shutdown();
        }
    }
}