// Escribe un programa que comprueba si un triangulo en base a sus laterales
// Para que un triangulo sea válido, la suma de dos laterales cualquiera debe
// ser superior al otro lado lateral

Algoritmo TrianguloBaseLaterales
	Definir b1, b2, b3 Como Real
	Escribir "Escribe le base 1: "
	Leer b1
	Escribir "Escribe le base 2: "
	Leer b2
	Escribir "Escribe le base 3: "
	Leer b3
	Si b1 + b2 > b3 o b1 + b3 > b2 o b2 + b3 > b1 Entonces
		Escribir "Triangulo Válido"
	SiNo
		Escribir "Triangulo Inválido"
	Fin Si
FinAlgoritmo
