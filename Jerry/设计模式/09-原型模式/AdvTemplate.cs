using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_原型模式
{
    public class AdvTemplate
    {
        /// <summary>
        /// 广告信名称
        /// </summary>
        private string advSubject = "xx银行国庆信用卡抽奖活动";
        /// <summary>
        /// 广告信内容
        /// </summary>
        private string advContext = "国庆抽奖活动通知:只要刷卡就送你一百万！......";

        /// <summary>
        /// 获取广告信名称
        /// </summary>
        public string AdvSubject { get { return advSubject; } }

        /// <summary>
        /// 获取广告信内容
        /// </summary>
        public string AdvContext { get { return advContext; } }


    }
}
