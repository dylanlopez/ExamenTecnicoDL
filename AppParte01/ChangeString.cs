namespace AppParte01
{
    public class ChangeString
    {
        public string build (string entrada)
        {
            string salida = string.Empty;
            foreach(char letra in entrada)
            {
                if (letra == 'z')
                {
                    salida = salida + "a";
                }
                else if (letra == 'Z')
                {
                    salida = salida + "A";
                }
                else if (char.IsLetter(letra))
                {
                    salida = salida + (char)(((int)letra) + 1);
                }
                else
                {
                    salida = salida + letra;
                }
            }
            return salida;
        }
    }
}