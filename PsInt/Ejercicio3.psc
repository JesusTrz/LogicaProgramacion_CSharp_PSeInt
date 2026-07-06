// Escribe un programa que calcule la nota media de un alumno
// en base a 4 notas diferentes introducidas por el usuario
// En este caso las notas ponderarán de la siguiente manera:
// Examen 1: 10%
// Examen 2: 25%
// Examen 3: 50%
// Examen 4: 15%

Algoritmo TercerEjercicio
	Definir cal1, cal2, cal3, cal4 Como Real
	Escribir "Introduce tu primer calificacion:"
	Leer cal1
	Escribir "Introduce tu segunda calificacion:"
	Leer cal2
	Escribir "Introduce tu tercera calificacion:"
	Leer cal3
	Escribir "Introduce tu cuarta calificacion:"
	Leer cal4
	nota <- 0.1*cal1 + 0.25*cal2 + 0.5*cal3 + 0.15*cal4
	Si nota >= 8 Entonces
		Escribir "Tu media es de: " + ConvertirATexto(nota)
		Escribir "Eres Alumno regular"
	SiNo
		Escribir "Tu media es de: " + ConvertirATexto(nota)
		Escribir "Eres Alumno irregular"
	Fin Si
FinAlgoritmo
