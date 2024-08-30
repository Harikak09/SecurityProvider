#Overview
This project shows the design and development of Security Provider. 

#Design
Modules in the project - UX MOdule, Controller Module, Security Provider Module.

![Module Diagram](Images\Module Diagram.jpg)

- **Security Provider**

This module contains different security operations like AntiVirus Provider, AccountSecurity Provider etc. Also contains two interfaces ISecurityNotifier and ISecurityProvider.

    -*ISecurityNotifier*: Notifies users/systems about security events.Can be used by different classes that sends notifications.

    -*ISecurityProvider*: This defines the core security operations that any security provider must implement.

- **Controller**

This module takes the i/p from the UI and decides which security providers to use. It is a bridge between UX and Security Provider.

- **UX**
This provides interface to the user.

![Class Diagram](Images\Class Diagram.jpg)


