// Escibe un programa que calculeel precio final de un articulo. El usuario introducirá el precio
// sin descuento y su precio final tenrá un descuento del 5% únicamente si su precio es superior a 400$
Algoritmo Descuento
	Definir precio Como Real
	Escribir "Introduce el precio del articulo: "
	Leer precio
	Si precio > 400 Entonces
		total <- precio * 5 / 100
		totalDescuento <- precio - total
		Escribir "El precio final del articlo con descuento del 5% es de ", ConvertirATexto(totalDescuento)
	SiNo
		Escribir "El precio final del articlo es de ", ConvertirATexto(precio)
	Fin Si
FinAlgoritmo
