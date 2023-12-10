namespace Line_bot_Leo.Services
{
    public class QrCodeService
    {
        public string DecodingQrCodeImg()
        {
            if (CheckImgIsQrCode())
            {

            }
            return "這張圖片中不包含QRCode";
        }


        public bool CheckImgIsQrCode()
        {

            return true;
        }
    }
}
