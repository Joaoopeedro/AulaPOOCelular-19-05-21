namespace sistema_de_orientação_celular
{
    public class Personagem
    {
        public string nome;

        public int idade;

        public string armadura;

        public int pontoVida;

        public int Atacar()
        {
            int dano = 30;
            return dano;
        }

        public int Defender()
        {
            int defesa = 15;
            return defesa;
        }

        public int Restaurar()
        {
            int Restaura = 40;
            return Restaura;
        }
    }
}