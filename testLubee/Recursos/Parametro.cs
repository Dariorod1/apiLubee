namespace testLubee.Recursos
{
    public class Parametro
    {
        public Parametro(string nombre, int valor)
        {
            Nombre = nombre;
            Valor = valor;
        }

        public string Nombre { get; set; }

        public int Valor { get; set; }
    }
}
