// Escribe un programa quie solicite al usuario el radio (R) de un
// circulo y calcule el área (A) y el perimetro (P) del circulo
// en base a dicho parametro. Las formulas para el calculo del area y el
// perimetro de un circulo son las siguientes:
// A = piR^2
// P = 2piR

Algoritmo RadioCirculo
	Definir radio Como Real
	Escribir "Escribe el radio del circulo: "
	Leer radio
	area <- radio * radio * pi
	perimetro <- 2 * pi * radio
	Escribir "Radio: " + ConvertirATexto(radio)
	Escribir "Area: " + ConvertirATexto(area)
	Escribir "Perimetro" + ConvertirATexto(perimetro)
FinAlgoritmo
