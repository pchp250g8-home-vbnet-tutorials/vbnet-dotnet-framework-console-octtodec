Imports System.Text.RegularExpressions

Module Module1

	Sub Main()
		Const MAX_INT = UInteger.MaxValue
		Dim nDecNum = 0
		Dim nOctPower = 1
		Dim nMaxOctalLen = Math.Ceiling(Math.Log(MAX_INT, 8))
		Dim oRegEx = New Regex("^[0-7]+$")
		Console.WriteLine("Input an octal number")
		Dim strLine = Console.ReadLine()
		Dim nStrLen = strLine.Length
		Dim bIsMatch = oRegEx.IsMatch(strLine)
		Dim bRightString = (nStrLen <= nMaxOctalLen) AndAlso bIsMatch
		If Not bRightString Then
			Console.WriteLine("Wrong octal number format!!!")
			Console.Read()
			Return
		End If
		For i As Integer = 0 To nStrLen - 1
			Dim nBinDight As Integer = AscW(strLine.Chars(nStrLen - 1 - i)) - AscW("0"c)
			nDecNum += (nBinDight * nOctPower)
			nOctPower *= 8
		Next i
		Console.WriteLine("The decimal equivalent of the octal number {0} is {1}", strLine, nDecNum)
		Console.Read()
	End Sub

End Module
