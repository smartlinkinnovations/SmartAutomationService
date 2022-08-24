using SmartAutomationService.Model.Proto;

namespace SmartAutomationService.Model.Connections
{
    public class KrollFdbConnection : IDbConnection
    {
        public string ConnectionString()
        {
            return "Data Source=172.24.50.100;Initial Catalog=FDB;User Id=sa_smartlink;Password=''']LyZxwG;F-@5WMy';Persist Security Info=True;";
        }
    }
}