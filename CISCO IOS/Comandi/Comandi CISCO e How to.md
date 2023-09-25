# Comandi CISCO

## Shortcut

**shift + ctrl + 6** | Esce da un loop (es un ping) 

## Comandi in generale

|                                 **Comandi cisco** | **Descrizione**                                              |
| ------------------------------------------------: | :----------------------------------------------------------- |
|                                          `enable` | entrare in modalità pribilegiata                             |
|                               `enable secret ***` | Abilita password per modalità privilegiata, questa è automaticamente criptata |
|                             `enable password ***` | Abilita password per modalità privilegiata, NON è criptata   |
|                     `service password-encryption` | Cifra tutte le password                                      |
|                             `no ip domain-lookup` | Blocca il ping da fare quel "loop" che fa ogni volta         |
|                                 `interface vlan1` | Seleziona interfaccia vlan1                                  |
|                 `interface GigabitEthernet 0/0/0` | Come sopra ma selezione l'inetrfaccia gigabit 0              |
|            `ip address 192.168.1.1 255.255.255.0` | Configura un interfaccia un ip e una netmask                 |
|              `ipv6 address 2001:db8:acad:4::1/64` | Per impostare IPV6 e la sua subnetmask                       |
|                                     `no shutdown` | non faccio spegnere automaticamente una porta                |
| `copy running-config startup-config oppure write` | salva la configurazione                                      |
|               `show running-config oppure sh run` | Mostra le ipostazioni attuali                                |
|                                          `conf t` | Entro nella modalità di configurazione                       |
|                                   `line vty 0 15` | Configuro una linea virtuale dalla 0 alla 15                 |
|                                           `login` | attivo il controllo della passowrd                           |
|                        `crypto key  generate rsa` | Crea la chiave RSA per ssh                                   |
|                                     `hostname **` | Iposta l'hostname per il dispositivo                         |
|                             `ip domain-name ****` | Imposta il nome del dominio                                  |
|                      `sh crypto key mypubkey rsa` | Fa vedere la tua chiave pubblica rsa                         |
|                     `username **** password ****` | Crea un utente                                               |
|                                     `login local` | Dico alla macchina che per fare l'accesso deve usare il database locale (Quello degli utenti locali) |
|                             `transport input ssh` | Specifichi il modo di collegarsi della linea che stai configurando |
|                                    `show version` | Controllo la versione SSH                                    |
|                 `banner motd "Banner fantastico"` | Per aggiungere un banner                                     |
|                     `exec-timeout minuti secondi` | Per disconnettere dopo tot tempo di inattività               |
|                             `logging synchronous` | Per impedire ai messaggi della console di interrompere i comandi |
|                                                   |                                                              |



## Configurare accesso remoto switch CISCO

```bash
enable
configure terminal
enable secret pippo 
interface vlan1
ip address 192.168.1.1 255.255.255.0
no shutdown
line vty 0 15
password 123456
login
hostname s1
ip domain-name cisco.com
crypto key generate rsa [chiede poi prompt per quanti bit, mettere 4096]
username admin password 123456 
line vty 0 15
login local
transport input ssh
```



## Domande Condolf 25/09/2023

1. Il link local sulla inetfaccia, spiegalo  | ipv6 address fe80::2:a link-local
2. logging synchronous è quello per fare il timeout dei comandi?
3. Routing IPV6
