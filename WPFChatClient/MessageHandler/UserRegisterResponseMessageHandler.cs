using ChatProtocol;

namespace WPFChatClient.MessageHandler
{
    public class UserRegisterResponseMessageHandler : IMessageHandler
    {
        public void Execute(MainWindowViewModel viewModel, IMessage message)
        {
            var userRegisterResponseMessage = message as UserRegisterResponseMessage;

            if (userRegisterResponseMessage.Success)
            {
                viewModel.ChatHistory += "Registration Succeeded. Please login to begin...";
                viewModel.Username = string.Empty;
            }
            else
            {
                viewModel.ChatHistory += $"Registration failed: {userRegisterResponseMessage.ErrorMessage}";
                viewModel.Username = string.Empty;
            }
        }
    }
}
