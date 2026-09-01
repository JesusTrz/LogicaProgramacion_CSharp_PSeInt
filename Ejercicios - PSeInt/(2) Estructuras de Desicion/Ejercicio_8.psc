// Escribe un programa que compruebe si una letra es vocal o consonante.

Algoritmo VocalConsonante
	Definir vocal Como Caracter
	Escribir "Escribe una letra"
	Leer vocal
	vocalCon <- Minusculas(vocal)
	Si vocalCon == 'a' o vocalCon == 'e' o vocalCon == 'i' o vocalCon == 'o' o vocalCon = 'u' Entonces
		Escribir "Tu letra " + vocal + " es una vocal"
	SiNo
		Escribir "Tu letra " + vocal + " es una consonante"
	Fin Si
FinAlgoritmo
