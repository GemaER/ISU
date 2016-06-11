#!/bin/bash
clear
#FALTA WHILE
tput cup 3 3; echo "Directorio de trabajo :"
tput cup 4 3; echo "Administrador (S/N) :"
tput cup 5 3; echo "Nombre del usuario :"
tput cup 6 3; echo "Cedula de identidad :"

tput cup 3 27; read homeuser
#si no esta creado el home no se puede asignarlo a un usuario
if [ -d $homeuser ]
then
  
else
	menuhome=false
	while [ !$menuhome ]
	do
		tput cup 4 3; read -p "Home no existente. ¿Desea crearlo? (S/N)" ophome
		case $ophome in
		"S") mkdir $homeuser
			sudo usermod -d $nombre $usuario
			creado=true
			menuhome=true
			tput cup 5 3; echo "Home creado y modirficado en el usuario $usuario , ci: $ci"
		;;
		"N") menuhome=true
		;;
		*) tput cup 2 3; tput setaf 1; read -p "Ingrese S/N" aux ; tput setaf 0
		;;
		esac
	done
fi
SON=0
while [ SON=0 ]
do
	tput cup 4 25; read ngrup
	case $ngrup in
		"S") ngrup=10
			SON=1
		;;
		"N") ngrup=20
			SON=1
		;;
		*) tput cup 2 3; tput setaf 1; read -p "Ingrese S/N" aux; tput setaf 0
		;;
	esac
done
tput cup 5 24; read nombreuser
busqueda=$(grep "$nombreuser:" /etc/passwd)

if [ -z $busueda  ]  #si no existe el usuario se peude crear
then
	verificar=false; echo "false" > aux2.txt
	while [ ! $verificar ]
	do
		tput cup 6 25; read come; echo $come > aux.txt
		. verificar.sh  #verifica la ci
		verificar=(cat aux2.txt)
	done
	if [useradd -d $homeuser -mk /etc/skell -g $ngrup -c $come -s shell $nombreuser]
	then
		tput cup 7 3; echo "Usuario creado"
	fi
else
	tput cup 2 3; tput setaf 1 ; echo " $nombreuser ya existe"
	tput cup 2 24; tput setaf 0 ; echo " Ingrese otro nombre de usuario"
fi
