namespace sistema_de_orientação_celular
{
    public class Celular
    {
        public bool ligado;

        public bool Ligar(){
            return ligado = true;
        }
        public bool Desligar(){
            return ligado = false;
        }
        public string cor;

        public string modelo;
        public double tamanho;

        public string Ligacao(){
            string ligacao2 ="LIGAÇÃO";
            return ligacao2;
        }

        public string Mensagem(){
            string mensagem = "ENVIAR MENSAGEM";
            return mensagem;
        }
        

        
    }
}