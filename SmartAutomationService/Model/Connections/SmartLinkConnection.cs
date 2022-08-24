using SmartAutomationService.Model.Proto;

namespace SmartAutomationService.Model.Connections
{
    public class SmartLinkConnection : IDbConnection
    {
        public string ConnectionString()
        {
            return "Data Source=172.24.50.59,1433;Initial Catalog=smartlink;User Id=sa;Password=5martlink!;Persist Security Info=True;";
        }
    }
}