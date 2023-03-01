using Xunit;
using System.IO;
using System;
using TikTakToe;
using FluentAssertions;

namespace TikTakToe.Test;

[Collection("Sequential")]
public class TestTikTakToeGame
{
    [Theory(DisplayName = "Deve preencher o tabuleiro com o caractere correto na posição adequada")]
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
    public void TestMakeMove(int lineEntry, int columnEntry, char playerEntry, char[] expected)
    {
        TikTakToeGame result = new();

        result.makeMove(lineEntry, columnEntry, playerEntry);

        result.board.Should().BeEquivalentTo(fromArrayToMultiDimArray(expected, 3, 3));
    }
    
    [Theory(DisplayName = "Deve imprimir o tabuleiro")]
    [InlineData(
        new char[] {
            'x', 'x', 'x',
            'x', 'x', 'x',
            'x', 'x', 'x'
        },
        new string[] {
            "x x x",
            "x x x",
            "x x x"
        }
    )]
    public void TestPrintBoard(char[] entry, string[] expected)
    {
        TikTakToeGame result = new()
        {
            board = fromArrayToMultiDimArray(entry, 3, 3)
        };

        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        result.printBoard();

        stringWriter.ToString().Trim().Should().Be(string.Join(" ",expected));
    }

    [Theory(DisplayName = "Deve retornar corretamente se o jogo acabou ou não")]
    [InlineData(
        new char[] {
            'x', 'x', 'x',
            'x', 'x', 'x',
            'x', 'x', 'x'
        },
        'x',
        true
    )]
    public void TestIsGameOver(char[] entry, char expectedWinner, bool expectedReturn)
    {
        TikTakToeGame instance = new()
        {
            board = fromArrayToMultiDimArray(entry, 3, 3)
        };

        bool result = instance.isGameOver();

        instance.winner.Should().Be(expectedWinner);
        result.Should().Be(expectedReturn);
    }

    [Theory(DisplayName = "Deve imprimir o vencedor correto do jogo")]
    [InlineData(' ', "Empate! Deu Velha!")]
    public void TestPrintResults(char entry, string expected)
    {
        TikTakToeGame result = new()
        {
            winner = entry
        };

        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        result.printResults();

        stringWriter.ToString().Trim().Should().Be(expected);
    }

    public static char[,] fromArrayToMultiDimArray(char[] array, int lines, int columns)
    {
        char[,] result = new char[lines, columns];
        for (int i = 0; i < array.Length; i++)
        {
            result[i / columns, i % columns] = array[i];
        }
        return result;
    }
}
