using ChatProtocol;

namespace WPFChatClient.MessageHandler
{
    public class ConnectResponseMessageHandler : IMessageHandler
    {
        public void Execute(MainWindowViewModel viewModel, IMessage message)
        {
            var connectResponseMessage = message as ConnectResponseMessage;
            if (connectResponseMessage.Success)
            {
                viewModel.IsConnected = true;
                viewModel.RequestUsers();
            }
        }
    }
}
