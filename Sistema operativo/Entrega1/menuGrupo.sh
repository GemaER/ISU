#!/bin/bash
op=0
while [  $op -ne 5  ]
do
	clear
	tput cup 1 3; echo "I. S."; tput cup 1 8; tput setaf 4 ; echo " U. insumos y soporte al usuario"
	tput cup 3 3; tput setaf 0 ; echo "1) Dar de alta un grupo"
	tput cup 4 3; echo "2) Dar de baja un grupo"
	tput cup 5 3; echo "3) Modificar un grupo"
	tput cup 6 3; echo "4) Consulta un grupo"
	tput cup 7 3; echo "5) Atras"
	tput cup 8 3; read -p "Opcion: " op
	case $op in
		1) . altaGrupo.sh;;
		2) . bajaGrupo.sh;;
		3) . modificarGrupo.sh;;
		4) . consultarGrupo.sh;;
		5) ;;
		*) tput cup 2 3; tput setaf 1; read  -p "Dato no valido" aux ; tput setaf 0
			op=0
		;;
	esac
done

