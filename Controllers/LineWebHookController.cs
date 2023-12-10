using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace isRock.Template
{
    public class LineWebHookController : isRock.LineBot.LineWebHookControllerBase
    {
        [Route("api/LineBotWebHook")]
        [HttpPost]
        public IActionResult POST()
        {
            var AdminUserId = "U78e44abb4b3a8cb1f5070566869122d7";

            try
            {
                //設定ChannelAccessToken
                this.ChannelAccessToken = "aui07WjvSMvx4OvVUekqiBLEOGNejgTNdw0R/+vVhrAdMcUmqHnxeooH8FD9+qFo/bbtSFLpPqBQB4J2w71yWrJpE+JzHOHyI5iKFH4K8A12Id0xRV9CD3XZEGDqvpG5Pn045RGFkTZys93+sJPyEgdB04t89/1O/w1cDnyilFU=";
                //配合Line Verify
                if (this.ReceivedMessage.events == null || this.ReceivedMessage.events.Count() <= 0 ||
                    this.ReceivedMessage.events.FirstOrDefault().replyToken == "00000000000000000000000000000000") return Ok();
                //取得Line Event
                var LineEvent = this.ReceivedMessage.events.FirstOrDefault();
                var responseMsg = "";
                //準備回覆訊息
                if (LineEvent.type.ToLower() == "message" && LineEvent.message.type == "text")
                    responseMsg = $"你說了: {LineEvent.message.text}";
                else if (LineEvent.type.ToLower() == "message")
                    responseMsg = $"收到 event : {LineEvent.type} type: {LineEvent.message.type} ";
                else if()
                    
                else
                    responseMsg = $"收到 event : {LineEvent.type} ";
                //回覆訊息
                this.ReplyMessage(LineEvent.replyToken, responseMsg);
                //response OK
                return Ok();
            }
            catch (Exception ex)
            {
                //回覆訊息
                this.PushMessage(AdminUserId, "發生錯誤:\n" + ex.Message);
                //response OK
                return Ok();
            }
        }
    }
}