namespace Answer_Searcher.Data
{
    public class Info
    {
        public int Count { get; set; }
        public string Zapros { get; set; }
        public string Otvet { get; set; }
        public Info(string _zapros, string _otvet)
        {
            Zapros = _zapros;
            Otvet = _otvet;
        }
    }
}
