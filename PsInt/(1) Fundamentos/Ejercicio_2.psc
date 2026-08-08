// Escribe un programa que calcule la nota media de un alumno
// en base a 3 notas diferentes, introducidas por el usuario
Algoritmo SegundoEjercicio
	Definir cal1, cal2, cal3 Como Entero
	Escribir "Introduce tu primer calificacion:"
	Leer cal1
	Escribir "Introduce tu segunda calificacion:"
	Leer cal2
	Escribir "Introduce tu tercera calificacion:"
	Leer cal3
	nota <- (cal1 + cal2 + cal3) / 3
	Si nota >= 8 Entonces
		Escribir "Tu media es de: " + ConvertirATexto(nota)
		Escribir "Eres Alumno regular"
	SiNo
		Escribir "Tu media es de: " + ConvertirATexto(nota)
		Escribir "Eres Alumno irregular"
	Fin Si
	
FinAlgoritmo
