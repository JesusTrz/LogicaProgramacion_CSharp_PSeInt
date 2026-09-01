// Una agencia de seguros únicamente asegura a personas que cumplan las siguientes condiciones:
	//* La persona está casada
	//* La persona no está casada, es hombre y tiene más de 30 años
	//* La persona no está casada, es mujer y tiene más de 25 años
//Escribe un programa que compruebe si una persona está asegurada o no.
Algoritmo AgenciaSeguros
	Definir Casada Como Logico
	Definir Genero Como Caracter
	Definir Edad como Entero
	Escribir "¿Eres una persona casada?"
	Leer Casada
	Si Casada == Verdadero Entonces
		Escribir "Estas Asegurad@"
	SiNo
		Escribir "¿Eres Hombre o Mujer?"
		Leer Genero
		Si Genero == "Hombre" Entonces
			Escribir "¿Cuantos años tienes?"
			Leer Edad
			Si Edad > 30 Entonces
				Escribir "Estas Asegurado"
			SiNo
				Escribir "No estas Asegurado"
			Fin Si
		SiNo
			Escribir "¿Cuantos años tienes?"
			Leer Edad
			Si Edad > 25 Entonces
				Escribir "Estas Asegurada"
			SiNo
				Escribir "No estas Asegurada"
			Fin Si
		Fin Si
	Fin Si
FinAlgoritmo
