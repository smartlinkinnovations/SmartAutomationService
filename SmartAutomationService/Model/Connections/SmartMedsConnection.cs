using SmartAutomationService.Model.Proto;

namespace SmartAutomationService.Model.Connections
{
    public class SmartMedsConnection : IDbConnection
    {
        public string ConnectionString()
        {
            return "Data Source=172.24.50.59,1433;Initial Catalog=SmartMeds;User Id=developer;Password=Welcome123!;Persist Security Info=True;";
        }
    }
}