namespace NotasCursoPOO
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public int[] Notas { get; set; }

        public Estudiante(string nombre, int[] notas)
        {
            Nombre = nombre;
            Notas = notas;
        }
    }
}