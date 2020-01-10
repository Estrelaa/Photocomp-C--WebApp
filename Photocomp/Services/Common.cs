namespace Photocomp
{
    public abstract class Common
    {
        private protected string backEndIP = "34.248.103.39";
        private protected string token = "5e7f6416-786a-430a-83fc-90acd7f5b3b2";

        public string buildURL(string path)
        {
            return "http://" + backEndIP + "/images" + path + "?token=" + token;
        }
    }
}
