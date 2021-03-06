// Install the C# / .NET helper library from twilio.com/docs/csharp/install

using System;
using System.Collections.Generic;
using Twilio;
using Twilio.Rest.Autopilot.V1.Assistant;


class Program 
{
    static void Main(string[] args)
    {
        // Find your Account Sid and Token at twilio.com/console
        const string accountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        const string authToken = "your_auth_token";

        TwilioClient.Init(accountSid, authToken);

        var defaults = new Dictionary<string, Object>()
        {
            {"defaults", new Dictionary<string, Object>()
                {
                    {"assistant_initiation", "task://hello-world"},
                    {"fallback", "task://hello-world"}
                }}
        };

        var defaults = DefaultsResource.Update(
            defaults: defaults,
            pathAssistantSid: "UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        );

        Console.WriteLine(defaults.AssistantSid);
    }
}
