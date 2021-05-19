using System;

namespace sistema_de_orientação_celular
{
    class Program
    {
        static void Main(string[] args)
        {
            string ligar;
            string menu;
            int menu2;
            int numero;
            int contato;
            string mensagem;
            string nomeMen;

            Celular celular = new Celular();
            celular.cor = "Preto";
            celular.modelo = "Sansung Galaxis S21";
            celular.tamanho = 12;
            

            bool senhaCorreta = false;

            do
            {
                
            

            Console.WriteLine("Digite L para ligar o celular:");
            ligar = Console.ReadLine().ToLower();

            if (ligar == "l")
            {
                celular.Ligar();
            }

            if (celular.ligado == true)
            {
                Console.WriteLine("O celular esta ligado! ");

                Console.WriteLine("");
                Console.WriteLine($"A cor do celular é {celular.cor}");
                Console.WriteLine($"O modelo do celular é {celular.modelo}");
                Console.WriteLine($"O celular tem {celular.tamanho} polegadas");
                Console.WriteLine("");


                Console.WriteLine("Digite M para cessar o menu :");
                menu = Console.ReadLine().ToLower();

                do
                {



                    if (menu == "m")
                    {

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($@"
=======================================
|               04:50       23°C  80% |
=======================================
|               MENU                  |
|=====================================|
|         1- FAZER LIGAÇÃO            |
|                                     |
|         2- VER CONTATOS             |
|                                     |
|         3- MANDAR MENSAGEM          |
|                                     |
|         4- VER AS MENSAGENS         |
|                                     |
|         5- JOGAR                    |
|                                     |
|         6- DESLIGAR                 | 
|=====================================|");
                        Console.ForegroundColor = ConsoleColor.White;
                        menu2 = int.Parse(Console.ReadLine());


                        if (menu2 == 1)
                        {
                            Console.WriteLine(celular.Ligacao());
                            Console.WriteLine("Digite o  numero que você deseja ligar:");
                            numero = int.Parse(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($@"
=======================================
|               04:50       23°C  80% |
=======================================
|               MENU                  |
|=====================================|
|                                     |
|                                     |
|            CHAMANDO...              |
|                                     |
|                                     |
|                                     |
|                                     |
|                                     |
|                                     |
|                                     |
|                                     | 
|=====================================|");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("LIGAÇÃO FINALIZADA");
                            Console.ForegroundColor = ConsoleColor.White;


                        }


                        if (menu2 == 2)
                        {
                            Console.WriteLine($@"
=======================================
|               04:50       23°C  80% |
=======================================
|               MENU                  |
|=====================================|
|         1- Thiago(11)98741-5681     |
|                                     |
|         2- Ordilei(11)97653-3245    |
|                                     |
|         3- Gustavo(11)92345-1090    |
|                                     |
|         4- João(11)96625-6992       |
|                                     |
|                                     |
|                                     |
|                                     | 
|=====================================|");

                            contato = int.Parse(Console.ReadLine());

                            if (contato == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($@"
=======================================
|               04:50       23°C  80% |
=======================================
|               MENU                  |
|=====================================|
|                                     |
|                                     |
|            CHAMANDO...              |
|                                     |
|                                     |
|                                     |
|                                     |
|                                     |
|                                     |
|                                     |
|                                     | 
|=====================================|");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("LIGAÇÃO FINALIZADA");
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            if (contato == 2)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($@"
=======================================
|               04:50       23°C  80% |
=======================================
|               MENU                  |
|=====================================|
|                                     |
|                                     |
|            CHAMANDO...              |
|                                     |
|                                     |
|                                     |
|                                     |
|                                     |
|                                     |
|                                     |
|                                     | 
|=====================================|");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("LIGAÇÃO FINALIZADA");
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            if (contato == 3)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($@"
=======================================
|               04:50       23°C  80% |
=======================================
|               MENU                  |
|=====================================|
|                                     |
|                                     |
|            CHAMANDO...              |
|                                     |
|                                     |
|                                     |
|                                     |
|                                     |
|                                     |
|                                     |
|                                     | 
|=====================================|");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("LIGAÇÃO FINALIZADA");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            if (contato == 4)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($@"
=======================================
|               04:50       23°C  80% |
=======================================
|               MENU                  |
|=====================================|
|                                     |
|                                     |
|            CHAMANDO...              |
|                                     |
|                                     |
|                                     |
|                                     |
|                                     |
|                                     |
|                                     |
|                                     | 
|=====================================|");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("LIGAÇÃO FINALIZADA");
                                Console.ForegroundColor = ConsoleColor.White;
                            }


                        }

                        if (menu2 == 3)
                        {
                            Console.WriteLine(celular.Mensagem());
                            Console.WriteLine("Digite a mensagem que vc deseja enviar :");
                            mensagem = Console.ReadLine();
                            Console.WriteLine("Para quem você deseja enviar:");
                            nomeMen = Console.ReadLine();

                            Console.WriteLine($@"
=======================================
|               04:50       23°C  80% |
=======================================
|               MENU                  |
|=====================================|
|                                     |
|                                     |
|            ENVIANDO...              |
|             para                    |
             {nomeMen}                
|                                     |
|                                     |
|                                     |
|                                     |
|                                     |
|                                     | 
|=====================================|");


                        }

                        if (menu2 == 4)
                        {
                            Console.WriteLine($@"
=======================================
|               04:50       23°C  80% |
=======================================
|               MENU                  |
|=====================================|
|                                     |
|                                     |
|            VOCÊ NAO TEM             |
|              NENHUMA                |
|             MENSAGEM                |
|                                     |
|                                     |
|                                     |
|                                     |
|                                     |
|                                     | 
|=====================================|");
                        }

                        if (menu2 == 5)
                        {
                            Personagem personagem1 = new Personagem();
                            Personagem personagens2 = new Personagem();

                            Console.WriteLine("DUELO DE PERSONAGEM");
                            Console.WriteLine("!ESCOLHA 2 PERSONAGEMS QUE VOCÊ DESEJA UTILIZAR!");

                            Console.WriteLine("");
                            Console.WriteLine("");



                            Console.WriteLine("PERSOANGEM 1");
                            Console.WriteLine("Qual o nome do personagem que você deseja usar??");
                            personagem1.nome = Console.ReadLine();

                            Console.WriteLine("Qual idade do seu personagem ?");
                            personagem1.idade = int.Parse(Console.ReadLine());
                            Console.WriteLine("Qual a armadura do seu personagem ??");
                            personagem1.armadura = Console.ReadLine();

                            do
                            {

                                Console.WriteLine("Digite a vida que seu personagem deseja ter: de (0/100)");
                                personagem1.pontoVida = int.Parse(Console.ReadLine());

                                if (personagem1.pontoVida > 100)
                                {
                                    Console.WriteLine("!Vida esta alem do desejado!");

                                }

                            } while (personagem1.pontoVida > 100);

                            Console.WriteLine("");
                            Console.WriteLine("");

                            Console.WriteLine("PERSOANGEM 2");
                            Console.WriteLine("Qual o nome do personagem que você deseja usar??");
                            personagens2.nome = Console.ReadLine();
                            Console.WriteLine("Qual idade do seu personagem ?");
                            personagens2.idade = int.Parse(Console.ReadLine());
                            Console.WriteLine("Qual a armadura do seu personagem ??");
                            personagens2.armadura = Console.ReadLine();

                            do
                            {

                                Console.WriteLine("Digite a vida que seu personagem deseja ter: de (0/100)");
                                personagens2.pontoVida = int.Parse(Console.ReadLine());

                                if (personagens2.pontoVida > 100)
                                {
                                    Console.WriteLine("!Vida esta alem do desejado!");

                                }

                            } while (personagens2.pontoVida > 100);



                            do
                            {


                                Console.Clear();
                                Console.WriteLine($@"
Selecione a opção do personagem 1
      1- Atacar
      2- Defender
      3- Restaurar armadura");

                                int opçãoP1 = int.Parse(Console.ReadLine());

                                Console.Clear();
                                Console.WriteLine($@"
Selecione a opção do personagem 2
      1- Atacar
      2- Defender
      3- Restaurar armadura");

                                int opçãoP2 = int.Parse(Console.ReadLine());

                                if (opçãoP1 == 1 && opçãoP2 == 1)
                                {
                                    personagem1.pontoVida = personagem1.pontoVida - personagens2.Atacar();

                                    personagens2.pontoVida = personagens2.pontoVida - personagem1.Atacar();
                                }
                                else if (opçãoP1 == 1 && opçãoP2 == 2)
                                {
                                    personagens2.pontoVida = personagens2.pontoVida - (personagem1.Atacar() - personagens2.Defender());


                                }
                                else if (opçãoP1 == 1 && opçãoP2 == 3)
                                {
                                    personagens2.pontoVida = personagens2.pontoVida + (personagens2.Restaurar() - personagem1.Atacar());
                                }
                                else if (opçãoP1 == 2 && opçãoP2 == 1)
                                {
                                    personagem1.pontoVida = personagem1.pontoVida - (personagens2.Atacar() - personagem1.Defender());
                                }
                                else if (opçãoP1 == 2 && opçãoP2 == 2)
                                {

                                    Console.WriteLine("Os personagens ficaram se encarando de maneira estranha");
                                }
                                else if (opçãoP1 == 2 && opçãoP2 == 3)
                                {
                                    personagens2.pontoVida = personagens2.pontoVida + personagens2.Restaurar();
                                }

                                else if (opçãoP1 == 3 && opçãoP2 == 1)
                                {
                                    personagem1.pontoVida = personagem1.pontoVida + (personagem1.Restaurar() - personagens2.Atacar());

                                }
                                else if (opçãoP1 == 3 && opçãoP2 == 2)
                                {
                                    personagem1.pontoVida = personagem1.pontoVida + personagem1.Restaurar();
                                }
                                else if (opçãoP1 == 3 && opçãoP2 == 3)
                                {
                                    personagem1.pontoVida = personagem1.pontoVida + personagem1.Restaurar();
                                    personagens2.pontoVida = personagens2.pontoVida + personagens2.Restaurar();
                                }





                                Console.WriteLine($"Vida do {personagem1.nome} esta de {personagem1.pontoVida} ");
                                Console.WriteLine($"Vida do  {personagens2.nome} esta de {personagens2.pontoVida}");

                            } while (personagem1.pontoVida > 0 && personagens2.pontoVida > 0);


                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("");
                            Console.WriteLine("GAME OVER !!!");
                            Console.ForegroundColor = ConsoleColor.White;

                        }

                        if (menu2 == 6)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;

                            Console.WriteLine("O celular esta desligando!!");
                            Console.ForegroundColor = ConsoleColor.White;

                            celular.Desligar();
                            senhaCorreta = true;
                        }


                    }
                } while (celular.ligado == true);

            }
            else
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro ! o celular esta desligado !");
                Console.ForegroundColor = ConsoleColor.White;

            }
            } while (senhaCorreta == false);
        }
    }
}
