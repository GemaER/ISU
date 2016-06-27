#!/bin/bash
clear
tput cup 3 3; echo "Login :"
tput cup 4 3; echo "Cedula de identidad :"
tput cup 5 3; echo "Directorio de trabajo :"
tput cup 6 3; echo "Grupo al que pertencera :"
DnLogg=0
DnCI=0
echo "$DnCI" > aux2.txt
DnGroupp=0
while [ $DnLogg -eq 0 ]
do
	tput cup 3 12; read Logg
	busqueda=$(grep "^$Logg:" /etc/passwd)
	if [ -z $busqueda  ]  #si no existe el usuario se peude crear
	then
		DnLogg=1
		while [ $DnCI -eq 0 ]
		do
			tput cup 4 25; read CI
			echo $CI > aux.txt
			. verificar.sh  # Chequea que el numero verificador sea el correcto, al igual que a cantidad de digitos
			DnCI=$(cat aux2.txt)
		done
		tput cup 5 27; read Homee
		while [ $DnGroupp -eq 0 ]
		do
			tput cup 6 29; read Groupp
			busqueda=$(cut -d: -f1  /etc/group | grep "$Groupp")
			if [ -z $busqueda ]
			then
				busqueda=$(cut -d: -f3  /etc/group | grep "$Groupp")
				if [ -z $busqueda ]
				then
					tput cup 2 3; tput setaf 1; read -p "Ingrese un grupo valido" aux; tput setaf 0
				else
					DnGroupp=1
				fi
			else
				DnGroupp=1
			fi
		done
		if  sudo useradd -d $Homee -mk /etc/skel -g $Groupp -c "$CI" -s /bin/shell $Logg
		then
			tput cup 2 3; tput setaf 1; read -p "Error" aux; tput setaf 0
		else
			tput cup 2 3;  tput setaf 2 ; read -p "Usuario creado" ;  tput setaf 0
			sudo passwd $Logg
		fi
	else
		tput cup 2 3; tput setaf 1; read -p "El usuario ya existe" aux; tput setaf 0
	fi
done

rm aux.txt
rm aux2.txt

