# Reflection parte 1: Metadados do seu código .NET

## Objetivos ao completar os estudos

- Torne seu código C# dinâmico
- Use recursos da linguagem que facilitam o uso de Reflection
- Entenda a tecnologia usada por trás do AspNET, EntityFramework, AutoMapper, etc.
- Veja como são representados Tipos, Métodos, Propriedades e Interfaces no .NET
- Descomplique seu código por meio de convenções e Reflection

## Ementas:

### Iniciando Aplicação
- Começando o nosso projeto
- Projeto inicial
- Escrevendo o código de suporte http
- Conhecendo nosso Assembly
- Trabalhando com o GetExecutingAssembly
- Trabalhando com Embedded Resources
- Embedded Resources e Streams
- Dando o pontapé no portal ByteBank

### Usando Assembly dinamicamente e convenções
- Criando convenções para acessar nosso assembly
- Como um recurso é localizado no Assembly .NET
- Convenção de nome de recursos no assembly .NET
- Criando nossa controller
- Usando as Actions de nossa controller
- Como obter um Stream de recurso em nosso Assembly
- Criando manipulador de requisições!

### Invocando métodos dinamicamente
- Criando manipuladores de requisição
- Criando instancias e invocando métodos dinamicamente
- Usando o Activator
- O tipo ObjectHandle
- CallerMemberNameAttribute
- Informações do método de chamada
- O comportamento do CallerMemberName
- Desenvolvendo a ControllerBase e o ManipuladorRequisicaoController!

### Trabalhando com sobrecargas de métodos
- Criando rotas parametrizaveis
- Traduzindo nossas URLs
- Lidando com sobrecarga e BindingFlags
- Operadores bit-a-bit e o BindingFlags
- GetMethod e GetMethods
- BindingFlags
- Type::GetMethods()
- Realizando testes no LinqPAD

### Invocando métodos com assinaturas complexas dinamicamente
- Recuperando sobrecargas
- Parâmetros de uma sobrecarga
- Sobrecargas com propriedades automáticas
- Encapsulando nosso MethodInfo
- Ordenando os parâmetros
- Ordenando parâmetros
- Projeto final do curso
- Conclusão
- Implementando suporte a várias sobrecargas