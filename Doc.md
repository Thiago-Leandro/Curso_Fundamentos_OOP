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

~~~csharp
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

~~~csharp
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

~~~csharp
class Program
{
    static void Main()
    {
        // Usando o construtor padrão
        Carro carro1 = new Carro();
        Console.WriteLine($"Carro 1: Marca={carro1.Marca}, Modelo={carro1.Modelo}, Ano={carro1.Ano}");

        // Usando o construtor com parâmetros
        Carro carro2 = new Carro("Toyota", "Corolla", 2022);
        Console.WriteLine($"Carro 2: Marca={carro2.Marca}, Modelo={carro2.Modelo}, Ano={carro2.Ano}");
    }
}
~~~

Saída do Programa:

~~~csharp
Carro 1: Marca=Desconhecida, Modelo=Desconhecido, Ano=0
Carro 2: Marca=Toyota, Modelo=Corolla, Ano=2022
~~~

Neste exemplo, os construtores são usados para criar objetos da classe Carro com diferentes estados iniciais, dependendo de como são chamados. Isso demonstra a utilidade dos construtores para inicializar objetos com valores específicos e prepará-los para uso no programa.

### 7. A palavra this

1. Referência a Instância Atual
**this** é usada para se referir à instância atual da classe. Isso é particularmente útil quando os nomes dos parâmetros de método ou de construtor são iguais aos dos campos da classe.

~~~csharp
public class Pessoa
{
    private string nome;

    public Pessoa(string nome)
    {
        this.nome = nome; // 'this.nome' refere-se ao campo da classe, 'nome' refere-se ao parâmetro do construtor
    }

    public void SetNome(string nome)
    {
        this.nome = nome; // 'this.nome' refere-se ao campo da classe, 'nome' refere-se ao parâmetro do método
    }

    public void MostrarNome()
    {
        Console.WriteLine(this.nome); // 'this.nome' refere-se ao campo da classe
    }
}
~~~

2. Chamando Outros Construtores
this também pode ser usada para chamar outro construtor na mesma classe. Isso é conhecido como "constructor chaining".

~~~csharp
public class Pessoa
{
    private string nome;
    private int idade;

    public Pessoa(string nome) : this(nome, 0) // Chama o outro construtor
    {
    }

    public Pessoa(string nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
    }
}
~~~

3. Passando a Instância Atual como Parâmetro
this pode ser usado para passar a instância atual de uma classe como um argumento para um método.

~~~csharp
public class Exemplo
{
    public void Metodo1()
    {
        Metodo2(this); // Passa a instância atual para Metodo2
    }

    public void Metodo2(Exemplo ex)
    {
        // Trabalha com a instância passada
    }
}
~~~

4. Indexadores e Propriedades
this pode ser usado para definir indexadores em uma classe ou estrutura.

~~~csharp
public class MinhaColecao
{
    private string[] items = new string[100];

    public string this[int index]
    {
        get { return items[index]; }
        set { items[index] = value; }
    }
}
~~~

5. Métodos de Extensão
Nos métodos de extensão, this é usado para indicar qual tipo está sendo estendido.

~~~csharp
public static class ExtensoesString
{
    public static int ContarPalavras(this string str)
    {
        return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }
}
~~~

Com isso, você pode chamar o método de extensão como se fosse um método padrão do tipo string:

~~~csharp
string frase = "Olá, como você está?";
int numeroDePalavras = frase.ContarPalavras(); // Chama o método de extensão
~~~

 - **Resumo**:
A palavra-chave this é uma ferramenta poderosa em C# para referenciar a instância atual de uma classe ou estrutura, evitando ambiguidades, facilitando a chamada de construtores sobrecarregados e passando a instância atual como um parâmetro. Além disso, é essencial para criar métodos de extensão e definir indexadores.

### 8. Modificadores de Acesso

1. public
O modificador public torna o membro acessível a qualquer outra classe. Não há restrições de acesso.

~~~csharp
public class MinhaClasse
{
    public int meuCampo; // Acessível de qualquer lugar
}
~~~

2. private
O modificador private torna o membro acessível apenas dentro da própria classe. Este é o nível de acesso mais restritivo.

~~~csharp
public class MinhaClasse
{
    private int meuCampo; // Acessível apenas dentro de MinhaClasse
}
~~~

3. protected
O modificador protected torna o membro acessível dentro da própria classe e em classes derivadas (subclasses).

~~~csharp
public class MinhaClasseBase
{
    protected int meuCampo; // Acessível em MinhaClasseBase e em classes derivadas
}

public class MinhaClasseDerivada : MinhaClasseBase
{
    public void Metodo()
    {
        meuCampo = 5; // Acessível porque MinhaClasseDerivada deriva de MinhaClasseBase
    }
}
~~~

4. internal
O modificador internal torna o membro acessível apenas dentro do mesmo assembly (projeto).

~~~csharp
internal class MinhaClasse
{
    internal int meuCampo; // Acessível apenas dentro do mesmo assembly
}
~~~

5. protected internal
O modificador protected internal torna o membro acessível dentro do mesmo assembly e em classes derivadas, mesmo que essas classes estejam em um assembly diferente.

~~~csharp
public class MinhaClasse
{
    protected internal int meuCampo; // Acessível dentro do mesmo assembly ou em subclasses
}
~~~

6. private protected
O modificador private protected torna o membro acessível apenas dentro da própria classe ou em classes derivadas, mas apenas se essas classes derivadas estiverem no mesmo assembly.

~~~csharp
public class MinhaClasse
{
    private protected int meuCampo; // Acessível dentro da própria classe ou em subclasses no mesmo assembly
}
~~~

 - Resumo
Os modificadores de acesso em C# são fundamentais para controlar a visibilidade e o acesso aos membros de uma classe, ajudando a proteger os dados e a lógica interna da classe. Escolher o modificador de acesso apropriado é uma prática essencial de design orientado a objetos, garantindo que a interface pública de uma classe seja bem definida e que os detalhes internos permaneçam encapsulados.

### 9. Propriedades

Propriedades e Encapsulamento em C#

**Encapsulamento**

Encapsulamento é um dos quatro pilares da programação orientada a objetos (POO). Ele se refere à prática de esconder os detalhes internos de um objeto e só expor aquilo que é necessário para o uso do objeto. Isso é feito para proteger os dados e garantir que eles sejam manipulados de maneira controlada.

**Propriedades**

Propriedades em C# são uma forma de encapsular o acesso aos campos de uma classe. Elas permitem que você controle como os valores dos campos são definidos e recuperados, proporcionando um mecanismo para validar, modificar ou restringir o acesso aos dados.

Sintaxe Básica das Propriedades

Uma propriedade em C# é definida com get e set acessores. O get acessor é usado para retornar o valor da propriedade, e o set acessor é usado para atribuir um valor à propriedade.

~~~csharp
public class Pessoa
{
    private string nome; // Campo privado

    // Propriedade pública
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }
}
~~~

Propriedades Automáticas

Propriedades automáticas permitem que você defina propriedades rapidamente sem a necessidade de criar campos privados explicitamente. O compilador gera os campos automaticamente.

~~~csharp
public class Pessoa
{
    public string Nome { get; set; } // Propriedade automática
}
~~~

Propriedades Somente Leitura

Você pode criar propriedades que são somente leitura omitindo o acessor set.

~~~csharp
public class Pessoa
{
    private string nome;

    public Pessoa(string nome)
    {
        this.nome = nome;
    }

    public string Nome
    {
        get { return nome; }
    }
}
~~~

Propriedades Somente Escrita

Embora menos comum, você pode criar propriedades que são somente escrita omitindo o acessor get.

~~~csharp
public class Pessoa
{
    private string nome;

    public string Nome
    {
        set { nome = value; }
    }
}
~~~

Propriedades com Lógica

Você pode adicionar lógica nos acessores get e set para controlar o comportamento da propriedade.

~~~csharp
public class Pessoa
{
    private int idade;

    public int Idade
    {
        get { return idade; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Idade não pode ser negativa");
            idade = value;
        }
    }
}
~~~

Propriedades Calculadas

Propriedades calculadas não armazenam um valor, mas calculam o valor com base em outros campos.

~~~csharp
public class Retangulo
{
    public double Largura { get; set; }
    public double Altura { get; set; }

    public double Area
    {
        get { return Largura * Altura; }
    }
}
~~~

Encapsulamento com Propriedades

Ao encapsular campos com propriedades, você protege os dados da sua classe e pode implementar validações e lógica adicional para manter o estado do objeto consistente.

Exemplo Completo

Aqui está um exemplo completo que demonstra o uso de propriedades para encapsular dados e aplicar validação.

~~~csharp
public class ContaBancaria
{
    private decimal saldo;

    public decimal Saldo
    {
        get { return saldo; }
        private set
        {
            if (value < 0)
                throw new ArgumentException("Saldo não pode ser negativo");
            saldo = value;
        }
    }

    public void Depositar(decimal quantia)
    {
        if (quantia <= 0)
            throw new ArgumentException("A quantia deve ser positiva");
        Saldo += quantia;
    }

    public void Sacar(decimal quantia)
    {
        if (quantia <= 0)
            throw new ArgumentException("A quantia deve ser positiva");
        if (quantia > Saldo)
            throw new InvalidOperationException("Saldo insuficiente");
        Saldo -= quantia;
    }
}
~~~

 - Nesse exemplo, a propriedade Saldo é encapsulada e só pode ser modificada dentro da classe ContaBancaria, garantindo que o saldo não fique negativo e que operações inválidas não sejam realizadas.

 ### 10. Modelo de Domínio

Modelo de Domínio

Um modelo de domínio é uma representação conceitual dos dados e comportamentos de um sistema de software. Ele captura a lógica de negócios e as regras do domínio da aplicação.

O objetivo do modelo de domínio é criar uma compreensão compartilhada do problema que está sendo resolvido e fornecer uma base para a implementação do software.

Encapsulamento no Contexto do Modelo de Domínio

No contexto de um modelo de domínio, o encapsulamento é usado para garantir que a lógica de negócios e as regras do domínio sejam aplicadas corretamente. Isso é feito protegendo os campos de dados e expondo métodos e propriedades que implementam a lógica de negócios.

Exemplo Prático: Sistema de Gestão de Pedidos

Vamos considerar um exemplo de um sistema de gestão de pedidos. Aqui, encapsulamento e modelo de domínio serão aplicados para garantir a integridade dos dados e a lógica de negócios.

~~~csharp
using System;
using System.Collections.Generic;

public class Cliente
{
    public string Nome { get; private set; }
    public string Email { get; private set; }

    public Cliente(string nome, string email)
    {
        if (string.IsNullOrWhiteSpace(nome)) throw new ArgumentException("Nome é obrigatório");
        if (string.IsNullOrWhiteSpace(email)) throw new ArgumentException("Email é obrigatório");

        Nome = nome;
        Email = email;
    }
}

public class Produto
{
    public string Nome { get; private set; }
    public decimal Preco { get; private set; }

    public Produto(string nome, decimal preco)
    {
        if (string.IsNullOrWhiteSpace(nome)) throw new ArgumentException("Nome do produto é obrigatório");
        if (preco <= 0) throw new ArgumentException("Preço deve ser maior que zero");

        Nome = nome;
        Preco = preco;
    }
}

public class Pedido
{
    public Cliente Cliente { get; private set; }
    public DateTime DataPedido { get; private set; }
    private List<Produto> produtos;
    public IReadOnlyList<Produto> Produtos => produtos.AsReadOnly();

    public Pedido(Cliente cliente)
    {
        Cliente = cliente ?? throw new ArgumentNullException(nameof(cliente));
        DataPedido = DateTime.Now;
        produtos = new List<Produto>();
    }

    public void AdicionarProduto(Produto produto)
    {
        if (produto == null) throw new ArgumentNullException(nameof(produto));
        produtos.Add(produto);
    }

    public decimal CalcularTotal()
    {
        decimal total = 0;
        foreach (var produto in produtos)
        {
            total += produto.Preco;
        }
        return total;
    }
}
~~~

Explicação do Exemplo

**Classe Cliente:**

* Propriedades Nome e Email são privadas, garantindo que só possam ser definidas através do construtor, evitando a modificação direta.

* Validações são realizadas no construtor para garantir que o nome e o email não sejam nulos ou vazios.

**Classe Produto:**

* Propriedades Nome e Preco são privadas, garantindo que só possam ser definidas através do construtor, evitando a modificação direta.

* Validações são realizadas no construtor para garantir que o nome não seja nulo ou vazio e que o preço seja maior que zero.

**Classe Pedido:**

* A propriedade Cliente e a lista de Produtos são encapsuladas.
* A lista de Produtos é exposta como somente leitura (IReadOnlyList<Produto>).
* O método AdicionarProduto garante que produtos válidos sejam adicionados à lista.
* O método CalcularTotal calcula o total do pedido somando os preços dos produtos na lista.

**Benefícios do Encapsulamento no Modelo de Domínio**

* **Proteção dos Dados:** Campos privados protegem os dados internos das classes, garantindo que só sejam acessados e modificados através de métodos controlados.
* **Manutenção da Integridade:** Validações nos construtores e métodos garantem que os objetos do domínio estejam sempre em um estado válido.
* **Facilidade de Manutenção:** Alterações na lógica de negócios podem ser feitas em um único lugar (nos métodos da classe), sem a necessidade de modificar o código que utiliza essas classes.
C**lareza na Lógica de Negócios:** Métodos encapsulados dentro das classes do domínio deixam claro onde a lógica de negócios reside, facilitando a leitura e o entendimento do código.

**Conclusão**

O encapsulamento é uma prática essencial na modelagem de domínio, pois garante que a lógica de negócios seja aplicada corretamente e que os dados estejam protegidos contra acessos indevidos. Ao usar propriedades, métodos e construtores com validações, é possível criar um modelo de domínio robusto e de fácil manutenção.

### 12. Métodos e Sobrecarga de Métodos

**Métodos**

Métodos são blocos de código que realizam uma tarefa específica. Eles são definidos dentro de classes ou estruturas e podem ser chamados para executar ações, manipular dados, ou retornar valores. Em C#, um método é definido com um modificador de acesso, um tipo de retorno, um nome, e um conjunto de parâmetros opcionais.

~~~csharp
public class Calculadora
{
    // Método simples que soma dois números
    public int Somar(int a, int b)
    {
        return a + b;
    }
}
~~~

**Sobrecarga de Métodos**

A sobrecarga de métodos é a capacidade de definir vários métodos com o mesmo nome, mas com diferentes assinaturas (diferentes tipos de parâmetros, diferentes números de parâmetros, ou ambos). A sobrecarga permite que você use o mesmo nome de método para realizar diferentes operações, dependendo dos parâmetros fornecidos.

Exemplo de Sobrecarga de Métodos

~~~csharp
public class Calculadora
{
    // Sobrecarga de método Somar para somar dois números inteiros
    public int Somar(int a, int b)
    {
        return a + b;
    }

    // Sobrecarga de método Somar para somar três números inteiros
    public int Somar(int a, int b, int c)
    {
        return a + b + c;
    }

    // Sobrecarga de método Somar para somar dois números decimais
    public decimal Somar(decimal a, decimal b)
    {
        return a + b;
    }

    // Sobrecarga de método Somar para somar dois números double
    public double Somar(double a, double b)
    {
        return a + b;
    }
}
~~~

**Chamando Métodos Sobrecaregados**

Os métodos sobrecarregados são chamados com base na assinatura que corresponde aos argumentos passados na chamada.

~~~csharp
public class Programa
{
    public static void Main()
    {
        Calculadora calc = new Calculadora();
        
        int resultado1 = calc.Somar(2, 3); // Chama Somar(int, int)
        int resultado2 = calc.Somar(2, 3, 4); // Chama Somar(int, int, int)
        decimal resultado3 = calc.Somar(2.5m, 3.5m); // Chama Somar(decimal, decimal)
        double resultado4 = calc.Somar(2.5, 3.5); // Chama Somar(double, double)
        
        Console.WriteLine($"Resultado1: {resultado1}");
        Console.WriteLine($"Resultado2: {resultado2}");
        Console.WriteLine($"Resultado3: {resultado3}");
        Console.WriteLine($"Resultado4: {resultado4}");
    }
}
~~~

**Benefícios da Sobrecarga de Métodos**

* **Clareza:** Usar o mesmo nome de método para operações relacionadas torna o código mais legível e intuitivo.

* **Flexibilidade:** Permite que métodos realizem operações semelhantes em diferentes tipos de dados ou diferentes números de argumentos.

* **Manutenção:** Facilita a manutenção do código, pois operações semelhantes são agrupadas sob um mesmo nome de método.

**Restrições na Sobrecarga de Métodos**

* **Assinaturas Diferentes:** Os métodos sobrecarregados devem ter assinaturas diferentes. Apenas diferentes tipos ou números de parâmetros podem ser usados para distingui-los.

* **Modificadores de Acesso:** A sobrecarga não pode ser feita apenas com modificadores de acesso diferentes.

* **Tipos de Retorno:** O tipo de retorno não é considerado parte da assinatura do método, então não é possível sobrecarregar métodos apenas mudando o tipo de retorno.

**Conclusão**
A sobrecarga de métodos é uma característica poderosa de C# que permite que desenvolvedores criem métodos flexíveis e reutilizáveis. Ao definir vários métodos com o mesmo nome, mas com diferentes assinaturas, você pode simplificar a interface de suas classes e melhorar a clareza do código. Lembre-se de sempre garantir que as assinaturas dos métodos sobrecarregados sejam distintas para evitar conflitos e ambiguidades.

### 13. Métodos : Parâmetros Opcionais

**Parâmetros Opcionais**

Parâmetros opcionais permitem que você defina valores padrão para parâmetros em um método. Se o chamador do método não fornecer um argumento para um parâmetro opcional, o valor padrão será usado. Isso simplifica a chamada de métodos e permite maior flexibilidade na forma como os métodos são invocados.

**Definindo Parâmetros Opcionais**
Para definir um parâmetro opcional, você atribui um valor padrão a ele na assinatura do método.

~~~csharp
public class Mensagem
{
    public void Mostrar(string texto, int vezes = 1)
    {
        for (int i = 0; i < vezes; i++)
        {
            Console.WriteLine(texto);
        }
    }
}
~~~

Neste exemplo, o parâmetro vezes é opcional e tem um valor padrão de 1. Isso significa que, se o chamador não fornecer um valor para vezes, ele será considerado como 1.

**Chamando Métodos com Parâmetros Opcionais**

Você pode chamar o método com ou sem fornecer um valor para o parâmetro opcional.

~~~csharp
public class Programa
{
    public static void Main()
    {
        Mensagem msg = new Mensagem();
        
        // Chamada usando o valor padrão do parâmetro opcional
        msg.Mostrar("Olá, mundo!");

        // Chamada fornecendo um valor para o parâmetro opcional
        msg.Mostrar("Olá, mundo!", 3);
    }
}
~~~

**Vários Parâmetros Opcionais**

Você pode definir vários parâmetros opcionais em um método. No entanto, todos os parâmetros opcionais devem estar à direita dos parâmetros obrigatórios na assinatura do método.

~~~csharp
public class Logger
{
    public void Log(string mensagem, string nivel = "INFO", DateTime? data = null)
    {
        data ??= DateTime.Now;
        Console.WriteLine($"{data:yyyy-MM-dd HH:mm:ss} [{nivel}] {mensagem}");
    }
}
~~~

Neste exemplo, nivel e data são parâmetros opcionais. O valor padrão de data é definido usando a sintaxe de atribuição condicional (??=).

**Chamando Métodos com Vários Parâmetros Opcionais**

Você pode fornecer argumentos para quaisquer combinações de parâmetros opcionais. Se omitir os argumentos para alguns parâmetros, os valores padrão serão usados.

~~~csharp
public class Programa
{
    public static void Main()
    {
        Logger logger = new Logger();
        
        // Usando valores padrão para ambos os parâmetros opcionais
        logger.Log("Iniciando a aplicação");

        // Fornecendo valor apenas para o primeiro parâmetro opcional
        logger.Log("Conectando ao banco de dados", "DEBUG");

        // Fornecendo valores para ambos os parâmetros opcionais
        logger.Log("Erro de conexão", "ERROR", DateTime.Now);
    }
}
~~~

**Benefícios dos Parâmetros Opcionais**

* **Simplificação da Chamada de Métodos:** Reduz a necessidade de definir várias sobrecargas de método para diferentes números de parâmetros.

* **Clareza e Legibilidade:** Torna o código mais claro e legível, mostrando claramente quais valores são opcionais.

* **Flexibilidade:** Permite maior flexibilidade na chamada de métodos, proporcionando valores padrão quando nenhum argumento é fornecido.

**Considerações e Melhores Práticas**

* **Ordens dos Parâmetros:** Coloque todos os parâmetros opcionais após os parâmetros obrigatórios na assinatura do método.

* **Valores Padrão Razoáveis:** Use valores padrão que façam sentido no contexto do método e que reduzam a necessidade de fornecer explicitamente esses valores na maioria dos casos.

* **Documentação:** Documente claramente os valores padrão dos parâmetros opcionais para que os usuários do método entendam seu comportamento.

**Conclusão**
Os parâmetros opcionais são uma funcionalidade poderosa em C# que simplifica a definição e a chamada de métodos. Eles permitem que você forneça valores padrão para parâmetros, reduzindo a necessidade de múltiplas sobrecargas de método e aumentando a flexibilidade e clareza do código. Quando usados corretamente, os parâmetros opcionais tornam o código mais intuitivo e fácil de manter.