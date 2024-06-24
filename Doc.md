# POO - Porgramação Orientada a objetos 

## 4. O paradigma da Programação Orientada a Objetos - POO

A **Porgramação Orientada a Objetos** é uma abordagem de projeto em que pensamos em termos de objetos do mundo real, em vez de funções ou métodos.

  - Enquanto a **programação procedural ou estruturada** trata de **escrever procedimentos ou funções** que executam operações nos dados, a programação orientada a objetos trata de criar **objetos que cotêm dados e métodos.**
  
  - Na POO os programas são organizados em torno de objetos e dados, em vez de **ações e procedimentos.**
  
  - O **objetivo** do paradgma da Programação orientada a objetos é refletir na estutura do software e a vida real do problema que o software busca resolver.

### Os princípios básicos da Programação Orientada a Objetos
 1. Encapsulamento:
    * Encapsulamento é o conceito de agrupar dados (atributos) e métodos (comportamentos) que operam nesses dados em uma única unidade, chamada de classe. Isso garante que os detalhes internos de como um objeto realiza suas funções sejam ocultos do mundo exterior e só possam ser acessados por métodos designados.
  
 2. Herança:
   * Herança permite que uma classe (subclasse) herde características (atributos e métodos) de outra classe (superclasse). Isso promove a reutilização de código e a extensibilidade do sistema, permitindo que novas classes compartilhem características de classes existentes.
  
 3. Polimorfismo:
    * Polimorfismo significa a capacidade de um objeto poder ser referenciado de várias formas. Em POO, isso pode ocorrer de duas maneiras: polimorfismo de sobrecarga (métodos com o mesmo nome, mas com diferentes parâmetros) e polimorfismo de sobreposição (métodos em classes diferentes que fornecem comportamentos diferentes para métodos com a mesma assinatura).
  
 4. Abstração: 
   * Abstração envolve a capacidade de focar nos aspectos essenciais de um objeto ou conceito, ignorando detalhes menos importantes. Na POO, isso se traduz na criação de classes que representam entidades com características e comportamentos relevantes para o sistema, ocultando os detalhes de implementação.
  
 5. Associação:
    * Associação é um relacionamento entre classes onde uma classe é conectada a outra por meio de seus objetos. Pode ser um relacionamento "tem-um" (exemplo: um carro tem um motor) ou "tem-muitos" (exemplo: um departamento tem muitos funcionários).
  
6. Agregação e Composição:
   * Agregação e composição são formas específicas de associação. Agregação implica que um objeto pode pertencer a vários outros objetos (relacionamento "tem-muitos"), enquanto composição implica que um objeto é composto de outros objetos (relacionamento "todo-parte"), e sua existência depende da existência desses objetos.

## 5. Classes e Objetos

### Na Programação Orientada a Objetos (POO), os conceitos de classes, objetos, atributos e comportamentos são fundamentais para entender como os sistemas são modelados e implementados. Vamos explicar cada um desses conceitos:

1. Classe:
    * Uma classe é um modelo ou um plano para criar objetos. Ela define um conjunto de atributos (dados) e métodos (funções) que os objetos criados a partir dela vão possuir. Por exemplo, uma classe Carro pode ter atributos como cor, marca, modelo e métodos como ligar(), desligar(), acelerar().
  
2. Objeto:
    * Um objeto é uma instância concreta de uma classe. É criado a partir da classe e possui seus próprios valores para os atributos definidos na classe. Por exemplo, a partir da classe Carro, podemos criar objetos específicos como um Carro vermelho da marca Toyota.

3. Atributos:
    * Atributos são as características de um objeto. Eles são variáveis que armazenam dados específicos para cada objeto criado a partir da classe. No contexto de um carro, os atributos poderiam ser cor, marca, modelo, ano, entre outros. Cada objeto terá seus próprios valores para esses atributos.

4. Comportamentos (métodos):
    * Comportamentos são as ações que os objetos podem realizar. Em POO, esses comportamentos são definidos por métodos na classe. Por exemplo, um método ligar() na classe Carro pode alterar o estado do carro para ligado, enquanto um método acelerar() pode aumentar a velocidade do carro.

#### Exemplo Simples
Vamos ilustrar esses conceitos com um exemplo simples em pseudo-código:

~~~
// Definição da classe Carro
classe Carro {
    // Atributos da classe Carro
    cor
    marca
    modelo

    // Método construtor da classe Carro
    método construtor(cor, marca, modelo) {
        this.cor = cor
        this.marca = marca
        this.modelo = modelo
    }

    // Método ligar() da classe Carro
    método ligar() {
        // Implementação para ligar o carro
        imprimir("Carro ligado")
    }

    // Método acelerar() da classe Carro
    método acelerar() {
        // Implementação para acelerar o carro
        imprimir("Carro acelerando")
    }
}

// Criando objetos da classe Carro
carro1 = novo Carro("vermelho", "Toyota", "Corolla")
carro2 = novo Carro("azul", "Honda", "Civic")

// Usando os objetos criados
carro1.ligar()    // Saída: Carro ligado
carro2.acelerar()  // Saída: Carro acelerando

~~~

Neste exemplo:
 * Carro é a classe que define os atributos (cor, marca, modelo) e métodos (ligar(), acelerar()).
 * carro1 e carro2 são objetos específicos criados a partir da classe Carro, cada um com seus próprios valores para os atributos (cor, marca, modelo).
 * Os métodos ligar() e acelerar() são comportamentos que os objetos carro1 e carro2 podem realizar, alterando seu estado ou comportamento.

Esses conceitos de classes, objetos, atributos e comportamentos formam a base da Programação Orientada a Objetos, permitindo uma modelagem mais próxima do mundo real e facilitando a organização e manutenção de sistemas de software complexos.

### 6. Construtor

Em programação orientada a objetos, um construtor é um método especial dentro de uma classe que é automaticamente chamado quando um objeto dessa classe é instanciado (criado). O principal objetivo de um construtor é inicializar os atributos do objeto com valores específicos ou realizar outras operações necessárias para preparar o objeto para uso.

#### Características dos Construtores:
1. Nome do Método: O nome do construtor é sempre o mesmo nome da classe onde ele está definido.
2. Inicialização de Atributos: Os construtores são frequentemente usados para inicializar os atributos do objeto com valores iniciais, muitas vezes passados como parâmetros durante a criação do objeto.
3. Chamada Automática: Um construtor é chamado automaticamente quando o objeto é instanciado com a palavra-chave new.
4. Sobrecarga: Assim como outros métodos, os construtores podem ser sobrecarregados, o que significa que você pode ter vários construtores com diferentes listas de parâmetros. Isso permite criar objetos de diferentes maneiras, dependendo das necessidades do programa.

#### Exemplo de Construtor em C#:
Aqui está um exemplo simples em C# de uma classe Carro que possui um construtor para inicializar os atributos marca, modelo e ano.

~~~
public class Carro
{
    // Atributos da classe Carro
    private string marca;
    private string modelo;
    private int ano;

    // Construtor padrão sem parâmetros
    public Carro()
    {
        marca = "Desconhecida";
        modelo = "Desconhecido";
        ano = 0;
    }

    // Construtor com parâmetros para inicializar marca, modelo e ano
    public Carro(string marca, string modelo, int ano)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.ano = ano;
    }

    // Métodos para acessar os atributos (getters e setters), omitidos aqui por simplicidade
}
~~~

#### Explicação do Exemplo:
* Classe Carro: Define uma classe simples que representa um carro com atributos marca, modelo e ano.
* Construtores:
  * Construtor padrão: Não possui parâmetros e é usado para inicializar os atributos com valores padrão ("Desconhecida", "Desconhecido", 0).
  * Construtor com parâmetros: Aceita três parâmetros (marca, modelo, ano) para inicializar os atributos com valores específicos passados durante a criação do objeto.
* **this:** É usado dentro do construtor com parâmetros para diferenciar entre os nomes dos parâmetros e os nomes dos atributos da classe. Por exemplo, this.marca se refere ao atributo marca da classe Carro, enquanto marca se refere ao parâmetro passado para o construtor.
  
#### Uso dos Construtores:

~~~
class Program
{
    static void Main()
    {
        // Usando o construtor padrão
        Carro carro1 = new Carro();
        Console.WriteLine($"Carro 1: Marca={carro1.Marca}, Modelo={carro1.Modelo}, Ano={carro1.Ano}");

        // Usando o construtor com parâmetrosgit pull
        Carro carro2 = new Carro("Toyota", "Corolla", 2022);
        Console.WriteLine($"Carro 2: Marca={carro2.Marca}, Modelo={carro2.Modelo}, Ano={carro2.Ano}");
    }
}
~~~

Saída do Programa:

~~~
Carro 1: Marca=Desconhecida, Modelo=Desconhecido, Ano=0
Carro 2: Marca=Toyota, Modelo=Corolla, Ano=2022
~~~
Neste exemplo, os construtores são usados para criar objetos da classe Carro com diferentes estados iniciais, dependendo de como são chamados. Isso demonstra a utilidade dos construtores para inicializar objetos com valores específicos e prepará-los para uso no programa.