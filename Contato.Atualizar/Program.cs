using Contato.Atualizar;
using Contato.Atualizar.Aplicacao;
using Contato.Atualizar.Repositorios.ContatosRepositorios;
using Contato.Atualizar.Repositorios.Context;


public class Program
{
    public static void Main(string[] args)
    {
        var builder = Host.CreateApplicationBuilder(args);
        builder.Services.AddHostedService<Worker>();

        builder.Services.AddSingleton<IDbConection, DbConection>();
        builder.Services.AddSingleton<IContatosComandosRepositorio, ContatosComandosRepositorio>();
        builder.Services.AddSingleton<IContatoComandos, ContatoComandos>();

        var host = builder.Build();
        host.Run();
    }
}