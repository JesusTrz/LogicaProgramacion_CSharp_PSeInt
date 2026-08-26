// Escribe un programa que comprueba si un triángulo es válido en base a sus ángulos
// Para que un triangulo sea válido, sus tres angulos deben ser positivos, por debajo de 180 grados
// y la suma debe ser igual a 180 grados
Algoritmo TrianguloValido
	Definir ang1, ang2, ang3 Como Real
	Escribir "Escribe el pirmer angulo: "
	Leer ang1
	Escribir "Escribe el segundo angulo: "
	Leer ang2
	Escribir "Escribe el tercer angulo: "
	Leer ang3
	Si ang1 > 0 y ang2 > 0 y ang3 > 0 Entonces
		total <- ang1 + ang2 + ang3
		Si total == 180 Entonces
			Escribir "El triangulo es Valido"
		SiNo
			Escribir "El triangulo es Invalido"
		Fin Si
	SiNo
		Escribir "Los angulos deben ser positivos"
	Fin Si
FinAlgoritmo
