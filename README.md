# Reflection parte 1: Metadados do seu c�digo .NET

## Objetivos ao completar os estudos

- Torne seu c�digo C# din�mico
- Use recursos da linguagem que facilitam o uso de Reflection
- Entenda a tecnologia usada por tr�s do AspNET, EntityFramework, AutoMapper, etc.
- Veja como s�o representados Tipos, M�todos, Propriedades e Interfaces no .NET
- Descomplique seu c�digo por meio de conven��es e Reflection

## Ementas:

### Iniciando Aplica��o
- Come�ando o nosso projeto
- Projeto inicial
- Escrevendo o c�digo de suporte http
- Conhecendo nosso Assembly
- Trabalhando com o GetExecutingAssembly
- Trabalhando com Embedded Resources
- Embedded Resources e Streams
- Dando o pontap� no portal ByteBank

### Usando Assembly dinamicamente e conven��es
- Criando conven��es para acessar nosso assembly
- Como um recurso � localizado no Assembly .NET
- Conven��o de nome de recursos no assembly .NET
- Criando nossa controller
- Usando as Actions de nossa controller
- Como obter um Stream de recurso em nosso Assembly
- Criando manipulador de requisi��es!

### Invocando m�todos dinamicamente
- Criando manipuladores de requisi��o
- Criando instancias e invocando m�todos dinamicamente
- Usando o Activator
- O tipo ObjectHandle
- CallerMemberNameAttribute
- Informa��es do m�todo de chamada
- O comportamento do CallerMemberName
- Desenvolvendo a ControllerBase e o ManipuladorRequisicaoController!

### Trabalhando com sobrecargas de m�todos
- Criando rotas parametrizaveis
- Traduzindo nossas URLs
- Lidando com sobrecarga e BindingFlags
- Operadores bit-a-bit e o BindingFlags
- GetMethod e GetMethods
- BindingFlags
- Type::GetMethods()
- Realizando testes no LinqPAD

### Invocando m�todos com assinaturas complexas dinamicamente
- Recuperando sobrecargas
- Par�metros de uma sobrecarga
- Sobrecargas com propriedades autom�ticas
- Encapsulando nosso MethodInfo
- Ordenando os par�metros
- Ordenando par�metros
- Projeto final do curso
- Conclus�o
- Implementando suporte a v�rias sobrecargas