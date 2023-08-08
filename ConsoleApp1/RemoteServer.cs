namespace System.Runtime.Remoting
{
    using System.Runtime.Remoting;
    using System.Runtime.Remoting.Channels;
    using System.Runtime.Remoting.Channels.Tcp;

    TcpChannel chan = new TcpChannel(8085);
    ChannelServices.RegisterChannel(chan);}