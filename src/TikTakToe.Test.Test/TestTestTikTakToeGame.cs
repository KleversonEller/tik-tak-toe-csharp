using Xunit;
using System.IO;
using System;
using FluentAssertions;
using TikTakToe.Test;

namespace TikTakToe.Test.Test;

public class TestTestTikTakToeGame1
{
    [Trait("Category", "1 - Criou testes de sucesso para o makeMove.")]
    [Theory(DisplayName = "TestMakeMove deve preencher o tabuleiro com o caractere correto na posição adequada")]
    [InlineData(
        1,
        1,
        'x',
        new char[] {
            ' ', ' ', ' ',
            ' ', 'x', ' ',
            ' ', ' ', ' '
        }
    )]
    public void TestSuccessTestMakeMove(int line, int column, char player, char[] expected)
    {
        TestTikTakToeGame instance = new();
        Action act = () => instance.TestMakeMove(line, column, player, expected);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}


public class TestTestTikTakToeGame2
{
    [Trait("Category", "2 - Criou testes de falha para o makeMove.")]
    [Theory(DisplayName = "TestMakeMove deve falhar se a entrada for inválida")]
    [InlineData(
        1,
        1,
        'x',
        new char[] {
            ' ', ' ', ' ',
            ' ', 'o', ' ',
            ' ', ' ', 'x'
        }
    )]
    public void TestFailTestMakeMove(int line, int column, char player, char[] expected)
    {
        TestTikTakToeGame instance = new();
        Action act = () => instance.TestMakeMove(line, column, player, expected);
        act.Should().Throw<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}

public class TestTestTikTakToeGame3
{
    [Trait("Category", "3 - Criou testes de sucesso para printBoard.")]
    [Theory(DisplayName = "TestPrintBoard deve dar sucesso caso a entrada seja válida")]
    [InlineData(new object[] {
        new char[] {'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x'},
        new string[] {
            "x x x",
            "x x x",
            "x x x"
        }
    })]
    public void TestSuccessTestPrintBoard(char[] entry, string[] expected)
    {
        TestTikTakToeGame instance = new();
        Action act = () => instance.TestPrintBoard(entry, expected);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}

public class TestTestTikTakToeGame4
{
    [Trait("Category", "4 - Criou testes de falha para o printBoard.")]
    [Theory(DisplayName = "TestPrintBoard deve falhar se a entrada for inválida")]
    [InlineData(new object[] {
        new char[] {'x', 'o', 'x', 'x', 'x', 'x', 'x', 'o', 'x'},
        new string[] {
            "x x x",
            "x x x",
            "x x x"
        }
    })]
    public void TestFailTestPrintBoard(char[] entry, string[] expected)
    {
        TestTikTakToeGame instance = new();
        Action act = () => instance.TestPrintBoard(entry, expected);
        act.Should().Throw<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}

public class TestTestTikTakToeGame5
{
    [Trait("Category", "5 - Criou os testes de sucesso para isGameOver.")]
    [Theory(DisplayName = "TestIsGameOver deve dar sucesso caso a entrada seja válida")]
    [InlineData(
        new char[] {
            'x', 'x', 'x',
            'x', 'x', 'x',
            'x', 'x', 'x'
        },
        'x',
        true
    )]
    public void TestSuccessTestIsGameOver(char[] entry, char expectedWinner, bool expectedReturn)
    {
        TestTikTakToeGame instance = new();
        Action act = () => instance.TestIsGameOver(entry, expectedWinner, expectedReturn);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}

public class TestTestTikTakToeGame6
{
    [Trait("Category", "6 - Criou os testes de falha para isGameOver.")]
    [Theory(DisplayName = "TestIsGameOver deve falhar se a entrada for inválida")]
    [InlineData(
        new char[] {
            'x', 'x', 'x',
            'x', 'x', 'x',
            'x', 'x', 'x'
        },
        'o',
        false
    )]
    public void TestFailTestIsGameOver(char[] entry, char expectedWinner, bool expectedReturn)
    {
        TestTikTakToeGame instance = new();
        Action act = () => instance.TestIsGameOver(entry, expectedWinner, expectedReturn);
        act.Should().Throw<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}

public class TestTestTikTakToeGame7
{
    [Trait("Category", "7 - Criou os testes de sucesso para printResults.")]
    [Theory(DisplayName = "TestPrintResults deve dar sucesso caso a entrada seja válida")]
    [InlineData(' ', "Empate! Deu Velha!")]
    public void TestSuccessTestPrintResults(char entry, string expected)
    {
        TestTikTakToeGame instance = new();
        Action act = () => instance.TestPrintResults(entry, expected);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}

public class TestTestTikTakToeGame8
{
    [Trait("Category", "8 - Criou os testes de falha para printResults.")]
    [Theory(DisplayName = "TestPrintResults deve falhar se a entrada for inválida")]
    [InlineData('x', "Empate! Deu Velha!")]
    public void TestFailTestPrintResults(char entry, string expected)
    {
        TestTikTakToeGame instance = new();
        Action act = () => instance.TestPrintResults(entry, expected);
        act.Should().Throw<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}
