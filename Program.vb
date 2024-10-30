Imports System

Module Program  ' Classe Program

    Sub Main(args As String())   ' Metodo Main da classe program que usa uma string como argumento. O método que é chamado automaticamente pelo runtime quando ele inicia o aplicativo
        Console.WriteLine("Informe seu nome:")                     ' Quaisquer argumentos de linha de comando fornecidos quando o aplicativo for iniciado estão disponíveis na matriz args
        Dim name = Console.ReadLine()
        Dim currentDate = DateTime.Now
        Console.WriteLine($"{vbCrLf}Olá, {name}, agora é {currentDate:d} às {currentDate:t}")
        Console.Write($"{vbCrLf}Pressione qualquer tecla para sair...")     ' vbCrLf quebra linha
        Console.ReadKey(True)
    End Sub

End Module
