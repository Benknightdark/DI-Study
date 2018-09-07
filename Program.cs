using System;

namespace DI_Study {
    class Program {

        static void Main (string[] args) {
            Console.WriteLine ("Hello World!");
            EmailService a = new EmailService ();
            a.Send ("dfd", "fadf");
        }

    }
    class AuthenticationService {
        private IMessageService msgService;
        public AuthenticationService (IMessageService service) {
            this.msgService = service;
        }
    }

    /// <summary>
    /// email
    /// </summary>
    class EmailService : IMessageService {
        public void Send (string user, string msg) {
            // 寄送電⼦郵件給指定的 user (略)
            Console.WriteLine (" 寄送電⼦郵件給使⽤者，訊息內容：" + msg);
        }
    }
    /// <summary>
    /// sms
    /// </summary>
    class SMSService : IMessageService {
        public void Send (string user, string msg) {
            // 寄送電⼦郵件給指定的 user (略)
            Console.WriteLine (" 寄送電SMS給使⽤者，訊息內容：" + msg);
        }
    }
    interface IMessageService {
        void Send (string user, string msg);
    }
}