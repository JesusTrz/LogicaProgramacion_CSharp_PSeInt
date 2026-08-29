// Escribe un programa que solicite un usuario y contraseña.
// El usuario y contraseña valisods estaran almacenados como varieblaes en el programa.
// Si el usuario y contraseña introducidos son iguales a los almacenados, se mostrará un mensaje que diga "Acceso Permitido"
// Por el contrario, si no coinciden, se mostrará un mensaje que diga "Acceso Denegado".
// El usuario no debe ser sensitivo a mayúsculas, pero la contraseña si
// Ejemplo: 
// Usuario: User - Contraseña - PaSsWoRd
// Datos Introducidos
// Usuario: User - Contraseña - PaSsWoRd -> Correcto
// Usuario: USER - Contraseña - PaSsWoRd -> Correcto
// Usuario: User - Contraseña - PASAWORD - Incorrecto
 
Algoritmo LoginLogico
	userR<- "User"
	passR<- "PaSsWoRd"
	Definir user, pass Como Caracter
	Escribir "Escribe tu nombre de usuario"
	Leer user
	Escribir "Escribe la contraseña"
	Leer pass
	Si Minusculas(user) == Minusculas(userR) y pass == passR Entonces
		Escribir "Inicio se Sesion Exitoso"
	SiNo
		Escribir "Nombre de Usuario o Contraseña Incorrectos"
	Fin Si
	
FinAlgoritmo
