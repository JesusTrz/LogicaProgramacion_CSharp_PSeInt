// Escribe un programa que solicite dos números al usuario y que muestre en la consola
// el resultado de la suma, resta, multiplicacion y division
// entre ambos numeros

Algoritmo PrimerEjercicio
	Escribir "Escribe un numero"
	Leer num1
	Escribir "Escribe tu segundo numero"
	Leer num2
	
	suma <- num1 + num2
	Escribir "Resultado de la suma: " + ConvertirATexto(suma)
	
	resta <- num1 - num2
	Escribir  "Resultado de la resta: " + ConvertirATexto(resta)
	
	multiplicacion <- num1 * num2
	Escribir  "Resultado de la multiplicacion: " + ConvertirATexto(multiplicacion)
	
	division <- num1 / num2
	Escribir  "Resultado de la division: " + ConvertirATexto(division)
FinProceso
