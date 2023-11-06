# Symulator Microprocessor Intel8086 🌐
> Windows Presentation Foundation (WPF) Symulator-Microprocessor-Intel 8086
>
> <a name="top"></a>
##  Contents 🗒️
1. [Preview](#preview)
2. [About a App](#aboutaapp)
3. [User's Interface](#ui)
4. [How it works](#work)
4.1. [How does the MOV command work ?](#MOV)
4.2. [How does the XCHG command work ?](#XCHG)
5. [Validation](#validation)

<a name="preview"></a>
## 1. Preview 👁️
![Screenshot 2023-11-05 154032](https://github.com/RuslanPidhainyi/Symulator-Microprocessor-Intel8086/assets/136593314/b12b83a6-0ba8-4c66-9faf-5845002e6c7a)

<a name="aboutaapp"></a>
## 2. About an App 📟
The simulator is based on 4 registers capable of storing values from 0-9 and A-F which means that they can store values in the hexadecimal system.

https://github.com/RuslanPidhainyi/Symulator-Microprocessor-Intel8086/assets/136593314/da222dc6-cc0a-4673-90e1-0f3b809530b4

<a name="ui"></a>
## 3. User's Interface 📲

![Screenshot 2023-11-05 154032](https://github.com/RuslanPidhainyi/Symulator-Microprocessor-Intel8086/assets/136593314/f06a9cf0-8b6d-4a0a-8cc8-8c366baf9ca1)

<a name="work"></a>
## 4. How it works 💻
I. We need to provide values in our registers 0-9 or A-F. There will be 8 of these registers (AL, AH, BL, BH, CL, CH, DL, DH).

https://github.com/RuslanPidhainyi/Symulator-Microprocessor-Intel8086/assets/136593314/69468ca3-0e0e-4466-827e-1b9aaaef9445

II. How I entered the value in all registers. I need to select 2 registers and select one of the commands.

https://github.com/RuslanPidhainyi/Symulator-Microprocessor-Intel8086/assets/136593314/c75eda18-8034-400b-853e-5183bb1e7572

<a name="MOV"></a>
## 4.1. How does the MOV command work ? ⚙️
III. The simulator supports MOV commands responsible for transferring data from one register to another register selected by the user. My translation is poor, the first register AL = 00 and the second register BL = 11. It transferred my data from the second register to the first register

https://github.com/RuslanPidhainyi/Symulator-Microprocessor-Intel8086/assets/136593314/40f6f6d7-c8dc-4e53-934b-e3843b6b7d3e

<a name="XCHG"></a>
## 4.2. How does the XCHG command work ? 🛠️
IV. Symulator obsługuje Rozkaz XCHG który zmienia dane między rejestrami wybranymi przez 
użytkownika. Moim przekladem biedzie, pierwszy rejestr AL = 00 i drugi rejestr BL = 11. Zmienilo moi dane między rejestrami

https://github.com/RuslanPidhainyi/Symulator-Microprocessor-Intel8086/assets/136593314/dd3da382-fa46-4797-b3c6-b9536aa6422f

<a name="validation"></a>
## 5. Validation ⚠️
The program has several validations: 

I. When we do not enter anything in the registers and immediately select one of the commands.

II. We will enter the values in register in lowercase letters.

III. Entering wrong values or entering more than 2 symbols

https://github.com/RuslanPidhainyi/Symulator-Microprocessor-Intel8086/assets/136593314/8262bfad-4046-4591-a7a8-1943c54ffeef




