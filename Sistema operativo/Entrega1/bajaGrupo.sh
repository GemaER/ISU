#!/bin/bash
DnGroupp=0
while [ $DnGroupp -eq 0 ]
do
	clear
	tput cup 3 3; echo "Grupo o GID a dar de baja"
	tput cup 4 3;  read GIDD

	busqueda=$(cut -d: -f1 /etc/group |grep "$GIDD")
	if [ -z $busqueda ]
	then
		busqueda=$(cut -d: -f3 /etc/group | grep -n "$GIDD" | cut -d: -f1)
		if [ -z $busqueda ]
		then
			tput cup 2 3; tput setaf 1; read -p "Ingrese un grupo valido" aux; tput setaf 0
		else
			Groupp=$(head -$busqueda /etc/group | tail -1 | cut -d: -f1 )
			DnGroupp=1
		fi
	else
		Groupp=$GIDD
		DnGroupp=1
	fi 
	if [ $DnGroupp -eq 1 ]
	then
		if sudo groupdel $Groupp
		then
			tput cup 2 3; tput setaf 2; read -p "Grupo $Groupp, eliminado" aux; tput setaf 0
			DnGroupp=1
		else
				tput cup 2 3; tput setaf 1; read -p "Error" aux; tput setaf 
		fi
	fi
done

