#region
using System;
using System.Security.Cryptography.X509Certificates;

#endregion

namespace Kroll.KxProto.Client
{
    public interface IKxProtoTlsClient
    {
        void Connect(string host, int port, string remoteCertificateName, X509Certificate2 clientCertificate, TimeSpan connectionTimeout, KxProtoMessageSerializationType serializationType);
        void Disconnect();
        bool IsConnected();

        TResponseType SendMessageAndWait<TRequestType, TResponseType>(TRequestType request, string messageName, string messageVersion, TimeSpan timeout)
            where TRequestType : class
            where TResponseType : class;

        void SendOneWayMessage<TRequestType>(TRequestType request, string messageName, string messageVersion)
            where TRequestType : class;
    }
}