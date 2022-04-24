using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace estrutura_dados
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(EstruturaDeDados());

        }

        static string EstruturaDeDados()
        {
            //_____________________________|Tipos primitivos|_____________________________

            //números
            int numInt = 0123456789;
            short numShort = 012345;
            long numLong = 01234567891011121314;
            double numDouble = 2.5 *10000000000000000000; //como o limite do double é muito grande eu exemplifiquei com essa multiplicação.
            decimal numDecimal = 22222222222222222222222222222.5m;
            float numFloat = 222222222222222222222222222222222222222.5f;
            double numeroVazio = double.NaN;

            //texto
            char caractere = 'a';//aceita apenas um caractere.
            string texto = "Exemplo de string"; //o limite de caracteres de uma string é aproximadamente 1.073.741.824.
            string vazio = null;// "null" define que uma variavel não contém nada (note que "null" é diferente de "undefiened, pois uma vairavel "undefiened" não existe no escopo).

            //lógico
            bool verdadeiro = true;// aceita os valores "true"(verdadeiro) e "false"(falso), no caso da programação de alto nivel (onde existe uma linguagem de programação intermedianto o programador
                                   //da linguagem de máquina) "true" significa que as condições foram cumpridas, e "false" que não foram cumpridas.

            //_____________________________|Tipos primitivos|_____________________________




            //_____________________________|Estruturas|_____________________________

            
            
            
            /*            
            Array:

            arrays (também conhecidos como matrizes) são conjuntos de dados com um tamanho pré definido de um tipo de valor. para criar um array você deve declara o tipo e o idendificador
            e depois criar uma nova intância desse tipo, por exemplo:

            int[] numeros = new int[5];

            onde:

            int     []        numeros       =                new                int            [n];
            tipo   indices      nome     atribuição    criar nova instância     tipo     tamanho do indice

            para acessar os valores de um array você deve referenciar o seu indice, por exemplo "numeros[0];" onde "numeros" é o nome do array e "[0]" é o indice.
            cada item(indice) de um array possui um valor próprio.
            */


            //array unidimensional
                //arrays unidimensionais são chamados assim pois possuem apenas um indice.

                int[] arrayUni = new int[3];// esta é uma forma de declarar arrays unidimensionais.
                arrayUni[0] = 1;
                arrayUni[1] = 2;
                arrayUni[2] = 3;

                int[] arrayUni2 = new int[3]{0, 1, 2};// esta é outra forma de declarar arrays unidimensionais.

            
            //array multidimensional
                //assim como os arrays unidimensionais, os arrays multidimensionais usam indices para acessar os valores, porém você pode determinar quantos indices o array vai ter.
                //você pode determinar quantos indices um array multidimensional vai ter usando "," na declaração, por exemplo: "int[,,] Array = new int[3,3,3];" é um exemplo de array tridimensional.
                //o array abaixo é um exemplo de array bidimensional, pois tem dois indices (ou dois eixos).
                int[,] arrayMulti = new int[3,3];//indices(x=3 y=3)
                arrayMulti[0,0] = 1;
                arrayMulti[0,1] = 2;// assim conseguimos este resultado:
                arrayMulti[0,2] = 3;//      ___________
                arrayMulti[1,0] = 4;//      |1   2   3|
                arrayMulti[1,1] = 5;//      |4   5   6|
                arrayMulti[1,2] = 6;//      |7   8   9|
                arrayMulti[2,0] = 7;//      -----------
                arrayMulti[2,1] = 8;
                arrayMulti[2,2] = 9;



            //array de array
                //como o próprio nome diz, o array de array guarda arrays ao invés de valores.
                //obs: os arrays que estão dentro do array devem ter o mesmo tipo e o mesmo número de indices.

                    int[][] arrayDeArray = new int[3][];
                    arrayDeArray[0] = new int[2];
                    arrayDeArray[1] = new int[4];
                    arrayDeArray[2] = new int[8];


            



            /*
            Stack:

            as stacks (também conhecidas como pilhas), são um tipo de estrutura de dados que trabalha com o principio LIFO ("Last In First Out"), ou seja o primeiro elemento a ser adicionado
            a uma stack será o ultimo a ser retirado.
            */

            //no c# utilizamos as palavras chave "<Stack>.Push(Conteudo);" para adicionar um item a stack, "<Stack>.Pop();" para retirar um item (pela ordem LIFO)
            //e "<Stack>.Peek();" para ler um item (pela ordem LiFO).

            //uma stack é criada assim no c#:

            Stack<string> pilha = new Stack<string>();// aqui criamos a stack, onde "Stack" é a palavra chave para criar uma stack, "<string>" é o tipo e "pilha" é o nome da stack
            //e então criamos uma nova instância da stack.


            pilha.Push("zézim");// adicionamos "zézim".
            pilha.Push("marcão");// adicionamos "marcão".
            pilha.Push("ana");// adicionamos "ana".

            pilha.Peek();// pegamos o valor "ana".
            pilha.Peek();// pegamos o valor "marcão".
            pilha.Peek();// pegamos o valor "zézim".

            pilha.Pop();// retiramos o item "ana" da stack.
            pilha.Pop();// retiramos o item "marcão" da stack.
            pilha.Pop();// retiramos o item "zézim" da stack.







            /*
            Queue:

            as queues (também conhecidas como filas) como o proprio nome diz, atuam como filas, utilizando o principio FIFO ("First In First Out"), ou seja o primeiro a entrar é o primeiro a sair
            */

            //no c# usamos as palavras reservadas "<Queue>Enqueue.(Conteudo);" para adicionar um item a fila, "<Queue>.Dequeue();" para retirar um item da fila (pela ordem FIFO)
            //e "<Queue>.Peek();" para ler o valor de um item (pela ordem FIFO).

            //no c# criamos uma queue assim:
            Queue<string> fila = new Queue<string>();// aqui criamos a queue, onde "Queue" é a palavra chave para criar uma queue, "<string>" é o tipo e "fila" é o nome da queue
            //e então criamos uma nova instância da queue.
       
            fila.Enqueue("zézim");// adicionamos "zézim"
            fila.Enqueue("marcão");// adicionamos "marcão"
            fila.Enqueue("ana");// adicionamos "ana"

            fila.Peek();// pegamos o valor "zézim"
            fila.Peek();// pegamos o valor "marcão"
            fila.Peek();// pegamos o valor "ana"

            fila.Dequeue();// retiramos o item "zézim"
            fila.Dequeue();// retiramos o item "marcão"
            fila.Dequeue();// retiramos o item "ana"




            /*
            List:

            As lists (também conhecidas como "listas") são estruturas de dados muito utilizadas. Elas armazenam os dados em um formato de lista (dado o nome).
            Basicamente, uma list é, na verdade, um conjunto de estruturas chamadas “nós”. Um nó é uma estrutura que armazena
            a informação a ser gerenciada por uma list.
            */

            //no c# criamos uma lista assim:

            List<string> lista = new List<string>();// aqui criamos a list, onde "List" é a palavra chave para criar uma list, "<string>" é o tipo e "lista" é o nome da list
            //e então criamos uma nova instância da list.

            //para adicionarmos um novo item na list fazemos assim:
            lista.Add("Buffa sona riot");
            lista.Add("nunca te pedi nada");
            lista.Add("kkkkkkkkkk");

            //para limparmos todos os valores da list fazemos assim:
            lista.Clear();

            //adicionado um valor para depois remover
            lista.Add("a");

            //para removermos um valor da list fazemos assim:
            lista.Remove("a");

            //adicionando os valores novamente
            lista.Add("Buffa sona riot");
            lista.Add("nunca te pedi nada");
            lista.Add("kkkkkkkkkk");


            //para acessarmos os itens da lista podemos utilizar um laço de repetição, como por exemplo o foreach:


            foreach(string frase in lista)
            {
                //aqui você pode usar os dados da lista como quiser
                //como mostrar na tela do console por exemplo:
                //Console.WriteLine(frase);
                //a saída disso seria:
                //
                //Buffa sona riot
                //nunca te pedi nada
                //kkkkkkkkkk
            }

            //obs: podemos usar laços de repetição para acessar os valores de qualquer estrutura de dados que possua mais de um valor



            /*
            Dictionary

            Um dicionário serve para criar um conjunto de chaves, semelhante aos arrays, a diferença é que ao invés de usar indices
            usamos um identificador que pode assumir qualquer valor.
            */

            //um dicionário recebe dois valores, sendo um seu indentificador e o outro o seu valor.

            //no c# criamos um dicionário assim:

            Dictionary<string, int> Pessoas = new Dictionary<string, int>();// como já expliquei nos outros casos, aqui declaramos e criamos uma instância.
            
            Pessoas.Add("ana", 15);// adicionamos uma chave "ana" com um valor 15
            Pessoas.Add("felipe", 10);// adiconamos uma chave "felipe" com um valor 10
            Pessoas.Add("marcos", 20);// adicionamos uma chave "marcos" com um valor 20

            Pessoas.Remove("marcos");// removemos a chave "marcos" do dicionário
            Pessoas.Clear();// removemos todas as chaves declaradas até o contexto atual
            Pessoas.Add("elizabeth II", 999999999);// adicionamos uma chave "elizabeth II" com um valor 999999999




            //_____________________________|Estruturas|_____________________________





            return $"{numInt}, {numShort}, {numLong}, {numDouble}, {numDecimal}, {numFloat}, {numeroVazio}, {caractere}, {texto}, {vazio}, {verdadeiro} ";
        }
    }

}
