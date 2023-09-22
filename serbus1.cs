using System;
using System.Threading.Tasks;
using Azure.Messaging.ServiceBus;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace StandardDepInjFA
{
    public class serbus1
    {
        private readonly ILogger<serbus1> _logger;
        private readonly IMyService myService;

        public serbus1(ILogger<serbus1> logger, IMyService _myService)
        {
            _logger = logger;
            myService = _myService;
        }

        [Function(nameof(serbus1))]
        public async Task Run([ServiceBusTrigger("sbqueue", Connection = "sbconnstring")] ServiceBusReceivedMessage message)
        {
            await myService.MyServiceMethod();
            _logger.LogInformation("Message ID: {id}", message.MessageId);
            _logger.LogInformation("Message Body: {body}", message.Body);
            _logger.LogInformation("Message Content-Type: {contentType}", message.ContentType);
        }
    }
}
