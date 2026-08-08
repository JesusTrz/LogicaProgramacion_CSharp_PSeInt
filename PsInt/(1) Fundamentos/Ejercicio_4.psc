// Escribe un programa que calcule el salario neto de un trabajador en base al salario bruto.
// Las deducciones que se realizarán son las siguientes:
// Impuestos: 12%
// Cotizacion Social: 5%
// Seguro Medico: 4.5%
// En la consola se mostrará un mensaje en el que se muestren todas las deducciones
// y el salario bruto y neto
Algoritmo SalarioEjercicio
	Definir salario Como Real
	Escribir "Escribe tu salario: "
	Leer salario
	impuestos <- 0.12*salario
	cotizacionSocial <- 0.05*salario
	seguroMedico <- 0.045*salario
	
	deducciones <- impuestos + cotizacionSocial + seguroMedico
	total <- salario - deducciones
	
	Escribir "Deduccion despues de impuestos:" + ConvertirATexto(impuestos)
	Escribir "Deduccion despues de cotizacion social:" + ConvertirATexto(cotizacionSocial)
	Escribir "Deduccion despues de seguro medico:"+ ConvertirATexto(seguroMedico)
	
	Escribir "Total Final:" + ConvertirATexto(total)
FinAlgoritmo
