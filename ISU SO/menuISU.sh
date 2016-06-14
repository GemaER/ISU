#!/bin/bash
tput setaf 0; tput setab 7

op=0 
while [  $op -ne 4  ] 
do
	clear
	tput cup 1 3; echo "I. S."; tput cup 1 8; tput setaf 4 ; echo " U. insumos y soporte al usuario"
	tput cup 3 3; tput setaf 0 ; echo "1)Dar de alta a un usuario"
	tput cup 4 3; echo "2)Dar de baja a un usuario"
	tput cup 5 3; echo "3)Modificar un usuario"
	tput cup 6 3; echo "4) Salir"
	tput cup 7 3; read -p "Opcion: " op
	echo $op > anterior.txt
	
	case $op in
		1) . alta.sh;;
		2) . baja.sh;;
		3) . modificar.sh;;
		4) ;;
		*) tput cup 2 3; tput setaf 1; read  -p "Dato no valido" aux ; tput setaf 0 
			op=0 
		;;
	esac

done