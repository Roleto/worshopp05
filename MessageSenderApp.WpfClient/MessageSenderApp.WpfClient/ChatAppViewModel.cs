using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using MessageSenderApp.WpfClient;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace MessageSenderApp.WpfClient
{
    class ChatAppViewModel : ObservableRecipient
    {
        private Message message;

        public RestCollection<Message> Messages { get; set; }

        public Message Message
        {
            get { return message; }
            set { SetProperty(ref message, value); }
        }

        public ICommand SendMessageCommand { get; set; }

        public static bool IsInDesignMode
        {
            get
            {
                var prop = DesignerProperties.IsInDesignModeProperty;
                return (bool)DependencyPropertyDescriptor.FromProperty(prop, typeof(FrameworkElement)).Metadata.DefaultValue;
            }
        }

        public ChatAppViewModel()
        {
            if(!IsInDesignMode)
            {
                SendMessageCommand = new RelayCommand(() =>
                {

                });
            }
        }
    }

    internal class Message
    {
        string name;
        string messageContent;
        string timeStamp;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string MessageContent
        {
            get { return messageContent; }
            set { messageContent = value; }
        }
        public string TimeStamp
        {
            get { return timeStamp; }
            set { timeStamp = value; }
        }
    }
}
