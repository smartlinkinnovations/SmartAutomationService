using SmartAutomationService.Model.Proto;

namespace SmartAutomationService.Model.Connections
{
    public class SmartMedsConnection : IDbConnection
    {
        public string ConnectionString()
        {
            return "Data Source=10.33.2.27,1433;Initial Catalog=SmartMeds;" +
                   "User Id=smartlink_user;Password=smartlink$;" +
                   "Persist Security Info=True;";
        }
    }
}