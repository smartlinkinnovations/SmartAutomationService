using System.Collections.Generic;

namespace SmartAutomationService.Model.Proto
{
    public interface IDbService<T>
    {
        long Insert(T t);

        int Update(T t);

        int Delete(long id);

        T Select(string paramName, long paramValue);

        List<T> List(string paramName, long paramValue);
    }
}