using SmartAutomationService.Model.Proto;

namespace SmartAutomationService.Model.Queries
{
    public class KrollToDoQueries : IDbQuery
    {
        private const string Body =
            @"
        select 
            KrollToDo.Id, SmartLinkOrderId, WorkOrderId, DateOrderReceived, RxNum, OrigRxNum, NewRxNum, FileName, IsOrder,
            IsPenOrder, IsSmartDocOrder, IsFaxOrder, IsMedChecks, IsNarcotic, IsStatbox, IsMedPass, PatientID, PatientName,
            HomeId, KrollNhId, HomeName, WardId, KrollWardId, WardName, ToDoId, SharedDBStoreId, DueDate, ToDoOrigin,
            Resolved, ResolvedDate, ResolvedBy, ResolvedComment, PendingNewRxId, DateCreated,
            SmartLinkOrderType.Id, SmartLinkOrderType.Type, KrollRxStatus.Id, KrollRxStatus.Status,
            KrollResponseType.Id, KrollResponseType.Type, ToDoType.Id, ToDoType.Type,
            ToDoResolvedType.Id, ToDoResolvedType.Type                
        from KrollToDo
            join SmartLinkOrderType on KrollToDo.SmartLinkOrderTypeId = SmartLinkOrderType.Id 
            join KrollResponseType on KrollToDo.KrollResponseTypeId = KrollResponseType.Id 
            join ToDoResolvedType on KrollToDo.ToDoResolvedTypeId = ToDoResolvedType.Id 
            join KrollRxStatus on KrollToDo.KrollRxStatusId = KrollRxStatus.Id  
            join ToDoType on KrollToDo.ToDoTypeId = ToDoType.Id  
            ";
        
        public string Insert()
        {
            return 
                @"
                insert into KrollToDo 
                    (SmartLinkOrderId, WorkOrderId, DateOrderReceived, RxNum, OrigRxNum, FileName, IsOrder,
                     IsPenOrder, IsSmartDocOrder, IsFaxOrder, IsMedChecks, IsNarcotic, IsStatbox, IsMedPass, PatientID,
                     PatientName, HomeId, KrollNhId, HomeName, WardId, KrollWardId, WardName, ToDoId, SharedDBStoreId,
                     DueDate, ToDoOrigin, SmartLinkOrderTypeId, KrollRxStatusId, KrollResponseTypeId)
                values 
                    (@SmartLinkOrderId, @WorkOrderId, @DateOrderReceived, @RxNum, @OrigRxNum, @FileName, @IsOrder,
                     @IsPenOrder, @IsSmartDocOrder, @IsFaxOrder, @IsMedChecks, @IsNarcotic, @IsStatbox, @IsMedPass, @PatientID,
                     @PatientName, @HomeId, @KrollNhId, @HomeName, @WardId, @KrollWardId, @WardName, @ToDoId, @SharedDBStoreId,
                     @DueDate, @ToDoOrigin, @SmartLinkOrderTypeId, @KrollRxStatusId, @KrollResponseTypeId)
				select SCOPE_IDENTITY();
                ";
        }

        public string Update()
        {
            return
                @"
                update KrollToDo set NewRxNum = @NewRxNum, Resolved = @Resolved, ResolvedDate = @ResolvedDate,
                                     ResolvedBy = @ResolvedBy, ToDoTypeId = @ToDoTypeId, ResolvedComment = @ResolvedComment, 
                                     ToDoResolvedTypeId = @ToDoResolvedTypeId, PendingNewRxId = @PendingNewRxId 
                where Id = @ID; 
                ";
        }

        public string Delete()
        {
            return "delete from KrollToDo where Id = @ID;";
        }

        public string SelectByParam(string param)
        {
            return Body + " where KrollToDo." + param + " = @" + param + ";";
        }

        public string ListByParam(string param)
        {
            return Body + " where " + param + " = @" + param + " order by KrollToDo.Id desc;";
        }
    }
}