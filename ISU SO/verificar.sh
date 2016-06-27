#!/bin/bash
come=$(cat aux.txt)

ci[0]=0
ci[1]=0
ci[2]=0
ci[3]=0
ci[4]=0
ci[5]=0
ci[6]=0
ci[7]=0

cont=7
while [ $cont -ge 0 ]
do
	let cii=$come/10
	let aux=$cii*10
	let ci[$cont]=$come-$aux
	come=$cii
	let cont=$cont-1

done

if [ ${ci[0]} -eq 0 ]
then
	tput cup 2 3; tput setaf 1 ; read -p "Faltan digitos" ; tput setaf 0
else 
	if [ $come -gt 0 ]
	then
		tput cup 2 3 ; tput setaf 1 ; read -p "Sobran digitos" ; tput setaf 0
	else
		acum=0
		i=0
		while [ $i -lt 8 ]
		do
			case $i in
			0) let ci[$i]=${ci[$i]}*2
				let acum=$acum+${ci[$i]}
			;;
			1) let ci[$i]=${ci[$i]}*9
			let acum=$acum+${ci[$i]}
			;;
			2) let ci[$i]=${ci[$i]}*8
				let acum=$acum+${ci[$i]}
			;;
			3) let ci[$i]=${ci[$i]}*7
				let acum=$acum+${ci[$i]}
			;;
			4) let ci[$i]=${ci[$i]}*6
				let acum=$acum+${ci[$i]}
			;;
			5) let ci[$i]=${ci[$i]}*3
				let acum=$acum+${ci[$i]}
			;;
			6) let ci[$i]=${ci[$i]}*4
				let acum=$acum+${ci[$i]}
			;;
			7) sig0=$acum
				acum2=$acum

				let sig0=$acum/10
				let sig0=$sig0*10
				let sig0=$acum-$sig0

				while [ $sig0 -ne 0 ]
				do
					let acum2=$acum2+1
					let sig0=$acum2/10
					let sig0=$sig0*10
					let sig0=$acum2-$sig0

				done
				let veri=$acum-$acum2
				let veri=-$veri
				come=$(cat aux.txt)

				if [ ${ci[7]} -ne $veri ] 
				then
					tput cup 2 3; tput setaf 1; read -p "CI invalida"; tput setaf 0
				else
					chequeo=$(grep $come /etc/passwd)
					if [ -z $chequeo ]  #si no existe el usuario con esa ci se peude crear
					then
						echo "1" > aux2.txt
						tput cup 2 3; tput setaf 2 ; read -p "La CI fue verificada"; tput setaf 0
					else
						tput cup 2 3; tput setaf 1; read -p "CI ya registrada"; tput setaf 0
					fi
				fi
			;;
			esac
			let i=$i+1
		done
	fi
fi

