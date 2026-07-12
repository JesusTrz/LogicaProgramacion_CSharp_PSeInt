// Escribe un programa que solicite al usuario un número de 3 dígitos y 
// relice la suma de los 3 digitos
// Ejempplo: 483 = 4 + 8 + 3 = 15
Algoritmo SumaDigitos
	Definir num Como Entero
	Escribir "Escribe un Numero de 3 Digitos: "
	Leer num
	dig3 <- num % 10
	dig2 <- ((num - dig3) % 100) / 10
	dig1 <- (num - dig2 * 10 - dig3) / 100
	suma <- dig1 + dig2 + dig3
	Escribir num, " = ", dig1 " + ", dig2 " + ", dig3, " = ", suma
FinAlgoritmo
