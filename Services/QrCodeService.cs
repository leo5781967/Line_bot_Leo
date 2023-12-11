using ThoughtWorks.QRCode.Codec;
using ThoughtWorks.QRCode.Codec.Data;

namespace Line_bot_Leo.Services
{
    public class QrCodeService
    {
        public string DecodingQrCodeImg(Byte[] bytes)
        {
            if (CheckImgIsQrCode(bytes))
            {

            }
            return "這張圖片中不包含QRCode";
        }


        public bool CheckImgIsQrCode(Byte[] bytes)
        {
            




            return true;
        }
    }
}
