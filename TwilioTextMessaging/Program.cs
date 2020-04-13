using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace TwilioTextMessaging
{
    class Program
    {
        static void Main(string[] args)
        {
            const string accountSid = "AC812496781abd2bb93a1107c304b886fe";
            const string authToken = "42ae32bdadb6bd20222e6763acc68273";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: "Zach's Test Text Message from Twilio",
                from: new Twilio.Types.PhoneNumber("+18508425323"),
                to: new Twilio.Types.PhoneNumber("+18147220543")
            );

            Console.WriteLine(message.Sid);
        }
    }
}
