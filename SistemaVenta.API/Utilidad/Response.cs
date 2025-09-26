namespace SistemaVenta.API.Utilidad
{
    public class Response<T>
    {
        public bool status { get; set; }
        public T Value { get; set; }
        public string msg { get; set; }
    }
}
