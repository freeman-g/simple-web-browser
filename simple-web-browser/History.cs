namespace simple_web_browser
{

    internal class History
    {
        public string url;
        public System.DateTime dateTime;

        public History(string url, System.DateTime dateTime)
        {
            this.url = url;
            this.dateTime = dateTime;
        }


    }


}