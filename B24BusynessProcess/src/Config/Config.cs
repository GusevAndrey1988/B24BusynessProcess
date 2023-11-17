namespace B24BusynessProcess.Config
{
    [Serializable]
    internal class Config
    {
        public string WebHook { get; set; } = "";

        public void Rest()
        {
            WebHook = "";
        }
    }
}