#!/bin/bash
DnGroupp=0
while [ $DnGroupp -eq 0 ]
do
	clear
	tput cup 3 3; echo "Grupo o GID a consultar"
	tput cup 4 3;  read GIDD

	busqueda=$(cut -d: -f1 /etc/group |grep -n "$GIDD" | cut -d: -f1 )
	if [ -z $busqueda ]
	then
		busqueda=$(cut -d: -f3 /etc/group | grep -n "$GIDD" | cut -d: -f1)
		if [ -z $busqueda ]
		then
			tput cup 2 3; tput setaf 1; read -p "Ingrese un grupo valido" aux; tput setaf 0
		else
			DnGroupp=1
		fi
	else
		Groupp=$GIDD
		DnGroupp=1
	fi 
	if [ $DnGroupp -eq 1 ]
	then
		busqueda=$(head -$busqueda /etc/group | tail -1 ) 
		tput cup 2 3; tput setaf 2 ; echo "El grupo $Groupp fue encontrado" ; tput setaf 0 
		corte=$(echo $busqueda | cut -d: -f1)
		tput cup 6 3; echo "Grupo: $corte"
		corte=$(echo $busqueda | cut -d: -f3) 
		tput cup 7 3; echo "GID: $corte"
		corte=$(echo $busqueda | cut -d: -f4) 
		tput cup 8 3; echo "Integrantes: $corte"
		tput cup 9 3; read -p "" aux 
	fi
done
