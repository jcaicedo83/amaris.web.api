namespace amaris.web.api.core.dto
{
    public class Response
    {
        public bool Ok { get; set; }
        public string Message { get; set; }
        public object Content { get; set; }
    }
}
