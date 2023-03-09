# **Contexto do projeto**

Criando o jogo Tik-Tak-Toe (Jogo da velha no brasil) em C#, a aplicação é uma aplicação de console .NET C#, a aplicação também conta com testes unitários.

## **Stacks utilizadas no projeto**

Foi utilizado o .NET Core na versão 6.0
<br/>
A biblioteca de testes xUnit e a Fluent Assertions
<br/>

## **Como iniciar o projeto localmente**

Caso queira iniciar o projeto localmente devera ter instalado o .NET 6.0 e seguir os seguintes passos:
<br/>
Primeiro clone o projeto:
<br/>

```sh
git clone git@github.com:KleversonEller/tik-tak-toe-csharp.git
```
<br/>

Em seguida entre na pasta do projeto e utilize o seguinte comando para instalar as dependências do projeto:
<br/>

```sh
cd tik-tak-toe-csharp/src
dotnet restore
```
<br/>

Para rodar o jogo utilize o seguinte comando:
(Obs: por ser uma aplicação de console e não ter sido feito um tratamento na exibição das linhas o jogo nao terá uma aparência amigável).
<br/>

```sh
cd tik-tak-toe-csharp/src/TikTakToe
dotnet run
```

<br/>

Caso queira executar os testes basta utilizar:
<br/>

```sh
cd tik-tak-toe-csharp/src
dotnet test
```
