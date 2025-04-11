﻿using CasosDeUso;
using CasosDeUso.Interface;
using CasosDeUso.PluginsInterfaces;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using MinhaAgenda.Plugins.SqlLite;
using MinhaAgenda.Views;

namespace MinhaAgenda
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>().UseMauiCommunityToolkit();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            #region injeção de dependências
            builder.Services.AddSingleton<IRepositorioDeContatos, RepositorioContatosSqlLite>();
            builder.Services.AddSingleton<IRepositorioDeObs, RepositorioObservacaoSqlLite>();
            //builder.Services.AddSingleton<IRepositorioDeContatos, Plugins.DadosEmMemoria.Dados>();
            builder.Services.AddSingleton<IVisualizarContatosUseCase, VisualizarContatosUseCase>();
            builder.Services.AddSingleton<IApagarContatoUseCase, ApagarContatosUseCase>();
            builder.Services.AddSingleton<IAdicionarContatoUseCase, AdicionarContatoUseCase>();
            builder.Services.AddSingleton<IEditarContatoUseCase, EditarContatoUseCase>();
            builder.Services.AddSingleton<IAdicionarObsUseCase, AdicionarObservacaoUseCase>();

            #endregion
            builder.Services.AddSingleton<ContatosPage>();
            builder.Services.AddSingleton<EditarContatoPage>();
            builder.Services.AddSingleton<AdicionarContatoPage>();
            builder.Services.AddSingleton<AdicionarObservacaoPage>();
            return builder.Build();
        }
    }
}
