using ChatProtocol;

namespace WPFChatClient.MessageHandler
{
    public interface IMessageHandler
    {
        public void Execute(MainWindowViewModel viewModel, IMessage message);
    }
}
