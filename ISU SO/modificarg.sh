##!/bin/bash
tput setab 7
clear
#FALTA WHILE
tput cup 3 3; echo "1) Nombre del grupo"
tput cup 4 3; echo "2) GID"
tput cup 5 3; echo "3) Menu de grupo :"
read op
modificado=0
while [ $modificado -ne 1 ]
do
	case $op in
	1) clear
		tput cup 3 3; echo "Buscar por: 1) GID" 
		tput cup 3 15; echo " 2) nombre";;
		tput cup 4 3; read opcion
		
		tput cup 3 3; read -p "Ingrese el GID a modificar: " grupo

		aux=$(grep "^$grupo:" /etc/passwd)

		if [ -z $aux  ]
		then
			tput cup 4 3; read -p  "No existe el GID. Presione ENTER para continuar..." aux
		else 
			tput cup 4 3; read -p "Ingrese nuevo nombre" nombre
			usermod -n $nombre $grupo 
			tput cup 2 3; echo "El grupo $grupo fue modificado por el nombre $nombre"
		fi
	;;
	2) clear
		tput cup 3 3; echo "Buscar por: 1) GID" 
		tput cup 3 15; echo " 2) nombre";;
		tput cup 4 3; read opcion
		
		tput cup 3 3; read -p "Ingrese el GID a modificar: " grupo

		aux=$(grep "^$grupo:" /etc/passwd)

		if [ -z $aux  ]
		then
			tput cup 4 3; read -p  "No existe el GID. Presione ENTER para continuar..." aux
		else 
			tput cup 4 3; read -p "Ingrese nuevo GID" grupid
			usermod -g $grupid $grupo 
			tput cup 2 3; echo "El grupo $grupo fue modificado por el GID $grupid"
		fi
	;;
	3);;
	*) tput cup 2 3; tput setaf 1; read -p "Ingrese un dato valido" aux; tput setaf 0
done
