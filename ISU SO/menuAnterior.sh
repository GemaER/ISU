#!/bin/bash
clear
op=0
while [ $op -eq 0 ] 
do 
	tput cup 3 3;echo "1) Volver"
	tput cup 4 3;echo "2) Menu "
	tput cup 5 3;read op
	case $op in
		1)
			anterior=$(cat menu.txt)
			. $anterior.sh
		;;
		2) op=1 ;;
		*) tput cup 2 3; tput setaf 1; echo "Dato no valido";tput setaf 0 ;;
	esac 
done
