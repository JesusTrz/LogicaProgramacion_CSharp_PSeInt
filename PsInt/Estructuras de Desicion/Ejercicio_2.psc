// Escribe un Programa al que se le introduce una nota y muestra en pantalla
// si el alumno ha aprobado o no, dependiendo de su nota final. EL alumno aprobará si su nota es mayor
// o igual a 6, y suspendera si su nota es menor a 6
Algoritmo condicionalCalificacion
	Definir calf Como Real
	Escribir "Introduce tu calificacion"
	Leer calf
	Si calf >= 6 Entonces
		Escribir "Has aprobado"
	SiNo
		Escribir "Has Suspendido"
	Fin Si
FinAlgoritmo
