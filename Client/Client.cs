using CitizenFX.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CitizenFX.Core.Native.API;

namespace Client
{
    public class Client : BaseScript
    {
        public Client()
        {
            EventHandlers["onClientResourceStart"] += new Action<string>(OnClientResourceStart);
            EventHandlers["recieveMessage"] += new Action<string>(OnMassageRecieve);
        }
        private void OnClientResourceStart(string resourceName)
        {
            Cooldown();
        }
        private void OnMessageRequest()
        {

        }
        private void Cooldown()
        {
            TriggerServerEvent("serverStartMessage");
        }
        private void OnMassageRecieve(string message)
        {
            TriggerEvent("chat:addMessage", new
            {
                color = new[] { 138, 43, 226 },
                multiline = true,
                args = new[] { "Messanger:", $"^* ^4{message}" }
            });
            return;
        }
    }
}
