// Escribe un programa que diga si un número está dentro de dos rangos sepparados.
// El usuario introducirá el límite ingerior y superior de los rangos,
// y el número que se desea comprobar.
// Ejemplo:
// Rango 1: [2,5] - Rango 2: [8,12]
// Numero 9: Dentro - Numero 4: Dentro - Numero 6: Fuera

Algoritmo dentroYfueradeRango
	Definir r1n1, r1n2, r2n1, r2n2, num Como Real
	Escribir "(1) Ingresa el Primer Rango"
	Leer r1n1
	Escribir "(1) Ingresa el Segundo Rango"
	Leer r1n2
	Escribir "Primer Rango: " + ConvertirATexto(r1n1) + " - " + ConvertirATexto(r1n2)
	Escribir "(2) Ingresa el Primer Rango"
	Leer r2n1
	Escribir "(2) Ingresa el Segundo Rango"
	Leer r2n2
	Escribir "Primer Rango: " + ConvertirATexto(r2n1) + " - " + ConvertirATexto(r2n2)
	Escribir "Ingresa un Numero: "
	Leer num
	Si num > r1n1 y num < r1n2 o num > r2n1 y num < r2n2 Entonces
		Escribir "El numero esta dentro de rango"
	SiNo
		Escribir "El numero esta fuera de rango"
	Fin Si
FinAlgoritmo
