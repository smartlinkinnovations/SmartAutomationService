using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SmartAutomationService.Model.Data;
using SmartAutomationService.Model.Proto;
using SmartAutomationService.Model.Queries;
using IDbConnection = SmartAutomationService.Model.Proto.IDbConnection;

namespace SmartAutomationService.Model.Services
{
    public class KrollToDoService : KrollToDoQueries, IDbService<KrollToDo>
    {
        private readonly IDbConnection _connection;

        public KrollToDoService(IDbConnection connection)
        {
            _connection = connection ?? throw new ArgumentNullException(nameof(connection));
        }

        public long Insert(KrollToDo t)
        {
            using var connection = new SqlConnection(_connection.ConnectionString());
            connection.Open();
            using var command = new SqlCommand(Insert(), connection) {CommandType = CommandType.Text};
            command.Parameters.AddWithValue("SmartLinkOrderId", t.SmartLinkOrderId);
            command.Parameters.AddWithValue("WorkOrderId", t.WorkOrderId);
            command.Parameters.AddWithValue("DateOrderReceived", t.DateOrderReceived);
            command.Parameters.AddWithValue("RxNum", t.RxNum);
            command.Parameters.AddWithValue("OrigRxNum", t.OrigRxNum);
            command.Parameters.AddWithValue("FileName", t.FileName);
            command.Parameters.AddWithValue("IsOrder", t.IsOrder);
            command.Parameters.AddWithValue("IsPenOrder", t.IsPenOrder);
            command.Parameters.AddWithValue("IsSmartDocOrder", t.IsSmartDocOrder);
            command.Parameters.AddWithValue("IsFaxOrder", t.IsFaxOrder);
            command.Parameters.AddWithValue("IsMedChecks", t.IsMedChecks);
            command.Parameters.AddWithValue("IsNarcotic", t.IsNarcotic);
            command.Parameters.AddWithValue("IsStatbox", t.IsStatbox);
            command.Parameters.AddWithValue("IsMedPass", t.IsMedPass);
            command.Parameters.AddWithValue("PatientID", t.Pat.Id);
            command.Parameters.AddWithValue("PatientName", t.Pat.FullName);
            command.Parameters.AddWithValue("HomeId", t.Nh.SmId);
            command.Parameters.AddWithValue("KrollNhId", t.Nh.Id);
            command.Parameters.AddWithValue("HomeName", t.Nh.Name);
            command.Parameters.AddWithValue("WardId", t.NhWard.SmId);
            command.Parameters.AddWithValue("KrollWardId", t.NhWard.Id);
            command.Parameters.AddWithValue("WardName", t.NhWard.Name);
            command.Parameters.AddWithValue("ToDoId", t.ToDoId);
            command.Parameters.AddWithValue("SharedDBStoreId", t.SharedDbStoreId);
            command.Parameters.AddWithValue("DueDate", t.DueDate ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("ToDoOrigin", t.ToDoOrigin);
            command.Parameters.AddWithValue("SmartLinkOrderTypeId", t.SmartLinkOrderType.Id);
            command.Parameters.AddWithValue("KrollRxStatusId", t.KrollRxStatus.Id);
            command.Parameters.AddWithValue("KrollResponseTypeId", t.KrollResponseType.Id);
            return Convert.ToInt64(command.ExecuteScalar());
        }

        public int Update(KrollToDo t)
        {
            using var connection = new SqlConnection(_connection.ConnectionString());
            connection.Open();
            using var command = new SqlCommand(Update(), connection) {CommandType = CommandType.Text};
            command.Parameters.AddWithValue("NewRxNum", t.NewRxNum);
            command.Parameters.AddWithValue("Resolved", t.Resolved);
            command.Parameters.AddWithValue("ResolvedDate", t.ResolvedDate);
            command.Parameters.AddWithValue("ResolvedBy", t.ResolvedBy);
            command.Parameters.AddWithValue("ToDoTypeId", t.ToDoType.Id);
            command.Parameters.AddWithValue("ResolvedComment", t.ResolvedComment);
            command.Parameters.AddWithValue("ToDoResolvedTypeId", t.ToDoResolvedType.Id);
            command.Parameters.AddWithValue("PendingNewRxId", t.PendingNewRxId);
            command.Parameters.AddWithValue("ID", t.Id);
            return command.ExecuteNonQuery();
        }

        public int Delete(long id)
        {
            using var connection = new SqlConnection(_connection.ConnectionString());
            connection.Open();
            using var command = new SqlCommand(Delete(), connection) {CommandType = CommandType.Text};
            command.Parameters.AddWithValue("ID", id);
            return command.ExecuteNonQuery();
        }

        public KrollToDo Select(string paramName, long paramValue)
        {
            KrollToDo krollToDo = null;
            using var connection = new SqlConnection(_connection.ConnectionString());
            connection.Open();
            using var command = new SqlCommand(SelectByParam(paramName), connection) {CommandType = CommandType.Text};
            command.Parameters.AddWithValue(paramName, paramValue);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                krollToDo = new KrollToDo
                {
                    Id = reader.GetInt64(0),
                    SmartLinkOrderId = reader.GetInt64(1),
                    WorkOrderId = reader.GetInt32(2),
                    DateOrderReceived = reader.GetDateTime(3),
                    RxNum = reader.GetInt32(4),
                    OrigRxNum = reader.GetInt32(5),
                    NewRxNum = reader.GetInt32(6),
                    FileName = reader.GetString(7),
                    IsOrder = reader.GetBoolean(8),
                    IsPenOrder = reader.GetBoolean(9),
                    IsSmartDocOrder = reader.GetBoolean(10),
                    IsFaxOrder = reader.GetInt16(11),
                    IsMedChecks = reader.GetInt16(12),
                    IsNarcotic = reader.GetBoolean(13),
                    IsStatbox = reader.GetBoolean(14),
                    IsMedPass = reader.GetBoolean(15),
                    Pat = new Pat
                    {
                        Id = reader.GetInt32(16),
                        FullName = reader.GetString(17)
                    },
                    Nh = new Nh
                    {
                        SmId = reader.GetInt32(18),
                        Id = reader.GetInt32(19),
                        Name = reader.GetString(20)
                    },
                    NhWard = new NhWard
                    {
                        SmId = reader.GetInt32(21),
                        Id = reader.GetInt32(22),
                        Name = reader.GetString(23)
                    },
                    ToDoId = reader.GetInt32(24),
                    SharedDbStoreId = reader.GetInt32(25),
                    DueDate = UtilService.ConvertDate(reader.GetDouble(26)),
                    ToDoOrigin = reader.GetString(27),
                    Resolved = reader.GetBoolean(28),
                    ResolvedDate = reader.GetDateTime(29),
                    ResolvedBy = reader.GetString(30),
                    ResolvedComment = reader.GetString(31),
                    PendingNewRxId = reader.GetInt32(32),
                    DateCreated = reader.GetDateTime(33),
                    SmartLinkOrderType = new SmartLinkOrderType
                    {
                        Id = reader.GetInt32(34),
                        Type = reader.GetString(35)
                    },
                    KrollRxStatus = new KrollRxStatus
                    {
                        Id = reader.GetInt32(36),
                        Status = reader.GetString(37)
                    },
                    KrollResponseType = new KrollResponseType
                    {
                        Id = reader.GetInt32(38),
                        Type = reader.GetString(39)
                    },
                    ToDoType = new ToDoType
                    {
                        Id = reader.GetInt32(40),
                        Type = reader.GetString(41)
                    },
                    ToDoResolvedType = new ToDoResolvedType
                    {
                        Id = reader.GetInt32(42),
                        Type = reader.GetString(43)
                    }
                };
            }

            return krollToDo;
        }

        public List<KrollToDo> List(string paramName, long paramValue)
        {
            var list = new List<KrollToDo>();
            using var connection = new SqlConnection(_connection.ConnectionString());
            connection.Open();
            using var command = new SqlCommand(ListByParam(paramName), connection) {CommandType = CommandType.Text};
            command.Parameters.AddWithValue(paramName, paramValue);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var krollToDo = new KrollToDo
                {
                    Id = reader.GetInt64(0),
                    SmartLinkOrderId = reader.GetInt64(1),
                    WorkOrderId = reader.GetInt32(2),
                    DateOrderReceived = reader.GetDateTime(3),
                    RxNum = reader.GetInt32(4),
                    OrigRxNum = reader.GetInt32(5),
                    NewRxNum = reader.GetInt32(6),
                    FileName = reader.GetString(7),
                    IsOrder = reader.GetBoolean(8),
                    IsPenOrder = reader.GetBoolean(9),
                    IsSmartDocOrder = reader.GetBoolean(10),
                    IsFaxOrder = reader.GetInt16(11),
                    IsMedChecks = reader.GetInt16(12),
                    IsNarcotic = reader.GetBoolean(13),
                    IsStatbox = reader.GetBoolean(14),
                    IsMedPass = reader.GetBoolean(15),
                    Pat = new Pat
                    {
                        Id = reader.GetInt32(16),
                        FullName = reader.GetString(17)
                    },
                    Nh = new Nh
                    {
                        SmId = reader.GetInt32(18),
                        Id = reader.GetInt32(19),
                        Name = reader.GetString(20)
                    },
                    NhWard = new NhWard
                    {
                        SmId = reader.GetInt32(21),
                        Id = reader.GetInt32(22),
                        Name = reader.GetString(23)
                    },
                    ToDoId = reader.GetInt32(24),
                    SharedDbStoreId = reader.GetInt32(25),
                    DueDate = UtilService.ConvertDate(reader.GetDouble(26)),
                    ToDoOrigin = reader.GetString(27),
                    Resolved = reader.GetBoolean(28),
                    ResolvedDate = reader.GetDateTime(29),
                    ResolvedBy = reader.GetString(30),
                    ResolvedComment = reader.GetString(31),
                    PendingNewRxId = reader.GetInt32(32),
                    DateCreated = reader.GetDateTime(33),
                    SmartLinkOrderType = new SmartLinkOrderType
                    {
                        Id = reader.GetInt32(34),
                        Type = reader.GetString(35)
                    },
                    KrollRxStatus = new KrollRxStatus
                    {
                        Id = reader.GetInt32(36),
                        Status = reader.GetString(37)
                    },
                    KrollResponseType = new KrollResponseType
                    {
                        Id = reader.GetInt32(38),
                        Type = reader.GetString(39)
                    },
                    ToDoType = new ToDoType
                    {
                        Id = reader.GetInt32(40),
                        Type = reader.GetString(41)
                    },
                    ToDoResolvedType = new ToDoResolvedType
                    {
                        Id = reader.GetInt32(42),
                        Type = reader.GetString(43)
                    }
                };
                list.Add(krollToDo);
            }

            return list;
        }
    }
}