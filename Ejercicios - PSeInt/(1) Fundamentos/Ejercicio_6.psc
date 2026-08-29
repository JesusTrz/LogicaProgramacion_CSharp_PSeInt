// Escribe un programa que solicite una temperatura al usuario en Celsius (C)
// y m,uestre la conversion a Fahrenheit (F) y Kelvin (K)
// Las conversiones de Celsius a Fahrenheit y Kelvin son las siguientes:
// F = 9/5 C + 32
// K = C + 273.15

Algoritmo ConversionTemperaturas
	Definir C Como Real // C = Celsius
	Escribir "Escribe tu temperatura en Celsius"
	Leer C
	F <- 9/5 * C + 32 // F = Fahrenheit
	K <- C + 273.15 // K = Kelvin
	Escribir "Celsius: " + ConvertirATexto(C)
	Escribir "Celsius a Fahrenheit: " + ConvertirATexto(F)
	Escribir "Celsius a Kelvin: " + ConvertirATexto(K)
FinAlgoritmo
