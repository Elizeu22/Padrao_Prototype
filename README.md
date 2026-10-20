PrototypeJogo

Projeto desenvolvido em C# para praticar o padrão de projeto Prototype.

🎯 Objetivo

Aprender a criar novos objetos copiando objetos existentes, evitando configurar cada objeto do zero.

🎮 Sobre o projeto

O sistema simula a criação de personagens de um jogo.

Cada personagem possui as seguintes propriedades:

Nome: nome do personagem.

Vida: quantidade de vida.

Forca: força de ataque.

Classe: tipo do personagem.

O projeto deve permitir clonar um personagem existente e modificar os dados da cópia sem alterar 
o personagem original.

🧠 Padrão Prototype

O Prototype é um padrão de projeto criacional que permite criar novos objetos a partir da cópia
de objetos existentes.

Neste projeto, o método Clonar() será responsável por criar uma nova instância do personagem com
os mesmos valores do objeto original.

📁 Estrutura do projeto

PrototypeJogo/
├── Models/
│   └── Personagem.cs
├── Program.cs
├── PrototypeJogo.csproj
├── README.md
└── .gitignore

⚙️ Tecnologias utilizadas

C#

.NET

Programação Orientada a Objetos

Padrão de projeto Prototype
