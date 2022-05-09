namespace SmartAutomationService.Model.Proto
{
    public interface IDbQuery
    {
        string Insert();

        string Update();

        string Delete();

        string SelectByParam(string param);

        string ListByParam(string param);
    }
}