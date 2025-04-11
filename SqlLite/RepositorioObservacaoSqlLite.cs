using CasosDeUso.PluginsInterfaces;
using CoreBusiness.Entidades;
using SQLite;

namespace MinhaAgenda.Plugins.SqlLite
{
    public class RepositorioObservacaoSqlLite : IRepositorioDeObs
    {
        private SQLiteAsyncConnection _database;

        public RepositorioObservacaoSqlLite()
        {
            _database = new SQLiteAsyncConnection(Constantes._databasepath);
            _database.CreateTableAsync<Obs>().Wait();
        }

        public Task AdicionarObs(Obs obs)
        {
            return Task.FromResult(AdicionarObsAsync(obs));
        }

        public async Task AdicionarObsAsync(Obs obs)
        {
            await _database.InsertAsync(obs);
        }
    }
}
