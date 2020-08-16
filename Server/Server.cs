using CitizenFX.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Server : BaseScript
    {
        string message;
        bool isRunning = false;
        public Server()
        {
            EventHandlers["serverStartMessage"] += new Action(OnStartService);
        }
        public void OnStartService()
        {
            if (!isRunning)
            {
                isRunning = true;
                OnCooldown();
            }
        }
        public async void OnCooldown()
        {
            await Delay(420000);
            OnMessage();

        }
        public void OnMessage()
        {
            Random random = new Random();
            int value = random.Next(1, 6);
            if(value == 1)
            {
                message = "Dont Forget to Sign Up For our CAD";
            }
            else
            {
                if (value == 2)
                {
                    message = "Dont Forget to join our discord at discord.gg/Tx9MGVY";
                }
                else
                {
                    if(value == 3)
                    {
                        message = "Make sure to read the rules in our discord at #rules in our discord";
                    }
                    else
                    {
                        if(value == 4)
                        {
                            message = "Considering joining a department? Apply Today at our Discord!";
                        }
                        else
                        {
                            message = "Make sure to read the rules in our discord at #rules in our discord";
                        }
                    }
                }
            }
            TriggerClientEvent("recieveMessage", message);
            OnCooldown();
        }
    }
}
