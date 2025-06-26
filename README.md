﻿# Controle de Bar 🍻
Este é um sistema de gerenciamento de bar, desenvolvido em C#, com foco em controle de mesas, garçons, produtos e pedidos (contas). Permite cadastrar, editar, visualizar e excluir entidades, além de abrir e fechar contas com itens consumidos.

## Sumário

- [Visão geral](#visão-geral)
  - [Mídia](#mídia-)
  - [Funcionalidades](#funcionalidades)
  - [Desenvolvido com](#desenvolvido-com-)
  - [Estrutura do projeto](#estrutura-do-projeto-)
- [Como rodar o código?](#como-rodar-o-código-)
  - [Passo a passo - Clone ou baixe o projeto](#passo-a-passo---clone-ou-baixe-o-projeto--)
  - [Uso](#uso-)
- [Autor](#autor-)

## Visão geral

### Mídia 📷
##### GIF da aplicação - Clique no GIF para dar Play/Pause
![image](https://imgur.com/LYwof8X.gif)


###  Funcionalidades principais  ✅ 
- Módulo de Mesas
    - Cadastro, edição, visualização e exclusão de mesas

    - Visualização do status (Livre/Ocupada)

    - Detalhamento completo da mesa

    - Regras de negócio:

        - Número único e positivo

        - Quantidade de lugares obrigatória e positiva

        - Status padrão "Livre"

        - Não permite exclusão com pedidos vinculados

- Módulo de Garçons
    - Cadastro, edição, visualização e exclusão de garçons

    - Regras de negócio:

        - Nome obrigatório (3-100 caracteres)

        - CPF obrigatório e validado (formato XXX.XXX.XXX-XX)

        - CPF único

        - Não permite exclusão com pedidos vinculados

- Módulo de Produtos
    - Cadastro, edição, visualização e exclusão de produtos

    - Regras de negócio:

        - Nome obrigatório (2-100 caracteres)

        - Preço positivo com duas casas decimais

        - Nome único

        - Não permite exclusão com pedidos vinculados

- Módulo de Contas (Pedidos)
    - Abertura de contas vinculadas à mesa

    - Adição e remoção de itens

    - Fechamento de contas

    - Faturamento diário

    - Consulta de contas abertas e fechadas

- **Recursos adicionais**
    - Visualização dos dados em formato de tabela

    - Exclusão de registros por ID

    - Mensagens interativas no terminal

    - Validações em todos os cadastros


### Desenvolvido com 🚀

[![My Skills](https://skillicons.dev/icons?i=cs,dotnet,git&theme=light)](https://skillicons.dev)


### Estrutura do projeto 📁
```
├── Controle-de-Bar
│   ├── Controle-de-Bar-ConsoleApp
│   │   ├── Compartilhado
│   │   │   ├── EntidadeBase.cs
│   │   │   ├── ITela.cs
│   │   │   ├── RepositorioBase.cs
│   │   │   ├── TelaBase.cs
│   │   │   └── TelaPrincipal.cs
│   │   ├── ModuloConta
│   │   │   ├── Conta.cs
│   │   │   ├── Pedido.cs
│   │   │   ├── RepositorioConta.cs
│   │   │   └── TelaConta.cs
│   │   ├── ModuloGarcom
│   │   │   ├── Garcom.cs
│   │   │   ├── RepositorioGarcom.cs
│   │   │   └── TelaGarcom.cs
│   │   ├── ModuloMesa
│   │   │   ├── Mesa.cs
│   │   │   ├── RepositorioMesa.cs
│   │   │   └── TelaMesa.cs
│   │   ├── ModuloProduto
│   │   ├── Controle-de-Bar-ConsoleApp.csproj
│   │   └── Program.cs
│   ├── .gitattributes
│   ├── .gitignore
│   ├── Controle-de-Bar.sln
│   └── README.md

```


### Como rodar o código? 🤖

#### ❗❗Obs: Há a necessidade de ter o .NET SDK instalado em sua máquina previamente!

#### Passo a passo - Clone ou baixe o projeto  👣👣

1. Abra o terminal do seu editor de código;
2. Navegue até a pasta onde deseja instalar o projeto;
3. Clone o projeto 
ex:``` git clone git@github.com:alexandreSouza31/Controle_de_Bar.git```
 ou se preferir, baixe clicando no botão verde chamado "Code" no repositório desse projeto, e depois "Download zip.


#### Uso 💻
1. Inicie o App:
Certifique-se de estar na pasta do projeto, e navegue pelo terminal até o caminho do arquivo Program.cs
```
cd controle-de-bar/ControleDeBar.ConsoleApp

```
2. Compile e execute o programa: ```dotnet run```

    ou, com o arquivo Program.cs aberto clique no botão verde(Current Document(Program.cs)) para iniciar

3. Siga as instruções do menu interativo no terminal!


## Autor 😏 

<main>
<div style="display: flex; align-items: center; gap: 20px;padding-bottom: 2em">
  <img src="https://github.com/user-attachments/assets/74c712a4-9e48-4ae3-839c-46089b850a27" width="80" />
  <h3 style="margin: 0;"><i>Alexandre Mariano</i></h4>
</div>

  <p>
    <a href="https://www.linkedin.com/in/alexandresouza31/">
      <img src="https://skillicons.dev/icons?i=linkedin&theme=dark" width="50"/>
      LinkedIn
    </a> &nbsp;  |  &nbsp;
    <a href="https://github.com/alexandreSouza31">
      <img src="https://skillicons.dev/icons?i=github&theme=dark" width="50"/>
      GitHub
    </a>
  </p>
</main>


<a href="#controle-de-bar" 
   style="position: fixed; right: 10px; bottom: 20px; background-color:rgba(99, 102, 99, 0.32); color: white; padding: 1px 5px 5px; text-decoration: none; border-radius: 5px; font-size: 16px;">
   🔝Voltar ao topo🔝
</a>
