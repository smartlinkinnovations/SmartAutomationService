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
    public class SmartLinkOrdersService : SmartLinkOrdersQueries, IDbService<SmartLinkOrder>
    {
        private readonly IDbConnection _connection;

        public SmartLinkOrdersService(IDbConnection connection)
        {
            _connection = connection ?? throw new ArgumentNullException(nameof(connection));
        }

        public long Insert(SmartLinkOrder t)
        {
            throw new NotImplementedException();
        }

        public int Update(SmartLinkOrder t)
        {
            using var connection = new SqlConnection(_connection.ConnectionString());
            connection.Open();
            using var command = new SqlCommand(Update(), connection) {CommandType = CommandType.Text};
            command.Parameters.AddWithValue("StatusID", t.SmartLinkOrderStatus.StatusId);
            command.Parameters.AddWithValue("Proccessedby", t.ProcessedById);
            command.Parameters.AddWithValue("OrderToolTip", t.OrderToolTip);
            command.Parameters.AddWithValue("DateReadReceiptReceived", t.DateReadReceiptReceived);
            command.Parameters.AddWithValue("OrderID", t.OrderId);
            return command.ExecuteNonQuery();
        }

        public int Delete(long id)
        {
            throw new NotImplementedException();
        }

        public SmartLinkOrder Select(string paramName, long paramValue)
        {
            SmartLinkOrder order = null;
            using var connection = new SqlConnection(_connection.ConnectionString());
            connection.Open();
            using var command = new SqlCommand(SelectByParam(paramName), connection) {CommandType = CommandType.Text};
            command.Parameters.AddWithValue("OrderID", paramValue);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                order = new SmartLinkOrder
                {
                    OrderId = reader.GetInt64(0),
                    DateOrderReceived = reader.GetDateTime(1),
                    FileName = !reader.IsDBNull(2) ? reader.GetString(2) : "",
                    IsOrder = !reader.IsDBNull(3) && reader.GetBoolean(3),
                    IsPenOrder = !reader.IsDBNull(4) && reader.GetBoolean(4),
                    IsFaxOrder = !reader.IsDBNull(5) ? reader.GetInt16(5) : 0,
                    IsMedChecks = !reader.IsDBNull(6) ? reader.GetInt16(6) : 0,
                    IsSmartDocOrder = !reader.IsDBNull(7) && reader.GetBoolean(7),
                    IsDeleted = !reader.IsDBNull(8) && reader.GetBoolean(8),
                    SmartLinkOrderStatus = new SmartLinkOrderStatus
                    {
                        StatusId = reader.GetInt16(9),
                        Status = reader.GetString(10)
                    },
                    Pat = new Pat
                    {
                        Id = Convert.ToInt32(reader.GetInt64(11)),
                        FullName = reader.GetString(12)
                    },
                    RxNum = !reader.IsDBNull(13) ? reader.GetString(13) : "",
                    OrigRxNum = !reader.IsDBNull(14) ? reader.GetString(14) : "",
                    IsNarcotic = !reader.IsDBNull(15) && reader.GetBoolean(15),
                    IsCancelled = !reader.IsDBNull(16) && reader.GetBoolean(16),
                    NhWard = new NhWard
                    {
                        SmId = reader.GetInt32(17),
                        Name = reader.GetString(18),
                        Id = reader.GetInt32(19)
                    },
                    Nh = new Nh
                    {
                        SmId = reader.GetInt32(20),
                        Name = reader.GetString(21),
                        Id = reader.GetInt32(22)
                    }
                };
            }

            return order;
        }

        public List<SmartLinkOrder> List(string paramName, long paramValue)
        {
            var list = new List<SmartLinkOrder>();
            using var connection = new SqlConnection(_connection.ConnectionString());
            connection.Open();
            using var command = new SqlCommand(ListByParam(paramName), connection) {CommandType = CommandType.Text};
            command.Parameters.AddWithValue(paramName, paramValue);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var order = new SmartLinkOrder
                {
                    OrderId = reader.GetInt64(0),
                    DateOrderReceived = reader.GetDateTime(1),
                    FileName = !reader.IsDBNull(2) ? reader.GetString(2) : "",
                    IsOrder = !reader.IsDBNull(3) && reader.GetBoolean(3),
                    IsPenOrder = !reader.IsDBNull(4) && reader.GetBoolean(4),
                    IsFaxOrder = !reader.IsDBNull(5) ? reader.GetInt16(5) : 0,
                    IsMedChecks = !reader.IsDBNull(6) ? reader.GetInt16(6) : 0,
                    IsSmartDocOrder = !reader.IsDBNull(7) && reader.GetBoolean(7),
                    IsDeleted = !reader.IsDBNull(8) && reader.GetBoolean(8),
                    SmartLinkOrderStatus = new SmartLinkOrderStatus
                    {
                        StatusId = reader.GetInt16(9),
                        Status = reader.GetString(10)
                    },
                    Pat = new Pat
                    {
                        Id = Convert.ToInt32(reader.GetInt64(11)),
                        FullName = reader.GetString(12)
                    },
                    RxNum = !reader.IsDBNull(13) ? reader.GetString(13) : "",
                    OrigRxNum = !reader.IsDBNull(14) ? reader.GetString(14) : "",
                    IsNarcotic = !reader.IsDBNull(15) && reader.GetBoolean(15),
                    IsCancelled = !reader.IsDBNull(16) && reader.GetBoolean(16),
                    NhWard = new NhWard
                    {
                        SmId = reader.GetInt32(17),
                        Name = reader.GetString(18),
                        Id = reader.GetInt32(19)
                    },
                    Nh = new Nh
                    {
                        SmId = reader.GetInt32(20),
                        Name = reader.GetString(21),
                        Id = reader.GetInt32(22)
                    }
                };
                list.Add(order);
            }

            return list;
        }
    }
}