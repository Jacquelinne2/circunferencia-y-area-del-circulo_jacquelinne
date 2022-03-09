Imports System

Module Program
	Sub Main()
		Console.Title = "Jacquelinne"
		Dim selec As String
		selec = "S"
		While (selec = "S" Or selec = "s")
			Dim longi, area As Double
			Dim r, a As Double
			Dim opcion As Integer
			Console.WriteLine("Selecciona la accion que quieres realizar: ")
			Console.WriteLine("1 ------ calcular la longitud de una circunferencia.")
			Console.WriteLine("2 ------ calcular el area de un circulo")
			opcion = Console.ReadLine()

			If (opcion = 1) Then
				Console.WriteLine("Ingresa el valor del radio de la circunferencia:")
				r = Console.ReadLine
				longi = 2 * 3.1416 * r
				Console.WriteLine("El valor de la longitud de la circunferencia es: " & longi)
			ElseIf (opcion = 2) Then
				Console.WriteLine("Ingresa el valor del radio del circulo:")
				a = Console.ReadLine()
				area = 3.1416 * a * a

				Console.WriteLine("El valor del area del circulo es: " & area)
			End If
			Console.WriteLine("Desea realizar otra accion ingrese 's': ")
			selec = Console.ReadLine()
		End While
	End Sub
End Module
