using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_原型模式
{
    public class Mail
    {
        /// <summary>
        /// 收件人
        /// </summary>
        private string receiver;

        /// <summary>
        /// 邮件名称
        /// </summary>
        private string subject;

        /// <summary>
        /// 称谓
        /// </summary>
        private string application;

        /// <summary>
        /// 邮件内容
        /// </summary>
        private string context;

        /// <summary>
        /// 邮件尾部
        /// </summary>
        private string tail;

        public string Receiver
        {
            get
            {
                return receiver;
            }

            set
            {
                receiver = value;
            }
        }

        public string Subject
        {
            get
            {
                return subject;
            }

            set
            {
                subject = value;
            }
        }

        public string Application
        {
            get
            {
                return application;
            }

            set
            {
                application = value;
            }
        }

        public string Context
        {
            get
            {
                return context;
            }

            set
            {
                context = value;
            }
        }

        public string Tail
        {
            get
            {
                return tail;
            }

            set
            {
                tail = value;
            }
        }

        public Mail(AdvTemplate advTemplate)
        {
            this.Context = advTemplate.AdvContext;
            this.Subject = advTemplate.AdvContext;
        }
    }
}
