using SmartAutomationService.Model.Proto;

namespace SmartAutomationService.Model.Connections
{
    public class SmartFillConnection : IDbConnection
    {
        public string ConnectionString()
        {
            return "Data Source=172.24.50.59,1433;Initial Catalog=SmartFill;User Id=developer;Password=Welcome123!;Persist Security Info=True;";
        }
    }
}