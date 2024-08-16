using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Azure.Storage.Queues;

namespace MauiApp1.Services
{
    public class ListeningStateService
    {
        public bool IsActive { get; private set; } = false;

        public event Action OnChange;

        public void StartListening()
        {
            IsActive = true;
            NotifyStateChanged();
        }

        public void StopListening()
        {
            IsActive = false;
            NotifyStateChanged();
        }

        //used to notify user about listening mode being active or deactive
        private void NotifyStateChanged() => OnChange?.Invoke();

        //used to periodically check for new messages in the azure queue
        public async Task ListenToQueueAsync(string connectionString, string queueName, Func<MessageModel, Task> processMessageAsync)
        {
            var queueClient = new QueueClient(connectionString, queueName);

            while (IsActive)
            {
                try
                {
                    var messages = await queueClient.ReceiveMessagesAsync(maxMessages: 1, visibilityTimeout: TimeSpan.FromSeconds(30));

                    if (messages.Value.Length > 0)
                    {
                        var message = messages.Value[0];
                        var messageContent = JsonSerializer.Deserialize<MessageModel>(message.MessageText);

                        await processMessageAsync(messageContent);

                        await queueClient.DeleteMessageAsync(message.MessageId, message.PopReceipt);
                    }
                }
                catch (Exception ex)
                {

                }

                await Task.Delay(5000); // task frequency 5 seconds
            }
        }
    }

    public class MessageModel
    {
        public string Message { get; set; }
        public string ConnectionString { get; set; }
        public string ContainerName { get; set; }
    }

}
