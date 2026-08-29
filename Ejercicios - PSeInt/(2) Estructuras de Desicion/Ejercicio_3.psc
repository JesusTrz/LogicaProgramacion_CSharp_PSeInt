// Escribe un programa que diga si un número está dentro o fuera de rango.
// EL usuario introducirá el límite inferior y superior del rango y el número que se desea comprobar
// Ejemplo:
// Rango: [2 , 5]
// Numero: 3 -> Dentro del rango
// Numero: 7 -> Fuera del rango
Algoritmo fueraRango
	Definir R1 Como Real
	Definir R2 Como Real
	Definir num Como Real
	Escribir "Escribe tu Primer rango"
	Leer R1
	Escribir "Escribe tu Segundo rango"
	Leer R2
	Escribir "Escribe un numero"
	Leer num
	Si num > R1 y num < R2 Entonces
		Escribir "Tu numero esta dentro del rango"
	SiNo
		Escribir "Tu numero esta fuera del rango"
	Fin Si
FinAlgoritmo
